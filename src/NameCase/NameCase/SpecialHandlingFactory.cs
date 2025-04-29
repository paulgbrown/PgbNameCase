namespace PgbNameCase;

internal class SpecialHandlingFactory
{
	private readonly static List<string> _McSpecials;
	private readonly static List<string> _MacSpecials;
	private readonly static List<string> _Particles;
	private readonly static List<string> _TwoLetterNames;

	static SpecialHandlingFactory()
	{
		_MacSpecials = new List<string>() {
				"Macevicius",
				"Machado",
				"Machar",
				"Machin",
				"Machlin",
				"Macias",
				"Maciulis",
				"Mack",
				"Mackie",
				"Mackintosh",
				"Mackle",
				"Macklin",
				"Macquarie"
			};

		_McSpecials = new List<string>();

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

		_TwoLetterNames = new List<string>() { 
			"AJ",
			"BJ",
			"JD",
			"JJ",
		};
	}

	internal static List<string> GetMacSpecials()
	{
		return _MacSpecials;
	}

	internal static List<string> GetMcSpecials()
	{
		return _McSpecials;
	}

	internal static List<string> GetParticles()
	{
		return _Particles;
	}

	internal static List<string> GetTwoLetterNames()
	{
		return _TwoLetterNames;
	}
}

