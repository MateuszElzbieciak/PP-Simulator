namespace Simulator;

public readonly struct Point
{
    public readonly int X, Y;
    public Point(int x, int y) => (X, Y) = (x, y);
    public override string ToString() => $"({X}, {Y})";

    public Point Next(Direction direction)
    {
        switch (direction)
        {
            case Direction.Up:
                return new Point(X, Y + 1);
            case Direction.Down:
                return new Point(X, Y - 1);
            case Direction.Right:
                return new Point(X + 1, Y);
            case Direction.Left:
                return new Point(X - 1, Y);
            default:
                return default;
        };
    }

    public Point NextDiagonal(Direction direction)
    {
        switch (direction)
        {
            case Direction.Up:
                return new Point(X, Y + 1);
            case Direction.Down:
                return new Point(X, Y - 1);
            case Direction.Right:
                return new Point(X + 1, Y);
            case Direction.Left:
                return new Point(X - 1, Y);
            default:
                return default;
        };
    }
}