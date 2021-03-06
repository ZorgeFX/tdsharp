using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public class TestInt : Object
        {
            [JsonProperty("@type")] public override string DataType { get; set; } = "testInt";

            [JsonProperty("@extra")] public override string Extra { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("value")]
            public int Value { get; set; }
        }
    }
}