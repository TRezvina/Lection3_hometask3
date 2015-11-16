using System;
using System.Collections.Generic;
using System.Diagnostics;
using Lection3_Part3_Exceptions_Files;


namespace ConsoleApplication_NewYearGift.Collections
{
    class MyDictionary : MyCollections
    {
        private Dictionary<int, Gift> myDictionary = new Dictionary<int, Gift>();


        public override TimeSpan Init(Gift gift)
        {
            Stopwatch sWatch = new Stopwatch();
            sWatch.Start();
            for (int i = 1; i <= 1000; i++)
            {
                myDictionary.Add(i, gift);
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
            myDictionary.TryGetValue(N, out gift);
            sWatch.Stop();
            TimeSpan timeSpan = sWatch.Elapsed;
            return timeSpan;
        }

        public override TimeSpan RemoveNElement(int N)
        {
            Stopwatch sWatch = new Stopwatch();
            sWatch.Start();
            Gift gift = new Gift();
            myDictionary.Remove(N);
            sWatch.Stop();
            TimeSpan timeSpan = sWatch.Elapsed;
            return timeSpan;
        }

        public override string GetCollectionName()
        {
            return "Dictionary";
        }
    }
}
