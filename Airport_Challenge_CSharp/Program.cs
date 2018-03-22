using System;
using System.Collections.Generic;

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
        string name;
        int capacity;
        List<Plane> hanger = new List<Plane>();


        public Airport(string _name, int _capacity = 30)
        {
            capacity = _capacity;
            name = _name;
        }

        public string getName(){
            return name;
        }

        public int getCapacity(){
            return capacity;
        }

        public void updateCapacity(int newCapacity){
            capacity = newCapacity;
        }

        public List<Plane> getHanger(){
            return hanger;    
        }


        public bool isFull()
        {
            return (hanger.Count >= capacity);
        }

        public void land(Plane plane, bool stormy){
            if (plane.getAirportName() != null)
                throw new System.InvalidOperationException("Plane already landed at an airport.");
            
            if (isFull())
                throw new System.InvalidOperationException("Error! Airport Full.");

            if (stormy)
                throw new System.InvalidOperationException("BAD WEATHER CONDITION! Cannot allow to land.");

            plane.setAirportName(name);
            hanger.Add(plane);

        }

        public void takeOff(Plane plane, bool stormy){
            if (plane.getAirportName() != name)
                throw new System.InvalidOperationException("Plane not at this airport.");

            if (stormy)
                throw new System.InvalidOperationException("BAD WEATHER CONDITION! Cannot allow to land.");

            plane.setAirportName(null);
            hanger.Remove(plane);
   
        }

    }



    class MainClass
    {
        public static void Main()
        {
            //test system setup
            //change weather.isItStormy() to false to avoid random error
    
            Airport  airport = new Airport("Heathrow", 3);
            Plane plane1 = new Plane(1);
            Weather weather = new Weather();
            airport.land(plane1, weather.isItStormy());

            Console.WriteLine("Capacity = "+airport.getCapacity());
            Console.WriteLine("Hanger length: "+ airport.getHanger().Count);

            airport.updateCapacity(20);
            Console.WriteLine("Capacity = " + airport.getCapacity());
            Console.WriteLine("Hanger length: " + airport.getHanger().Count);

            Console.WriteLine(airport.getHanger());
            airport.takeOff(plane1, weather.isItStormy());
            Console.WriteLine("plane took off hanger should be empty");

            Console.WriteLine("Capacity = " + airport.getCapacity());
            Console.WriteLine("Hanger length: " + airport.getHanger().Count);

            Console.WriteLine(airport.getHanger());


        }
    }
}
