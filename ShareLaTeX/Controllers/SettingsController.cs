using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace ShareLaTeX.Controllers
{
    public class SettingsController
    {
        private const string PASSWORD = "Password";
        private const string EMAIL = "Email";

        public static string Password { get { return (string)ApplicationData.Current.LocalSettings.Values[PASSWORD]; } set { ApplicationData.Current.LocalSettings.Values[PASSWORD] = value; } }
        public static string Email { get { return (string)ApplicationData.Current.LocalSettings.Values[EMAIL]; } set { ApplicationData.Current.LocalSettings.Values[EMAIL] = value; } }
    }
}
