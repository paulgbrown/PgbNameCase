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
}
