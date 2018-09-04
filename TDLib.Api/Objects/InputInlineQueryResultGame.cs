using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public partial class InputInlineQueryResult : Object
        {
            public class InputInlineQueryResultGame : InputInlineQueryResult
            {
                [JsonProperty("@type")] public override string DataType { get; set; } = "inputInlineQueryResultGame";

                [JsonProperty("@extra")] public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("id")]
                public string Id { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("game_short_name")]
                public string GameShortName { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("reply_markup")]
                public ReplyMarkup ReplyMarkup { get; set; }
            }
        }
    }
}