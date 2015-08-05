using System;

namespace Geometry
{
	public class RightTriangle : TriangleBase
	{
		public RightTriangle(double pa, double pb, double pc) : base(pa, pb, pc)
		{
			if (edges[0] * edges[0] + edges[1] * edges[1] != edges[2] * edges[2])
				throw new ArgumentOutOfRangeException("Not right triangle: square of hypo is not equals to sum of cathets squares");
		}

		public override double GetSquare()
		{
			return edges[0] * edges[1] / 2;
		}
	}
}
