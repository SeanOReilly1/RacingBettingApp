using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceBettingApp
{
    public class Races
    {
        public string RaceName { get; set; }

        public DateTime Date { get; set; }

        public decimal Length { get; set; }

        public bool Result { get; set; }

        public Races()
        {

        }

        public Races(string race, DateTime date, decimal length, bool result)
        {
            if (date > DateTime.Now)
            {
                throw new ArgumentOutOfRangeException();

            }

            else
            {

                RaceName = race;
                Date = date;
                Length = length;
                Result = result;
            }

        }

    }
}

