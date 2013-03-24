using System;

namespace Mobile_Device
{
    class DisplayClass
    {
        private double? size;
        private int? colors;

        public double? DisplaySize
        {
            get
            {return this.size;}
            set
            {
                if (value>0)
                {
                    this.size = value; 
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }

        public int? DisplayColors
        {
            get { return this.colors; }
            set
            {
                if (value>0)
                {
                    this.colors = value;
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }

        public DisplayClass()
        {
            this.size = null;
            this.colors = null;
        }
        public DisplayClass(double? size)
            : this()
        {
            this.size = size;
        }
        public DisplayClass(double? size, int? colors)
            : this(size)
        {
            this.colors = colors;
        }
    }
}
