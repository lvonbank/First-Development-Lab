using System;

namespace GFUDemo_CS
{
    public class Class1
    {
    }

    public class Automobile
    {
        public Automobile()
        {
            this.Model = "Not specified";
            this.TopSpeed = -1;
            this.IsRunning = true;
        }

        public Automobile(string model, int topSpeed)
        {
            Model = model;
            TopSpeed = topSpeed;
        }

        public bool IsRunning { get; set; }
        public string Model { get; set; }
        public int TopSpeed { get; set; }

        public void Start()
        {
            if (this.Model != "Not specified" || this.TopSpeed != -1)
                this.IsRunning = true;
            else
                this.IsRunning = false;
        }
    }
}
