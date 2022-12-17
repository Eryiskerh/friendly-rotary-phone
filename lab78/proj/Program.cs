using System;
 
namespace proj{
	public static class App{
		public static int Main(string[]? argv){
			Console.WriteLine("Hello, World!");
			Console.WriteLine(F(0));
			Console.WriteLine(F(1));
			Console.WriteLine(F(-1));
			Console.WriteLine(F(-0.5d));
			Console.WriteLine(F(0.5d));
			Console.WriteLine(F(double.MaxValue));
			return 0;
		}
		public static double F(double x){
			return F1(x)*F2(x)-F3(x);
		}
		public static double F1(double x){
			return x*x*x;
		}
		public static double F2(double x){
			return Math.Cos(x);
		}
		public static double F3(double x){
			return Math.Exp(F4(x));
		}
		public static double F4(double x){
			return 2*x;
		}
	}
}