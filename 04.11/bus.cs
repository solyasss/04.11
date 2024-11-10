using System;

namespace hw
{
    public class bus : car
    {
        public bus(string name) : base(name, 5, 13)
        {
        }

        public override void start()
        {
            Console.WriteLine($"{name} Bus is starting.");
        }

        public override void display_winner()
        {
            Console.WriteLine(@"
   ___________________
  | []  []  []  []  []|
  |___________________|
   O               O
");
            Console.WriteLine($"{name} Bus is winner");
        }
    }
}