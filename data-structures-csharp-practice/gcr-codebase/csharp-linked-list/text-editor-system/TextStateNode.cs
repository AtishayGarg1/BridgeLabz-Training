using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.linkedlist.onlineticketreversationsystem
{
    internal class TextStateNode
    {
        public string Content;

        public TextStateNode next;
        public TextStateNode prev;

        public TextStateNode(string content)
        {
            Content = content;
            next = null;
            prev = null;
        }

        public override string ToString()
        {
            return Content;
        }
    }
}
