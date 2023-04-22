using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valami_Game
{
    class Inventory
    {
		private int eleted;
		private int okol;
		private int penz;
		private int kes;
		private int cigi;
		private int bor;
		private int szendvics;
		private int matekkonyv;
		private int toll;
		private int telefon;
		private int ora;

		public int Eleted
        {
			get { return eleted; }
            set { eleted = value; }
        }
		public int Okol
        {
            get { return eleted; }
            set { eleted = value; }
        }
		
		public int Penz
		{
			get { return penz; }
			set { penz = value; }
		}

		public int Kes
		{
			get { return kes; }
			set { kes = value; }
		}
		public int Cigi
		{
			get { return cigi; }
			set { cigi = value; }
		}

		public int Bor
		{
			get { return bor; }
			set { bor = value; }
		}

		public int Szendvics
		{
			get { return szendvics; }
			set { szendvics = value; }
		}
		public int Matekkonyv
		{
			get { return matekkonyv; }
			set { matekkonyv = value; }
		}

		public int Toll
		{
			get { return toll; }
			set { toll = value; }
		}

		public int Telefon
		{
			get { return telefon; }
			set { telefon = value; }
		}

		public int Ora
		{
			get { return ora; }
			set { ora = value; }
		}
		public Inventory()
		{
			Random rnd = new Random();
			eleted = 200;
			okol = rnd.Next(10, 150);
			penz = rnd.Next(1000,5000);
			kes = rnd.Next(100,175);
			cigi = rnd.Next(10,50);
			bor = rnd.Next(20,75);
			szendvics = rnd.Next(75,150);
			matekkonyv = rnd.Next(10,75);
			toll = rnd.Next(10,150);
			telefon = rnd.Next(500,2500);
			ora = rnd.Next(1500,3500);
		}

	}
}
