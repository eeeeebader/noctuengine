namespace noctuengine.math;

class vec3
{
    public float X { get; set; }
    public float Y { get; set; }
    public float Z { get; set; }

    public vec3()
    {
        X = 0;
        Y = 0;
        Z = 0;
    }

    public vec3(float value)
    {
        X = value;
        Y = value;
        Z = value;
    }

    public vec3(float x, float y, float z)
    {
        X = x;
        Y = y;
        Z = z;
    }
}