using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreAboutClassesAndMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car(); //creating one handle  in a class bucket

            Car.MyMethod(); // will print out called the static method , notice you don't have to include instance
           /* myCar.Make = "Oldmobile";   //mycar and myOtherCar is method , as long as this method is inside the scope of 
            myCar.Model = "Cutlas Supreme"; //Program , it can be referenced
            myCar.Year = 1986;
            myCar.Color = "Silver";
            */
            Car myOtherCar;

            myOtherCar = myCar; //creating another handle in the same class that will reference to the same bucket 
            //.NET Libaray has all the static,  classes and method to reuse in genereal 
            // some are static and some are instance 


            /*
            Console.WriteLine("{0} {1} {2} {3}",
                myOtherCar.Make,
                myOtherCar.Model,
                myOtherCar.Year,
                myOtherCar.Color);

            myOtherCar.Model = "98"; //myOtherCar.Model and myCar.Model will print out the same 
                                     //due to myOtherCar = myCar
                                     //if you set myOtherCar = Null , you will get exceptions (error) because if goes out of scope
            Console.WriteLine("{0} {1} {2} {3} ",
                myCar.Make,
                myCar.Model,
                myCar.Year,
                myCar.Color); //so we have the two references to the same memory : mycar and myOtherCar
                              //if the reference is set to null intentially ,it will remove those obj from memory 
                              //to get obj removed, one , the references goes out of scope ( main method) 
                              // two, if you create a different method and define a variable (null), that will be outside of the scope

            myOtherCar = null; // you will get excepptions because the objects that you referenced will be removed 
            Console.WriteLine("{0} {1} {2} {3}",
             myOtherCar.Make,
             myOtherCar.Model,
             myOtherCar.Year,
             myOtherCar.Color);

             */
            Console.ReadLine();
        }
    }


    class Car
    {
       /*  public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public Car() //creating a constructor ( a method) 
        {     
            //you could load from a configuration file, 
            //a database, etc 
            Make = "Nissan"; //the make property default is Nissan , this will display 

        }
        public Car(string make, string model, int year, string color) //overloaded method 
        {
            Make = make; //Make is referece to Make = "Nissan" , make is input parameter 
            Model = model;
            Year = year;   //once you define these, and go to Main, and deinf a new class variable , you can easilly call this method 
            Color = color; 
            
        } */

        public static void MyMethod () // with static you don't have to set a new class or create property for method
        {
            Console.WriteLine("Called the static Method");
            //Console.WriteLine(Make); This will return error becuase you can't 
            //instance member as seris of specfic properties, methods consturtor 
            //static doesn't depend on instance of a class. they are not really tied on specific class ex cars, 
        }
    




    }



}
