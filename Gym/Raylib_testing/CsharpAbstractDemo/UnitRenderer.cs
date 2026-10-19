namespace CsharpAbstractDemo;

public class UnitRenderer
{
    protected Color _color = Color.Red;
  public void Draw(Rectangle rect)
  {
    Raylib.DrawRectangleRec(rect, _color);
  }
}