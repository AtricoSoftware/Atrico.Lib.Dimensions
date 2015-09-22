namespace Atrico.Lib.Dimensions.Units.Time
{
    public sealed class Second : Unit<Dimensions.Time>
    {
        public override string Symbol
        {
            get { return "s"; }
        }

        protected override decimal ConvertToDatum(decimal value)
        {
            return value;
        }

        protected override decimal ConvertFromDatum(decimal value)
        {
            return value;
        }
    }
}