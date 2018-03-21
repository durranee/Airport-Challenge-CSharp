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

    class MainClass
    {
        public static void Main()
        {
                

        }
    }
}
