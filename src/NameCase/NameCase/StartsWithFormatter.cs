namespace PgbNameCase;

internal class StartsWithFormatter
{
	internal static string Format(string nameToBeFormatted)
	{
		var position = 0;


		if (nameToBeFormatted.StartsWith("Mac"))
		{
			if (nameToBeFormatted.Length <= 5) return nameToBeFormatted;

			if (nameToBeFormatted.EndsWithSpecifiedChars()) return nameToBeFormatted;

			position = 3;
		}

		if (nameToBeFormatted.StartsWith("Mc"))
		{
			if (nameToBeFormatted.Length <= 4) return nameToBeFormatted;

			if (nameToBeFormatted.EndsWithSpecifiedChars()) return nameToBeFormatted;

			position = 2;
		}

		if (nameToBeFormatted.StartsWith("Mac'"))
		{
			position = 4;
		}

		if (nameToBeFormatted.StartsWith("Mc'"))
		{
			if (nameToBeFormatted.Length <= 5) return nameToBeFormatted;

			position = 3;
		}

		if (position > 0)
		{
			nameToBeFormatted = UpperSpecificPosition(nameToBeFormatted, position);
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
