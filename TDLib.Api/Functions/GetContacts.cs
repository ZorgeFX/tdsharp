using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public class GetContacts : Function<Users>
        {
            [JsonProperty("@type")] public override string DataType { get; set; } = "getContacts";

            [JsonProperty("@extra")] public override string Extra { get; set; }
        }
    }
}