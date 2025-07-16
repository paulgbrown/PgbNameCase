using PgbNameCase;

namespace UnitTests.NameCaseFormatterShould;

public class GivenTwoPartName
{
	[Theory]
	[InlineData("James O'Connor-Barnes")]
	[InlineData("James O'Connor-D'Amico")]
	[InlineData("James O'Connor-LaRoche")]
	[InlineData("James O'Connor-MacNelis")]
	[InlineData("John Macey-MacKenzie")]
	[InlineData("James O'Connor-MacKenzie")]
	public void CorrectlyFormatAName(string expectedName)
	{
		var nameToBeFormatted = expectedName.ToLower();

		var actualName = NameCaseFormatter.Format(nameToBeFormatted);

		Assert.Equal(expectedName, actualName);
	}

}
