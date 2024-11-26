﻿using System.Drawing;

namespace Simulator.Maps;

/// <summary>
/// Map of points.
/// </summary>
public abstract class Map
{
    //Add(Creature, Point)
    //Remove(Creature, Point)
    
    //Move()
    
    //At(Point) albo x, y
    protected Map(int sizeX, int sizeY)
    {
        if (sizeX < 5 || sizeY < 5) throw new ArgumentOutOfRangeException(nameof(sizeX), "Map too small");
        SizeX = sizeX;
        SizeY = sizeY;
        _bounds = new Rectangle(0, 0, SizeX - 1, SizeY - 1);
    }
    public int SizeX { get; }
    public int SizeY { get; }
    private Rectangle _bounds;
    /// <summary>
    /// Check if give point belongs to the map.
    /// </summary>
    /// <param name="p">Point to check.</param>
    /// <returns></returns>
    public virtual bool Exist(Point p) => _bounds.Contains(p);

    /// <summary>
    /// Next position to the point in a given direction.
    /// </summary>
    /// <param name="p">Starting point.</param>
    /// <param name="d">Direction.</param>
    /// <returns>Next point.</returns>
    public abstract Point Next(Point p, Direction d);

    /// <summary>
    /// Next diagonal position to the point in a given direction 
    /// rotated 45 degrees clockwise.
    /// </summary>
    /// <param name="p">Starting point.</param>
    /// <param name="d">Direction.</param>
    /// <returns>Next point.</returns>
    public abstract Point NextDiagonal(Point p, Direction d);
}
