
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
        public void SimpleGreet2()
        {

        }
    }
}