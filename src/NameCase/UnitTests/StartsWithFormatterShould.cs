using PgbNameCase;
using System.Globalization;

namespace UnitTests.StartsWithFormatterShould;

public class GivenAMcName
{
	[Theory]
	[InlineData("McAdam")]
	[InlineData("McAlister")]
	[InlineData("McAllister")]
	[InlineData("McAlpine")]
	[InlineData("McAndrew")]
	[InlineData("McCaffey")]
	[InlineData("McCambridge")]
	[InlineData("McCarter")]
	[InlineData("McCartney")]
	[InlineData("McClintock")]
	[InlineData("McClure")]
	[InlineData("McConnell")]
	[InlineData("McCormack")]
	[InlineData("McCormick")]
	[InlineData("McDonald")]
	[InlineData("McDuff")]
	[InlineData("McFarlane")]
	[InlineData("McFee")]
	[InlineData("McGill")]
	[InlineData("McHenry")]
	[InlineData("McLean")]
	[InlineData("McMaster")]
	[InlineData("McMillan")]
	[InlineData("McNair")]
	[InlineData("McNally")]
	[InlineData("McSorley")]
	[InlineData("McVicar")]
	public void CorrectlyFormatAName(string expectedName)
	{
		var nameToBeFormatted = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(expectedName);

		var actualName = StartsWithFormatter.Format(nameToBeFormatted);

		Assert.Equal(expectedName, actualName);
	}
}

public class GivenAMacName
{
	[Theory]
	[InlineData("Macaluso")]
	[InlineData("Macaraeg")]
	[InlineData("Macari")]
	[InlineData("Macario")]
	[InlineData("Maccarone")]
	[InlineData("Macchi")]
	[InlineData("Macchia")]
	[InlineData("Macchio")]
	[InlineData("Macchione")]
	[InlineData("Maccini")]
	[InlineData("Macedo")]
	[InlineData("Macera")]
	[InlineData("Macevicius")]
	[InlineData("Machac")]
	[InlineData("Machacek")]
	[InlineData("Machado")]
	[InlineData("Machak")]
	[InlineData("Machala")]
	[InlineData("Machamer")]
	[InlineData("Machan")]
	[InlineData("Machar")]
	[InlineData("Machart")]
	[InlineData("Machemer")]
	[InlineData("Machen")]
	[InlineData("Macher")]
	[InlineData("Machia")]
	[InlineData("Machida")]
	[InlineData("Machin")]
	[InlineData("Machlin")]
	[InlineData("Machnicki")]
	[InlineData("Machnik")]
	[InlineData("Machon")]
	[InlineData("Machovec")]
	[InlineData("Machowski")]
	[InlineData("Machuca")]
	[InlineData("Machuga")]
	[InlineData("Maciag")]
	[InlineData("Macias")]
	[InlineData("Maciej")]
	[InlineData("Maciejewski")]
	[InlineData("Maciel")]
	[InlineData("Macina")]
	[InlineData("Macioce")]
	[InlineData("Maciolek")]
	[InlineData("Maciulis")]
	[InlineData("Mack")]
	[InlineData("Mackall")]
	[InlineData("Mackel")]
	[InlineData("Mackell")]
	[InlineData("Macken")]
	[InlineData("Mackenthun")]
	[InlineData("Macker")]
	[InlineData("Mackert")]
	[InlineData("Mackes")]
	[InlineData("Mackey")]
	[InlineData("Mackie")]
	[InlineData("Mackiewicz")]
	[InlineData("Mackin")]
	[InlineData("Mackintosh")]
	[InlineData("Mackle")]
	[InlineData("Macklem")]
	[InlineData("Mackler")]
	[InlineData("Mackley")]
	[InlineData("Macklin")]
	[InlineData("Mackowiak")]
	[InlineData("Mackowski")]
	[InlineData("Mackrell")]
	[InlineData("Maclin")]
	[InlineData("Macomb")]
	[InlineData("Macomber")]
	[InlineData("Macquarie")]
	[InlineData("Macrina")]
	[InlineData("Macris")]
	[InlineData("Macumber")]
	[InlineData("Maczko")]
	[InlineData("Maczynski")]
	public void CorrectlyFormatAName(string expectedName)
	{
		var nameToBeFormatted = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(expectedName);

		var actualName = StartsWithFormatter.Format(nameToBeFormatted);

		Assert.Equal(expectedName, actualName);
	}

	[Theory]
	[InlineData("Macaluso")]
	[InlineData("Macaraeg")]
	[InlineData("Macari")]
	[InlineData("Macario")]
	[InlineData("Maccarone")]
	[InlineData("Macchi")]
	[InlineData("Macchia")]
	[InlineData("Macchio")]
	[InlineData("Macchione")]
	[InlineData("Maccini")]
	[InlineData("Macomber")]
	[InlineData("Macedo")]
	[InlineData("Macera")]
	[InlineData("Macevicius")]
	[InlineData("Machac")]
	[InlineData("Machacek")]
	[InlineData("Machado")]
	[InlineData("Machak")]
	[InlineData("Machala")]
	[InlineData("Machamer")]
	[InlineData("Machan")]
	[InlineData("Machar")]
	[InlineData("Machart")]
	[InlineData("Machell")]
	[InlineData("Machemer")]
	[InlineData("Machen")]
	[InlineData("Macher")]
	[InlineData("Machia")]
	[InlineData("Machida")]
	[InlineData("Machiel")]
	[InlineData("Machin")]
	[InlineData("Machlin")]
	[InlineData("Machnicki")]
	[InlineData("Machnik")]
	[InlineData("Machon")]
	[InlineData("Machovec")]
	[InlineData("Machowski")]
	[InlineData("Machuca")]
	[InlineData("Machuga")]
	[InlineData("Maciag")]
	[InlineData("Macias")]
	[InlineData("Maciej")]
	[InlineData("Maciejewski")]
	[InlineData("Maciel")]
	[InlineData("Maciol")]
	[InlineData("Macina")]
	[InlineData("Macioce")]
	[InlineData("Maciolek")]
	//[InlineData("Macisaac")]
	[InlineData("Maciulis")]
	[InlineData("MacMillan")]
	[InlineData("Mackall")]
	[InlineData("Mackel")]
	[InlineData("Mackell")]
	[InlineData("Macklem")]
	[InlineData("Macken")]
	[InlineData("Mackenthun")]
	[InlineData("Macker")]
	[InlineData("Mackert")]
	[InlineData("Mackes")]
	[InlineData("Mackey")]
	[InlineData("Mackie")]
	[InlineData("Mackiewicz")]
	[InlineData("Mackin")]
	[InlineData("Mackintosh")]
	[InlineData("Mackle")]
	[InlineData("Macklem")]
	[InlineData("Mackler")]
	[InlineData("Mackley")]
	[InlineData("Macklin")]
	[InlineData("Mackowiak")]
	[InlineData("Mackowski")]
	[InlineData("Mackrell")]
	[InlineData("Maclin")]
	[InlineData("Macomb")]
	[InlineData("Macomber")]
	[InlineData("Macquarie")]
	[InlineData("Macrina")]
	[InlineData("Macris")]
	[InlineData("Macumber")]
	[InlineData("Maczko")]
	[InlineData("Maczynski")]
	public void HandleExceptions(string expectedName)
	{
		var nameToBeFormatted = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(expectedName);

		var actualName = StartsWithFormatter.Format(nameToBeFormatted);

		Assert.Equal(expectedName, actualName);
	}

	[Theory]
	[InlineData("Mack")]
	[InlineData("Macy")]
	[InlineData("Macda")]
	[InlineData("Macin")]
	[InlineData("Macri")]
	public void NotCapitalizeNamesOfFiveOrLess(string expectedName)
	{
		var nameToBeFormatted = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(expectedName);

		var actualName = StartsWithFormatter.Format(nameToBeFormatted);

		Assert.Equal(expectedName, actualName);
	}
}

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
	public void CorrectlyFormatAName(string expectedName)
	{
		var nameToBeFormatted = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(expectedName);

		var actualName = StartsWithFormatter.Format(nameToBeFormatted);

		Assert.Equal(expectedName, actualName);
	}
}

public class GivenAnNameWithAnApostrophe
{
	[Theory]
	[InlineData("Mc'Arthur")]
	[InlineData("Mac'Holmes")]
	[InlineData("Mac'Laren")]
	public void CorrectlyFormatAMcName(string expectedName)
	{
		var nameToBeFormatted = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(expectedName);

		var actualName = StartsWithFormatter.Format(nameToBeFormatted);

		Assert.Equal(expectedName, actualName);
	}
}

