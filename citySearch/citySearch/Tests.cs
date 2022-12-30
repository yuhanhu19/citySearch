using System;
using Xunit;

namespace citySearch
{
    public class Tests
    {
        [Fact]
        public void ShouldThrowExceptionGivenNullText()
        {
            var citySearch = new CitySearch();
            var ex = Assert.Throws<Exception>(() => citySearch.Search(""));
            Assert.Equal("Search text must be provided", ex.Message);
        }
    }
}
