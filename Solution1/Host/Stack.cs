using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Host
{
    internal class Stack : ImplementThis
    {
        int length = 0,choice=0,ret=0,add=0,del=0,top=0,index=0,index1=0,temp=0;
        int[] array = new int[20];
        internal int StackSize()
            {
            Console.WriteLine("enter maximum size : ");
            length =Convert.ToInt32(Console.ReadLine());
            menu();
            return choice;
            }
        public override void menu()
            {
            Console.WriteLine("\n\nenter your choice :\n\n 1: ADD \n 2: REMOVE \n 3: DISPLAY \n 4: SORT\n 5: GET STACK TOP \n 9: BACK");
            choice= Convert.ToInt32(Console.ReadLine());
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
                DisplayTop();
                }
            else if (choice == 9)
                {
                }
            else
                {
                choice = 9;
                Console.WriteLine("invalid entry");
                }
            }
        public override void Add()
            {
            Console.WriteLine("enter element to be entered : ");
            add= Convert.ToInt32(Console.ReadLine());
            if (top < length)
                {
                array[top] = add;
                Console.WriteLine("inserted element {0} successfully!",add);
                top++;
                }
            else
                {
                Console.WriteLine("not enough space!");
                }
            menu();
            }
        public override void Remove()
            {
            if (top != 0)
            {
                top--;
                Console.WriteLine("removed element : {0}",array[top]);
            }
            else
                {
                Console.WriteLine("nothing to remove!!");
                }
            menu();
            }
        public override void Display()
            {
            Console.WriteLine(" ");
            for(index=0;index<top;index++)
                {
                Console.Write(" {0}",array[index]);
                }
            menu();
            }
        public override void Sort()
            {
            for (index = 0; index < top - 1; index++)
                {
                for (index1 = 0; index1 < top - 1 - index; index1++)
                    {
                    if(array[index1]>array[index1+1])
                        {
                        array[index1] = array[index1] + array[index1 + 1];
                        array[index1 + 1] = array[index1] - array[index1 + 1];
                        array[index1] = array[index1] - array[index1 + 1];
                        }
                    }
                }
            Console.WriteLine("the sorted stack is :- ");
            for(index=0;index<top;index++)
                {
                Console.WriteLine(" {0}",array[index]);
                }
            menu();
            }
        public void DisplayTop()
            {
            if(top!=0)
            Console.WriteLine("Top is : {0}",array[top-1]);
            else
                Console.WriteLine("stack is empty");
            menu();
            }
    }
}
