namespace Atrico.Lib.Dimensions.Units.Time
{
    public sealed class Minute : Unit<Dimensions.Time>
    {
        public override string Symbol
        {
            get { return "m"; }
        }

        protected override decimal ConvertToDatum(decimal value)
        {
            return value * 60;
        }

        protected override decimal ConvertFromDatum(decimal value)
        {
            return value / 60;
        }
    }
}