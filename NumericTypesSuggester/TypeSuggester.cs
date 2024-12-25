using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace NumericTypesSuggester
{
    class TypeSuggester
    {
        public const string BigInteger = "BigInteger";
        public const string Long = "Long";
        public const string Ulong = "ulong";
        public const string Int = "int";
        public const string Uint = "uint";
        public const string Short = "short";
        public const string Ushort = "ushort";
        public const string Byte = "byte";
        public const string Sbyte = "sbyte";
        public const string Float = "float";
        public const string Double = "double";
        public const string Decimal = "decimal";
        public const string ImpossibleRepresentation = "Impossible representation";

        public static string GetType(BigInteger min, BigInteger max, bool isIntegral, bool isPrecise)
        {
            return isIntegral ? GetIntegralType(min, max) : GetFloatingPointType(min, max, isPrecise);
        }

        private static string GetFloatingPointType(BigInteger min, BigInteger max, bool isPrecise)
        {
            if (isPrecise)
            {
                if (min >= new BigInteger(decimal.MinusOne) && max <= new BigInteger(decimal.MaxValue))
                    return Decimal;
                return ImpossibleRepresentation;
            }
            else
            {
                if (min >= new BigInteger(float.MinValue) && max <= new BigInteger(float.MaxValue))
                    return Float;
                if (min >= new BigInteger(double.MinValue) && max <= new BigInteger(double.MaxValue))
                    return Double;
                return ImpossibleRepresentation;
            }
        }

        private static string GetIntegralType(BigInteger min, BigInteger max)
        {
            if (min >= 0) // Usighned check
                return GetIntegralUnsignType(min, max);
            else // Sighned check
            {
                return GetIntegerSignType(min, max);
            }
        }

        private static string GetIntegerSignType(BigInteger min, BigInteger max)
        {
            if (min >= sbyte.MinValue && max <= sbyte.MaxValue)
                return Sbyte;
            else if (min >= short.MinValue && max <= short.MaxValue)
                return Short;
            else if (min >= int.MinValue && max <= int.MaxValue)
                return Int;
            else if (min >= long.MinValue && max <= long.MaxValue)
                return Long;
            return BigInteger;
        }

        private static string GetIntegralUnsignType(BigInteger min, BigInteger max)
        {
            if (max <= byte.MaxValue)
                return Byte;
            if (max <= ushort.MaxValue)
                return Ushort;
            if (max <= uint.MaxValue)
                return Uint;
            if (max <= ulong.MaxValue)
                return Ulong;
            return BigInteger;
        }
    }
}
