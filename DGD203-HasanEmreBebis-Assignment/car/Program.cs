using System;

namespace FirstGame
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Car car = new Car(50);

            
            car.StartCar();  
            car.Accelerate(10);  
            car.Brake(5);        
            car.Refuel(20);      
            car.Accelerate(15);  

           
            Console.WriteLine("End of simulation.");
        }
    }
}
