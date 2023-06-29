using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            Car car1 = new Car();
            car1.Year = 2012;
            car1.Make = "Toyota";
            car1.Model = "Corola S";
            car1.EngineNoise = "Purrr";
            car1.HonkNoise = "Beep!";
            car1.IsDriveable = true;
            Console.WriteLine();
            car1.MakeEngineNoise(car1.EngineNoise);
            car1.MakeHonkNoise(car1.HonkNoise);

            Car car2 = new Car() 
            { 
                Year =2008, 
                Make = "Ford", 
                Model = "4x4", 
                EngineNoise = "Vrooom!", 
                HonkNoise = "HONK!", 
                IsDriveable = true
            };
            Console.WriteLine();
            car2.MakeEngineNoise(car2.EngineNoise);
            car2.MakeHonkNoise(car2.HonkNoise);

            Car car3 = new Car(1967,"Chevy", "Impala", "Kachiga", "honk...", false);
            Console.WriteLine();
            car3.MakeEngineNoise(car3.EngineNoise);
            car3.MakeHonkNoise(car3.HonkNoise);

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
