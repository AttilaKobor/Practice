using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            string todoText = " - Buy milk\n";
            StringBuilder MyTodo = new StringBuilder(todoText);
            MyTodo.Insert(0, "- Download Games\n");
            MyTodo.Append("- Diablo\n");
            todoText = MyTodo.ToString();
            Console.WriteLine(todoText);
            Console.ReadKey();
        }
    }
}
