using System;

namespace hw
{
    public abstract class car
    {
        public string name { get; set; }
        public double sit { get; set; }
        public double speed { get; set; }
        public double min_speed { get; set; }
        public double max_speed { get; set; }

        public event Action<car> finish_handler;

        protected Random random = new Random();

        public car(string name, double min_speed, double max_speed)
        {
            this.name = name;
            this.sit = 0;
            this.min_speed = min_speed;
            this.max_speed = max_speed;
        }

        public virtual void start()
        {
        }

        public virtual void drive()
        {
            speed = random.NextDouble() * (max_speed - min_speed) + min_speed;
            sit += speed;

            if (sit >= 100)
            {
                sit = 100;
                finish_handler?.Invoke(this);
            }
        }

        public abstract void display_winner();
    }
}