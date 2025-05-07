using PgbNameCase;

namespace UnitTests;

public class GivenANameWithAParticle
{
	[Theory]
	[InlineData("DeWitt")]
	[InlineData("DeRosa")]
	[InlineData("LaRue")]
	[InlineData("LaRosa")]
	[InlineData("Leblanc")]
	[InlineData("Leclair")]
	public void CorrectlyFormatAName(string expectedName)
	{
		var nameToBeFormatted = expectedName.ToLower();

		var actualName = NameCaseFormatter.Format(nameToBeFormatted);

		Assert.Equal(expectedName, actualName);
	}

	[Theory]
	[InlineData("Leonardo da Vinci")]
	[InlineData("Leonardo di Caprio")]
	[InlineData("Pierre du Pont")]
	[InlineData("Robert van der Graaf")]
	[InlineData("Maria von Trapp")]
	public void CorrectlyFormatAFullName(string expectedName)
	{
		var nameToBeFormatted = expectedName.ToLower();

		var actualName = NameCaseFormatter.Format(nameToBeFormatted);

		Assert.Equal(expectedName, actualName);
	}

	[Theory]
	[InlineData("John ROMERO", "John Romero")]
	public void CorrectlyFormatOddCaseNames(string nameToBeFormatted, string expectedName)
	{
		var actualName = NameCaseFormatter.Format(nameToBeFormatted);

		Assert.Equal(expectedName, actualName);
	}
}
