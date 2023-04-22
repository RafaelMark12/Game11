using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valami_Game
{
    class Egyeb
    {
        DateTime startTime;
        public DateTime StartTime { get { return startTime; } set { startTime = value; } }
        public Egyeb()
        {
            startTime = DateTime.Now;
        }

        public string Idő()
        {
            
            
            TimeSpan elapsedTime = DateTime.Now - startTime;

            string elapsedTimeString = string.Format("{0:00}:{1:00}:{2:00}",
           (int)elapsedTime.TotalHours, elapsedTime.Minutes, elapsedTime.Seconds);

            return $"Játékidő: {elapsedTimeString}";

        }
        





    }
}
