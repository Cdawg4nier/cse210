public class Rectangle : Shape
{
    private double _sideShort;
    private double _sideLong;
    public Rectangle(string color, double sideShort, double sideLong): base(color)
    {
        _sideShort = sideShort;
        _sideLong = sideLong;
    }
    public override double GetArea()
    {  
        return _sideShort * _sideLong;
    }
}