namespace tests;
using proj;

[TestClass]
public class TestApp
{
    [TestMethod]
    public void TestF_1()
    {
		Assert.AreEqual(App.F(0d), -1d);
    }
	[TestMethod]
    public void TestF_2()
    {
		Assert.AreEqual(App.F(1d), -6.84875379306251d);
    }
	[TestMethod]
    public void TestF_3()
    {
		Assert.AreEqual(App.F(-1d), -0.6756375891047525d);
    }
	[TestMethod]
    public void TestF_4()
    {
		Assert.AreEqual(App.F(-0.5d), -0.47757726140773893d);
    }
	[TestMethod]
    public void TestF_5()
    {
		Assert.AreEqual(App.F(0.5d), -2.6085840082227483d);
    }
	[TestMethod]
    public void TestF_6()
    {
		Assert.AreEqual(App.F(double.MaxValue), -1d*double.MaxValue*double.MaxValue);
    }
	[TestMethod]
    public void TestF4_1()
    {
		Assert.AreEqual(App.F4(0d), 0d);
    }
	[TestMethod]
    public void TestF4_2()
    {
		Assert.AreEqual(App.F4(1d), 2d);
    }
	[TestMethod]
    public void TestF4_3()
    {
		Assert.AreEqual(App.F4(-1d), -2d);
    }
	[TestMethod]
    public void TestF4_4()
    {
		Assert.AreEqual(App.F4(-0.5d), -1d);
    }
	[TestMethod]
    public void TestF4_5()
    {
		Assert.AreEqual(App.F4(0.5d), 1d);
    }
	[TestMethod]
    public void TestF4_6()
    {
		Assert.AreEqual(App.F4(double.MaxValue), 2d*double.MaxValue);
    }
	[TestMethod]
    public void TestF3_1()
    {
		Assert.AreEqual(App.F3(0d), Math.Exp(0d));
    }
	[TestMethod]
    public void TestF3_2()
    {
		Assert.AreEqual(App.F3(1d), Math.Exp(2d));
    }
	[TestMethod]
    public void TestF3_3()
    {
		Assert.AreEqual(App.F3(-1d), Math.Exp(-2d));
    }
	[TestMethod]
    public void TestF3_4()
    {
		Assert.AreEqual(App.F3(-0.5d), Math.Exp(-1d));
    }
	[TestMethod]
    public void TestF3_5()
    {
		Assert.AreEqual(App.F3(0.5d), Math.Exp(1d));
    }
	[TestMethod]
    public void TestF3_6()
    {
		Assert.AreEqual(App.F3(double.MaxValue), Math.Exp(2d*double.MaxValue));
    }
	[TestMethod]
    public void TestF2_1()
    {
		Assert.AreEqual(App.F2(0d), Math.Cos(0d));
    }
	[TestMethod]
    public void TestF2_2()
    {
		Assert.AreEqual(App.F2(1d), Math.Cos(1d));
    }
	[TestMethod]
    public void TestF2_3()
    {
		Assert.AreEqual(App.F2(-1d), Math.Cos(-1d));
    }
	[TestMethod]
    public void TestF2_4()
    {
		Assert.AreEqual(App.F2(-0.5d), Math.Cos(-0.5d));
    }
	[TestMethod]
    public void TestF2_5()
    {
		Assert.AreEqual(App.F2(0.5d), Math.Cos(0.5d));
    }
	[TestMethod]
    public void TestF2_6()
    {
		Assert.AreEqual(App.F2(double.MaxValue), Math.Cos(double.MaxValue));
    }
	[TestMethod]
    public void TestF1_1()
    {
		Assert.AreEqual(App.F1(0d), 0d*0d*0d));
    }
	[TestMethod]
    public void TestF1_2()
    {
		Assert.AreEqual(App.F1(1d), 1d*1d*1d);
    }
	[TestMethod]
    public void TestF1_3()
    {
		Assert.AreEqual(App.F1(-1d), -1d*-1d*-1d);
    }
	[TestMethod]
    public void TestF1_4()
    {
		Assert.AreEqual(App.F1(-0.5d), -0.5d*-0.5d*-0.5d);
    }
	[TestMethod]
    public void TestF1_5()
    {
		Assert.AreEqual(App.F1(0.5d), 0.5d*0.5d*0.5d);
    }
	[TestMethod]
    public void TestF1_6()
    {
		Assert.AreEqual(App.F1(double.MaxValue), double.MaxValue*double.MaxValue*double.MaxValue);
    }
	[TestMethod]
    public void TestMain()
    {
		Assert.AreEqual(App.Main(new string[] {"App"}), 0);
    }
}