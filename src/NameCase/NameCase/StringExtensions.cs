using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PgbNameCase;

internal static class StringExtensions
{
	internal static bool EndsWithSpecifiedChars(this string word)
	{
		char lastChar = char.ToLower(word[word.Length - 1]);

		return "acioczj".Contains(lastChar);
	}
}
