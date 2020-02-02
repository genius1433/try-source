using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructing_a_car
{
    public interface ICar
    {
        bool EngineIsRunning { get; }
        void BrakeBy(int speed); // car #2

        void Accelerate(int speed); // car #2

        void EngineStart();

        void EngineStop();

        void FreeWheel(); // car #2

        void Refuel(double liters);

        void RunningIdle();
    }

    public interface IDrivingInformationDisplay // car #2
    {
        int ActualSpeed { get; }
    }

    public interface IDrivingProcessor // car #2
    {
        int ActualSpeed { get; }

        void IncreaseSpeedTo(int speed);

        void ReduceSpeed(int speed);
    }

    public interface IEngine
    {
        bool IsRunning { get; }

        void Consume(double liters);

        void Start();

        void Stop();
    }
    public interface IFuelTank
    {
        double FillLevel { get; }

        bool IsOnReserve { get; }

        bool IsComplete { get; }

        void Consume(double liters);

        void Refuel(double liters);
    }
    public interface IFuelTankDisplay
    {
        double FillLevel { get; }

        bool IsOnReserve { get; }

        bool IsComplete { get; }
    }
    public class Car : ICar
    {
        public IDrivingInformationDisplay drivingInformationDisplay; // car #2

        public IFuelTankDisplay fuelTankDisplay;

        private IDrivingProcessor drivingProcessor; // car #2

        private IEngine engine;

        private IFuelTank fuelTank;
        static int caller;
        public Car()
        {

        }
        public Car(double fuelLevel)
        {
            FuelTank.fillLevel = fuelLevel;
        }
        public bool EngineIsRunning { get; }

        public void EngineStart() 
        {
            caller++;
            ((Engine)engine).Start();
        }

        public void EngineStop()
        {
            caller++;
            ((Engine)engine).Stop();
        }

        public void Refuel(double liters)
        {
            caller++;
            ((FuelTank)fuelTank).Refuel(liters);
        }


        public void RunningIdle()
        {
            //caller++; поидее не нужен в этом методе
            FuelTank.fillLevel -= 0.0003 * caller;
        }

        public Car(double fuelLevel, int maxAcceleration) // car #2
        {

        }
        public void BrakeBy(int speed) // car #2
        {
            caller++;
            if (speed != 10)
            {
                DrivingProcessor.globalspeed -= 10;
            }
            else DrivingProcessor.globalspeed -= speed;
        }
        public void Accelerate(int speed) // car #2
        {
            caller++;
            if (DrivingProcessor.globalspeed >= 1 && DrivingProcessor.globalspeed <= 60)
            {
                FuelTank.fillLevel -= 0.0020;
            }
            else if (DrivingProcessor.globalspeed >= 61 && DrivingProcessor.globalspeed <= 100)
            {
                FuelTank.fillLevel -= 0.0014;
            }
            else if (DrivingProcessor.globalspeed >= 101 && DrivingProcessor.globalspeed <= 140)
            {
                FuelTank.fillLevel -= 0.0020;
            }
            else if (DrivingProcessor.globalspeed >= 141 && DrivingProcessor.globalspeed <= 200)
            {
                FuelTank.fillLevel -= 0.0025;
            }
            else if (DrivingProcessor.globalspeed >= 201 && DrivingProcessor.globalspeed <= 250)
            {
                FuelTank.fillLevel -= 0.0030;
            }
            if (speed != 10)
            {
                DrivingProcessor.globalspeed += 10;
            }
            else DrivingProcessor.globalspeed += speed;
        }
        public void FreeWheel() // car #2
        {
            caller++;           
            if (DrivingProcessor.globalspeed - 1 >= 0)
            {
                DrivingProcessor.globalspeed--;
            }
            else DrivingProcessor.globalspeed = 0;
        }
    }
    public class DrivingInformationDisplay : IDrivingInformationDisplay // car #2
    {
        public int ActualSpeed { get; }
    }

    public class DrivingProcessor : IDrivingProcessor // car #2
    {
        public static int globalspeed;
        public int ActualSpeed { get; }

        public void IncreaseSpeedTo(int speed)
        {
            if (globalspeed + speed <= 250)
            {
                globalspeed += speed;
            }
            else globalspeed = 250;
        }

        public void ReduceSpeed(int speed)
        {
            if (globalspeed - speed >= 0)
            {
                globalspeed -= speed;
            }
            else globalspeed = 0;
        }
    }

    public class Engine : IEngine
    {
        public bool IsRunning
        {
            get;
            set;
        }
        public void Consume(double liters)
        {
            FuelTank.fillLevel = FuelTank.fillLevel - liters;
            
        }
        public void Start()
        {
            IsRunning = true;
        }
        public void Stop()
        {
            IsRunning = false;
        }
    }

    public class FuelTank : IFuelTank
    {
        public static double fillLevel = 20;
        public double FillLevel { get; }
        public bool IsOnReserve { get; set; }
        public bool IsComplete { get; }
        public void Consume(double liters)
        {
            if (fillLevel <= 5)
            {
                IsOnReserve = true;
            }
            FuelTank.fillLevel = FuelTank.fillLevel - liters;
        }
        public void Refuel(double liters)
        {
            if (fillLevel + liters <= 60)
            {
                fillLevel += liters;
            }
            else fillLevel = 60;
        }
    }

    public class FuelTankDisplay : IFuelTankDisplay
    {
        public double FillLevel 
        {
            get
            {
                return Math.Round(FillLevel, 2);
            }
        }    
        public bool IsOnReserve { get; }
        public bool IsComplete { get; }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
