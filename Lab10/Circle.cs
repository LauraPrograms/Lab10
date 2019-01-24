using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Circle
    {
        private double radius;
        public static int circleCount=0;
        public Circle (double radius)
        {
            this.radius = radius;  
            circleCount++;
        }

        public double CalculateCircumference()
        { 
            double circumference = Math.PI * 2 * radius;
            return circumference;
        }

        public string CalcualteFormattedCircumference()
        {
           double formatedCircumference= Math.Round(CalculateCircumference(),2);
            string circumferenceString = FormatDouble(formatedCircumference);
            return circumferenceString;
        }

        public double CalculatedArea()
        { 
            double area = Math.PI * radius * radius;
            return area;
        }

        public string CalculatedFormattedArea()
        {
            double formatedArea = Math.Round(CalculatedArea(), 2);
            string areaString = FormatDouble(formatedArea);
            return areaString;
        }

        public string FormatDouble(double x)
        {
            string FormatDouble = x.ToString();
            return FormatDouble;
        }

    }
}
