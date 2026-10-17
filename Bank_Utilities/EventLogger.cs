using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
namespace Bank_Utilities
{
    public static class EventLogger
    {

        private static string SourceName= "Bank";


        static EventLogger()
        {
            if (!EventLog.SourceExists(SourceName))
            {
                EventLog.CreateEventSource(SourceName, "Application");
            }
        }


        public static void Log(string message, EventLogEntryType type)
        {
            EventLog.WriteEntry(SourceName, message, type);
        }


        public static void LogException(Exception ex, [CallerMemberName]string location="")
        {
            EventLog.WriteEntry(SourceName, FormatMessage(ex,location), EventLogEntryType.Error);
        }



        private static  string FormatMessage(Exception ex,string location)
        {

            string message =
             $"--- Exception Log ---\n" +
             $"Timestamp: {DateTime.Now}\n" +
             $"Location: {location}\n" +
             $"Message: {ex.Message}\n" +
             $"Inner Exception: {(ex.InnerException != null ? ex.InnerException.Message : "N/A")}\n" +
             $"Stack Trace: {ex.StackTrace}\n" +
             $"Source: {ex.Source}\n" +
             $"-----------------------";





            // Using StringBuilder for efficient string construction

            //StringBuilder sb = new StringBuilder();

            //sb.AppendLine("--- Exception Log ---");
            //sb.AppendLine($"Timestamp: {DateTime.Now}");
            //sb.AppendLine($"Location: {location}");
            //sb.AppendLine($"Message: {ex.Message}");
            //sb.AppendLine($"Inner Exception: {(ex.InnerException != null ? ex.InnerException.Message : "N/A")}");
            //sb.AppendLine($"Stack Trace: {ex.StackTrace}");
            //sb.AppendLine($"Source: {ex.Source}");
            //sb.AppendLine("-----------------------");

            //string message = sb.ToString();



            return message;


        }   


    }
}
