namespace Atrico.Lib.Dimensions.Units.Time
{
    public sealed class Millisecond : Unit<Dimensions.Time>
    {
        public override string Symbol
        {
            get { return "ms"; }
        }

        protected override decimal ConvertToDatum(decimal value)
        {
            return value / 1000;
        }

        protected override decimal ConvertFromDatum(decimal value)
        {
            return value * 1000;
        }
    }
}