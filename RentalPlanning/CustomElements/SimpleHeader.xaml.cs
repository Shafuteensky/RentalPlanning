namespace RentalPlanning.CustomElements
{
    public sealed partial class SimpleHeader : UserControl
    {
        public SimpleHeader()
        {
            this.InitializeComponent();
        }

        public static readonly DependencyProperty LabelProperty =
            DependencyProperty.Register("Label", typeof(string), typeof(SimpleHeader), new PropertyMetadata("", OnLabelPropertyChanged));

        public string Label
        {
            get { return (string)GetValue(LabelProperty); }
            set { SetValue(LabelProperty, value); }
        }

        private static void OnLabelPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            SimpleHeader? control = d as SimpleHeader;
            control?.SetLabel((string)e.NewValue);
        }

        private void SetLabel(string labelText)
        {
            HeaderText.Label = labelText;
        }
    }
}
