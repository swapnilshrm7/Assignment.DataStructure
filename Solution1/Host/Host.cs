using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Host
{
    class Host
    {
        static void Main(string[] args)
        {
            int choice1 = 0,choice2=0;
            Stack stack=new Stack();
            Queue queue = new Queue(); ;
            LinkedList Llist=new LinkedList();
            while (choice1 != 4)
            {
                choice2 = 0;
                Console.WriteLine("enter your choice : \n\n 1: Stack\n\n 2: Queue \n\n 3: Linked List\n\n 4: Exit");
                choice1 = Convert.ToInt32(Console.ReadLine());
                if (choice1 == 1)
                    stack = new Stack();
                else if (choice1 == 2)
                    queue = new Queue();
                else if (choice1 == 3)
                    Llist = new LinkedList();
                else if (choice1 == 4)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("invalid choice");
                }
                while(choice2!=9)
                    {
                    if (choice1 == 1)
                    {
                        choice2 = stack.StackSize();                      
                    }
                    else if(choice1==2)
                        {
                        choice2 = queue.QueueSize();
                        }
                    else if (choice1 == 3)
                    {
                        choice2 = Llist.Menu2();
                    }
                }
            }
        }
    }
}
