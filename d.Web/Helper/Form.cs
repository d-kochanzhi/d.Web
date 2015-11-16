using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Web;

namespace d.Web.Helper
{
    public static class Form
    {
        public static T QueryValue<T>(string key, string format = "yyyyMMdd", string decimalSeparator = ".")
        {
            Type type = typeof(T);
            TypeCode code = type.IsGenericType ? Type.GetTypeCode(type.GetGenericArguments()[0]) : Type.GetTypeCode(type);
            string value = HttpContext.Current.Request.QueryString[key];
            object result = null;

            switch (code)
            {
                case TypeCode.String:
                    return (T)Convert.ChangeType(value, type);

                case TypeCode.Char:
                    char charvalue;
                    if (Char.TryParse(value, out charvalue))
                    {
                        result = charvalue;
                    }
                    break;

                case TypeCode.Boolean:
                    bool boolvalue;
                    if (bool.TryParse(value, out boolvalue))
                    {
                        result = boolvalue;
                    }
                    break;

                case TypeCode.Int16:
                    Int16 int16value;
                    if (Int16.TryParse(value, out int16value))
                    {
                        result = int16value;
                    }
                    break;

                case TypeCode.Int32:
                    Int32 int32value;
                    if (Int32.TryParse(value, out int32value))
                    {
                        result = int32value;
                    }
                    break;

                case TypeCode.Int64:
                    Int64 int64value;
                    if (Int64.TryParse(value, out int64value))
                    {
                        result = int64value;
                    }
                    break;

                case TypeCode.DateTime:
                    DateTime datetimevalue;
                    if (DateTime.TryParseExact(value, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out datetimevalue))
                    {
                        result = datetimevalue;
                    }
                    break;

                case TypeCode.Decimal:
                    decimal decimalvalue;
                    if (decimal.TryParse(value, NumberStyles.Number, new NumberFormatInfo { NumberDecimalSeparator = decimalSeparator }, out decimalvalue))
                    {
                        result = decimalvalue;
                    }
                    break;

                default: break;
            }

            return result == null ? default(T) : (T)result;
        }

        public static T PostValue<T>(string key, string format = "yyyyMMdd", string decimalSeparator = ".")
        {
            Type type = typeof(T);
            TypeCode code = type.IsGenericType ? Type.GetTypeCode(type.GetGenericArguments()[0]) : Type.GetTypeCode(type);
            string value = HttpContext.Current.Request.Params[key];
            object result = null;

            switch (code)
            {
                case TypeCode.String:
                    return (T)Convert.ChangeType(value, type);

                case TypeCode.Char:
                    char charvalue;
                    if (Char.TryParse(value, out charvalue))
                    {
                        result = charvalue;
                    }
                    break;

                case TypeCode.Boolean:
                    bool boolvalue;
                    if (bool.TryParse(value, out boolvalue))
                    {
                        result = boolvalue;
                    }
                    break;

                case TypeCode.Int16:
                    Int16 int16value;
                    if (Int16.TryParse(value, out int16value))
                    {
                        result = int16value;
                    }
                    break;

                case TypeCode.Int32:
                    Int32 int32value;
                    if (Int32.TryParse(value, out int32value))
                    {
                        result = int32value;
                    }
                    break;

                case TypeCode.Int64:
                    Int64 int64value;
                    if (Int64.TryParse(value, out int64value))
                    {
                        result = int64value;
                    }
                    break;

                case TypeCode.DateTime:
                    DateTime datetimevalue;
                    if (DateTime.TryParseExact(value, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out datetimevalue))
                    {
                        result = datetimevalue;
                    }
                    break;

                case TypeCode.Decimal:
                    decimal decimalvalue;
                    if (decimal.TryParse(value, NumberStyles.Number, new NumberFormatInfo { NumberDecimalSeparator = decimalSeparator }, out decimalvalue))
                    {
                        result = decimalvalue;
                    }
                    break;

                default: break;
            }

            return result == null ? default(T) : (T)result;
        }
    }
}
