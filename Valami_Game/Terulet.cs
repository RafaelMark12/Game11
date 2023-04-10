using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valami_Game
{

	public interface Terulet
	{
		string Leiras();
	}
	public class ElsoTerem : Terulet
	{
		public string Leiras()
		{
			return "Az eddigi legősibb terem, ahová csak Neumann János lépett be.";
		}

		public class MasodikTerem : Terulet
		{
			public string Leiras()
			{
				return "A masodik Terem, ahol Babucs tanarno szokta tartani az óráit.";
			}

		}

		public class HarmadikTerem : Terulet
		{
			public string Leiras()
			{
				return "A harmadik terem, ahol Murányi Mariann tartsa az adott óráját és te bejelentkeztél.";
			}

		}

		public class NegyedikTerem : Terulet
		{
			public string Leiras()
			{
				return "Negyedik terem, ahova bejártál. (NO COMMENT)";
			}

		}

		public class Bufe : Terulet
		{
			public string Leiras()
			{
				return "Üdvözöllek a Büfében. Az ételek megdrágultak, a szankciók sokasága bővül" +
				", az infláció emelkedik, de a hasad nem vár.";
			}

		}

		public class Igazgato : Terulet
		{
			public string Leiras()
			{
				return "Megtisztelő, hogy bekerültél az Igazgatóságra." +
				"Az igazgató már várta önt.";
			}

		}
	}
}
