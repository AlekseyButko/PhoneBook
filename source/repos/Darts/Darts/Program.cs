using System.Xml.Schema;

namespace Darts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                Console.WriteLine("Press Space button to start play in darts");
                Console.ReadLine(); 
                
                int points = 100;
                int pointsToSubstract = 10;

                Random random= new Random();
                int x = random.Next(-200,200);
                int y = random.Next(-200,200);

                ThrowDarts (points, pointsToSubstract, x, y);
            }
        }
        static void ThrowDarts (int points, int pointsToSubstract, int x, int y) 
        {
            int newX = x;
            int newY = y;   

            if(x < 0) 
            {
                newX *= -1;
            }
            if(y < 0) 
            {
                newY *= -1;
            }
            if(newX <= 10 && newY <= 10 && newX >= -10 && newY >= 10) 
            {
                Console.WriteLine($"x = {x}, y ={y}");
                Console.WriteLine($"My congratulations, you get {points} points");
            }
            else if(((newX > 10 || newY > 10) && (newX < 100 && newY < 100)) || (newX < -10 || newY < - 100) || (newX < - 10 || newY < -10) && (newX > -100 && newY > -100)) 
            {
                if(newX>newY)
                {
                    string firstValue = newX.ToString();
                    string secondValue = firstValue.Substring(0, 1);

                    int value = Convert.ToInt32(secondValue);

                    points = points - pointsToSubstract * value;
                }
                else 
                {
                    string firstValue = newY.ToString();
                    string secondValue = firstValue.Substring(0, 1);

                    int value = Convert.ToInt32(secondValue);

                    points = points - pointsToSubstract * value;
                }
                Console.WriteLine($"x = {x} , y = {y}");
                Console.WriteLine($"Congraulation, you get {points} points");
            }
            else if ((newX > 100 || newY > 100 || (newX < - 100 || newY < -100))) 
            {
                Console.WriteLine($"x = {x} , y = {y}");
                Console.WriteLine("Sorry, but you miss....");
            }
                
        }
    }
}