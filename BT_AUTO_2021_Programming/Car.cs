﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programming
{
    class Car
    {
        bool carStatus;               
        double direction;
        float fuelLevel;
        byte gear;
        float speed;
        ConsoleColor color;
        const byte MAX_GEAR = 6;
        string carBrand;

        public string CarBrand { get => carBrand; set => carBrand = value; }

        public Car()
        {

        }

        public Car(bool carStatus, double direction, float fuelLevel, byte gear, float speed, ConsoleColor color)
        {
            this.carStatus = carStatus;
            this.direction = direction;
            this.fuelLevel = fuelLevel;
            this.gear = gear;
            this.speed = speed;
            this.color = color;
        }

        public void Accelerate()
        {
            speed += 5;
        }

        public void Accelerate(float speedDelta)
        {
            speed += speedDelta; 
        }

        public void Decelerate (float speedDelta)
        {
            if(speed - speedDelta < 0)
            {
                speed = 0;
            }
            else
            {
                speed -= speedDelta;
            }                  
        }
        public void Steer(double angle)
        {
            direction += angle;
        }

        public void GearUp()
        {
            if (gear == MAX_GEAR)
            {
                Console.WriteLine("Cannot increase gear, we are at maximum gear: {0}", MAX_GEAR);
            }
            else
            {
                gear++;
            }
        }

        public void GearDown()
        {
            if (gear == 0)
            {
                Console.WriteLine("Already in gear 0 cannot decrease down");
            }
            else
            {
                gear--;
            }
        }

        public void Start()
        {
            carStatus = true;
        }

        public void Stop()
        {
            carStatus = false;
            speed = 0;
            gear = 1;
        }

        public void turnLeft()
        {
            direction -= 90;
        }

        public void turnRight()
        {
            direction += 90;
        }

        public static double ConvertHpToKw(double hp)
        {
            return hp * 0.735499;
        }

        public void PrintCar()
        {
            Console.WriteLine("Current status of the car is: ");
            Console.WriteLine("Gear level {0} ",gear);
            Console.WriteLine("Direction angle {0} ", direction);
            //Console.WriteLine("Gear level {0} ", gear);

        }
    }
}
