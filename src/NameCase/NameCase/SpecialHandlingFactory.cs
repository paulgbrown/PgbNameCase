namespace PgbNameCase;

internal class SpecialHandlingFactory
{
	private readonly static List<string> _Particles;

	static SpecialHandlingFactory()
	{
		_Particles = new List<string>()
		{
			" Van ",
			" Van Der",
			" Von ",
			" Al ",
			" Ben ",
			" Bin ",
			" Da ",
			" De ",
			" Di ",
			" Du ",
			" El "
		};
	}

	internal static List<string> GetParticles()
	{
		return _Particles;
	}
}

