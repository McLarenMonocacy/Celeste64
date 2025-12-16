
using System.Runtime.InteropServices;

namespace Celeste64;

class GlobalMouseEvents
{
    private static float mouseSensitivity = 1/25f;
    private static Vec2 mousePos = Input.Mouse.Position;
    public static Vec2 delta = mousePos;
    public static void Update()
    {
        //int centerx = App.WidthInPixels/2;
        //int centery = App.HeightInPixels/2;
        Vec2 newMousePos = Input.Mouse.Position;
        Vec2 output = newMousePos - mousePos;
        mousePos = newMousePos;
        delta = output * mouseSensitivity;
    }
}