using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public partial class MessageContent : Object
        {
            public class MessageDocument : MessageContent
            {
                [JsonProperty("@type")] public override string DataType { get; set; } = "messageDocument";

                [JsonProperty("@extra")] public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("document")]
                public Document Document { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("caption")]
                public FormattedText Caption { get; set; }
            }
        }
    }
}