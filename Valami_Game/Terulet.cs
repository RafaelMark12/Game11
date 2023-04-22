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
		void Esemeny();
	}
	public class TeremOs : Terulet
	{
		public string Leiras()
		{
			return "Megérkeztél az eddigi legősibb terembe, ahová csak Neumann János lépett be.";
		}
		public void Esemeny()
        {
			
        }
	}

	public class GT4 : Terulet
	{
		public string Leiras()
		{
			return "Megérkeztél a 4-es Gépterembe...";
		}
		public void Esemeny()
        {

        }

	}

	public class Terem205 : Terulet
	{
		public string Leiras()
		{
			return "Megérkeztél a 205-ös terembe. \nEz a terem régen a 11.A osztály" +
				"teremje volt, de mostmár a 11.C osztály terme lett 1 éve.";
		}
		public void Esemeny()
		{

		}
	}

	public class Terem46 : Terulet
	{
		public string Leiras()
		{
			return "46-s terem, ahova bejártál. (NO COMMENT)";
		}
		public void Esemeny()
		{

		}
	}

	public class Terem33 : Terulet
	{
		public string Leiras()
		{
			return "Megérkeztél a 33-as terembe, késésben voltál, úgyhogy próbálj meg csendben helyet foglalni.";
		}
		public void Esemeny()
		{

		}
	}

	public class Terem133 : Terulet
	{
		public string Leiras()
		{
			return "Megérkeztél a 133-as terembe, egy kis nosztalgia.";
		}
		public void Esemeny()
		{

		}
	}


	public class Bufe : Terulet
	{
		public string Leiras()
		{
			return "Üdvözöllek a Büfében. Az ételek megdrágultak.\nA szankciók sokasága bővül" +
			" az infláció emelkedik.\nAzonban a hasad nem vár." +
			"\n\nSzeretnél venni valamit esetleg?";
		}
		public void Esemeny()
		{

		}
	}

	public class IgazgatoTerem : Terulet
	{
		public string Leiras()
		{
			return "Megtisztelő, hogy bekerültél az Igazgatóságra." +
			"Az igazgató már várta önt.";
		}
		public void Esemeny()
		{

		}
	}

		public class Aula : Terulet
	{
		public string Leiras()
		{
			return "Megérkeztél az Aulába, 20 perces szünet van, zsong az aula.";
		}
		public void Esemeny()
		{

		}
	}

		public class Lepcso : Terulet
	{
		public string Leiras()
		{
			return "Megérkeztél a lépcsőhöz, menj fel az első emeletre.";
		}
		public void Esemeny()
		{

		}
	}

		public class Oltozo : Terulet
	{
		public string Leiras()
		{
			return "Beléptél az öltözőbe, vedd ki a szekrényből a cuccod és nyomás testnevelés órára.";
		}
		public void Esemeny()
		{

		}
	}
	
		public class Tornaterem : Terulet
	{
		public string Leiras()
		{
			return "Megérkeztél a tornaterembe, 3 kör futás.";
		}
		public void Esemeny()
		{

		}
	}

		public class Kijárat : Terulet
	{
		public string Leiras()
		{
			return "Vége a napnak, irány haza.";
		}
		public void Esemeny()
		{

		}
	}
}
