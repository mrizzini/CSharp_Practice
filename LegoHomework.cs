using System;

namespace LegoHW
{

    class Program // this is our program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car ("Red", "Toyota"); // this instantiates our class
            SaloonCar saloonCar1 = new SaloonCar(2);
            SaloonCar saloonCar2 = new SaloonCar(3, "Nissan");
            SaloonCar saloonCar3 = new SaloonCar(4, "ford", "purple");
            Console.WriteLine("car1 is a " + car1.color + " " + car1.manufacturer);
            Console.WriteLine("saloonCar1 is a " + saloonCar1.numberOfSeats + " seater");
            Console.WriteLine("saloonCar2 is a " + saloonCar2.numberOfSeats + " seater" + saloonCar2.manufacturer);
            Console.WriteLine("saloonCar3 is a " + saloonCar3.numberOfSeats + " seater" + saloonCar3.color + " " + saloonCar3.manufacturer);

        }
    }

    public class Car // this is our Car class. This is our blueprint
    {
        public Car (string _color, string _manufacturer) { // constructor
            this.color = _color;
            this.manufacturer = _manufacturer;
        }

        public string color { get; set; } // property
        public string manufacturer { get; set; } // property
    }

    public class SaloonCar : Car
    {
        public SaloonCar (int _numberOfSeats) {
            this.numberOfSeats = _numberOfSeats;
        }

        public SaloonCar (int _numberOfSeats, string manufacturer) {
            this.numberOfSeats = _numberOfSeats;
            this.manufacturer = _manufacturer;
        }

        public SaloonCar (int _numberOfSeats, string manufacturer, string color) {
            this.numberOfSeats = _numberOfSeats;
            this.manufacturer = _manufacturer;
            this.color = _color;
        }

        public int numberOfSeats { get; set; } // property
    }



}
//     Make a Car class with properties: color and manufacturer

// From that class, make car1 object (instantiate with color red and manufacturer Toyota)

// Make new SaloonCar class that inherits from Car class
// Add new property called: numberOfSeats

// Write 3 constructors to do the following:

// 1) Constructor 1 allows assignment of numberOfSeats only
// 2) Constructor 2 allows assignment of numberOfSeats and manufacturer only
// 3) Constructor 3 allows assignment of numberOfSeats, manufacturer and color

// Create 3 objects:

// 1) Create object saloonCar1 with 2 seats
// 2) Create object saloonCar2 with 3 seats and manufacturer Nissan
// 3) Create object saloonCar3 with 4 seats, manufacturer ford, and color purple

// *These above should only take 1 line in our program