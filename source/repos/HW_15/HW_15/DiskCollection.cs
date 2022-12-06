using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_15
{
    internal class DiskCollection
    {
        List<string> songList1 = new List<string>();    
        List<string> songList2 = new List<string>();

        public ArrayList discCollection= new ArrayList();

        public List<string> FillFirstDisc()
        {
            songList1.Add("Let is snow");
            songList1.Add("Dean Martin");

            return songList1;
        }
        public List<string> FillSecondDisc() 
        {
            songList2.Add("Winter Wonderland");
            songList2.Add("Bing Crosby");
            return songList2;
        }
        public List<String> AddSongToSongList1(string songToAdd)
        {
            songList1.Add(songToAdd);
            return songList1;
        }

        public List<string> AddSongToSongList2(string songToAdd)
        {
            songList2.Add(songToAdd);
            return songList2;
        }

        public List<string> RemoveSongFromList1(string songName)
        {
            songList1.Remove(songName);
            return songList1;
        }
        public List<string> RemoveSongFromList2(string songName)
        {
            songList2.Remove(songName);
            return songList2;
        }

        public void FillCollection()
        {
            discCollection.Add(new Disc("Disk1", "Dean Martin", FillFirstDisc()));
            discCollection.Add(new Disc("Disk2", "Bing Crosby", FillSecondDisc()));
        }

        public void ShowCollection()
        {
            foreach (Disc d in discCollection)
            {
                d.ShowDiscInfo();
            }
        }

        public void ShowCollectionBySingerName(string singerName)
        {
            foreach (Disc d in discCollection)
            {
                if (d.singer == singerName)
                {
                    d.ShowDiscInfo();
                }
            }
        }

        public void ShowCollectionByName(string diskName)
        {
            foreach (Disc d in discCollection)
            {
                if (d.diskName == diskName)
                {
                    d.ShowDiscInfo();
                }
            }
        }
    }
}
