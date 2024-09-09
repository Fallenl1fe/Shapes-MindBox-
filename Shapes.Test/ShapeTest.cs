using Shapes.Shapes;

namespace Shapes.Test;

public class ShapeTest
{
	[Fact]
	public void ShapeSquereAsCircle()
	{
		//arrange
		Shape circle  = new Shape(new Circle(5.5)); ;
		double isValid = Math.PI * 30.25;
		//act
		double result = circle.Squere;
		//assert
		Assert.Equal(isValid, result);
	}

	[Fact]
	public void ShapeSquereAsTriangle()
	{
		//arrange
		Shape triangle = new Shape(new Triangle(3,4,5)); ;
		double isValid = 6;
		//act
		double result = triangle.Squere;
		//assert
		Assert.Equal(isValid, result);
	}
}
