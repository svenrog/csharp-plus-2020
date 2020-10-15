using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using KlassStruktur.Helpers;


namespace KlassStruktur
{
    class Computer
    {
        private string _serialNumber;
        private int _height;
        private int _width;
        private int _length;
        private ColorEnum _color;

        public System.String Ram { get; set; }
        public int ScreenSze { get; set; }

        public ColorEnum Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public Computer(string serialNumber, string ram, int screenSize, int height, int width, int length)
        {
            _serialNumber = serialNumber;
            Ram = ram;
            ScreenSze = screenSize;
            _height = height;
            _width = width;
            _length = length;
        }

        public int GetVolume()
        {
            int computerArea = GetArea();

            return _height * computerArea;
        }

        private int GetArea()
        {
            return _length * _width;
        }

    }
}
