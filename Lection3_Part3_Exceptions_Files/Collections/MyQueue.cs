using System;
using System.Collections.Generic;
using System.Diagnostics;
using Lection3_Part3_Exceptions_Files;


namespace ConsoleApplication_NewYearGift.Collections
{
    public class MyQueue : MyCollections
    {
        private Queue<Gift> myQueue = new Queue<Gift>();
        public override TimeSpan Init(Gift gift)
        {
            Stopwatch sWatch = new Stopwatch();
            sWatch.Start();
            for (int i = 1; i <= 1000; i++)
            {
                myQueue.Enqueue(gift);
            }
            sWatch.Stop();
            TimeSpan timeSpan = sWatch.Elapsed; 
            return timeSpan;
        }
        public override TimeSpan GetNElement(int N)
        {
            Stopwatch sWatch = new Stopwatch();
            sWatch.Start();
            Gift gift = new Gift();
            gift = myQueue.ToArray()[N-1];
            sWatch.Stop();
            TimeSpan timeSpan = sWatch.Elapsed;
            return timeSpan;
        }

        public override TimeSpan RemoveNElement(int N)
        {
            Stopwatch sWatch = new Stopwatch();
            
            Queue<Gift> tmpQueue = new Queue<Gift>();
            sWatch.Start(); 
           
            for(int i=1; i<N; i++)
            { tmpQueue.Enqueue(myQueue.Dequeue());}
            tmpQueue.Dequeue();
            foreach (var value in tmpQueue)
            {
                myQueue.Enqueue(value);
            }
            sWatch.Stop();
           
            TimeSpan timeSpan = sWatch.Elapsed;
            return timeSpan;
        }

        public override string GetCollectionName()
        {
            return "Queue";
        }
    }
}
