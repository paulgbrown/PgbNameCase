namespace PgbNameCase;

internal class IrishFormatter
{
	internal static string Format(string nameToBeFormatted)
	{
		var position = 0;
		var specials = new List<string>();

		if (nameToBeFormatted.StartsWith("O'"))
		{
			position = 2;
		}

		if (nameToBeFormatted.StartsWith("Mac"))
		{
			if (nameToBeFormatted.Length <= 5) return nameToBeFormatted;

			specials = SpecialHandlingFactory.GetMacSpecials();
			position = 3;
		}

		if (nameToBeFormatted.StartsWith("Mc"))
		{
			specials = SpecialHandlingFactory.GetMcSpecials();
			position = 2;
		}

		if (nameToBeFormatted.StartsWith("Mac'"))
		{
			position = 4;
		}

		if (nameToBeFormatted.StartsWith("Mc'"))
		{
			position = 3;
		}

		if (position > 0)
		{
			if (!specials.Contains(nameToBeFormatted))
			{
				nameToBeFormatted = UpperSpecificPosition(nameToBeFormatted, position);
			}
		}

		return nameToBeFormatted;
	}

	private static string UpperSpecificPosition(string nameToBeFormatted, int position)
	{
		char[] chars = nameToBeFormatted.ToCharArray();
		chars[position] = char.ToUpper(chars[position]);
		nameToBeFormatted = new string(chars);
		return nameToBeFormatted;
	}
}
