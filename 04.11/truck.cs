using System;

namespace hw
{
    public class truck : car
    {
        public truck(string name) : base(name, 6, 14)
        {
        }

        public override void start()
        {
            Console.WriteLine($"{name} Truck is starting.");
        }

        public override void display_winner()
        {
            Console.WriteLine(@"
      _____________
     /             \
   _/      ___      \_
  |    __ |[]| __     |
  |___|__|____|__|____|
   O               O
");
            Console.WriteLine($"{name} Truck is winner");
        }
    }
}