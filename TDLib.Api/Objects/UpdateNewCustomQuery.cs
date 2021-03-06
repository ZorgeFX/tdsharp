using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public partial class Update : Object
        {
            public class UpdateNewCustomQuery : Update
            {
                [JsonProperty("@type")] public override string DataType { get; set; } = "updateNewCustomQuery";

                [JsonProperty("@extra")] public override string Extra { get; set; }

                [JsonConverter(typeof(Converter.Int64))]
                [JsonProperty("id")]
                public Int64 Id { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("data")]
                public string Data { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("timeout")]
                public int Timeout { get; set; }
            }
        }
    }
}