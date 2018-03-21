using System;

namespace Airport_Challenge_CSharp
{
   

    public class Plane
    {
        int id;
        string airport_id;

        public Plane(int _id, string _airport_id = null)
        {
            id = _id;
            airport_id = _airport_id;
        }

        public int getId()
        {
            return id;
        }

        public string getAirportId(){
            return airport_id;
        }

    }

    public class Weather
    {
        Boolean[] stormy;

        public Weather(){
            stormy = new Boolean[] { false, false, false, false, true };
        }

        public Boolean isItStormy(){
            Random rnd = new Random();
            return stormy[rnd.Next(0, 5)];
        }
    }


    class MainClass
    {
        public static void Main()
        {
        }
    }
}
