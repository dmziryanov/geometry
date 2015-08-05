using Microsoft.VisualStudio.TestTools.UnitTesting;
using Geometry;

namespace TestingGeometry
{
	[TestClass]
	public class TestRightTriangle
	{
		[TestMethod]
		public void TestIsTriangle()
		{
			var t = new AnyTriangle(10, 6, 5);
		}
		
		[TestMethod]
		public void TestSquare1()
		{
			var t = new RightTriangle(3, 4, 5);
			Assert.AreEqual(6, t.GetSquare());
		}

		[TestMethod]
		public void TestSquare2()
		{
			var t = new RightTriangle(534, 712, 890);
			Assert.AreEqual(190104, t.GetSquare());
		}

		[TestMethod]
		public void WrongSquare()
		{
			var t = new RightTriangle(534, 712, 890);
			Assert.AreEqual(190105, t.GetSquare());
		}

		[TestMethod]
		public void WrongTriangleDueAccuracy()
		{
			var t = new RightTriangle(10, 10, 14.14213562373095);
		}

		[TestMethod]
		public void WrongParam()
		{
			var t = new RightTriangle(10, 10, 15);
		}
	}
}
