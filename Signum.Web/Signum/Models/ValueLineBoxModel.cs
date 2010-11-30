﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Signum.Entities;
using Signum.Utilities;
using System.Reflection;
using Signum.Web.Properties;

namespace Signum.Web
{
    [Serializable]
    public class ValueLineBoxModel : Entity
    {
        public ValueLineBoxModel()
        {
        }

        public ValueLineBoxModel(ModifiableEntity relatedEntity, ValueLineBoxType boxType, string fieldName, string topText)
        {
            related = relatedEntity;
            this.boxType = boxType;
            this.fieldName = fieldName;
            this.topText = topText;
        }

        ModifiableEntity related;
        [NotNullValidator]
        public ModifiableEntity Related
        {
            get { return related; }
            set { Set(ref related, value, () => Related); }
        }

        string topText;
        public string TopText
        {
            get { return topText; }
            set { Set(ref topText, value, () => TopText); }
        }

        string fieldName;
        public string FieldName
        {
            get { return fieldName; }
            set { Set(ref fieldName, value, () => FieldName); }
        }

        ValueLineBoxType boxType;
        public ValueLineBoxType BoxType
        {
            get { return boxType; }
            set { Set(ref boxType, value, () => BoxType); }
        }

        int? intValue;
        public int? IntValue
        {
            get { return intValue; }
            set { Set(ref intValue, value, () => IntValue); }
        }

        decimal? decimalValue;
        public decimal? DecimalValue
        {
            get { return decimalValue; }
            set { Set(ref decimalValue, value, () => DecimalValue); }
        }

        bool? boolValue;
        public bool? BoolValue
        {
            get { return boolValue; }
            set { Set(ref boolValue, value, () => BoolValue); }
        }

        string stringValue;
        public string StringValue
        {
            get { return stringValue; }
            set { Set(ref stringValue, value, () => StringValue); }
        }

        DateTime? dateValue;
        public DateTime? DateValue
        {
            get { return dateValue; }
            set { Set(ref dateValue, value, () => DateValue); }
        }

        protected override string PropertyValidation(PropertyInfo pi)
        {
            string error = Resources.ValueMustBeSpecifiedFor0.Formato(fieldName);
            switch (boxType)
            { 
                case ValueLineBoxType.Boolean:
                    if (boolValue == null)
                        return error;
                    break;
                case ValueLineBoxType.Integer:
                    if (intValue == null)
                        return error;
                    break;
                case ValueLineBoxType.Decimal:
                    if (decimalValue == null)
                        return error;
                    break;
                case ValueLineBoxType.DateTime:
                    if (dateValue == null)
                        return error;
                    break;
                case ValueLineBoxType.String:
                    if (stringValue == null)
                        return error;
                    break;
                default:
                    throw new ArgumentException("ValueLineBoxType {0} does not exist".Formato(boxType));
            }
            return null;
        }
    }

    public enum ValueLineBoxType
    { 
        String,
        Boolean,
        Integer,
        Decimal,
        DateTime,
    }
}
