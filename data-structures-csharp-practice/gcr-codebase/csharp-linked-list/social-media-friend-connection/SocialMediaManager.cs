using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.linkedlist.socialmediafriendconnection
{
    internal class SocialMediaManager
    {
        private UserNode head;

        public SocialMediaManager()
        {
            head = null;
        }

        public void AddUser(int userId, string name, int age)
        {
            UserNode node = new UserNode(userId, name, age);
            node.next = head;
            head = node;
        }

        private UserNode FindUserById(int userId)
        {
            UserNode temp = head;
            while (temp != null)
            {
                if (temp.UserId == userId)
                    return temp;
                temp = temp.next;
            }
            return null;
        }

        public void AddFriendConnection(int userId1, int userId2)
        {
            UserNode user1 = FindUserById(userId1);
            UserNode user2 = FindUserById(userId2);

            if (user1 == null || user2 == null)
                return;

            if (!user1.FriendIds.Contains(userId2))
                user1.FriendIds.Add(userId2);

            if (!user2.FriendIds.Contains(userId1))
                user2.FriendIds.Add(userId1);
        }

        public void RemoveFriendConnection(int userId1, int userId2)
        {
            UserNode user1 = FindUserById(userId1);
            UserNode user2 = FindUserById(userId2);

            if (user1 == null || user2 == null)
                return;

            user1.FriendIds.Remove(userId2);
            user2.FriendIds.Remove(userId1);
        }

        public void FindMutualFriends(int userId1, int userId2)
        {
            UserNode user1 = FindUserById(userId1);
            UserNode user2 = FindUserById(userId2);

            if (user1 == null || user2 == null)
                return;

            foreach (int id in user1.FriendIds)
            {
                if (user2.FriendIds.Contains(id))
                {
                    Console.WriteLine("Mutual Friend ID: " + id);
                }
            }
        }

        public void DisplayFriends(int userId)
        {
            UserNode user = FindUserById(userId);
            if (user == null)
                return;

            Console.WriteLine(user);
        }

        public void SearchByUserId(int userId)
        {
            UserNode user = FindUserById(userId);
            if (user != null)
                Console.WriteLine(user);
        }

        public void SearchByName(string name)
        {
            UserNode temp = head;
            while (temp != null)
            {
                if (temp.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(temp);
                }
                temp = temp.next;
            }
        }

        public void CountFriendsForEachUser()
        {
            UserNode temp = head;
            while (temp != null)
            {
                Console.WriteLine($"User ID: {temp.UserId}, Friends Count: {temp.FriendIds.Count}");
                temp = temp.next;
            }
        }
    }
}
