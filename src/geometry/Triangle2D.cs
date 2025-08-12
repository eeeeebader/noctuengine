using Raylib_cs;
using noctuengine.math;

namespace noctuengine.geometry;

class Triangle2D
{
    public vec2 V0 { get; }
    public vec2 V1 { get; }
    public vec2 V2 { get; }

    public Segment2D S0 { get; }
    public Segment2D S1 { get; }
    public Segment2D S2 { get; }

    public Color C { get; set; }

    public Triangle2D(vec2 v0, vec2 v1, vec2 v2)
    {
        V0 = v0;
        V1 = v1;
        V2 = v2;

        S0 = new Segment2D(V0, V1);
        S1 = new Segment2D(V1, V2);
        S2 = new Segment2D(V2, V0);

        C = new Color(255, 0, 0);
    }


    public void Draw()
    {
        Raylib.DrawPixel((int)V0.X, (int)V0.Y, C);
        Raylib.DrawPixel((int)V1.X, (int)V1.Y, C);
        Raylib.DrawPixel((int)V2.X, (int)V2.Y, C);

        S0.Draw();
        S1.Draw();
        S2.Draw();
    }

    /// <summary>
    /// Check if a point is within the triangle
    /// </summary>
    public bool InTriangle(vec2 p)
    {
        v1v2 = 
        return true;
    }
}