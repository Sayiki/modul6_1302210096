using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302210096
{
    public class SayaTubeVideo
    {
        private int id;
        public string title;
        public int playCount;

        public SayaTubeVideo(string title)
        {
            this.id = new Random().Next(10000,99999);
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int p)
        {
            this.playCount += p;
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("ID: " + this.id);
            Console.WriteLine("Title: " + this.title);
            Console.WriteLine("PlayCount: " + this.playCount);
        }

        public string getTitle()
        {
            return title;
        }
    }

}
