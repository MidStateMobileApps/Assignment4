using Xamarin.Forms;

namespace GoSoon
{
    public partial class GoSoonPage : ContentPage
    {
        public GoSoonPage()
        {
            InitializeComponent();
            Label l = new Label()
            {
                Text = "Bubba!"
            };
            this.Content = l;
            l.Font = Font.SystemFontOfSize(28);
            l.HorizontalOptions = LayoutOptions.Center;
            l.VerticalOptions = LayoutOptions.Center;
        }
    }
}
