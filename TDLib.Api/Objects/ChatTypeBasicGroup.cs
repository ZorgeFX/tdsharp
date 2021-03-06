using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public partial class ChatType : Object
        {
            public class ChatTypeBasicGroup : ChatType
            {
                [JsonProperty("@type")] public override string DataType { get; set; } = "chatTypeBasicGroup";

                [JsonProperty("@extra")] public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("basic_group_id")]
                public int BasicGroupId { get; set; }
            }
        }
    }
}