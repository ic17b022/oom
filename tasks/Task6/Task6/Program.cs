using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject<Human> subject = new Subject<Human>();
            List<Human> list1 = new List<Human> { new Human(180, "Hans", "Maier", 80), new Human(160, "Gretel", "Maier", 50) };
            List<Human> list2 = new List<Human>();


            subject.Subscribe<Human>(x => list2.Add(x));

            for (int i = 0; i < 2; i++)
            {

                subject.OnNext(list1[i]);
                Console.WriteLine(list2[i].ToString());
            }

            Console.WriteLine("We found a super complicated way to copy a list! YAY!!");

            for (int i = 10; i > 0; i--)
            {
                int counter = i;
                Task<string> spinOff = Task.Run(() => longAndHardWork(counter*1000));
                spinOff.ContinueWith(t => Console.WriteLine(t.Result));
            }

            Task<string> waity = longAndHardWorkAsync(5000);
            waity.ContinueWith(x => Console.WriteLine(x.Result));
            Console.WriteLine("This should pop up before async finishes");

            //wait for sleepyheads to finish
            System.Threading.Thread.Sleep(15000);
        }

        private static string longAndHardWork(int duration)
        {
            Console.WriteLine("received:" + duration);
            System.Threading.Thread.Sleep(duration);    //This produces the expected output: Tasks finish randomly, repeatet runs yield different results
            //System.Threading.Thread.Sleep(5000);      //This does not. A constant sleep timer will produce the same order every time. Why?
            return "I twiddled my thumbs for " + duration + " milliseconds!";
        }

        private static async Task<string> longAndHardWorkAsync(int duration)
        {
            Console.WriteLine("async received:" + duration);
            await Task.Delay(duration);

            return "I twiddled my thumbs for " + duration + " milliseconds asynchroniously!";
        }
    } 
}
