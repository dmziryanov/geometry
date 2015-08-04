using System;

namespace Geometry
{
	public class RightTriangle : TriangleBase
	{
		public RightTriangle(double pa, double pb, double pc) : base(pa, pb, pc)
		{
			if (smallEdge1*smallEdge1 + smallEdge2*smallEdge2 != longestEdge*longestEdge)
				throw new ArgumentOutOfRangeException("Not right triangle: square of hypo is not equals to sum of cathets squares");
		}

		public override double GetSquare()
		{
			return smallEdge1 * smallEdge2 / 2;
		}
	}
}
