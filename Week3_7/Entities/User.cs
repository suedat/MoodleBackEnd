using System;
namespace Week3_7.Entities
{
    public class User
    {
        public string Username { get; private set; }
        public int FollowerCount { get; private set; }

        // Constructor
        public User(string username, int followerCount)
        {
            Username = username;
            FollowerCount = followerCount;
        }
    }
}
