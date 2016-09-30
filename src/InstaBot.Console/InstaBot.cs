﻿using InstaBot.Console.Tasks;

namespace InstaBot.Console
{
    public interface IInstaBot
    {
        void Run();
    }

    public class InstaBot : IInstaBot
    {
        public ConfigurationManager ConfigurationManager { get; set; }
        public ILogin LoginTask { get; set; }
        public ILikeTask LikeTask { get; set; }
        public IFollowingTask FollowingTask { get; set; }


        public void Run()
        {
            LoginTask.DoLogin().Wait();
            LikeTask.Start();
            FollowingTask.Start();
        }
    }
}