namespace RentalPlanning.CustomElements
{
	public sealed partial class DatePicker : UserControl
	{
		public DatePicker()
		{
			this.InitializeComponent();
        }

        public static readonly DependencyProperty HeaderLabelProperty =
            DependencyProperty.Register("HeaderLabel", typeof(string), typeof(DatePicker), new PropertyMetadata("", OnHeaderLabelPropertyChanged));

        public string HeaderLabel
        {
            get { return (string)GetValue(HeaderLabelProperty); }
            set { SetValue(HeaderLabelProperty, value); }
        }

        private static void OnHeaderLabelPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            DatePicker? control = d as DatePicker;
            control?.SetHeaderLabel((string)e.NewValue);
        }

        private void SetHeaderLabel(string labelText)
        {
            CustomDatePicker.Header = labelText;
        }
    }
}
