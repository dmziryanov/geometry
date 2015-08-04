using System;

namespace MoreTranglez_
{
	class Program
	{
		static void Main()
		{
			NextPythagoreanTriple(534, 712, 890);
		}

		private static void NextPythagoreanTriple(int a, int b, int c)
		{
			var s = a.ToString() + b.ToString() + c.ToString();
			if (s.Length > 9) return;
			for (int k = 1; ; k++)
			{
				int a1 = a * k, b1 = b * k, c1 = c * k;
				var s1 = a1.ToString() + b1.ToString() + c1.ToString();
				if (s1.Length > 9) break;
				if (Check(s1)) Console.WriteLine("({0}, {1}, {2})", a1, b1, c1);
			}
			
			NextPythagoreanTriple(a - 2 * b + 2 * c, 2 * a - b + 2 * c, 2 * a - 2 * b + 3 * c);
			NextPythagoreanTriple(a + 2 * b + 2 * c, 2 * a + b + 2 * c, 2 * a + 2 * b + 3 * c);
			NextPythagoreanTriple(-a + 2 * b + 2 * c, -2 * a + b + 2 * c, -2 * a + 2 * b + 3 * c);
		}

		private static bool Check(string s)
		{
			if (s.Length != 9) return false;
			var cc = s.ToCharArray();
			Array.Sort(cc);
			for (int i = 1; i < cc.Length; i++) if (cc[i] == cc[i - 1]) return false;
			return true;
		}
	}
}
