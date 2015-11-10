using System;

namespace Geometry
{
    public abstract class TriangleBase
    {
	    protected double[] edges = new Double[3];
	    
	    public TriangleBase()
	    {

	    }

	    public TriangleBase(double pa, double pb, double pc)
	    {
		    edges[0] = pa;
			edges[1] = pb;
		    edges[2] = pc;

			Array.Sort(edges);

			if (edges[0] + edges[1] < edges[2])
				throw new ArgumentOutOfRangeException("Not triangle: sum of smaller edges is less then longest edge");
		}

	    public abstract double GetSquare();
    }
}
