﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_103022330080
{
    internal class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        public string Username;

        public SayaTubeUser(string username)
        {
            Contract.Requires(username.Length <= 100);
            Contract.Requires(!string.IsNullOrEmpty(username));
            this.Username = username;
            this.uploadedVideos = new List<SayaTubeVideo>();
        }

        public int GetTotalVideoPlayCount()
        {
            int total = 0;
            foreach (SayaTubeVideo video in uploadedVideos)
            {
                total += video.playCount;
            }
            return total;
        }

        public void AddVideo(SayaTubeVideo video)
        {
            Debug.Assert(condition: video != null);
            Debug.Assert(condition: video.playCount <= int.MaxValue);
            this.uploadedVideos.Add(video);
        }

        public void PrintAllVideoPlaycount()
        {
            Console.WriteLine("User: " + Username);
            for (int i = 0; i < uploadedVideos.Count|| i < 8; i++)
            {
                uploadedVideos[i].PrintVideoDetails();
            }
        }
    }
}
