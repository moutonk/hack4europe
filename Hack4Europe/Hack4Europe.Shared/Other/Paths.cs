using System;

namespace Hack4Europe.Other
{
    public static class Paths
    {
        public static readonly Uri ConnectionView = new Uri("/View/LoginView.xaml", UriKind.Relative);
        public static readonly Uri SignUpView = new Uri("/View/SignUpView.xaml", UriKind.Relative);
        public static readonly Uri FirstView = new Uri("/View/FirstView.xaml", UriKind.Relative);
        public static readonly Uri StartView = new Uri("/View/StartPage.xaml", UriKind.Relative);
        public static readonly Uri SettingsView = new Uri("/View/SettingsView.xaml", UriKind.Relative);
        public static readonly Uri TooManyFantasmsView = new Uri("/View/TooManyFantasmsView.xaml", UriKind.Relative);

        //PROD: http://spicer-env-stag.elasticbeanstalk.com/api/
        //INT: http://spicer-env-3.elasticbeanstalk.com/api/
        public static readonly string ServerAddress = "http://spicer-env-stag.elasticbeanstalk.com/api/";

        static Paths()
        {

        }
    }
}
