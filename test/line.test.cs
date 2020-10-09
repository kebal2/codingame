using Xunit;

namespace Codingames.Math.Test
{
    public class EgyenesEgyenletTest
    {
        Line sut = new Line(new Point(3, 5), new Point(5, 2));

        [Fact]
        public void EquationsOfStraightLine()
        {
            Assert.Equal(3, sut.X);
            Assert.Equal(2, sut.Y);
            Assert.Equal(-19, sut.C);
        }

        [Fact]
        public void NormalVector()
        {
            Assert.Equal(3, sut.NV.X);
            Assert.Equal(2, sut.NV.Y);
        }
        [Fact]
        public void DirectionVector()
        {
            Assert.Equal(2, sut.DV.X);
            Assert.Equal(-3, sut.DV.Y);
        }
        [Fact]
        public void Slope()
        {
            Assert.Equal(-1.5, sut.S);
        }

        [Fact]
        public void PontDistance()
        {
            var s = new Line(2, 3, -28);
            var p = new Point(4, -2);

            var d = s.PointDistance(p);

            Assert.Equal(7.2111, d, 4);
        }

        [Fact]
        public void OrientedPontDistance()
        {
            var s = new Line(2, 3, -28);
            var p = new Point(4, -2);

            var d = s.OrientedPointDistance(p);

            Assert.Equal(-7.2111, d, 4);
        }
    }
}