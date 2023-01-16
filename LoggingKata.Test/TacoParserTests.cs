using System;
using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldDoSomething()
        {
            // TODO: Complete Something, if anything

            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse("34.073638, -84.677017, Taco Bell Acwort...");

            //Assert
            Assert.NotNull(actual);

        }

        [Theory]
        [InlineData("34.073638, -84.677017,Taco Bell Acwort...", -84.677017)]
        [InlineData("34.280205,-86.217115,Taco Bell Albertvill...", -86.217115)]
        [InlineData("34.996237,-85.291147,Taco Bell Chattanooga...", -85.291147)]
        public void ShouldParseLongitude(string line, double expected)
        {
            // TODO: Complete - "line" represents input data we will Parse to
            //       extract the Longitude.  Your .csv file will have many of these lines,
            //       each representing a TacoBell location

            //Arrange
            var tp = new TacoParser();
            //Act
            var actual = tp.Parse(line);
            //Assert
            Assert.Equal(expected, actual.Location.Longitude);
        }


        [Theory]
        [InlineData("34.073638, -84.677017,Taco Bell Acwort...", 34.073638)]
        [InlineData("34.280205,-86.217115,Taco Bell Albertvill...", 34.280205)]
        [InlineData("34.996237,-85.291147,Taco Bell Chattanooga...", 34.996237)]
        public void ShouldParseLatitude(string line, double expected)
        {
            // TODO: Complete - "line" represents input data we will Parse to
            //       extract the Longitude.  Your .csv file will have many of these lines,
            //       each representing a TacoBell location

            //Arrange
            var tp = new TacoParser();
            //Act
            var actual = tp.Parse(line);
            //Assert
            Assert.Equal(expected, actual.Location.Latitude);
        }


        [Theory]
        [InlineData("34.073638, -84.677017,Taco Bell Acwort...", "Taco Bell Acwort")]
        [InlineData("34.280205,-86.217115,Taco Bell Albertvill...", "Taco Bell Albertvill")]
        [InlineData("34.996237,-85.291147,Taco Bell Chattanooga...", "Taco Bell Chattanooga")]
        public void ShouldParseName(string line, string expected)
        {
            // TODO: Complete - "line" represents input data we will Parse to
            //       extract the Longitude.  Your .csv file will have many of these lines,
            //       each representing a TacoBell location

            //Arrange
            var tp = new TacoParser();
            //Act
            var actual = tp.Parse(line);
            //Assert
            Assert.Equal(expected, actual.Name);
        }

    }
}
