using PgbNameCase;

namespace UnitTests.NameCaseFormatterShould;

public class GivenABasicName
{
	[Theory]
	[InlineData("Keith")]
	[InlineData("Yuri's")]
	[InlineData("Leigh-Williams")]
	[InlineData("McCarthy")]
	[InlineData("O'Callaghan")]
	[InlineData("St. John")]
	[InlineData("Van")]
	[InlineData("Ben")]
	[InlineData("Mack Knife")]
	[InlineData("Dougal MacDonald")]
	[InlineData("Yusof bin Ishak")]
	[InlineData("Mr & Mrs J David McFadden")]
	[InlineData("John Mc")]
	[InlineData("John Mac")]
	[InlineData("John DeWitt")]
	[InlineData("John DeRosa")]
	[InlineData("Wernher von Braun")]
	public void CorrectlyFormatAName(string expectedName)
	{
		var nameToBeFormatted = expectedName.ToLower();

		var actualName = NameCaseFormatter.Format(nameToBeFormatted);

		Assert.Equal(expectedName, actualName);
	}

	[Theory]
	[InlineData("ROMERO", "Romero")]
	[InlineData("George A. ROMERO", "George A. Romero")]
	public void CorrectlyFormatNamesWithOddCaps(string nameToBeFormatted, string expectedName)
	{
		var actualName = NameCaseFormatter.Format(nameToBeFormatted);

		Assert.Equal(expectedName, actualName);
	}
}





public class GivenANull()
{
	[Fact]
	public void CorrectlyFormatAString()
	{
		string nameToBeFormatted = null;

		var actualName = NameCaseFormatter.Format(nameToBeFormatted);

		Assert.Null(actualName);
	}

	[Fact]
	public void CorrectlyFormatANullableString()
	{
		string? nameToBeFormatted = null;

		var actualName = NameCaseFormatter.Format(nameToBeFormatted);

		Assert.Null(actualName);
	}
}
