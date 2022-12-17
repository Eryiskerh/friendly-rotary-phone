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
	
}