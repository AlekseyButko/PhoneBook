using System.ComponentModel.DataAnnotations;

namespace NFS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cars[] carArr = new Cars[4];
            Race race = new Race(carArr);
            Console.WriteLine("===== Chosse car for this race : ====");

            carArr[0] = new Cars("Alex",true,true);
            carArr[1] = new Cars("Kevin",true, false);
            carArr[2] = new Cars("Dmitro",false, true);
            carArr[3] = new Cars("Arthur",false, false);

            for(int i = 0; i < 4; i++)
            {
                carArr[i].ShowCar();
            }
            Console.WriteLine("Please, press w if you want to start race");

            char start = char.Parse(Console.ReadLine());

            if (start == 'w')
            {
                race.StartRace();
                race.RaceResult();
            }
        }
    }
}