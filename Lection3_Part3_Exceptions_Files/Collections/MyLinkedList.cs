using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Lection3_Part3_Exceptions_Files;


namespace ConsoleApplication_NewYearGift.Collections
{
    public class MyLinkedList : MyCollections
    {
        private LinkedList<Gift> myLinkedList = new LinkedList<Gift>();

        public override TimeSpan Init(Gift gift)
        {
            Stopwatch sWatch = new Stopwatch();
            sWatch.Start();
            myLinkedList.AddFirst(gift);
            for (int i = 1; i <= 1000; i++)
            {
                myLinkedList.AddLast(gift);
            }
            sWatch.Stop();
            TimeSpan timeSpan = sWatch.Elapsed;
            return timeSpan;
        }

        public override TimeSpan GetNElement(int N)
        {
            Stopwatch sWatch = new Stopwatch();
            sWatch.Start();

            // uncomment to show element
            //Console.WriteLine("========================================================================");
            //Console.WriteLine("{0} element is:", N);
            Gift gift = (Gift)myLinkedList.ElementAt(N);
            //myLinkedList.ElementAt(N).ShowGiftList();
            //Console.WriteLine("========================================================================");

            sWatch.Stop();
            TimeSpan timeSpan = sWatch.Elapsed;
            return timeSpan;
        }

        public override TimeSpan RemoveNElement(int N)
        {
            Stopwatch sWatch = new Stopwatch();
            sWatch.Start();
            LinkedListNode<Gift> tempNode = myLinkedList.First;
            if (N < myLinkedList.Count)
            {
                for (int i = 0; i < N; i++)
                {
                    tempNode = tempNode.Next;
                }
                myLinkedList.Remove(tempNode);
            }
            sWatch.Stop();
            TimeSpan timeSpan = sWatch.Elapsed;
            return timeSpan;
        }

        public override string GetCollectionName()
        {
            return "LinkedList";
        }
    }
}
