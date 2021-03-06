using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public class SendEmailAddressVerificationCode : Function<EmailAddressAuthenticationCodeInfo>
        {
            [JsonProperty("@type")] public override string DataType { get; set; } = "sendEmailAddressVerificationCode";

            [JsonProperty("@extra")] public override string Extra { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("email_address")]
            public string EmailAddress { get; set; }
        }
    }
}