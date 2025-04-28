using NameCase;

namespace UnitTests.NameCaseFormatterShould;

public class GivenATwoLetterName
{
	[Theory]
	[InlineData("JJ Abrams")]
	[InlineData("JD Salinger")]
	[InlineData("AJ Michalka")]
	[InlineData("J. F. Kennedy")]
	[InlineData("J.F. Kennedy")]	
	public void CorrectlyFormatAName(string expectedName)
	{
		var nameToBeFormatted = expectedName.ToLower();

		var actualName = NameCaseFormatter.Format(nameToBeFormatted);

		Assert.Equal(expectedName, actualName);
	}

	[Theory]
	[InlineData("Mr Smith")]
	[InlineData("Ms Smith")]
	[InlineData("Dr Martin Luther King Jr")]
	[InlineData("St Patrick")]
	[InlineData("Martin Luther King Sr")]
	[InlineData("Lt Worf")]
	public void AllowForExceptions(string expectedName)
	{
		var nameToBeFormatted = expectedName.ToLower();

		var actualName = NameCaseFormatter.Format(nameToBeFormatted);

		Assert.Equal(expectedName, actualName);
	}



}
