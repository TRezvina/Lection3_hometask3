using System;
using System.Collections.Generic;
using System.Diagnostics;
using Lection3_Part3_Exceptions_Files;


namespace ConsoleApplication_NewYearGift.Collections
{
    public class MyStack : MyCollections
    {
        private Stack<Gift> myStack = new Stack<Gift>();

        public override TimeSpan Init(Gift gift)
        {
            Stopwatch sWatch = new Stopwatch();
            sWatch.Start();
            for (int i = 1; i <= 1000; i++)
            {
                myStack.Push(gift);
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
            gift = myStack.ToArray()[N-1];
            sWatch.Stop();
            TimeSpan timeSpan = sWatch.Elapsed;
            return timeSpan;
        }

        public override TimeSpan RemoveNElement(int N)
        {
            Stopwatch sWatch = new Stopwatch();

            Gift gift = new Gift();
            Stack<Gift> tmpStack = new Stack<Gift>();
            sWatch.Start();
            int count = myStack.Count - N;

            for (int i = 0; i < count; i++)
            {
                tmpStack.Push(myStack.Pop()); 
            }
            tmpStack.Pop();
            count = tmpStack.Count;
            for (int i = 0; i < count; i++)
            {
                tmpStack.Push(tmpStack.Pop());
            }
            myStack.Pop();
            sWatch.Stop();
            TimeSpan timeSpan = sWatch.Elapsed;
            return timeSpan;
        }

        public override string GetCollectionName()
        {
            return "Stack";
        }
    }
}
