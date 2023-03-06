using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valami_Game
{
    
		public interface Terulet
		{
		void Leiras();
		}
	class ElsoTerem : Terulet
	{
		public void Leiras()
		{
			Console.WriteLine("Az eddigi legősibb terem, ahová csak Neumann János lépett be.");
		}

		public class MasodikTerem : Terulet
		{
			public void Leiras()
			{
				Console.WriteLine("A masodik Terem, ahol Babucs tanarno szokta tartani az óráit.");
			}

		}

		class HarmadikTerem : Terulet
		{
			public void Leiras()
			{
				Console.WriteLine("A harmadik terem, ahol Murányi Mariann tartsa az adott óráját és te bejelentkeztél.");
			}

		}

		class NegyedikTerem : Terulet
		{
			public void Leiras()
			{
				Console.WriteLine("Negyedik terem, ahova bejártál. (NO COMMENT)");
			}

		}

		class Bufe : Terulet
		{
			public void Leiras()
			{
				Console.WriteLine("Üdvözöllek a Büfében. Az ételek megdrágultak, a szankciók sokasága bővül" +
				", az infláció emelkedik, de a hasad nem vár.");
			}

		}

		class Igazgato : Terulet
		{
			public void Leiras()
			{
				Console.WriteLine("Megtisztelő, hogy bekerültél az Igazgatóságra." +
				"Az igazgató már várta önt.");
			}

		}
	}
}
