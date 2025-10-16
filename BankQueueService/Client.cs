using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankQueueService
{
    public class Client
    {
        public string Name { get; set; }
        public int Age {  get; set; }
        public bool Priority {  get; set; }
        public Client Next { get; set; }

        public Client() 
        {
            Next = null;
        }

        public override string ToString()
        {
            return $"{Name} age {Age}";
        }
    }
}
