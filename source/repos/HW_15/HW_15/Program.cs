namespace HW_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool wantToExit = false;

            DiskCollection firstColelction = new DiskCollection();
            firstColelction.FillCollection();
            firstColelction.ShowCollection();
            while(!wantToExit) 
            {
                Console.WriteLine("== Press 1 : If you want to see collection == \n== Press 2 : If you want to search by singer name " + " == \n== Press 3 : If you want to search by disk name ==\n== Press 4 : If you want to add songn == \n== Press 5 : If you want to delate song == \n **Press G : If you want to exit from this menu **");
                string userData = Console.ReadLine();
                if (userData == "G") 
                {
                    wantToExit= true;
                }
                switch (userData) 
                {
                    case "1":
                        firstColelction.ShowCollection();
                        break;
                    case "2":
                        Console.WriteLine("Enter singer name: ");
                        string name = Console.ReadLine();
                        firstColelction.ShowCollectionBySingerName(name);
                        break;
                    case "3":
                        Console.WriteLine("Enter the disc name: ");
                        string diskName = Console.ReadLine();
                        firstColelction.ShowCollectionByName(diskName);
                        break;  
                    case "4":
                        Console.WriteLine("Do you want to add song to FirstCD or SecondCD ?");
                        string diskNumber = Console.ReadLine(); 
                        if(diskNumber == "1")
                        {
                            Console.WriteLine("Type of the Song Name");
                            string songName = Console.ReadLine();
                            firstColelction.AddSongToSongList1(songName);
                        }
                        if(diskNumber == "2")
                        {
                            Console.WriteLine("Type of the Song Name");
                            string songName = Console.ReadLine();
                            firstColelction.AddSongToSongList2(songName);
                        }
                        break;
                    case "5":
                        Console.WriteLine("Do you want to remove song from FirstCD or SecondCD");
                        string _discNumber = Console.ReadLine();    
                        if(_discNumber == "1")
                        {
                            Console.WriteLine("Type of the Song Name");
                            string songName = Console.ReadLine();
                            firstColelction.RemoveSongFromList1(songName);
                        }
                        if(_discNumber == "2")
                        {
                            Console.WriteLine("Type of the Song Name");
                            string songName = Console.ReadLine();
                            firstColelction.RemoveSongFromList2(songName);
                        }
                        break;
                }
            }
        }
    }
}