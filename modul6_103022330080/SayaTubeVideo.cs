using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_103022330080
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        public int playCount;

        public SayaTubeVideo(string name)
        {
            Debug.Assert(name.Length < 200);
            Debug.Assert(!string.IsNullOrEmpty(name));
            Random rnd = new Random();
            this.title = name;
            this.id = rnd.Next(100000);
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            Debug.Assert(count <= 25000000);
            try
            {
                checked
                {
                    this.playCount += count;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("Judul video: " + title);
            Console.WriteLine("Id video: " + id);
            Console.WriteLine("Video diputar sebanyak: " + playCount);
        }
    }
}
