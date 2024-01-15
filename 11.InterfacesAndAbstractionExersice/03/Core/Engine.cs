using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03.Core.Interface;
using Telephony;

namespace _03.Core
{
    public class Engine : IEngine
    {
        public void Run()
        {
            string[] input = Console.ReadLine().Split();
            string[] input2 = Console.ReadLine().Split();
            foreach (var s in input)
            {
                ICaller phone;
                if (s.Length == 7)
                {
                    phone = new StationaryPhone();

                }
                else
                {
                    phone = new SmartPhone();
                }
                try
                {
                    Console.WriteLine(phone.Call(s));

                }

                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }


            }

            IBrowser phone2 = new SmartPhone();
            foreach (var s in input2)
            {
                try
                {
                    Console.WriteLine(phone2.Browse(s));
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

    }

}
