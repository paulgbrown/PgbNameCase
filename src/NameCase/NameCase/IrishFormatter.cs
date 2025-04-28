namespace NameCase;

internal class IrishFormatter
{
	internal static string Format(string nameToBeFormatted)
	{
		if (nameToBeFormatted.StartsWith("O'"))
		{
			nameToBeFormatted = UpperSpecificPosition(nameToBeFormatted, 2);
		}

		if (nameToBeFormatted.StartsWith("Mac"))
		{
			var macSpecials = SpecialHandlingFactory.GetMacSpecials();
			if (!macSpecials.Contains(nameToBeFormatted))
			{
				nameToBeFormatted = UpperSpecificPosition(nameToBeFormatted, 3);
			}
		}

		if (nameToBeFormatted.StartsWith("Mc"))
		{
			var macSpecials = SpecialHandlingFactory.GetMcSpecials();
			if (!macSpecials.Contains(nameToBeFormatted))
			{
				nameToBeFormatted = UpperSpecificPosition(nameToBeFormatted, 2);
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
