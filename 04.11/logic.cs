using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace hw
{
    public class logic
    {
        public List<car> cars { get; set; } = new List<car>();
        public bool race_finished { get; set; } = false;
        public car winner { get; set; }

        public delegate void car_do(car car);
        public event car_do car_start;

        public void add_car(car car)
        {
            cars.Add(car);
            car.finish_handler += car_finish;
        }

        public void start_race()
        {
            Console.WriteLine("The race started\n");

            foreach (var car in cars)
            {
                car_start?.Invoke(car);
            }

            while (!race_finished)
            {
                foreach (var car in cars)
                {
                    car.drive();
                    Console.WriteLine($"{car.name}is on sit {car.sit:F2}");
                }

                Console.WriteLine();
                Thread.Sleep(1000);
            }

            Console.WriteLine($"\nWinner: {winner.name}!\n");
            winner.display_winner();
        }

        private void car_finish(car car)
        {
            if (!race_finished)
            {
                race_finished = true;
                winner = car;
            }
        }
    }
}