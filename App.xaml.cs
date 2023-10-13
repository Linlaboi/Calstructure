namespace Calstructure
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Views.KiTableContentPage();
                //new AppShell();
        }
    }
}