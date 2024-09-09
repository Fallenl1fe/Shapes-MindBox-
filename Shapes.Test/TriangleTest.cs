using Shapes.Shapes;

namespace Shapes.Test;

public class TriangleTest
{
	[Fact]
	public void TriangleSidesGreaterThen0()
	{
		//arrange
		Triangle triangle;
		//act
		Action act = () => triangle = new Triangle(-1, -1, -1);
		//assert
		ArgumentOutOfRangeException exception = Assert.Throws<ArgumentOutOfRangeException>(act);
	}

	[Fact]
	public void TriangleSquere()
	{
		//arrange
		Triangle triangle = new Triangle(3, 4, 5);
		double isValid = 6;
		//act
		double result = triangle.Squere;
		//assert
		Assert.Equal(isValid, result);
	}

	[Fact]
	public void IsRightTriangle1()
	{
		//arrange
		Triangle triangle = new Triangle(3, 4, 5);
		bool isValid = true;
		//act
		bool result = triangle.IsRightTriangle();
		//assert
		Assert.Equal(isValid, result);
	}
		
	[Fact]
	public void IsRightTriangle2()
	{
		//arrange
		Triangle triangle = new Triangle(3, 4, 6);
		bool isValid = false;
		//act
		bool result = triangle.IsRightTriangle();
		//assert
		Assert.Equal(isValid, result);
	}
}
