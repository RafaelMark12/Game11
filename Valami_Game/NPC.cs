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

    class Igazgato : Npc
    {
        public Igazgato()
        {
            this.Eletero = 250;
            this.Info = "Igazgato";
        }

    }

    class TanarEgy : Npc
    {
        public TanarEgy()
        {
            this.Eletero = 150;
            this.Info = "TanarEgy";
        }

    }

    class TanarKetto : Npc
    {
        public TanarKetto()
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
            this.Info = "Bufes";
        }

    }

    class Futar : Npc
    {
        public Futar()
        {
            this.Info = "Futar";
        }
    }
}
