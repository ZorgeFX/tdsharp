using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public partial class PassportElement : Object
        {
            public class PassportElementPassportRegistration : PassportElement
            {
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "passportElementPassportRegistration";

                [JsonProperty("@extra")] public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("passport_registration")]
                public PersonalDocument PassportRegistration { get; set; }
            }
        }
    }
}