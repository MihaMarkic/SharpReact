#addin "Cake.FileHelpers"

enum Implementation
{
	Android81,
	Wpf,
	AndroidAppCompatV7
}

var configuration = Argument("BuildConfiguration", "Release");
var newBuildVersion = Argument<string>("BuildVersion", null);
var implementation = Argument<Implementation?>("Implementation", null);

var Src = Directory("./src");
var Core = Src + Directory("./SharpReact.Core/");
var CoreCsproj = Core + File("SharpReact.Core.csproj");
var Router = Src + Directory("./SharpReact.Routing/");
var RouterCsproj = Router + File("SharpReact.Routing.csproj");
var Wpf = Src + Directory("./SharpReact.Wpf/");
var WpfCsproj = Wpf + File("SharpReact.Wpf.csproj");
var WpfNuSpec = Wpf + File("SharpReact.Wpf.nuspec");

var Test = Src + Directory("./test/");
var CoreTest = Test + File("SharpReact.Core.Test/SharpReact.Core.Test.csproj");
var RouterTest = Test + File("SharpReact.Routing.Test/SharpReact.Routing.Test.csproj");

var MetadataGenerator = Src + File("SharpReact.MetaDataGenerator/bin/Debug/ReactGenerator.exe");
var Implementations = Src + Directory("Implementations");
var AndroidImplementation = Implementations + Directory("Android");
var Android81Implementation = AndroidImplementation + Directory("SharpReact.Android.8_1");
var AndroidAppCompatv7Implementation = AndroidImplementation + Directory("SharpReact.Support.v7.AppCompat");
var WpfImplementations = Implementations + Directory("Wpf");
var WpfImplemenation = WpfImplementations + Directory("SharpReact.Wpf");

var solution = Src + File("SharpReact.sln");
var version = File("./version.xml");
string buildVersion;

var nupkg = Directory("./nupkg");

var target = Argument("target", "Default");

ConvertableDirectoryPath GetImplementationDirectoy()
{
	if (!implementation.HasValue)
	{
		throw new ArgumentNullException(nameof(Implementation));
	}
	switch (implementation)
	{
		case Implementation.Wpf:
			return WpfImplemenation;
		case Implementation.Android81:
			return Android81Implementation;
		case Implementation.AndroidAppCompatV7:
			return AndroidAppCompatv7Implementation;
		default:
			throw new ArgumentOutOfRangeException(nameof(Implementation));
	}
}

Task("Restore")
	.Does(() => {
 		DotNetCoreRestore(solution);
	});

Task("Build")
	.IsDependentOn("Restore")
	.Does (() =>
	{
		MSBuild (solution, new MSBuildSettings {
			Configuration = configuration,
			Verbosity = Verbosity.Minimal,
			ToolVersion = MSBuildToolVersion.VS2017
		});
});

Task("UnitTest")
	.IsDependentOn("Build")
	.Does(() =>
	{
		foreach (var project in new []{ CoreTest, RouterTest })
		{
			DotNetCoreTest(project, new DotNetCoreTestSettings {
				Configuration = configuration,
				NoBuild = true
			});
		}
	});

Task("ReadVersion")
	.Does(() => {
		buildVersion = XmlPeek(version, "build/@version");
		Information($"Build version is {buildVersion}");
	});

Task("SetVersion")
	.Does(() => {
		XmlPoke(version, "build/@version", newBuildVersion);
	});

Task("Pack")
	.IsDependentOn("ReadVersion")
	.IsDependentOn("UnitTest")
	.Does (() =>
{
	if (string.IsNullOrEmpty(buildVersion))
	{
		throw new Exception($"Build version not set. Check {version} file, it should contain node <build version=\"[version]\"");
	}
	CreateDirectory(nupkg);
	foreach (var project in new []{ CoreCsproj, RouterCsproj })
	{
		DotNetCorePack (project, new DotNetCorePackSettings { 
			Configuration = configuration,
			OutputDirectory = nupkg,
			NoBuild = true,
			MSBuildSettings = new DotNetCoreMSBuildSettings ().WithProperty("PackageVersion", buildVersion)
		});	
	}
	// separately pack wpf visualizer since it's not a .netstandard or .netcore project
	NuGetPack (WpfNuSpec, new NuGetPackSettings { 
		Version = buildVersion,
		Verbosity = NuGetVerbosity.Normal,
		OutputDirectory = nupkg,
		BasePath = Wpf,
		Symbols=true,
	});	
});

Task("CreateImplementation")
.Does(() =>
{
	var directory = GetImplementationDirectoy();
	var buildFile = directory + File("build.yaml");
	string absolutePath = MakeAbsolute(buildFile).ToString();
	Information($"Building implementation for {absolutePath}");
	var exitCode = StartProcess(MetadataGenerator, new ProcessSettings { Arguments = absolutePath });
	Information($"Exit code is {exitCode}");
});

Task("Default")
	.Does(() => {
		Information(
$@"Targets: ReadVersion, SetVersion, Restore, Build, UnitTest, Pack, CreateImplementation
Arguments:
	BuildConfiguration (default is Release)
	BuildVersion (required when using SetVersion)
	Implementation (required when CreateImplementation)
		{string.Join(", ", Enum.GetNames(typeof(Implementation)))}

Samples:
	CreateImplementation -Implementation Android81");
	});

RunTarget (target);
