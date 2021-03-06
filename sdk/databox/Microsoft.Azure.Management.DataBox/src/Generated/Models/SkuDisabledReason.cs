// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataBox.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for SkuDisabledReason.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SkuDisabledReason
    {
        /// <summary>
        /// SKU is not disabled.
        /// </summary>
        [EnumMember(Value = "None")]
        None,
        /// <summary>
        /// SKU is not available in the requested country.
        /// </summary>
        [EnumMember(Value = "Country")]
        Country,
        /// <summary>
        /// SKU is not available to push data to the requested Azure region.
        /// </summary>
        [EnumMember(Value = "Region")]
        Region,
        /// <summary>
        /// Required features are not enabled for the SKU.
        /// </summary>
        [EnumMember(Value = "Feature")]
        Feature,
        /// <summary>
        /// Subscription does not have required offer types for the SKU.
        /// </summary>
        [EnumMember(Value = "OfferType")]
        OfferType,
        /// <summary>
        /// Subscription has not registered to Microsoft.DataBox and Service
        /// does not have the subscription notification.
        /// </summary>
        [EnumMember(Value = "NoSubscriptionInfo")]
        NoSubscriptionInfo
    }
    internal static class SkuDisabledReasonEnumExtension
    {
        internal static string ToSerializedValue(this SkuDisabledReason? value)
        {
            return value == null ? null : ((SkuDisabledReason)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this SkuDisabledReason value)
        {
            switch( value )
            {
                case SkuDisabledReason.None:
                    return "None";
                case SkuDisabledReason.Country:
                    return "Country";
                case SkuDisabledReason.Region:
                    return "Region";
                case SkuDisabledReason.Feature:
                    return "Feature";
                case SkuDisabledReason.OfferType:
                    return "OfferType";
                case SkuDisabledReason.NoSubscriptionInfo:
                    return "NoSubscriptionInfo";
            }
            return null;
        }

        internal static SkuDisabledReason? ParseSkuDisabledReason(this string value)
        {
            switch( value )
            {
                case "None":
                    return SkuDisabledReason.None;
                case "Country":
                    return SkuDisabledReason.Country;
                case "Region":
                    return SkuDisabledReason.Region;
                case "Feature":
                    return SkuDisabledReason.Feature;
                case "OfferType":
                    return SkuDisabledReason.OfferType;
                case "NoSubscriptionInfo":
                    return SkuDisabledReason.NoSubscriptionInfo;
            }
            return null;
        }
    }
}
