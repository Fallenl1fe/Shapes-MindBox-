using Shapes.Shapes;

namespace Shapes.Test;

public class CircleTest
{
	[Fact]
	public void CircleRadiusGreaterThen0()
	{
		//arrange
		Circle circle;
		//act
		Action act = () => circle = new Circle(-1);
		//assert
		ArgumentOutOfRangeException exception = Assert.Throws<ArgumentOutOfRangeException>(act);
	}

	[Fact]
	public void CircleValidSquere()
	{
		//arrange
		Circle circle = new Circle(5.5);
		double isValid = Math.PI * 30.25;
		//act
		double result = circle.Squere;
		//assert
		Assert.Equal(isValid, result);
	}
}