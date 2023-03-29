using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

namespace Code_Coach_Challenge
{

    class Lassgna
    {
        private int expected = 40;

        public int ExpectedMinutesInOven()
        {
            return expected ;
        }

        public int RemainingMinutesInOven(int timeinoven)
        {
            return ExpectedMinutesInOven() - timeinoven;
        }

        public int PreparationTimeInMinutes(int layers)
        {
            return layers * 2;
        }

        public int ElapsedTimeInMinutes(int timeinoven, int layers)
        {
            return timeinoven + layers * 2;
        }
    }

}