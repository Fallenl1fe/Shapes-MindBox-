using Shapes.Interfaces;

namespace Shapes.Shapes;

public class Triangle : IShape
{
	private double _x;
	private double _y;
	private double _z;

	public double Squere
	{
		get
		{ // По формуле Герона
			double p = (_x + _y + _z) / 2;
			return Math.Sqrt(p * (p - _x) * (p - _y) * (p - _z));
		}
	}

	public Triangle()
	{
		//_x =_y =_z = 0;
	}

	public Triangle(double x, double y, double z)
	{
		if (x < 0 || y < 0 || y < 0)
			throw new ArgumentOutOfRangeException("Сторона не может быть меньше 0");
		
		_x = x;
		_y = y;
		_z = z;
	}

	public bool IsRightTriangle()
	{
		return _x == Math.Sqrt(Math.Pow(_y, 2) + Math.Pow(_z, 2))
			|| _y == Math.Sqrt(Math.Pow(_x, 2) + Math.Pow(_z, 2))
			|| _z == Math.Sqrt(Math.Pow(_x, 2) + Math.Pow(_y, 2));
	}

}
