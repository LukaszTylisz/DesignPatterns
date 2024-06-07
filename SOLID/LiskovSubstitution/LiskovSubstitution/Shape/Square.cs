namespace LiskovSubstitution.Shape;

public class Square : Rectangle
{
    public override void SetHeight(int height)
    {
        _height = height;
        _width = height;
    }
    
    public override void SetWidth(int width)
    {
        _height = width;
        _width = width;
    }
}