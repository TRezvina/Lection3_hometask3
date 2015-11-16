using System;
using System.Collections;
using System.Diagnostics;
using Lection3_Part3_Exceptions_Files;


namespace ConsoleApplication_NewYearGift.Collections
{
    public class MyArrayList : MyCollections
    {
        private ArrayList myArrayList = new ArrayList();

        public override TimeSpan Init(Gift gift)
        {
            Stopwatch sWatch = new Stopwatch();
            sWatch.Start();
            for (int i = 0; i <= 1000; i++)
            {
                myArrayList.Add(gift);
            }
            sWatch.Stop();
            TimeSpan timeSpan = sWatch.Elapsed;
            
            return timeSpan;
        }

        public override TimeSpan GetNElement(int N)
        {
            Stopwatch sWatch = new Stopwatch();
            sWatch.Start();
            Gift gift = (Gift)myArrayList[N];
            sWatch.Stop();
            TimeSpan timeSpan = sWatch.Elapsed;
            return timeSpan;
        }

        public override TimeSpan RemoveNElement(int N)
        {
            Stopwatch sWatch = new Stopwatch();
            sWatch.Start();
            myArrayList.RemoveAt(N);
            sWatch.Stop();
            TimeSpan timeSpan = sWatch.Elapsed;
            return timeSpan;
        }

        public override string GetCollectionName()
        {
            return "ArrayList";
        }
    }
}
