using System;
using System.Diagnostics;
using Atrico.Lib.Assertions;
using Atrico.Lib.Assertions.Constraints;
using Atrico.Lib.Assertions.Elements;
using Atrico.Lib.Common;
using Atrico.Lib.Dimensions.Dimensions;
using Atrico.Lib.Dimensions.Units;
using Atrico.Lib.Testing;

namespace Atrico.Lib.Dimensions.Tests
{
    public class TestDimensionBase<TDim> : TestFixtureBase where TDim : Dimension
    {
        private static decimal CorrectPrecision(decimal value)
        {
            return Math.Round(value, 16, MidpointRounding.ToEven);
        }

        private static bool CompareDecimals(decimal lhs, object rhs)
        {
            var lhsRnd = CorrectPrecision(lhs);
            var rhsRnd = CorrectPrecision((decimal) rhs);
            return lhsRnd.Equals(rhsRnd);
        }

        protected static void AssertValue<TUnit>(DimensionValue<TDim> dimValue, decimal value, string symbol) where TUnit : Unit<TDim>, new()
        {
            Debug.WriteLine(dimValue.ToString<TUnit>());
            Assert.That(Value.Of(dimValue.GetValue<TUnit>()).Is().EqualTo(value, CompareDecimals), "{0}: Compare to literal", typeof(TUnit).Name);
            Assert.That(Value.Of(dimValue.ToString<TUnit>()).Is().EqualTo(string.Format("{0}{1}", CorrectPrecision(value).ToTrimmedString(), symbol)), "{0}: To String", typeof(TUnit).Name);
        }
    }
}