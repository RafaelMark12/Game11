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
    interface INpc
    {
        void Info(string info, int eletero);
    }
    

    class Rasszista : INpc
    {
        public void Info(string info, int eletero)
        {
            eletero = 75;
            info = "Rasszista";
        }
    }

    class Agressziv : Npc
    {
        public void Info(string info, int eletero)
        {
            eletero = 90;
            info = "Agresszív";
        }
    }

    class Kedves : Npc
    {
        public void Info(string info, int eletero)
        {
            eletero = 120;
            info = "Kedves";
        }
        
    }

    class Igazgato : Npc
    {
        public void Info(string info, int eletero)
        {
            eletero = 250;
            info = "Igazgato";
        }
        
    }

    class TanarEgy : Npc
    {
        public void Info(string info, int eletero)
        {
            eletero = 150;
            info = "TanarEgy";
        }
        
    }

    class TanarKetto : Npc
    {
        public void Info(string info, int eletero)
        {
            eletero = 145;
            info = "Tanarketto";
        }
        
    }

    class RendszerGazda : Npc
    {
        public void Info(string info, int eletero)
        {
            eletero = 150;
            info = "Rendszer Gazda";
        }
        
    }

    class Bufes : Npc
    {
        public void Info(string info, int eletero)
        {
            
            info = "Bufes";
        }
        
    }

    class Futar : Npc
    {
        public void Info(string info, int eletero)
        {
            
            info = "Futar";
        }
    }
}
