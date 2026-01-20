using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.DSA_FOLDER.scenariobased.exam_proctor
{
    internal class AnswerMap
    {
        private int[] keys;      // question IDs
        private char[] values;   // answers
        private int size;

        public AnswerMap(int capacity)
        {
            keys = new int[capacity];
            values = new char[capacity];
            size = 0;
        }

        public void Put(int questionId, char answer)
        {
            for (int i = 0; i < size; i++)
            {
                if (keys[i] == questionId)
                {
                    values[i] = answer; // update
                    return;
                }
            }

            keys[size] = questionId;
            values[size] = answer;
            size++;
        }

        public char Get(int questionId)
        {
            for (int i = 0; i < size; i++)
            {
                if (keys[i] == questionId)
                    return values[i];
            }
            return '\0'; // not answered
        }

        public int Size()
        {
            return size;
        }

        public int GetKeyAt(int index)
        {
            return keys[index];
        }
    }
}
