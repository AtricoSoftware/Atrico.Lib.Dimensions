using System;
using Atrico.Lib.Common;
using Atrico.Lib.Dimensions.Dimensions;
using Atrico.Lib.Dimensions.Units;
using Atrico.Lib.DomainModel;

namespace Atrico.Lib.Dimensions
{
    public class DimensionValue<TDim> : ValueObject<DimensionValue<TDim>> where TDim : Dimension
    {
        private readonly decimal _value;
        private readonly Unit<TDim> _unit;

        public static DimensionValue<TDim> Create<TUnit>(decimal value) where TUnit : Unit<TDim>, new()
        {
            return Create(value, new TUnit());
        }

        public static DimensionValue<TDim> Create(decimal value, Unit<TDim> unit)
        {
            return new DimensionValue<TDim>(value, unit);
        }

        public decimal GetValue<TUnit>() where TUnit : Unit<TDim>, new()
        {
            return GetValue(new TUnit());
        }

        private decimal GetValue(Unit<TDim> unit)
        {
            var converted = _unit.ConvertValue(_value, unit);
            return Math.Round(converted, 16, MidpointRounding.ToEven);
        }

        private DimensionValue(decimal value, Unit<TDim> unit)
        {
            _value = value;
            _unit = unit;
        }

        #region Equality

        protected override int GetHashCodeImpl()
        {
            return _value.GetHashCode();
        }

        protected override bool EqualsImpl(DimensionValue<TDim> other)
        {
            return Equals(_value, other.GetValue(_unit));
        }

        #endregion

        public string ToString<TUnit>() where TUnit : Unit<TDim>, new()
        {
            return ToString(new TUnit());
        }

        private string ToString(Unit<TDim> unit)
        {
            return string.Format("{0}{1}", GetValue(unit).ToTrimmedString(), unit.Symbol);
        }
    }
}