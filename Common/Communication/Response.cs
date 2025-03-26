using System.Text.Json.Serialization;

namespace Common.Communication
{
    public class Response
    {
        public object Result { get; set; }

        [JsonIgnore] // Ignoriše Exception prilikom serijalizacije
        public Exception Exception { get; set; }
        public bool IsSuccessful { get; set; }
    }
}
