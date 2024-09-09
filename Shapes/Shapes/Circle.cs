using Shapes.Interfaces;

namespace Shapes.Shapes;

public class Circle : IShape
{
	private double _radius;

	public double Squere
	{ get { return Math.PI * Math.Pow(_radius, 2); } }

	public Circle()
	{ }

	public Circle(double radius)
	{
		if (radius < 0)
			throw new ArgumentOutOfRangeException("Радиус не может быть меньше 0");

		_radius = radius;
	}
}
