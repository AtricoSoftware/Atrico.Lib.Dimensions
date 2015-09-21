namespace Atrico.Lib.Dimensions.Units.Distance
{
    public sealed class Centimetre : Unit<Dimensions.Distance>
    {
        public override string Symbol
        {
            get { return "cm"; }
        }

        protected override decimal ConvertToDatum(decimal value)
        {
            return value / 100;
        }

        protected override decimal ConvertFromDatum(decimal value)
        {
            return value * 100;
        }
    }
}