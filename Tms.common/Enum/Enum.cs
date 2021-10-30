using Newtonsoft.Json.Converters;
using System.Text.Json.Serialization;
using System.ComponentModel;
namespace Tms.Common.Enum
{
    public static partial class Enum
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public enum Subject
        {
            Feedback=1,
            Complaint,
            Suggestion
        }
    }
}
