namespace AppBindingCommands01
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }

        protected override void OnStart()
        {
            base.OnStart();
            Preferences.Set("AcaoStart", string.Format("* App executado às {0} ", DateTime.Now));
        }

        protected override void OnSleep()
        {
            base.OnSleep();
            Preferences.Set("AcaoSleep", string.Format("* App em segundo plano às {0} ", DateTime.Now));
        }

        protected override void OnResume()
        {
            base.OnResume();
            Preferences.Set("AcaoResume", string.Format("* App reativado às {0}", DateTime.Now));
        }
    }
}