using System;

namespace hw
{
    public class passenger_car : car
    {
        public passenger_car(string name) : base(name, 7, 15)
        {
        }

        public override void start()
        {
            Console.WriteLine($"{name} Passender car is starting.");
        }

        public override void display_winner()
        {
            Console.WriteLine(@"
     ______
   _/[] []\_
  (_________)
   ()     ()
");
            Console.WriteLine($"{name} Passender car is winner");
        }
    }
}