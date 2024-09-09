using Shapes.Interfaces;

namespace Shapes.Shapes;

public class Shape : IShape
{
	private IShape _shape;
	public double Squere
	{ get { return _shape.Squere; } }

	public Shape(IShape shape)
	{
		_shape = shape;
	}
}
