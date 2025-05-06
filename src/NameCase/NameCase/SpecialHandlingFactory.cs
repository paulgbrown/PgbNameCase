namespace PgbNameCase;

internal class SpecialHandlingFactory
{
	private readonly static List<string> _McSpecials;
	private readonly static List<string> _MacSpecials;
	private readonly static List<string> _Particles;
	private readonly static Dictionary<string, string> _ParticleNames;
	private readonly static List<string> _TwoLetterNames;

	static SpecialHandlingFactory()
	{
		_MacSpecials = new List<string>() {
			"Macaluso",
			"Macaraeg",
			"Macari",
			"Macario",
			"Maccarone",
			"Macchi",
			"Macchia",
			"Macchio",
			"Macchione",
			"Maccini",
			"Macedo",
			"Macera",
			"Macevicius",
			"Machac",
			"Machacek",
			"Machado",
			"Machak",
			"Machala",
			"Machamer",
			"Machan",
			"Machar",
			"Machart",
			"Machell",
			"Machemer",
			"Machen",
			"Macher",
			"Machia",
			"Machida",
			"Machiel",
			"Machin",
			"Machlin",
			"Machnicki",
			"Machnik",
			"Machon",
			"Machovec",
			"Machowski",
			"Machuca",
			"Machuga",
			"Maciag",
			"Macias",
			"Maciej",
			"Maciejewski",
			"Maciel",
			"Macina",
			"Macioce",
			"Maciol",
			"Maciolek",
			"Maciulis",
			"Mack",
			"Mackall",
			"Mackel",
			"Mackell",
			"Macken",
			"Mackenthun",
			"Macker",
			"Mackert",
			"Mackes",
			"Mackey",
			"Mackie",
			"Mackiewicz",
			"Mackin",
			"Mackintosh",
			"Mackle",
			"Macklem",
			"Mackler",
			"Mackley",
			"Macklin",
			"Mackowiak",
			"Mackowski",
			"Mackrell",
			"Maclin",
			"Macomb",
			"Macomber",
			"Macquarie",
			"Macrina",
			"Macris",
			"Macumber",
			"Maczko",
			"Maczynski"
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

		_ParticleNames = new Dictionary<string, string>()
		{
			{ "derosa", "DeRosa" },
			{ "dewitt", "DeWitt" },
			{ "larosa", "LaRosa" },
			{ "larue", "LaRue" }
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

	internal static Dictionary<string, string> GetParticleNames()
	{
		return _ParticleNames;
	}

	internal static List<string> GetTwoLetterNames()
	{
		return _TwoLetterNames;
	}
}

