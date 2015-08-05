using System;

namespace Geometry
{
	public class AnyTriangle : TriangleBase
	{
		public AnyTriangle(double pa, double pb, double pc)
			: base(pa, pb, pc)
		{
		}

		public override double GetSquare()
		{
			throw new NotImplementedException();
		}
	}
}
