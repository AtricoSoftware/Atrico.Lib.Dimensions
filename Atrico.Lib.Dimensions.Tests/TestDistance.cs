using Atrico.Lib.Dimensions.Dimensions;
using Atrico.Lib.Dimensions.Units.Distance;
using Atrico.Lib.Testing.TestAttributes.NUnit;

namespace Atrico.Lib.Dimensions.Tests
{
    [TestFixture]
    public class TestDistance : TestDimensionBase<Distance>
    {
        private static void Convert(decimal m, out decimal mm, out decimal cm, out decimal km)
        {
            mm = m * 1000;
            cm = m * 100;
            km = m / 1000;
        }

        [Test]
        public void TestMetre()
        {
            // Arrange
            var mValue = RandomValues.Value<decimal>();
            decimal mmValue;
            decimal cmValue;
            decimal kmValue;
            Convert(mValue, out mmValue, out cmValue, out kmValue);

            // Act
            var dimValue = DimensionValue<Distance>.Create<Metre>(mValue);

            // Assert
            AssertValue<Millimetre>(dimValue, mmValue, "mm");
            AssertValue<Centimetre>(dimValue, cmValue, "cm");
            AssertValue<Metre>(dimValue, mValue, "m");
            AssertValue<Kilometre>(dimValue, kmValue, "km");
        }

        [Test]
        public void TestMillimetre()
        {
            // Arrange
            var mValue = RandomValues.Value<decimal>();
            decimal mmValue;
            decimal cmValue;
            decimal kmValue;
            Convert(mValue, out mmValue, out cmValue, out kmValue);

            // Act
            var dimValue = DimensionValue<Distance>.Create<Millimetre>(mmValue);

            // Assert
            AssertValue<Millimetre>(dimValue, mmValue, "mm");
            AssertValue<Centimetre>(dimValue, cmValue, "cm");
            AssertValue<Metre>(dimValue, mValue, "m");
            AssertValue<Kilometre>(dimValue, kmValue, "km");
        }

        [Test]
        public void TestCentimetre()
        {
            // Arrange
            var mValue = RandomValues.Value<decimal>();
            decimal mmValue;
            decimal cmValue;
            decimal kmValue;
            Convert(mValue, out mmValue, out cmValue, out kmValue);

            // Act
            var dimValue = DimensionValue<Distance>.Create<Centimetre>(cmValue);

            // Assert
            AssertValue<Millimetre>(dimValue, mmValue, "mm");
            AssertValue<Centimetre>(dimValue, cmValue, "cm");
            AssertValue<Metre>(dimValue, mValue, "m");
            AssertValue<Kilometre>(dimValue, kmValue, "km");
        }

        [Test]
        public void TestKilometre()
        {
            // Arrange
            var mValue = RandomValues.Value<decimal>();
            decimal mmValue;
            decimal cmValue;
            decimal kmValue;
            Convert(mValue, out mmValue, out cmValue, out kmValue);

            // Act
            var dimValue = DimensionValue<Distance>.Create<Kilometre>(kmValue);

            // Assert
            AssertValue<Millimetre>(dimValue, mmValue, "mm");
            AssertValue<Centimetre>(dimValue, cmValue, "cm");
            AssertValue<Metre>(dimValue, mValue, "m");
            AssertValue<Kilometre>(dimValue, kmValue, "km");
        }
    }
}
