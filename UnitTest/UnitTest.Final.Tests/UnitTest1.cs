namespace UnitTest.Final.Tests
{
    public class Tests
    {
        Calculator calc = new Calculator();

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AdditionTest()
        {
            Assert.AreEqual(8, calc.Additional(3, 5));
            //Assert.Pass();
        }
        [Test]
        public void SubtractionTest()
        {
            Assert.AreEqual(-2, calc.Subtraction(3, 5));
        }
        [Test]
        public void MiltiplicationTest()
        {
            Assert.AreEqual(15, calc.Miltiplication(3, 5));
        }
        [Test]
        public void DivisionTest()
        {
            Assert.That(calc.Division(35, 5) == 7);
        }
        [Test]
        public void DivisionByZeroEceptionTest()
        {
            Assert.Throws<DivideByZeroException>(() => calc.Division(3, 0));
        }

    }
}