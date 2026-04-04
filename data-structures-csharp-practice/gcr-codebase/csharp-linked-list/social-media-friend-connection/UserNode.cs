using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.linkedlist.socialmediafriendconnection
{
    internal class UserNode
    {
        public int UserId;
        public string Name;
        public int Age;
        public List<int> FriendIds;

        public UserNode next;

        public UserNode(int userId, string name, int age)
        {
            UserId = userId;
            Name = name;
            Age = age;
            FriendIds = new List<int>();
            next = null;
        }

        public override string ToString()
        {
            return $"User ID: {UserId}\nName: {Name}\nAge: {Age}\nFriends: {string.Join(", ", FriendIds)}";
        }
    }
}
