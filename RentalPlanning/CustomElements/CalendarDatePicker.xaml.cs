namespace RentalPlanning.CustomElements
{
	public sealed partial class CalendarDatePicker : UserControl
	{
		public CalendarDatePicker()
		{
			this.InitializeComponent();
        }

        public static readonly DependencyProperty HeaderLabelProperty =
            DependencyProperty.Register("HeaderLabel", typeof(string), typeof(CalendarDatePicker), new PropertyMetadata("", OnHeaderLabelPropertyChanged));

        public string HeaderLabel
        {
            get { return (string)GetValue(HeaderLabelProperty); }
            set { SetValue(HeaderLabelProperty, value); }
        }

        private static void OnHeaderLabelPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            CalendarDatePicker? control = d as CalendarDatePicker;
            control?.SetHeaderLabel((string)e.NewValue);
        }

        private void SetHeaderLabel(string labelText)
        {
            CustomCalendarDatePicker.Header = labelText;
        }
    }
}
