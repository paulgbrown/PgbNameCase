using PgbNameCase;
using System.Globalization;

namespace UnitTests.IrishFormatterShould;

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

		var actualName = IrishFormatter.Format(nameToBeFormatted);

		Assert.Equal(expectedName, actualName);
	}
}

public class GivenAMacName
{
	[Theory]
	[InlineData("MacAdam")]
	[InlineData("MacAlister")]
	[InlineData("MacAllister")]
	[InlineData("MacAlpine")]
	[InlineData("MacAmbrais")]
	[InlineData("MacAndie")]
	[InlineData("MacAndrew")]
	[InlineData("MacAnroy")]
	[InlineData("MacArthur")]
	[InlineData("MacAulay")]
	[InlineData("MacBeath")]
	[InlineData("MacBeth")]
	[InlineData("MacBey")]
	[InlineData("MacBratney")]
	[InlineData("MacBrayne")]
	[InlineData("MacCaffey")]
	[InlineData("MacCambridge")]
	[InlineData("MacCartney")]
	[InlineData("MacCavity")]
	[InlineData("MacCaw")]
	[InlineData("MacClery")]
	[InlineData("MacClintock")]
	[InlineData("MacClure")]
	[InlineData("MacCombie")]
	[InlineData("MacConnell")]
	[InlineData("MacCormack")]
	[InlineData("MacCormick")]
	[InlineData("MacCrossan")]
	[InlineData("MacCulloch")]
	[InlineData("MacDonald")]
	[InlineData("MacDuff")]
	[InlineData("MacFarlane")]
	[InlineData("MacFee")]
	[InlineData("MacGavin")]
	[InlineData("MacGill")]
	[InlineData("MacGillivray")]
	[InlineData("MacGowan")]
	[InlineData("MacGruer")]
	[InlineData("MacGruther")]
	[InlineData("MacInally")]
	[InlineData("MacIndoe")]
	[InlineData("MacInroy")]
	[InlineData("MacIntosh")]
	[InlineData("MacIntyre")]
	[InlineData("MacKeggie")]
	[InlineData("Mackintosh")]
	[InlineData("MacLean")]
	[InlineData("MacLeish")]
	[InlineData("MacLennan")]
	[InlineData("MacLerie")]
	[InlineData("MacLinton")]
	[InlineData("MacLure")]
	[InlineData("MacMaster")]
	[InlineData("MacMillan")]
	[InlineData("MacNair")]
	[InlineData("MacNally")]
	[InlineData("MacNevin")]
	[InlineData("MacNiven")]
	[InlineData("MacPhee")]
	[InlineData("MacPherson")]
	[InlineData("MacQueen")]
	[InlineData("MacSorley")]
	[InlineData("MacTaggart")]
	[InlineData("MacVaxter")]
	[InlineData("MacVicar")]
	[InlineData("MacVitie")]
	[InlineData("MacWhannell")]
	[InlineData("MacWhillan")]
	[InlineData("Magruder")]
	[InlineData("Malloch")]
	[InlineData("McCarter")]
	[InlineData("McElshender")]
	[InlineData("McHenry")]
	public void CorrectlyFormatAName(string expectedName)
	{
		var nameToBeFormatted = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(expectedName);

		var actualName = IrishFormatter.Format(nameToBeFormatted);

		Assert.Equal(expectedName, actualName);
	}

	[Theory]
	[InlineData("Machin")]
	[InlineData("Machlin")]
	[InlineData("Machar")]
	[InlineData("Mackle")]
	[InlineData("Macklin")]
	[InlineData("Mackie")]
	[InlineData("Macquarie")]
	[InlineData("Machado")]
	[InlineData("Macevicius")]
	[InlineData("Maciulis")]
	[InlineData("Macias")]
	[InlineData("MacMurdo")]
	public void HandleExceptions(string expectedName)
	{
		var nameToBeFormatted = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(expectedName);

		var actualName = IrishFormatter.Format(nameToBeFormatted);

		Assert.Equal(expectedName, actualName);
	}
}

public class GivenAnOName
{
	[Theory]
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

		var actualName = IrishFormatter.Format(nameToBeFormatted);

		Assert.Equal(expectedName, actualName);
	}
}

