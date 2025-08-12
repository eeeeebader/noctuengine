namespace noctuengine.math;

class vec2
{
    public float X { get; set; }
    public float Y { get; set; }

    public vec2() : this(0f) { }

    public vec2(float value) : this(value, value) { }

    public vec2(float x, float y)
    {
        X = x;
        Y = y;
    }

    public vec2 Transpose()
    {
        return new vec2(Y, X);
    }

    public static vec2 Transpose(vec2 v)
    {
        return new vec2(v.Y, v.X);
    }
}