using System;
using Windows.Storage;
using Hack4Europe.Utils;

namespace Hack4Europe.Data
{
    public class LocalData
    {
        private const string ConnectionInfos = "spicerConnectionInfos";
        private const string FirstConnection = "spicerFirstConnection";
        private const string AccessLocation = "spicerAccessLocation";
        private const string AuthId = "spicerAuthentificationId";
        private const string Settings = "spicerSettings";

        public static void ResetAll()
        {
            try
            {
                ApplicationData.Current.LocalSettings.Values.Remove(ConnectionInfos);
                ApplicationData.Current.LocalSettings.Values.Remove(FirstConnection);
                ApplicationData.Current.LocalSettings.Values.Remove(AccessLocation);
                ApplicationData.Current.LocalSettings.Values.Remove(AuthId);
                ApplicationData.Current.LocalSettings.Values.Remove(Settings);
            }
            catch (Exception exp)
            {
                Logs.Error.ShowError("ResetAll: " + exp.Message, exp);
            }
        }

        public static object GetSettings()
        {
            try
            {
                return ApplicationData.Current.LocalSettings.Containers[Settings];
            }
            catch (Exception exp)
            {
                Logs.Error.ShowError("GetSettings: " + exp.Message, exp);
            }
            return null;
        }

        public static void SetSettings<T>(T s)
        {
            try
            {
                ApplicationData.Current.LocalSettings.Values[Settings] = s;
            }
            catch (Exception exp)
            {
                Logs.Error.ShowError("SetSettings: " + exp.Message, exp);
            }
        }

        public static bool IsFirstConnection()
        {
            try
            {
                return (ApplicationData.Current.LocalSettings.Values.ContainsKey(FirstConnection) == false);
            }
            catch (Exception exp)
            {
                Logs.Error.ShowError("IsFirstConnection: " + exp.Message, exp);
            }
            return true;
        }

        public static void SetFirstConnection()
        {
            try
            {
                if (ApplicationData.Current.LocalSettings.Values.ContainsKey(FirstConnection) == true)
                    ApplicationData.Current.LocalSettings.Values[FirstConnection] = false;
                else
                    ApplicationData.Current.LocalSettings.Values[FirstConnection] = true;
            }
            catch (Exception exp)
            {
                Logs.Error.ShowError("SetFirstConnection: " + exp.Message, exp);
            }
        }

        public static void SaveConnectionInfos<T>(T infos)
        {
            try
            {
                ApplicationData.Current.LocalSettings.Values[ConnectionInfos] = infos;
            }
            catch (Exception exp)
            {
                Logs.Error.ShowError("SaveConnectionInfos: " + exp.Message, exp);
            }
        }

        public static T GetConnectionInfos<T>() where T : class
        {
            try
            {
                return (T)ApplicationData.Current.LocalSettings.Values[ConnectionInfos];
            }
            catch (Exception exp)
            {
                Logs.Error.ShowError("GetConnectionInfos: " + exp.Message, exp);
            }
            return default(T);
        }

        public static void SaveAuthId(string id)
        {
            try
            {
                ApplicationData.Current.LocalSettings.Values[AuthId] = id;
            }
            catch (Exception exp)
            {
                Logs.Error.ShowError("SaveAuthId: " + exp.Message, exp);
            }
        }

        public static string GetAuthId()
        {
            try
            {
                return ApplicationData.Current.LocalSettings.Values.ContainsKey(AuthId) == true
               ? (string)ApplicationData.Current.LocalSettings.Values[AuthId]
               : null;
            }
            catch (Exception exp)
            {
                Logs.Error.ShowError("GetAuthId: " + exp.Message, exp);
            }
            return null;
        }

        public static void SaveAccessLocation(bool status)
        {
            try
            {
                ApplicationData.Current.LocalSettings.Values[AccessLocation] = status;
            }
            catch (Exception exp)
            {
                Logs.Error.ShowError("SaveAccessLocation: " + exp.Message, exp);
            }
        }

        public static bool? GetAccessLocation()
        {
            try
            {
                return ApplicationData.Current.LocalSettings.Values.ContainsKey(AccessLocation) == true
                     ? (bool)ApplicationData.Current.LocalSettings.Values[AccessLocation]
                     : (bool?)null;
            }
            catch (Exception exp)
            {
                Logs.Error.ShowError("GetAccessLocation: " + exp.Message, exp);
            }
            return null;
        }
    }
}
