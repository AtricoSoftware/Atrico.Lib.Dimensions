namespace Atrico.Lib.Dimensions.Units.Time
{
    public sealed class Day : Unit<Dimensions.Time>
    {
        public override string Symbol
        {
            get { return "d"; }
        }

        protected override decimal ConvertToDatum(decimal value)
        {
            return value * 86400;
        }

        protected override decimal ConvertFromDatum(decimal value)
        {
            return value / 86400;
        }
    }
}