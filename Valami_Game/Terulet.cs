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
			return "Negyedik terem, ahova bejártál. (NO COMMENT)";
		}
		public void Esemeny()
		{

		}
	}

	public class Bufe : Terulet
	{
		public string Leiras()
		{
			return "Üdvözöllek a Büfében. Az ételek megdrágultak, a szankciók sokasága bővül" +
			", az infláció emelkedik, de a hasad nem vár." +
			"\n\n Szeretnél venni valamit esetleg?";
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
	
}
