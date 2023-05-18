
using Xunit.Abstractions;

namespace Greeting.Test
{
    public class GreetingTest
    {
        private readonly Greeting _sut;
        private readonly ITestOutputHelper _output;
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

        [Fact]
        public void IsUpperCaseTest()
        {
            var result = _sut.Greet("JERRY");
            Assert.Equal("HELLO, JERRY!", result);
        }

        [Fact]
        public void TwoNames()
        {
            var result = _sut.Greet("Jill","Jane");
            Assert.Equal("Hello, Jill and Jane.", result);
        }

        //[Fact]
        //public void SandBox()
        //{
        //    var result = _sut.Greet("Andre", "Paperino");
        //    _output.WriteLine(result);
        //}
        [Fact]
        public void ALotOfNames()
        {
            var result = _sut.Greet("Amy", "Brian", "Charlotte");
            Assert.Equal("Hello, Amy, Brian, and Charlotte.", result);
        }
    }
}