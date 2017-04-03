 
using tdddemoapp;
using Xunit;

namespace TDDDemoAppTests
{
    public class TextAnalyzerUnitTests
    {
        [Fact]
        public void GetTotalWordCount_WhenPassedRegularText_ShouldReturnExpectedCount()
        {
            // arrange
            const string textToAnalyze = @"xUnit.net is a free, open source, community-focused
                                            unit testing tool for the .NET Framework.";
            var analyzer = new TextAnalyzer();

            // act 
            var count = analyzer.GetTotalWordCount(textToAnalyze);

            // assert
            Assert.Equal(14,count);
        }
    }
}


