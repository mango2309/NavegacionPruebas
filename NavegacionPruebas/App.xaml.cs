using NavegacionPruebas.MVVM.Pages;

namespace NavegacionPruebas
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new NavigationPage(new StartPage());
		}
	}
}
