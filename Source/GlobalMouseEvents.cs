
namespace Celeste64;

class GlobalMouseEvents
{
    Vec2 mousePos = Input.Mouse.Position;
    private Vec2 MoveCursor()
    {
        Vec2 newMousePos = Input.Mouse.Position;
        Vec2 output = newMousePos - mousePos;
        mousePos = newMousePos;
        return output;
    }
}