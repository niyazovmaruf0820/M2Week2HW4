namespace task2;

public class Circle
{
    double radius;
    double pi = 3.14;
    public Circle(){}
    public Circle(double radius)
    {
        this.radius = radius;
    }
    public void SetRadius(double radius)
    {
        this.radius = radius;
    }
    public double GetRsdius()
    {
        return radius;
    }
    public double GetArea()
    {
        return radius * pi * radius;
    }
    public double GetDiameter()
    {
        return radius * 2;
    }
    public double GetCircumference()
    {
        return radius * 2 * pi;
    }

}
