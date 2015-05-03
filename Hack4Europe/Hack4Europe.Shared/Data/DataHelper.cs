
namespace Hack4Europe.Data
{
    public static class ErrorInterpretor
    {
        public static string GetValue(int code, object extra = null)
        {
            switch (code)
            {
                //case 400:
                //    return AppResources.UserAlreadyExists;
                //case 401:
                //    return AppResources.IncorrectLoginOrPassword;
                //case 404:
                //    return AppResources.NetworkProblem;
                //default:
                //    return AppResources.UnknownError;
            }
            return string.Empty;
        }
    }
}
