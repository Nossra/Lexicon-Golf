﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golf
{
    class Swing
    {
        int velocity;
        int angle;
        readonly double GRAVITY = 9.8;

        public Swing(int angle, int velocity)
        {
            this.velocity = velocity;
            this.angle = angle;
        }

        public int Velocity { get => velocity; set => velocity = value; }
        public int Angle { get => angle; set => angle = value; }

        public double angleInRadians(int angle)
        {
            double angleInRadians = (Math.PI / 180) * angle;
            return angleInRadians;
        }

        public double calculateDistance(int angle)
        {
            double distance = Math.Pow(velocity, 2) / GRAVITY * Math.Sin(2 * angleInRadians(angle));
            return distance;
        }

        public void printDistance()
        {
            Console.WriteLine("The ball traveled " + calculateDistance(angle) + " meters!");
        }
    }
}