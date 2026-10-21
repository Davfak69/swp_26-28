using FirstOOP;
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
        Kuh myKuh = new Kuh("Paula", "Schwarz");
        Assert.That(myKuh.Name, Is.EqualTo("Paula"));
        }
    }
}
