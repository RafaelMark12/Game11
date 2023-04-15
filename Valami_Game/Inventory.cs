using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valami_Game
{
    class Inventory
    {
		private int penz;
		private string kes;
		private int cigi;
		private string bor;
		private string szendvics;
		private string matekkonyv;
		private string toll;
		private string telefon;
		private string ora;


		public int Penz
		{
			get { return penz; }
			set { penz = value; }
		}

		public string Kes
		{
			get { return kes; }
			set { kes = value; }
		}
		public int Cigi
		{
			get { return cigi; }
			set { cigi = value; }
		}

		public string Bor
		{
			get { return bor; }
			set { bor = value; }
		}

		public string Szendvics
		{
			get { return szendvics; }
			set { szendvics = value; }
		}
		public string Matekkonyv
		{
			get { return matekkonyv; }
			set { matekkonyv = value; }
		}

		public string Toll
		{
			get { return toll; }
			set { toll = value; }
		}

		public string Telefon
		{
			get { return telefon; }
			set { telefon = value; }
		}

		public string Ora
		{
			get { return ora; }
			set { ora = value; }
		}
		public Inventory()
		{
			
			penz = 2500;
			kes = "";
			cigi = -5;
			bor = "van bor";
			szendvics = "van ez";
			matekkonyv = "van konyv";
			toll = "van toll";
			telefon = "van telefon";
			ora = "van ora";
			
		}

	}
}
