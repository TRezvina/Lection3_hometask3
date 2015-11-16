using System;
using System.Collections;
using System.Diagnostics;
using Lection3_Part3_Exceptions_Files;


namespace ConsoleApplication_NewYearGift.Collections
{
    public class MyHashTable : MyCollections
    {
        private Hashtable myHashtable = new Hashtable();


        public override TimeSpan Init(Gift gift)
        {
            Stopwatch sWatch = new Stopwatch();
            sWatch.Start();
            for (int i = 1; i <= 1000; i++)
            {
                myHashtable.Add(i, gift);
            }
            sWatch.Stop();
            TimeSpan timeSpan = sWatch.Elapsed;
            return timeSpan;
        }

        public override TimeSpan GetNElement(int N)
        {
            int i = 1;
            Stopwatch sWatch = new Stopwatch();
            sWatch.Start();
            Gift gift = new Gift();
            foreach (DictionaryEntry key in myHashtable)
            {
                if (i == N)
                {
                    gift = (Gift) key.Value;
                    break;
                }
                i++;
            }
            sWatch.Stop();
            TimeSpan timeSpan = sWatch.Elapsed;
            return timeSpan;
        }

        public override TimeSpan RemoveNElement(int N)
        {
            Stopwatch sWatch = new Stopwatch();
            sWatch.Start();
            Gift gift = new Gift();
            myHashtable.Remove(N);
            sWatch.Stop();
            TimeSpan timeSpan = sWatch.Elapsed;
            return timeSpan;
        }

        public override string GetCollectionName()
        {
            return "HashTable";
        }
    }
}
