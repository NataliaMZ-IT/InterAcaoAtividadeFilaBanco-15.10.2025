using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankQueueService
{
    public class Bank
    {
        public ClientQueue NormalQ { get; set; }
        public ClientQueue PriorityQ { get; set; }
        public int Counter { get; set; }

        public Bank()
        {
            NormalQ = new ClientQueue();
            PriorityQ = new ClientQueue();
            Counter = 0;
        }

        public void AddClient(Client client)
        {
            if (client.Priority)
            {
                PriorityQ.InsertQueue(client);
            }
            else
            {
                NormalQ.InsertQueue(client);
            }
        }

        public void AttendClient()
        {
            if (NormalQ.EmptyQueue() && PriorityQ.EmptyQueue())
            {
                Console.WriteLine("\nThere is no one to attend to at this moment.");
            }
            else
            {
                if (Counter > 1 || NormalQ.EmptyQueue())
                {
                    Console.WriteLine($"\nAttending to " + PriorityQ.GetHead().ToString() + " from the Normal Queue");
                    PriorityQ.RemoveQueue();
                    Counter = 0;
                }
                else
                {
                    Console.WriteLine($"\nAttending to " + NormalQ.GetHead().ToString() + " from the Priority Queue");
                    NormalQ.RemoveQueue();
                    Counter++;
                }
            }
        }

        public void ShowAllQueues()
        {
            Console.WriteLine("\n\nNormal Queue: ");
            NormalQ.ShowQueue();
            Console.WriteLine("\nPriority Queue: ");
            PriorityQ.ShowQueue();
            Console.WriteLine();
        }
    }
}
