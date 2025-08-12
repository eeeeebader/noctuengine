using Raylib_cs;
using noctuengine.geometry;
using noctuengine.math;

namespace noctuengine;

class Engine
{
    [STAThread]
    public static void run(int xDim, int yDim, string window_name)
    {
        // initialize raylib window, so we can see things
        Raylib.InitWindow(xDim, yDim, window_name);

        // Gameloop
        while (!Raylib.WindowShouldClose())
        {
            WriteText(12, 12, 20, "Basic Scene");
            Scene();
        }

        Raylib.CloseWindow();
    }


    public static void WriteText(int x, int y, int fontSize, string text)
    {
        Raylib.BeginDrawing();
        Raylib.ClearBackground(Color.White);
        Raylib.DrawText(text, x, y, fontSize, Color.Black);
        Raylib.EndDrawing();
    }

    public static void Scene()
    {
        vec2 p1 = new vec2(50, 50);
        vec2 p2 = new vec2(300, 50);
        vec2 p3 = new vec2(175, 200);

        Triangle2D t = new Triangle2D(p1, p2, p3);
        t.Draw();
    }

}