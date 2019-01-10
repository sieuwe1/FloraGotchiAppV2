using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FloraGotchiAppV2
{
    public class GameScore
    {



        public void UpdateScore(int settemperature)
        {

            PlantContext p = new PlantContext("server=studmysql01.fhict.local;user id=dbi414674;password=Dse56VGQx3;database=dbi414674;");

            var ideal = p.GetIdealValues(1);

            var diffrance = Math.Abs(Convert.ToInt32(ideal[1]) - settemperature);

            var newScore = p.GetGameScore() - (100 * diffrance);

            p.UpdateGameScore(newScore);



        }






    }
}
