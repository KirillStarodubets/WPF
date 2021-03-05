﻿using System;

namespace ConsoleApp1
{
    class Trajectory
    {
        public struct Coords
        {
            public double x, y;
        }

        public double velocity, angle, degrees;

        public void calc_angle(double degrees)
        {
            angle = (Math.PI * degrees / 180);
        }

        public Coords Track(double time)
        {
            Coords coords;
            coords.x = velocity * time * Math.Cos(angle);
            coords.y = velocity * time * Math.Sin(angle) - 4.9 * time * time;
            if (coords.y < 0) coords.y = 0;
            return (coords);
        }

        public void Graph(double time)
        {
            Coords coords;
            coords.x = velocity * time * Math.Cos(angle); 
            coords.y = velocity * time * Math.Sin(angle) - 4.9 * time * time;
            if (coords.y < 0) coords.y = 0;

            Console.WriteLine($"({coords.x}, {coords.y})");
            return;
        }

        public Trajectory(double degrees, double velocity)
        {
            this.degrees = degrees;
            this.velocity = velocity;
            calc_angle(degrees);
        }

        public static void Main(string[] args)
        {
            Trajectory graph = new Trajectory(50, 5);
            graph.Graph(5);
        }
    }
}
