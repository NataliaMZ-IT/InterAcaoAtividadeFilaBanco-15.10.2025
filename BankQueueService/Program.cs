// Atendimento de um Banco
using BankQueueService;

Client RegisterClient()
{
    Client aux = new Client();
    Console.Write("\nInsert client name: ");
    aux.Name = Console.ReadLine()!;
    Console.Write("Insert client's age: ");
    aux.Age = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Does client meet requirements for the priority queue? (true/false)");
    aux.Priority = bool.Parse(Console.ReadLine()!);
    return aux;
}

Bank bank = new Bank();
Client client;
int op;
do
{
    Console.WriteLine("\n-----------------------------");
    Console.WriteLine("Choose an option:\n1 - Add Client\n2 - Attend Next Client\n3 - Show Queues\n0 - Exit");
    Console.WriteLine("-----------------------------");
    op = int.Parse(Console.ReadLine()!);

    switch (op)
    {
        case 0:
            Console.WriteLine("Exiting program...");
            break;
        case 1:
            client = RegisterClient();
            bank.AddClient(client);
            Console.WriteLine("\nClient sucessfully added! Updating queues...");
            bank.ShowAllQueues();
            break;
        case 2:
            bank.AttendClient();
            Console.WriteLine("Updating queues...");
            bank.ShowAllQueues();
            break;
        case 3:
            bank.ShowAllQueues();
            break;
        default:
            Console.WriteLine("\nInvalid option!");
            break;
    }
} while (op != 0);