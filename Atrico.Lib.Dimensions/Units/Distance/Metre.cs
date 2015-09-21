namespace Atrico.Lib.Dimensions.Units.Distance
{
    public sealed class Metre : Unit<Dimensions.Distance>
    {
        public override string Symbol
        {
            get { return "m"; }
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