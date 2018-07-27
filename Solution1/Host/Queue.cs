using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Host
{
    internal class Queue : ImplementThis
    {
        int[] array = new int[20];
        int sizeq = 0, choice = 0, front = -1,end=-1,add=0,index=0,index1=0;
        internal int QueueSize()
            {
            Console.WriteLine("enter maximum size : ");
            sizeq = Convert.ToInt32(Console.ReadLine());
            menu();
            return choice;
            }
        public override void menu()
            {
            Console.WriteLine("enter your choice :\n\n 1: ADD \n 2: REMOVE \n 3: DISPLAY \n 4: SORT\n 5: PEEK \n 6: CHECK IF EMPTY \n 7: CHECK IF FULL \n 9: BACK");
            choice = Convert.ToInt32(Console.ReadLine());
            if(choice==1)
                {
                Add();
                }
            else if(choice==2)
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
                Peek();
                }
            else if (choice == 6)
                {
                IfEmpty();
                }
            else if (choice == 7)
                {
                IsFull();
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
            if (end < sizeq-1)
                {
                Console.WriteLine("enter element to be entered : ");
                add = Convert.ToInt32(Console.ReadLine());
                if (front == -1)
                    front++;
                end++;
                array[end] = add;
                Console.WriteLine("element {0} successfully added", add);
                }
            else
                {
                Console.WriteLine("not enough space!");
                }
            menu();
        }
    public override void Remove()
        {
            if (front!=-1)
            {
                for (index = 0; index <= end-1; index++)
                    {
                    array[index] = array[index + 1];
                    }
                if (end == 0)
                    front--;
                end--;
            }
            else
                {
                Console.WriteLine("nothing to remove");
                }
            menu();
        }
    public override void Display()
        {
            if (front != -1)
            {
                for (index = 0; index <=end; index++)
                {
                    Console.WriteLine(" {0}", array[index]);
                }
            }
            else
                {
                Console.WriteLine("queue empty!");
                }
            menu();
        }
    public override void Sort()
        {
            for (index = 0; index <=end - 1; index++)
            {
                for (index1 = 0; index1 <=end - 1 - index; index1++)
                {
                    if (array[index1] > array[index1 + 1])
                    {
                        array[index1] = array[index1] + array[index1 + 1];
                        array[index1 + 1] = array[index1] - array[index1 + 1];
                        array[index1] = array[index1] - array[index1 + 1];
                    }
                }
            }
            Console.WriteLine("the sorted queue is :- ");
            for (index = 0; index <=end; index++)
            {
                Console.WriteLine(" {0}", array[index]);
            }
            menu();
        }
    public void Peek()
        {
            if(front!=-1)
            Console.WriteLine("element at front : {0}",array[front]);
            else
            {
                Console.WriteLine("queue empty");
            }
            menu();
        }
    public void IfEmpty()
        {
            if(front==-1)
            {
                Console.WriteLine("queue is empty !");
            }
            else
            {
                Console.WriteLine("Queue is not empty");
            }
            menu();
        }
    public void IsFull()
        {
            if(end==sizeq-1)
            {
                Console.WriteLine("Queue is full!");
            }
            else
                {
                Console.WriteLine("Queue is not full!");
                }
            menu();
        }
    }
}
