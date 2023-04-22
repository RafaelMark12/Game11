using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valami_Game
{
    class Npc
    {
        private string info;
        private int eletero;

        public string Info
        {
            get { return info; }
            set { info = value; }
        }

        public int Eletero
        {
            get { return eletero; }
            set { eletero = value; }
        }
    }
    class Rasszista : Npc
    {
        public Rasszista()
        {
            this.Eletero = 75;
            this.Info = "Rasszista";
        }
    }

    class Agressziv : Npc
    {
        public Agressziv()
        {
            this.Eletero = 90;
            this.Info = "Agresszív";
        }
    }

    class Kedves : Npc
    {
        public Kedves()
        {
            this.Eletero = 120;
            this.Info = "Kedves";
        }
    }

    class Dealer : Npc
    {
        public Dealer()
        {
            this.Eletero = 140;
            this.Info = "Szeretnél valamit öcsi?";
        }
    }

    class Igazgato : Npc
    {
        public Igazgato()
        {
            this.Eletero = 250;
            this.Info = "Igazgato";
        }
    }

    class BabucsTanarno : Npc
    {
        public BabucsTanarno()
        {
            this.Eletero = 150;
            this.Info = "TanarEgy";
        }

    }

    class JozsiTanar: Npc
    {
        public JozsiTanar()
        {
            this.Eletero = 145;
            this.Info = "Tanarketto";
        }
    }

    class RendszerGazda : Npc
    {
        public RendszerGazda()
        {
            this.Eletero = 150;
            this.Info = "Rendszer Gazda";
        }

    }

    class Bufes : Npc
    {
        public Bufes()
        {
            this.Info = "A koromhoz képest kifejezetten jól kínálok a leendő diákoknak a kosztomat." +
                "\n\nEsetleg szeretnél kérni valamit? ";
        }
    }

    class Futar : Npc
    {
        public Futar()
        {
            this.Info = "Futar";
        }
    }

    class LegjobbBarat : Npc
    {
        public LegjobbBarat()
        {
            this.Info = "Legjobb barat";
        }
    }
}
