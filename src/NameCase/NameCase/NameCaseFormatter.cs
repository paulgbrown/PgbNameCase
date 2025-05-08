using System.Globalization;

namespace PgbNameCase;

public class NameCaseFormatter
{
	public static string? Format(string nameToBeFormatted)
	{
		// If the string is null, just return a null.
		if (nameToBeFormatted == null) return null;

		var basicName = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(nameToBeFormatted.ToLower());

		var nameAfterParticles = ParticleFormatter.FormatParticles(basicName);

		var nameParts = nameAfterParticles.Split(' ');

		for (int i = 0; i < nameParts.Length; i++)
		{
			nameParts[i] = ParticleFormatter.FormatParticleNames(nameParts[i]);

			nameParts[i] = StartsWithFormatter.Format(nameParts[i]);

			nameParts[i] = HandleTwoLetterNames(nameParts[i]);

			nameParts[i] = HandleRomanNumerals(nameParts[i]);
		}

		return string.Join(" ", nameParts);
	}

	private static string HandleNamesWithParticles(string basicName)
	{
		var particleSpecials = SpecialHandlingFactory.GetParticles();
		foreach (var particleSpecial in particleSpecials.OrderByDescending(x=>x.Length))
		{
			if (basicName.Contains(particleSpecial))
			{
				basicName = basicName.Replace(particleSpecial, particleSpecial.ToLower());
			}
		}

		return basicName;
	}

	private static string HandleRomanNumerals(string nameToBeFormatted)
	{
		var romanNumerals = new string[] { "II", "III", "IV" };
		var upperNameToBeFormatted = nameToBeFormatted.ToUpper();

		if (romanNumerals.Contains(upperNameToBeFormatted))
		{
			return upperNameToBeFormatted;
		}

		return nameToBeFormatted;
	}

	private static string HandleTwoLetterNames(string nameToBeFormatted)
	{
		var twoLetterNames = SpecialHandlingFactory.GetTwoLetterNames();
		var upperNameToBeFormatted = nameToBeFormatted.ToUpper();

		if (nameToBeFormatted.Length == 2 && twoLetterNames.Contains(upperNameToBeFormatted))
		{
			return upperNameToBeFormatted;
		}

		return nameToBeFormatted;
	}
}
