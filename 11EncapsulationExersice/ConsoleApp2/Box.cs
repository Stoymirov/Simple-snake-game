using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ClassBoxData
{
    public class Box
    {

        private double height;
        private double length;
        private double width;

        public Box(double height, double length, double width)
        {
            Length = length;
            Width = width;
            Height = height;
        }
        public double Length
        {
            get => length;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(Length)} cannot be zero or negative.");
                }
                length = value;
            }
        }
    public double Width
    {
        get => width;
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException($"{nameof(Width)} cannot be zero or negative.");
            }
            width = value;
        }
    }

    public double Height
    {
        get => height;
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException($"{nameof(Height)} cannot be zero or negative.");
            }
            height = value;
        }
    }

    public double SurfaceArea()
    {
        return 2 * Length * Height + 2 * Width * Height + 2 * Width * Length;
    }

    public double LateralSurfaceArea()
    {
        return 2 * Length * Height + 2 * Width * Height;
    }

    public double Volume() => Length * Width * Height;
}
}

    