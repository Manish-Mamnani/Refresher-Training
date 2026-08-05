using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metro_Smart_Card_System
{
    public class Journey
    {
        public int EntryStation;
        public long EntryTime;

        public Journey(int station, long time)
        {
            EntryStation = station;
            EntryTime = time;
        }
    }
}
