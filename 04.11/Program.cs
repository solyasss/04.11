using System;

namespace hw
{
    class Program
    {
        static void Main(string[] args)
        {
            logic game = new logic();
            game.car_start += car => car.start();
            
            game.add_car(new sportcar("Fast"));
            game.add_car(new passenger_car("Family"));
            game.add_car(new truck("Heavy"));
            game.add_car(new bus("City"));
            game.start_race();

            Console.ReadLine();
        }
    }
}