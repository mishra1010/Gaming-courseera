using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamer
{
    
    class Program
    {
        //Main function started
        static void Main(string[] args)
        {
            //Welcome Message
            Console.WriteLine("Hello, Welcome!! This application will calculate the distance between 2 points and also the angle between these points.");
            //Taking Inputs for X and Y coordinates between the 2 points
            Console.WriteLine("Enter the value of X1:");
            float X1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of Y1:");
            float Y1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of X2:");
            float X2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of Y2:");
            float Y2 = float.Parse(Console.ReadLine());

            //Finding difference between the 2 points based on X and Y Coordinates
            float dx = X2 - X1;
            float dy = Y2 - Y1;
            Console.WriteLine("dx=" + dx +" "+ "and" + " "+"dy=" + dy);

            //Finding the distance between 2 points using pythagoras theorem and rount it to 3 decimal places
            double distance = Math.Sqrt((dx * dx) + (dy * dy));
            double rnddist = Math.Round(distance,3);
            Console.WriteLine("distance between the 2 points is c=sqrt(a^2+b^2)="+" "+ rnddist);
            
            //Finding the angle which is by default in Radian and gets converted to degrees by multiplying 180.0/Math.PI
            double angle = Math.Atan2(dy, dx)*180.0 / Math.PI;
            Console.WriteLine("Angle between the 2 points is Math.Atan2(dy, dx)*180.0 / Math.PI=" + " " + angle + " "+ "degrees");
            Console.ReadLine();
        }
    }
}
