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
		private int laptop;
		private int ruzs;
		private int tornacsuka;
		private int amongus;
		private int fank;

		public int Eleted
        {
			get { return eleted; }
            set { eleted = value; }
        }
		public int Okol
        {
            get { return okol; }
            set { okol = value; }
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
		public int Laptop
		{
			get { return laptop; }
			set { laptop = value; }
		}
		public int Ruzs
		{
			get { return ruzs; }
			set { ruzs = value; }
		}
		public int Tornacsuka
		{
			get { return tornacsuka; }
			set { tornacsuka = value; }
		}
		public int Amongus
        {
            get { return amongus; }
            set { amongus = value; }
        }
		public int Fank
		{
			get { return fank; }
			set { fank = value; }
		}
		public Inventory()
		{
			Random rnd = new Random();
			eleted = 200;
			okol = rnd.Next(10, 150);
			penz = rnd.Next(500,1500);
			kes = rnd.Next(100,175);
			cigi = rnd.Next(10,50);
			bor = rnd.Next(100,250);
			szendvics = rnd.Next(100,125);
			matekkonyv = rnd.Next(1000,2000);
			toll = rnd.Next(10,150);
			telefon = rnd.Next(500,2500);
			ora = rnd.Next(1500,3500);
			laptop = rnd.Next(2000,4500);
			ruzs = rnd.Next(10,150);
			tornacsuka = rnd.Next(10,150);
			amongus = rnd.Next(1250,1350);
			fank = rnd.Next(100,200);
		}

	}
}
