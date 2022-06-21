using System;
using System.Reflection.Metadata.Ecma335;

namespace C02_properties
{
    public class Box
    {
        private int _length;
        private int _height;
        private int _width;

        // public int Length
        // {
        //     get => _length;
        //     set => _length = value;
        // }
        //
        // public int Height
        // {
        //     get => _height;
        //     set => _height = value;
        // }
        //
        // public int Width
        // {
        //     get => _width;
        //     set => _width = value;
        // }

        public int Length { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public int Volume => Height * Width * Length;

        public int FrontSurface => Height * Length;

        public Box(int length, int height, int width)
        {
            Length = length;
            Height = height;
            Width = width;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Length is {Length} and height is {Height} and width is {Width} so volume is {Volume}");
        }


    }
}