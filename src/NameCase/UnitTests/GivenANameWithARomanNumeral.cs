using PgbNameCase;

namespace UnitTests.NameCaseFormatterShould;

public class GivenANameWithARomanNumeral
{
	[Theory]
	[InlineData("Charles I")]
	[InlineData("Charles II")]
	[InlineData("Louis III")]
	[InlineData("Henry IV")]
	[InlineData("Richard V")]
	public void CorrectlyFormatAName(string expectedName)
	{
		var nameToBeFormatted = expectedName.ToLower();

		var actualName = NameCaseFormatter.Format(nameToBeFormatted);

		Assert.Equal(expectedName, actualName);
	}
}
