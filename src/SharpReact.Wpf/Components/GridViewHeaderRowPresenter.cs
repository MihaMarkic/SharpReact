
namespace SharpReact.Wpf.Components
{
	public  class GridViewHeaderRowPresenter<TProps, TElement>: GridViewRowPresenterBase<TProps, TElement>
		where TProps : Props.GridViewHeaderRowPresenter
		where TElement : System.Windows.Controls.GridViewHeaderRowPresenter
	{
		protected override void CreateElement()
		{
			Element = (TElement)new System.Windows.Controls.GridViewHeaderRowPresenter();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
			if (nextProps.ColumnHeaderContainerStyle.HasValue)
			{
				Element.ColumnHeaderContainerStyle = nextProps.ColumnHeaderContainerStyle.Value.Value;
			}
			if (nextProps.ColumnHeaderTemplate.HasValue)
			{
				Element.ColumnHeaderTemplate = nextProps.ColumnHeaderTemplate.Value.Value;
			}
			if (nextProps.ColumnHeaderTemplateSelector.HasValue)
			{
				Element.ColumnHeaderTemplateSelector = nextProps.ColumnHeaderTemplateSelector.Value.Value;
			}
			if (nextProps.ColumnHeaderStringFormat.HasValue)
			{
				Element.ColumnHeaderStringFormat = nextProps.ColumnHeaderStringFormat.Value.Value;
			}
			if (nextProps.AllowsColumnReorder.HasValue)
			{
				Element.AllowsColumnReorder = nextProps.AllowsColumnReorder.Value.Value;
			}
			if (nextProps.ColumnHeaderContextMenu.HasValue)
			{
				Element.ColumnHeaderContextMenu = nextProps.ColumnHeaderContextMenu.Value.Value;
			}
			if (nextProps.ColumnHeaderToolTip.HasValue)
			{
				Element.ColumnHeaderToolTip = nextProps.ColumnHeaderToolTip.Value.Value;
			}
		}
	}
}
