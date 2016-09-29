using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo2
{
    class Program
    {
        static void Main(string[] args)
        {

            object[] stack = new object[0];
            Console.WriteLine("Hello and welcome to the SuperStack!\n");
            while (true)
            {
               Console.WriteLine("What do you want to do?\n"
                                + "1...Add element to stack\n"
                                + "2...Remove element from stack\n"
                                + "3...Get top element\n"
                                + "4...Display whole stack!\n"
                                + "0...End Stack\n"
                                );



                int menuoption = int.Parse(Console.ReadLine());
                if (menuoption == 0)
                {
                    break;
                }

                switch (menuoption)
                {
                    case 1:
                        Console.WriteLine("Please enter object you want to add\n");
                        stack = AddToStack(Console.ReadLine(),stack);
                        Console.WriteLine("Object successfully added\n");
                        break;

                    case 2:
                        if (stack.Length == 0)
                        {
                            Console.WriteLine("Stack is empty cannot remove anything!");
                        }
                        else
                        {
                           stack = RemoveFromStack(stack);
                            Console.WriteLine("Object successfully removed\n");
                        }
                        break;
                    case 3:
                        if (stack.Length == 0)
                        {
                            Console.WriteLine("Stack is empty");
                        }else
                        {
                            Console.WriteLine("Top object: " + stack[stack.Length - 1] + "\n");
                        }
                       
                        break;


                    case 4:
                        if (stack.Length == 0)
                        {
                            Console.WriteLine("Stack is empty");
                        }
                        else
                        {
                            int cnt = 0;
                            foreach (object o in stack)
                            {
                                Console.WriteLine("{0}: {1}", cnt++, o);
                            }
                            Console.WriteLine();
                        }
                        break;

                    default:

                        break;

                }
            }
            

           

        }

       

        private static object[] RemoveFromStack(object[] obj)
        {
            
            object[] stack = new object[obj.Length - 1];
            int i = 0;
            for (; i < obj.Length-1; i++)
            {
                stack[i] = obj[i];
            }
            return stack;
        }

        static object[] AddToStack(object o, object[] obj)
        {
            object[] stack = new object[obj.Length+1];

            int i = 0;
            for(; i < obj.Length; i++)
            {
                stack[i] = obj[i];
            }
            stack[i] = o;
            return stack;

        }
    }
}
