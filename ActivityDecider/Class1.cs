using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivityDecider
{
    internal class Class1
    {
    }

    public static class SharedData
    {
        public static List<string> friends = new List<string>(); //create a List for friends
        public static int poolVote = 0; //public variables for the amount of votes for the options
        public static int cinemaVote = 0;
        public static int gameNightVote = 0;

    }
}
