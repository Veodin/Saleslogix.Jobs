﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SalesLogix.Jobs.Delivery.Localization
{
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;

    internal class SRCategoryAttribute : System.ComponentModel.CategoryAttribute
    {
        public SRCategoryAttribute(string category) :
            base(category)
        {
        }
        protected override string GetLocalizedString(string value)
        {
            return SR.GetString(value);
        }
    }
    internal class SRDefaultValueAttribute : System.ComponentModel.DefaultValueAttribute
    {
        private bool _replaced;
        public SRDefaultValueAttribute(string value) :
            base(value)
        {
        }
        public override object Value
        {
            get
            {
                if ((this._replaced == false))
                {
                    base.SetValue(SR.GetString(((string)(base.Value))));
                    this._replaced = true;
                }
                return base.Value;
            }
        }
    }
    internal class SRDescriptionAttribute : System.ComponentModel.DescriptionAttribute
    {
        private bool _replaced;
        public SRDescriptionAttribute(string description) :
            base(description)
        {
        }
        public override string Description
        {
            get
            {
                if ((this._replaced == false))
                {
                    base.DescriptionValue = SR.GetString(base.Description);
                    this._replaced = true;
                }
                return base.Description;
            }
        }
    }
    [GeneratedCodeAttribute("Sage.VisualStudio.SRGenerator", "1.0.0.0")]
    [DebuggerNonUserCodeAttribute()]
    [CompilerGeneratedAttribute()]
    internal sealed class SR
    {
        private static System.Resources.ResourceManager resourceMan;
        private static System.Globalization.CultureInfo resourceCulture;
        public const string Job_ProcessDeliveryItems_DisplayName = "Job_ProcessDeliveryItems_DisplayName";
        public const string Job_ProcessDeliveryItems_Description = "Job_ProcessDeliveryItems_Description";

        internal static System.Globalization.CultureInfo Culture
        {
            get
            {
                return SR.resourceCulture;
            }
            set
            {
                SR.resourceCulture = value;
            }
        }
        public static string GetString(string name)
        {
            if (object.ReferenceEquals(SalesLogix.Jobs.Delivery.Localization.SR.resourceMan, null))
            {
                SR.resourceMan = new System.Resources.ResourceManager("SalesLogix.Jobs.Delivery.Localization.SR", typeof(SR).Assembly);
            }
            return SR.resourceMan.GetString(name);
        }
    }
    [AttributeUsage(AttributeTargets.All)]
    internal class SRDisplayNameAttribute : System.ComponentModel.DisplayNameAttribute
    {
        private bool _replaced;
        public SRDisplayNameAttribute(string displayname) :
            base(displayname)
        {
        }
        public override string DisplayName
        {
            get
            {
                if ((this._replaced == false))
                {
                    base.DisplayNameValue = SR.GetString(base.DisplayName);
                    this._replaced = true;
                }
                return base.DisplayName;
            }
        }
    }
}