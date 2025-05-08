using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PgbNameCase;

internal class ParticleFormatter
{
	internal static string FormatParticles(string basicName)
	{
		var particleSpecials = SpecialHandlingFactory.GetParticles();
		foreach (var particleSpecial in particleSpecials.OrderByDescending(x => x.Length))
		{
			if (basicName.Contains(particleSpecial))
			{
				basicName = basicName.Replace(particleSpecial, particleSpecial.ToLower());
			}
		}

		return basicName;
	}

	internal static string FormatParticleNames(string basicName)
	{
		var particleNames = SpecialHandlingFactory.GetParticleNames();

		string value = particleNames.TryGetValue(basicName.ToLower(), out string result) ? result : string.Empty;

		if (!string.IsNullOrEmpty(value))
		{
			return value;
		}

		return basicName;
	}
}
