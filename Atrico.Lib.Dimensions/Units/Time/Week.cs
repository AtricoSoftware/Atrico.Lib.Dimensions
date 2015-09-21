namespace Atrico.Lib.Dimensions.Units.Time
{
    public sealed class Week : Unit<Dimensions.Time>
    {
        public override string Symbol
        {
            get { return "w"; }
        }

        protected override decimal ConvertToDatum(decimal value)
        {
            return value * 604800;
        }

        protected override decimal ConvertFromDatum(decimal value)
        {
            return value / 604800;
        }
    }
}