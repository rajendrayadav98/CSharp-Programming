// Create a class Car with the following properties
// Instance variables:
// carname,companyname(string public)
// milage (double public)
// generate getters and setters
// Create a delegate with name CarInformationDisplay return type void with 1 parameter parameter is datatype:Car (class name) variable c(consider like object)
// Create another class Test 
// Methods:
// method name:DisplayCarName
// return type:void
// access modifier:public
// parameters:(Car c)
// method name:DisplayCompanyName
// return type:void
// access modifier:public
// parameters:(Car c)


// method name:DisplayMileage
// return type:void
// access modifier:public
// parameters:(Car c)


// create object for class Car and pass the values using get and set
// create object for delegate pass the methods for delegates.

using System;



    public class Car
    {
         string carname, companyname;
         double milage;
        public string _carname
        {
            get
            {
                return carname;
            }
            set

            {
                carname = value;
            }
        }
        public string _companyname
        {
            get
            {
                return companyname;
            }
            set
            {
                companyname = value;
            }
        }
        public double _milage
        {
            get
            {
                return milage;
            }
            set
            {
                milage = value;
            }
        }
    }
    public delegate void CarInformationDisplay(Car c); 
    public class Test1:Car
    {
        public void DisplayCarName(Car c)
        {
            Console.WriteLine("Car Name: "+c._carname);
        }
        public void DisplayCompanyName(Car c)
        {
            Console.WriteLine("Company Name: "+c._companyname);
        }
        public void DisplayMilage(Car c)
        {
            Console.WriteLine("Milage: "+c._milage);
        }

        static void Main(string[] args)
        {
           Test1 c = new Test1();
           
            c._carname = "CRETA";
            c._companyname = "Hundai";
            c._milage = 16.25;
            CarInformationDisplay a = c.DisplayCarName;
            a(c);
            CarInformationDisplay b = c.DisplayCompanyName;
            b(c);
            CarInformationDisplay c2 = c.DisplayMilage;
            c2(c);
            Console.ReadLine();
        }
    }
}