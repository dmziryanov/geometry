using System;

namespace Geometry
{
    public abstract class TriangleBase
    {
	    protected double smallEdge1;
	    protected double smallEdge2;
	    protected double longestEdge;

	    public TriangleBase()
	    {

	    }

	    public TriangleBase(double pa, double pb, double pc)
		{
			smallEdge1 = Math.Min(pa, pb);
			smallEdge2 = Math.Min(pb, pc);
			longestEdge = Math.Max(Math.Max(pa, pb), pc);
			if (smallEdge1 + smallEdge2 < longestEdge)
				throw new ArgumentOutOfRangeException("Not triangle: sum of smaller edges is less then longest edge");
		}

	    public abstract double GetSquare();
    }
}
