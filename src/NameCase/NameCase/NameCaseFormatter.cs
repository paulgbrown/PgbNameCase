using System.Globalization;
using System.Text.RegularExpressions;

namespace PgbNameCase;

public class NameCaseFormatter
{
	public static string? Format(string nameToBeFormatted)
	{
		var formattedNames = FormattedNameFactory.GetNames();
		return Format(nameToBeFormatted, formattedNames);
	}

	public static string? Format(string nameToBeFormatted, IReadOnlySet<string> formattedNames)
	{
		// If the string is null, just return a null.
		if (nameToBeFormatted == null) return null;

		var basicName = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(nameToBeFormatted.ToLower());

		var nameAfterParticles = ParticleFormatter.FormatParticles(basicName);

		if(nameAfterParticles.Contains("'"))
		{
			nameAfterParticles = FormatNameWithAnApostrophe(nameAfterParticles);
		}

		var nameParts = nameAfterParticles.Split(' ');

		for (int i = 0; i < nameParts.Length; i++)
		{
			var finalName = HandlePossibleDashName(formattedNames, nameParts[i]);
			nameParts[i] = finalName;
		}

		return string.Join(" ", nameParts);
	}

	private static string HandlePossibleDashName(IReadOnlySet<string> formattedNames, string name)
	{
		string nameA = name;
		string nameB = string.Empty;

		if (name.Contains("-"))
		{
			var dashName = name.Split('-');
			nameA = dashName[0];
			nameB = dashName[1];
		}

		nameA = PerformFinalFormatting(formattedNames, nameA);

		if (string.IsNullOrEmpty(nameB))
		{
			return nameA;
		}

		nameB = PerformFinalFormatting(formattedNames, nameB);

		return nameA + "-" + nameB;
	}

	private static string PerformFinalFormatting(IReadOnlySet<string> formattedNames, string name)
	{ 
		string? formattedName = formattedNames.FirstOrDefault(w => w.Equals(name, StringComparison.OrdinalIgnoreCase));

		if (formattedName != null)
		{
			return formattedName;
		}
		else
		{
			return StartsWithFormatter.Format(name);
		}
	}

	public static string FormatNameWithAnApostrophe(string nameToBeFormatted)
	{
		if (string.IsNullOrWhiteSpace(nameToBeFormatted))
			return string.Empty;

		// Trim spaces and normalize apostrophe spacing
		nameToBeFormatted = Regex.Replace(nameToBeFormatted, @"\s*'\s*", "'");

		// Capitalize each word properly
		TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
		string result = textInfo.ToTitleCase(nameToBeFormatted.ToLower());

		// Ensure the letter after an apostrophe is capitalized (e.g., O'Loaughlin)
		result = Regex.Replace(result, @"\b(\w)'(\w)", m => $"{m.Groups[1].Value}'{char.ToUpper(m.Groups[2].Value[0])}{m.Groups[2].Value.Substring(1)}");

		return result;
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
}
