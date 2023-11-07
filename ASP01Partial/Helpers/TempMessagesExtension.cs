using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace ASP01Partial.Helpers
{
    public static class TempMessagesExtension
    {
        public static void AddMessage(this ITempDataDictionary tempData, string key, TempMessage msg)
        {

        }
    }

    public enum MessageType {
        Success = 1,
        Danger,
        Warning,
        Info
    }

    public class TempMessage
    {
        public TempMessage(MessageType type, string text)
        {
            Type = type;
            Text = text;
        }

        public MessageType Type { get; set; }
        public string Text { get; set; }
    }
}
