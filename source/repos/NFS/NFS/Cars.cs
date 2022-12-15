using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFS
{
    internal class Cars
    {
        public string driverName;
        private bool hasNitro;
        private bool hasSpoiler;

        public int time = 0;
        public int timeWithPenalty = 0;

        
        private static string brand = Console.ReadLine();
        private int moveSpeed = 10;

        public int MoveSpeed
        {
            get
            {
                if(hasSpoiler && hasNitro)
                {
                    return (moveSpeed + 3);
                }
                else if(hasNitro || hasSpoiler)
                {
                    return (moveSpeed + 1);
                }
                return moveSpeed;
            }
        }
        public Cars(string driverName, bool hasNitro, bool hasSpoiler)
        {
            this.driverName = driverName;
            this.hasNitro = hasNitro;
            this.hasSpoiler = hasSpoiler;
        }
        public void ShowCar()
        {
            Console.WriteLine($"Driver : {driverName}\tCar brand : {brand}\tMove speed : {MoveSpeed}\tCar has nitro : {hasNitro}\tCar has spoielr : {hasSpoiler}");
        }
        public int Go()
        {
            return MoveSpeed * 60;
        }
    }
}
