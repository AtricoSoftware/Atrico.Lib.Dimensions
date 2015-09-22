using Atrico.Lib.Dimensions.Dimensions;
using Atrico.Lib.Dimensions.Units.Time;
using Atrico.Lib.Testing.TestAttributes.NUnit;

namespace Atrico.Lib.Dimensions.Tests
{
    [TestFixture]
    public class TestTime : TestDimensionBase<Time>
    {
        private static void Convert(decimal s, out decimal ms, out decimal min, out decimal hour, out decimal day, out decimal week)
        {
            ms = s * 1000;
            min = s / 60;
            hour = min / 60;
            day = hour / 24;
            week = day / 7;
        }

        [Test]
        public void TestSecond()
        {
            // Arrange
            const decimal sValue = 3600;
            decimal msValue;
            decimal minValue;
            decimal hourValue;
            decimal dayValue;
            decimal weekValue;
            Convert(sValue, out msValue, out minValue, out hourValue, out dayValue, out weekValue);

            // Act
            var dimValue = DimensionValue<Time>.Create<Second>(sValue);

            // Assert
            AssertValue<Millisecond>(dimValue, msValue, "ms");
            AssertValue<Second>(dimValue, sValue, "s");
            AssertValue<Minute>(dimValue, minValue, "m");
            AssertValue<Hour>(dimValue, hourValue, "h");
            AssertValue<Day>(dimValue, dayValue, "d");
            AssertValue<Week>(dimValue, weekValue, "w");
        }

        [Test]
        public void TestMillisecond()
        {
            // Arrange
            const decimal sValue = 3600;
            decimal msValue;
            decimal minValue;
            decimal hourValue;
            decimal dayValue;
            decimal weekValue;
            Convert(sValue, out msValue, out minValue, out hourValue, out dayValue, out weekValue);

            // Act
            var dimValue = DimensionValue<Time>.Create<Millisecond>(msValue);

            // Assert
            AssertValue<Millisecond>(dimValue, msValue, "ms");
            AssertValue<Second>(dimValue, sValue, "s");
            AssertValue<Minute>(dimValue, minValue, "m");
            AssertValue<Hour>(dimValue, hourValue, "h");
            AssertValue<Day>(dimValue, dayValue, "d");
            AssertValue<Week>(dimValue, weekValue, "w");
        }

        [Test]
        public void TestMinute()
        {
            // Arrange
            const decimal sValue = 3600;
            decimal msValue;
            decimal minValue;
            decimal hourValue;
            decimal dayValue;
            decimal weekValue;
            Convert(sValue, out msValue, out minValue, out hourValue, out dayValue, out weekValue);

            // Act
            var dimValue = DimensionValue<Time>.Create<Minute>(minValue)
                ;

            // Assert
            AssertValue<Millisecond>(dimValue, msValue, "ms");
            AssertValue<Second>(dimValue, sValue, "s");
            AssertValue<Minute>(dimValue, minValue, "m");
            AssertValue<Hour>(dimValue, hourValue, "h");
            AssertValue<Day>(dimValue, dayValue, "d");
            AssertValue<Week>(dimValue, weekValue, "w");
        }

        [Test]
        public void TestHour()
        {
            // Arrange
            const decimal sValue = 3600;
            decimal msValue;
            decimal minValue;
            decimal hourValue;
            decimal dayValue;
            decimal weekValue;
            Convert(sValue, out msValue, out minValue, out hourValue, out dayValue, out weekValue);

            // Act
            var dimValue = DimensionValue<Time>.Create<Hour>(hourValue);

            // Assert
            AssertValue<Millisecond>(dimValue, msValue, "ms");
            AssertValue<Second>(dimValue, sValue, "s");
            AssertValue<Minute>(dimValue, minValue, "m");
            AssertValue<Hour>(dimValue, hourValue, "h");
            AssertValue<Day>(dimValue, dayValue, "d");
            AssertValue<Week>(dimValue, weekValue, "w");
        }

        [Test]
        public void TestDay()
        {
            // Arrange
            const decimal sValue = 3600;
            decimal msValue;
            decimal minValue;
            decimal hourValue;
            decimal dayValue;
            decimal weekValue;
            Convert(sValue, out msValue, out minValue, out hourValue, out dayValue, out weekValue);

            // Act
            var dimValue = DimensionValue<Time>.Create<Day>(dayValue);

            // Assert
            AssertValue<Millisecond>(dimValue, msValue, "ms");
            AssertValue<Second>(dimValue, sValue, "s");
            AssertValue<Minute>(dimValue, minValue, "m");
            AssertValue<Hour>(dimValue, hourValue, "h");
            AssertValue<Day>(dimValue, dayValue, "d");
            AssertValue<Week>(dimValue, weekValue, "w");
        }

        [Test]
        public void TestWeek()
        {
            // Arrange
            const decimal sValue = 3600;
            decimal msValue;
            decimal minValue;
            decimal hourValue;
            decimal dayValue;
            decimal weekValue;
            Convert(sValue, out msValue, out minValue, out hourValue, out dayValue, out weekValue);

            // Act
            var dimValue = DimensionValue<Time>.Create<Week>(weekValue);

            // Assert
            AssertValue<Millisecond>(dimValue, msValue, "ms");
            AssertValue<Second>(dimValue, sValue, "s");
            AssertValue<Minute>(dimValue, minValue, "m");
            AssertValue<Hour>(dimValue, hourValue, "h");
            AssertValue<Day>(dimValue, dayValue, "d");
            AssertValue<Week>(dimValue, weekValue, "w");
        }
    }
}