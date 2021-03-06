using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public partial class ChatMemberStatus : Object
        {
            public class ChatMemberStatusBanned : ChatMemberStatus
            {
                [JsonProperty("@type")] public override string DataType { get; set; } = "chatMemberStatusBanned";

                [JsonProperty("@extra")] public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("banned_until_date")]
                public int BannedUntilDate { get; set; }
            }
        }
    }
}