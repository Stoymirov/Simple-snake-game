using System;
using System.Linq;
using System.Collections.Generic;

namespace TilesMaster
{
    public class TilesMaster
    {
        static void Main()
        {
            Stack<int> stack = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            Queue<int> queue = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());

            Dictionary<string, int> values = new Dictionary<string, int>()
            {
                { "Floor", 0 },
                { "Oven", 0 },
                { "Countertop", 0 },
                { "Sink", 0 },
                { "Wall", 0 },
            };

            while (stack.Count > 0 && queue.Count > 0)
            {
                int currentStack = stack.Pop();
                int currentQueue = queue.Dequeue();

                if (currentStack == currentQueue)
                {

                    int sum = currentQueue + currentStack;
                    switch (sum)
                    {
                        case 40:
                            values["Sink"]++;
                            break;
                        case 50:
                            values["Oven"]++;
                            break;
                        case 60:
                            values["Countertop"]++;
                            break;
                        case 70:
                            values["Wall"]++;
                            break;
                        default:
                            values["Floor"]++;
                            break;
                    }

                }
                else
                {
                    currentStack /= 2;
                    stack.Push(currentStack);
                    queue.Enqueue(currentQueue);
                }
            }

            if (stack.Count == 0)
                Console.WriteLine("White tiles left: none");
            else
                Console.WriteLine($"White tiles left: {string.Join(", ", stack)}");
            if (queue.Count == 0)
                Console.WriteLine("Grey tiles left: none");
            else
                Console.WriteLine($"Grey tiles left: {string.Join(", ", queue)}");

            foreach (var value in values.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                if (value.Value != 0) Console.WriteLine($"{value.Key}: {value.Value}");
            }
        }
    }

}