using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metro_Smart_Card_System
{
    public interface MetroOperations
    {

        void issueCard(int cardNumber, String commuterName, String commuterType);

        bool tapIn(int cardNumber, int stationId, long epochTime);

        bool tapOut(int cardNumber, int stationId, long epochTime);

        Commuter getCommuterInfo(int cardNumber);

        List<Double> fareHistory(int cardNumber);

        Dictionary<String, Double> getZoneWiseRevenue(long startTime, long endTime);

        List<String> getFrequentRoute(int cardNumber);

        double getDailyPassSavings(int cardNumber, long date);

    }
}
