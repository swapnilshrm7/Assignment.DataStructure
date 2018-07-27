using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Host
{
    internal class LinkedList : ImplementThis
    {
        int[,] Llist = new int[20, 2];
        int index2 = 0, choice = 0,count=0,add=0,position=0,index=0,index1=0;
        internal LinkedList()
            {
                for(index2=0;index2<20;index2++)
                    {
                Llist[index2, 1] = -1;
                    }
            }
    internal int Menu2()
    {
        Console.WriteLine("enter your choice :\n\n 1: ADD AT END \n 2: REMOVE FROM SPECIFIC POSITION \n 3: DISPLAY \n 4: SORT\n 5: INSERT AT SPECIFIC POSITION \n 9: BACK");
        choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                Add();
            }
            else if (choice == 2)
            {
                Remove();
            }
            else if (choice == 3)
            {
                Display();
            }
            else if (choice == 4)
            {
                Sort();
            }
            else if (choice == 5)
            {
                Insert();
            }
            else if (choice == 9)
            {
            }
            else
            {
                choice = 9;
                Console.WriteLine("invalid entry");
            }
            return choice;
    }
        public override void menu()
        {
        }
        public override void Add()
        {
            if(count<20)
                {
                Console.WriteLine("enter element to be entered : ");
                add = Convert.ToInt32(Console.ReadLine());
                Llist[count,0]=add;
                Llist[count, 1] = count;
                count++;
                Console.WriteLine("element {0} successfully added",add);
                }
            Menu2();
        }
        public override void Remove()
        {
            Console.WriteLine("enter position from where the element is to be removed : ");
            position = Convert.ToInt32(Console.ReadLine());
            if (position >= count)
            {
                Console.WriteLine("linked list is not big enough");
            }
            else
            {
               for(index2=position;index2<=count-1;index2++)
                    {
                    Llist[index2, 0] = Llist[index2 + 1, 0];
                    }
                count--;
            }
            Menu2();
        }
        public override void Display()
        {
            for(index2=0;index2<count;index2++)
                {
                Console.WriteLine(" {0}",Llist[index2,0]);
                }
            Menu2();
        }
        public override void Sort()
        {
            for (index = 0; index < count - 1; index++)
            {
                for (index1 = 0; index1 < count - 1 - index; index1++)
                {
                    if (Llist[index1,0] > Llist[index1 + 1,0])
                    {
                        Llist[index1,0] = Llist[index1,0] + Llist[index1 + 1,0];
                        Llist[index1 + 1,0] = Llist[index1,0] - Llist[index1 + 1,0];
                        Llist[index1,0] = Llist[index1,0] - Llist[index1 + 1,0];
                    }
                }
            }
            Console.WriteLine("the sorted Linked list is :- ");
            for (index = 0; index <count; index++)
            {
                Console.WriteLine(" {0}", Llist[index,0]);
            }
            Menu2();
        }
        public void Insert()
            {
            Console.WriteLine("enter position where the element is to be entered: ");
            position = Convert.ToInt32(Console.ReadLine());
            if (position >= count)
            {
                Console.WriteLine("Not enough elements in the linked list");
            }
            else
            {
                Console.WriteLine("enter element to be entered : ");
                add = Convert.ToInt32(Console.ReadLine());
                for (index=position;index<count;index++)
                    {
                    Llist[index + 1, 0] = Llist[index, 0];
                    }
                Llist[position, 0] = add;
                count++;
            }
            Menu2();
        }
    }
}
