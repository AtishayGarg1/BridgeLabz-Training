using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.linkedlist.socialmediafriendconnection
{
    internal class SocialMediaMain
    {
        static void Main(string[] args)
        {
            SocialMediaManager manager = new SocialMediaManager();

            manager.AddUser(1, "Atishay", 21);
            manager.AddUser(2, "Aman", 22);
            manager.AddUser(3, "Akshat", 23);
            manager.AddUser(4, "Amrit", 24);

            manager.AddFriendConnection(1, 2);
            manager.AddFriendConnection(1, 3);
            manager.AddFriendConnection(2, 3);
            manager.AddFriendConnection(3, 4);

            manager.DisplayFriends(1);

            manager.FindMutualFriends(1, 2);

            manager.SearchByUserId(3);
            manager.SearchByName("Amrit");

            manager.CountFriendsForEachUser();

            manager.RemoveFriendConnection(1, 3);
            manager.DisplayFriends(1);
        }
    }
}
