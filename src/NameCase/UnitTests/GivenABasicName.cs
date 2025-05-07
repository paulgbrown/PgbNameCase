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
	public void CorrectlyFormatAName(string expectedName)
	{
		var nameToBeFormatted = expectedName.ToLower();

		var actualName = NameCaseFormatter.Format(nameToBeFormatted);

		Assert.Equal(expectedName, actualName);
	}

	[Fact]	
	public void CorrectlyFormatANameWithAllCaps()
	{
		var expectedName = "George A. Romero";
		var nameToBeFormatted = "George A. ROMERO"; ;

		var actualName = NameCaseFormatter.Format(nameToBeFormatted);

		Assert.Equal(expectedName, actualName);
	}
}

public class GivenANameThatStartsWithO
{
	[Theory]
	[InlineData("Alex O'Loughlin")]
	[InlineData("Alexis Ohanian")]
	[InlineData("Ana Ortiz")]
	[InlineData("Ashley Olsen")]
	[InlineData("Aubrey O'Day")]
	[InlineData("Barack Obama")]
	[InlineData("Beth Ostrosky Stern")]
	[InlineData("Chad Ochocinco")]
	[InlineData("Charlie O'Connell")]
	[InlineData("Chord Overstreet")]
	[InlineData("Clive Owen")]
	[InlineData("Conan O'Brien")]
	[InlineData("Corinne Olympios")]
	[InlineData("Daphne Oz")]
	[InlineData("Elizabeth Olsen")]
	[InlineData("Emily Osment")]
	[InlineData("Frank Ocean")]
	[InlineData("Gary Oldman")]
	[InlineData("Jamie Otis")]
	[InlineData("Jerry O'Connell")]
	[InlineData("Jonathan Owens")]
	[InlineData("Kelly Osbourne")]
	[InlineData("Lamar Odom")]
	[InlineData("Mary-Kate Olsen")]
	[InlineData("Michelle Obama")]
	[InlineData("Neri Oxman")]
	[InlineData("Nick Offerman")]
	[InlineData("Ozzy Osbourne")]
	[InlineData("Rita Ora")]
	[InlineData("Ronnie Ortiz-Magro")]
	[InlineData("Rosie O'Donnell")]
	[InlineData("Sandra Oh")]
	[InlineData("Shaquille O'Neal")]
	[InlineData("Sharon Osbourne")]
	[InlineData("Shohei Ohtani")]
	[InlineData("Tatum O'Neal")]
	public void CorrectlyFormatAName(string expectedName)
	{
		var nameToBeFormatted = expectedName.ToLower();

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
