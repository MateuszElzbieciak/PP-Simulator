using Simulator;
using Simulator.Maps;

namespace TestSimulator;

public class SmallSquareMapTests
{
    [Fact]
    public void Constructor_ValidSize_ShouldSetSize()
    {
        int sizeX = 10;
        int sizeY = 10;
        var map = new SmallSquareMap(sizeX, sizeY);
        Assert.Equal(sizeX, map.SizeX);
        Assert.Equal(sizeY, map.SizeY);
    }

    [Theory]
    [InlineData(4, 4)]
    [InlineData(21, 21)]
    public void Constructor_InvalidSize_ShouldThrowArgumentOutOfRangeException(int sizeX, int sizeY)
    {
        // Act & Assert
        Assert.Throws<ArgumentOutOfRangeException>(() => new SmallSquareMap(sizeX, sizeY));
    }

    [Theory]
    [InlineData(3, 4, 5, 5, true)]
    [InlineData(6, 1, 5, 5, false)]
    [InlineData(19, 19, 20, 20, true)]
    [InlineData(20, 20, 20, 20, false)]
    public void Exist_ShouldReturnCorrectValue(int x, int y, int sizeX, int sizeY, bool expected)
    {
        // Arrange
        var map = new SmallSquareMap(sizeX, sizeY);
        var point = new Point(x, y);

        // Act
        var result = map.Exist(point);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(2, 2, Direction.Up, 2, 3)]
    [InlineData(0, 0, Direction.Down, 0, 0)]
    [InlineData(2, 2, Direction.Down, 2, 1)]
    [InlineData(4, 4, Direction.Right, 4, 4)]
    [InlineData(2, 2, Direction.Right, 3, 2)]
    [InlineData(1, 4, Direction.Left, 0, 4)]
    public void Next_ShouldReturnCorrectNextPoint(int x, int y, Direction direction, int expectedX, int expectedY)
    {
        // Arrange
        var map = new SmallSquareMap(20 ,20);
        var point = new Point(x, y);

        // Act
        var nextPoint = map.Next(point, direction);

        // Assert
        Assert.Equal(new Point(expectedX, expectedY), nextPoint);
    }

    [Theory]
    [InlineData(2, 2, Direction.Up, 3, 3)]
    [InlineData(0, 0, Direction.Down, 0, 0)]
    [InlineData(2, 2, Direction.Down, 1, 1)]
    [InlineData(4, 4, Direction.Right, 4, 4)]
    [InlineData(2, 2, Direction.Right, 3, 1)]
    [InlineData(1, 3, Direction.Left, 0, 4)]
    public void NextDiagonal_ShouldReturnCorrectNextPoint(int x, int y, Direction direction, int expectedX, int expectedY)
    {
        // Arrange
        var map = new SmallSquareMap(20, 20);
        var point = new Point(x, y);

        // Act
        var nextPoint = map.NextDiagonal(point, direction);

        // Assert
        Assert.Equal(new Point(expectedX, expectedY), nextPoint);
    }
} 