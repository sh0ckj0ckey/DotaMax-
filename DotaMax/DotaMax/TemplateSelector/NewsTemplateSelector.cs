using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace DotaMax.TemplateSelector
{
    public sealed class NewsTemplateSelector : DataTemplateSelector
    {
        public DataTemplate HeaderNews { get; set; }
        public DataTemplate NormalNews { get; set; }
        protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
        {
            var itemsControl = ItemsControl.ItemsControlFromItemContainer(container);
            return (itemsControl.IndexFromContainer(container) == 0) ? HeaderNews : NormalNews;
        }
    }
}
