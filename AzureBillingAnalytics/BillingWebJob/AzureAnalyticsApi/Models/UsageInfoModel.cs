﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using Newtonsoft.Json.Linq;

namespace BillingWebJob.Models
{
    public partial class UsageInfoModel
    {
        private double? _itemTotal;

        /// <summary>
        /// Optional.
        /// </summary>
        public double? ItemTotal
        {
            get { return this._itemTotal; }
            set { this._itemTotal = value; }
        }

        private string _meterCategory;

        /// <summary>
        /// Optional.
        /// </summary>
        public string MeterCategory
        {
            get { return this._meterCategory; }
            set { this._meterCategory = value; }
        }

        private string _meteredRegion;

        /// <summary>
        /// Optional.
        /// </summary>
        public string MeteredRegion
        {
            get { return this._meteredRegion; }
            set { this._meteredRegion = value; }
        }

        private string _meteredService;

        /// <summary>
        /// Optional.
        /// </summary>
        public string MeteredService
        {
            get { return this._meteredService; }
            set { this._meteredService = value; }
        }

        private string _meteredServiceType;

        /// <summary>
        /// Optional.
        /// </summary>
        public string MeteredServiceType
        {
            get { return this._meteredServiceType; }
            set { this._meteredServiceType = value; }
        }

        private string _meterName;

        /// <summary>
        /// Optional.
        /// </summary>
        public string MeterName
        {
            get { return this._meterName; }
            set { this._meterName = value; }
        }

        private string _meterSubCategory;

        /// <summary>
        /// Optional.
        /// </summary>
        public string MeterSubCategory
        {
            get { return this._meterSubCategory; }
            set { this._meterSubCategory = value; }
        }

        private string _organizationId;

        /// <summary>
        /// Optional.
        /// </summary>
        public string OrganizationId
        {
            get { return this._organizationId; }
            set { this._organizationId = value; }
        }

        private double? _quantity;

        /// <summary>
        /// Optional.
        /// </summary>
        public double? Quantity
        {
            get { return this._quantity; }
            set { this._quantity = value; }
        }

        private string _subceriptionId;

        /// <summary>
        /// Optional.
        /// </summary>
        public string SubceriptionId
        {
            get { return this._subceriptionId; }
            set { this._subceriptionId = value; }
        }

        private string _usageEndTime;

        /// <summary>
        /// Optional.
        /// </summary>
        public string UsageEndTime
        {
            get { return this._usageEndTime; }
            set { this._usageEndTime = value; }
        }

        private int? _usageInfoModelId;

        /// <summary>
        /// Optional.
        /// </summary>
        public int? UsageInfoModelId
        {
            get { return this._usageInfoModelId; }
            set { this._usageInfoModelId = value; }
        }

        private string _usageStartTime;

        /// <summary>
        /// Optional.
        /// </summary>
        public string UsageStartTime
        {
            get { return this._usageStartTime; }
            set { this._usageStartTime = value; }
        }

        private string _userProject;

        /// <summary>
        /// Optional.
        /// </summary>
        public string UserProject
        {
            get { return this._userProject; }
            set { this._userProject = value; }
        }

        /// <summary>
        /// Initializes a new instance of the UsageInfoModel class.
        /// </summary>
        public UsageInfoModel()
        {
        }

        /// <summary>
        /// Deserialize the object
        /// </summary>
        public virtual void DeserializeJson(JToken inputObject)
        {
            if (inputObject != null && inputObject.Type != JTokenType.Null)
            {
                JToken itemTotalValue = inputObject["ItemTotal"];
                if (itemTotalValue != null && itemTotalValue.Type != JTokenType.Null)
                {
                    this.ItemTotal = ((double) itemTotalValue);
                }
                JToken meterCategoryValue = inputObject["MeterCategory"];
                if (meterCategoryValue != null && meterCategoryValue.Type != JTokenType.Null)
                {
                    this.MeterCategory = ((string) meterCategoryValue);
                }
                JToken meteredRegionValue = inputObject["MeteredRegion"];
                if (meteredRegionValue != null && meteredRegionValue.Type != JTokenType.Null)
                {
                    this.MeteredRegion = ((string) meteredRegionValue);
                }
                JToken meteredServiceValue = inputObject["MeteredService"];
                if (meteredServiceValue != null && meteredServiceValue.Type != JTokenType.Null)
                {
                    this.MeteredService = ((string) meteredServiceValue);
                }
                JToken meteredServiceTypeValue = inputObject["MeteredServiceType"];
                if (meteredServiceTypeValue != null && meteredServiceTypeValue.Type != JTokenType.Null)
                {
                    this.MeteredServiceType = ((string) meteredServiceTypeValue);
                }
                JToken meterNameValue = inputObject["MeterName"];
                if (meterNameValue != null && meterNameValue.Type != JTokenType.Null)
                {
                    this.MeterName = ((string) meterNameValue);
                }
                JToken meterSubCategoryValue = inputObject["MeterSubCategory"];
                if (meterSubCategoryValue != null && meterSubCategoryValue.Type != JTokenType.Null)
                {
                    this.MeterSubCategory = ((string) meterSubCategoryValue);
                }
                JToken organizationIdValue = inputObject["OrganizationId"];
                if (organizationIdValue != null && organizationIdValue.Type != JTokenType.Null)
                {
                    this.OrganizationId = ((string) organizationIdValue);
                }
                JToken quantityValue = inputObject["Quantity"];
                if (quantityValue != null && quantityValue.Type != JTokenType.Null)
                {
                    this.Quantity = ((double) quantityValue);
                }
                JToken subceriptionIdValue = inputObject["SubceriptionId"];
                if (subceriptionIdValue != null && subceriptionIdValue.Type != JTokenType.Null)
                {
                    this.SubceriptionId = ((string) subceriptionIdValue);
                }
                JToken usageEndTimeValue = inputObject["UsageEndTime"];
                if (usageEndTimeValue != null && usageEndTimeValue.Type != JTokenType.Null)
                {
                    this.UsageEndTime = ((string) usageEndTimeValue);
                }
                JToken usageInfoModelIdValue = inputObject["UsageInfoModelId"];
                if (usageInfoModelIdValue != null && usageInfoModelIdValue.Type != JTokenType.Null)
                {
                    this.UsageInfoModelId = ((int) usageInfoModelIdValue);
                }
                JToken usageStartTimeValue = inputObject["UsageStartTime"];
                if (usageStartTimeValue != null && usageStartTimeValue.Type != JTokenType.Null)
                {
                    this.UsageStartTime = ((string) usageStartTimeValue);
                }
                JToken userProjectValue = inputObject["UserProject"];
                if (userProjectValue != null && userProjectValue.Type != JTokenType.Null)
                {
                    this.UserProject = ((string) userProjectValue);
                }
            }
        }
    }
}