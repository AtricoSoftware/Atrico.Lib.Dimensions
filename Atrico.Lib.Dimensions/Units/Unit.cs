using System;
using Atrico.Lib.Common;
using Atrico.Lib.Dimensions.Dimensions;

namespace Atrico.Lib.Dimensions.Units
{
    public abstract class Unit<TDim> : EquatableObject<Unit<TDim>> where TDim : Dimension
    {
        private readonly Type _type;

        protected Unit()
        {
            _type = GetType();
        }

        public abstract string Symbol { get; }

        public decimal ConvertValue(decimal value, Unit<TDim> newUnit)
        {
            return Equals(newUnit) ? value : newUnit.ConvertFromDatum(ConvertToDatum(value));
        }

        protected abstract decimal ConvertToDatum(decimal value);
        protected abstract decimal ConvertFromDatum(decimal value);

        protected override int GetHashCodeImpl()
        {
            return _type.GetHashCode();
        }

        protected override bool EqualsImpl(Unit<TDim> other)
        {
            return _type == other._type;
        }
    }
}