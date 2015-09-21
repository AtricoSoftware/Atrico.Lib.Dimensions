namespace Atrico.Lib.Dimensions.Units.Time
{
    public sealed class Hour : Unit<Dimensions.Time>
    {
        public override string Symbol
        {
            get { return "h"; }
        }

        protected override decimal ConvertToDatum(decimal value)
        {
            return value * 3600;
        }

        protected override decimal ConvertFromDatum(decimal value)
        {
            return value / 3600;
        }
    }
}