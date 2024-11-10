using System;

namespace hw
{
    public class sportcar : car
    {
        public sportcar(string name) : base(name, 8, 16)
        {
        }

        public override void start()
        {
            Console.WriteLine($"{name} Sportcar is starting.");
        }

        public override void display_winner()
        {
            Console.WriteLine(@"
       ______
   /|_||_\`.__
  (   _    _ _\
 =`-(_)--(_)-' 

");
            Console.WriteLine($"{name} Sportcar is winner");
        }
    }
}