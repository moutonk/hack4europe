using System;
using System.Diagnostics;

namespace Hack4Europe.Utils
{
    public static class Logs
    {
        public static class Error
        {
            public static void ShowError(Exception exp)
            {
                Output.ShowOutput(Environment.NewLine + "Priority: " + Environment.NewLine + exp.StackTrace + ": " + exp.Message + Environment.NewLine);
            }

            public static void ShowError(string msg)
            {
                Output.ShowOutput(Environment.NewLine + "Priority: " + ": " + msg);
            }

            public static void ShowError(string msg, Exception exp)
            {
                Output.ShowOutput(Environment.NewLine + "Priority: " + ": " + msg + ":" + Environment.NewLine + exp.Message);
            }
        }

        public static class Output
        {
            [Conditional("DEBUG")]
            public static void ShowOutput(string output)
            {
                Debug.WriteLine(output);
            }
        }
    }
}
