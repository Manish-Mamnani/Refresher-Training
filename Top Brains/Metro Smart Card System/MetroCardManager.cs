using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metro_Smart_Card_System
{
    public class MetroCardManager : MetroOperations
    {
        public double BaseFare { get; set; }
        public double PerKmRate { get; set; }
        public double MaxDailyCap { get; set; }
        public List<Station> Stations { get; set; }

        MetroCardManager(List<Station> stations, double baseFare, double perKmRate, double maxDailyCap)
        {
            this.Stations = stations;
            this.BaseFare = baseFare;
            this.PerKmRate = perKmRate;
            this.MaxDailyCap = maxDailyCap;
        }

        public List<double> fareHistory(int cardNumber)
        {
            throw new NotImplementedException();
        }

        public Commuter getCommuterInfo(int cardNumber)
        {
            throw new NotImplementedException();
        }

        public double getDailyPassSavings(int cardNumber, long date)
        {
            throw new NotImplementedException();
        }

        public List<string> getFrequentRoute(int cardNumber)
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, double> getZoneWiseRevenue(long startTime, long endTime)
        {
            throw new NotImplementedException();
        }

        public void issueCard(int cardNumber, string commuterName, string commuterType)
        {
            throw new NotImplementedException();
        }

        public bool tapIn(int cardNumber, int stationId, long epochTime)
        {
            throw new NotImplementedException();
        }

        public bool tapOut(int cardNumber, int stationId, long epochTime)
        {
            throw new NotImplementedException();
        }
    }
}
