using System;

namespace Airport_Challenge_CSharp
{
   

    public class Plane
    {
        int id;
        string airportName;

        public Plane(int _id, string _airportName = null)
        {
            id = _id;
            airportName = _airportName;
        }

        public int getId()
        {
            return id;
        }

        public void setAirportName(string _airportName)
        {
            airportName = _airportName;
        }

        public string getAirportName(){
            return airportName;
        }
    }


    public class Weather
    {
        bool[] stormy;

        public Weather(){
            stormy = new bool[] { false, false, false, false, true };
        }

        public bool isItStormy(){
            Random rnd = new Random();
            return stormy[rnd.Next(0, 5)];
        }
    }


    public class Airport
    {
        public string name;
        public int capacity;

        public Plane[] hanger;
        public Airport(string _name, int _capacity = 30)
        {
            capacity = _capacity;
            hanger = new Plane[capacity];
            name = _name;
        }

        public bool isFull()
        {
            return hanger.Length >= capacity;
        }

        public void land(Plane plane, bool stormy){
            if (plane.getAirportName() != null)
                throw new System.InvalidOperationException("Plane already landed at an airport.");
            
            if (isFull())
                throw new System.InvalidOperationException("Error! Airport Full.");

            if (stormy)
                throw new System.InvalidOperationException("BAD WEATHER CONDITION! Cannot allow to land.");

            //plane.setAirportName(name);
            ////hanger.
            
        }

    }



    class MainClass
    {
        public static void Main()
        {
        }
    }
}
