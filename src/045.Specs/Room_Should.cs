namespace PaintProgram.Specs;

public class Room_Should
{
    #region Happy Path Tests
    [Theory]
    [InlineData(10, 8, 3.5)]
    [InlineData(6, 4, 3.5)]
    public void Parse_String_Data_Dimensions_In_Correct_Order(double width, double length, double height)
    {
        // Arrange
        string givenText = $"{width},{length},{height}";
        // Act
        Room sut = Room.Parse(givenText);
        // Assert
        sut.Width.Should().Be(width);
        sut.Height.Should().Be(height);
        sut.Length.Should().Be(length);
    }

    [Fact]
    public void Parse_From_String_Data_With_Spaces()
    {
        // Arrange
        string given = " 10 , 8,3.5 ";
        // Act
        Room sut = Room.Parse(given);
        // Assert
        sut.Width.Should().Be(10);
        sut.Height.Should().Be(3.5);
        sut.Length.Should().Be(8);
    }

    [Theory]
    [InlineData(10, 8, 3.5, 126)]   // 10 * 3.5 * 2 + 8 * 3.5 * 2 = 126
    [InlineData(6, 4, 3.5, 70)]     // 6 * 3.5 * 2 + 4 * 3.5 * 2 = 70
    public void Calculate_Area(double width, double length, double height, double expectedArea)
    {
        // Arrange
        Room sut = new Room(width, height, length);
        // Act
        double actual = sut.Area;
        // Assert
        sut.Width.Should().Be(width);
        sut.Height.Should().Be(height);
        sut.Length.Should().Be(length);
        actual.Should().Be(expectedArea);
    }
    #endregion

    #region Validation Tests
    [Theory]
    [InlineData("")]
    [InlineData(null)]
    [InlineData("   ")]
    public void Throw_FormatException_When_Parsing_Empty_String(string given)
    {
        // Arrange
        Action act = () => Room.Parse(given);
        // Act/Assert
        act.Should().ThrowExactly<FormatException>().WithMessage("Cannot parse an empty string into a Room object");
    }

    [Fact]
    public void Throw_FormatException_When_String_Has_Two_Parts()
    {
        // Arrange
        Action act = () => Room.Parse("10,5");
        // Act/Assert
        act.Should().ThrowExactly<FormatException>().WithMessage("*must have three numeric values*");
    }

    [Fact]
    public void Throw_FormatException_When_String_Has_Four_Parts()
    {
        // Arrange
        Action act = () => Room.Parse("10,5,9,20");
        // Act/Assert
        act.Should().ThrowExactly<FormatException>();
    }

    [Theory]
    [InlineData("Bob,10,10")]
    [InlineData("10,Bob,10")]
    [InlineData("10,10,Bob")]
    public void Throw_FormatException_From_NonNumeric_Data(string given)
    {
        // Arrange
        Action act = () => Room.Parse(given);
        // Act/Assert
        act.Should().ThrowExactly<FormatException>();
    }    
    #endregion
}