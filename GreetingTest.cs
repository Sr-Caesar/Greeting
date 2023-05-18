
namespace Greeting.Test
{
    public class GreetingTest
    {
        private readonly Greeting _sut;

        public GreetingTest()
        {//ctor del _sut
            _sut = new Greeting();
        }

        [Fact]
        public void SimpleGreet()
        {
            var result = _sut.Greet("Bob");
            Assert.Equal($"Hello, Bob.", result);
        }

        [Fact]
        public void SimpleGreetNull()
        {
            var result = _sut.Greet(null);
            Assert.Equal("Hello, my friend.", result);
        }

        //[Fact]
        //public void IsUpperCaseTest() 
        //{
        //    var result = _sut.Greet("JERRY");
        //    Assert.Equal("HELLO JERRY", result);
        //}

        //[Fact]
        //public void MoreName()
        //{
        //    var result = _sut.Greet({"Jill","Jane"});
        //}
    }
}