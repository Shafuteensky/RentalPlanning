using Microsoft.UI.Xaml.Controls;

namespace RentalPlanning.CustomElements
{

    public sealed partial class ContentContainer : UserControl
	{
		public ContentContainer()
		{
			this.InitializeComponent();
        }

        public object AdditionalContent
        {
            get { return (object)GetValue(AdditionalContentProperty); }
            set { SetValue(AdditionalContentProperty, value); }
        }
        public static readonly DependencyProperty AdditionalContentProperty =
            DependencyProperty.Register("AdditionalContent", typeof(object), typeof(ContentContainer),
              new PropertyMetadata(null));
    }
}
