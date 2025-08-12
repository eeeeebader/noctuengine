using Raylib_cs;
using noctuengine.math;

namespace noctuengine.geometry;

class Segment2D
{
    vec2 P0 { get; set; }
    vec2 P1 { get; set; }

    public Segment2D(vec2 p0, vec2 p1)
    {
        P0 = p0;
        P1 = p1;
    }

    public void Draw()
    {
        vec2 start = P0;
        vec2 end = P1;
        if (start.X > P1.X)
        {
            start = P1;
            end = P0;
        }

        for (int x = (int)start.X; x < (int)end.X; x++)
            {
                // calculate y by the linear interpolation
                int y = (int)((start.Y * (end.X - x) + end.Y * (x - start.X)) / (end.X - start.X));
                Raylib.DrawPixel(x, y, Color.Black);
            }
    }
}