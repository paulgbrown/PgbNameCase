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
	[InlineData("MacConnell")]
	[InlineData("MacCormack")]
	[InlineData("MacDermott")]
	[InlineData("MacDonald")]
	[InlineData("MacDonnell")]
	[InlineData("MacDougal")]
	[InlineData("MacDowell")]
	[InlineData("MacDuff")]
	[InlineData("MacFarlane")]
	[InlineData("MacGill")]
	[InlineData("MacGrath")]
	[InlineData("MacGregor")]
	[InlineData("MacGuire")]
	[InlineData("MacHale")]
	[InlineData("MacInnes")]
	[InlineData("MacIntosh")]
	[InlineData("MacIntyre")]
	[InlineData("MacKay")]
	[InlineData("MacKnight")]
	[InlineData("MacLachlan")]
	[InlineData("MacLaren")]
	[InlineData("MacLaughlin")]
	[InlineData("MacLeod")]
	public void CorrectlyFormatAName(string expectedName)
	{
		var nameToBeFormatted = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(expectedName);

		var actualName = StartsWithFormatter.Format(nameToBeFormatted);

		Assert.Equal(expectedName, actualName);
	}

	[Theory]
	[InlineData("Macera")]
	[InlineData("Macchi")]
	[InlineData("Maczko")]
	[InlineData("Machovec")]
	[InlineData("Maciej")]
	[InlineData("Mackiewicz")]
	public void NotChangeNamesThatEndInSpecifiedCharacters(string expectedName)
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




