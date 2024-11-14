using System;

namespace FirstGame
{
    public class Car
    {
        private float _fuel;  
        private float _speed; 

       
        public Car(float initialFuel)
        {
            if (initialFuel < 0)
                throw new ArgumentException("Fuel amount cannot be negative.", nameof(initialFuel));

            _fuel = initialFuel;
            _speed = 0;
        }

        
        public void StartCar()
        {
            if (_fuel <= 0)
            {
                Console.WriteLine("Not enough fuel to start the car.");
                return;
            }

            Console.WriteLine("Car started.");
        }

       
        public void Refuel(float amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Refuel amount must be positive.");
                return;
            }

            _fuel += amount;
            Console.WriteLine($"Car refueled by {amount} liters. Current fuel: {_fuel} liters.");
        }

       
        public void Accelerate(float amount)
        {
            if (_fuel <= 0)
            {
                Console.WriteLine("Cannot accelerate. The car is out of fuel.");
                return;
            }

            if (amount <= 0)
            {
                Console.WriteLine("Acceleration amount must be positive.");
                return;
            }

            _speed += amount; 
            _fuel -= amount * 0.1f; 
            if (_fuel < 0) _fuel = 0; 

            Console.WriteLine($"Car accelerated by {amount} units. Current speed: {_speed} km/h. Fuel: {_fuel} liters.");
        }

       
        public void Brake(float amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Braking amount must be positive.");
                return;
            }

            _speed -= amount; 
            if (_speed < 0) _speed = 0; 

            Console.WriteLine($"Car slowed down by {amount} units. Current speed: {_speed} km/h.");
        }
    }
}
