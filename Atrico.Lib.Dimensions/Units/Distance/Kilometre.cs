namespace Atrico.Lib.Dimensions.Units.Distance
{
    public sealed class Kilometre : Unit<Dimensions.Distance>
    {
        public override string Symbol
        {
            get { return "km"; }
        }

        protected override decimal ConvertToDatum(decimal value)
        {
            return value * 1000;
        }

        protected override decimal ConvertFromDatum(decimal value)
        {
            return value / 1000;
        }
    }
}