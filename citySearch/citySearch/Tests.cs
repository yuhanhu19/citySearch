using System;
using System.Linq;
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
        
        [Fact]
        public void ShouldReturnNoResultWhenTextIsFewerThan2Chars()
        {
            var citySearch = new CitySearch();
            var result = citySearch.Search("a");
            Assert.Equal(0, result.Length);
        }
        
        [Fact]
        public void ShouldReturnSearchResultWhenTextHas2OrMoreChars()
        {
            var citySearch = new CitySearch();
            var result = citySearch.Search("Va");
            Assert.Equal(2, result.Length);
            Assert.True(result.Contains("Valencia"));
            Assert.True(result.Contains("Vancouver"));
            
        }
    }
}
