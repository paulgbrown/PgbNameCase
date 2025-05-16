using PgbNameCase;
using System.Globalization;

namespace UnitTests.NameCaseFormatterShould;

public class GivenANameWithAnApostrophe
{
	[Theory]
	[InlineData("D'Amico")]
	[InlineData("D'Angelo")]
	[InlineData("D'Arcy")]
	[InlineData("D'Eufemio")]
	[InlineData("L'Oreal")]
	[InlineData("M'Barek")]
	[InlineData("O'Loughlin")]
	[InlineData("Ohanian")]
	[InlineData("Ortiz")]
	[InlineData("Olsen")]
	[InlineData("O'Day")]
	[InlineData("Obama")]
	[InlineData("Ostrosky")]
	[InlineData("Ochocinco")]
	[InlineData("O'Connell")]
	[InlineData("Overstreet")]
	[InlineData("Owen")]
	[InlineData("O'Brien")]
	[InlineData("Olympios")]
	[InlineData("Oz")]
	[InlineData("Olsen")]
	[InlineData("Osment")]
	[InlineData("Ocean")]
	[InlineData("Oldman")]
	[InlineData("Otis")]
	[InlineData("O'Connell")]
	[InlineData("Owens")]
	[InlineData("Osbourne")]
	[InlineData("Odom")]
	[InlineData("Olsen")]
	[InlineData("Obama")]
	[InlineData("Oxman")]
	[InlineData("Offerman")]
	[InlineData("Osbourne")]
	[InlineData("Ora")]
	[InlineData("Ortiz-Magro")]
	[InlineData("O'Donnell")]
	[InlineData("Oh")]
	[InlineData("O'Neal")]
	[InlineData("Osbourne")]
	[InlineData("Ohtani")]
	[InlineData("O'Neal")]
	[InlineData("Mc'Arthur")]
	[InlineData("Mac'Holmes")]
	[InlineData("Mac'Laren")]
	public void CorrectlyFormatAName(string expectedName)
	{
		var nameToBeFormatted = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(expectedName);

		var actualName = NameCaseFormatter.Format(nameToBeFormatted);

		Assert.Equal(expectedName, actualName);
	}
}

