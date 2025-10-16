using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankQueueService
{
    public class ClientQueue
    {
        private Client Head;
        private Client Tail;

        public Client GetHead()
        {
            return Head;
        }

        public ClientQueue()
        {
            Head = null;
            Tail = Head;
        }

        public void InsertQueue(Client client)
        {
            if (EmptyQueue())
            {
                Head = client;
                Tail = client;
            }
            else
            {
                Tail.Next = client;
                Tail = client;
            }
        }

        public bool EmptyQueue()
        {
            if (Head == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void RemoveQueue()
        {
            if (EmptyQueue())
            {
                Console.WriteLine("The queue is empty!");
            }
            else
            {
                Head = Head.Next;
                if (Head == null)
                {
                    Tail = null;
                }
            }
        }

        public void ShowQueue()
        {
            if (EmptyQueue())
            {
                Console.WriteLine("There is no one in this queue!");
            }
            else
            {
                Client aux = Head;
                int i = 1;
                while (aux != null)
                {
                    Console.WriteLine($"{i} - " + aux.ToString());
                    aux = aux.Next;
                    i++;
                }
            }
        }
    }
}
