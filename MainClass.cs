using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace lab5
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {
            //1)
            Student student = new Student(new Person("Maksym","Dobzhinetskii",new DateOnly(2002,08,20)), Education.Master, 301);

            WriteLine(student.DeepCopy());
            //2)
            WriteLine("Enter the name of the file in which you want to write the data about the object:");
            student.Save(ReadLine());
            WriteLine("Enter the name of the file from which you want to read the object data:");
            Student student2 = new Student();
            student2.Load(ReadLine());
            WriteLine(student2);

            //3)
            student.AddFromConsole();
            WriteLine("Enter the name of the file in which you want to write the data about the object:");
            student.Save(ReadLine());
            WriteLine("Enter the name of the file from which you want to read the object data:");
            student.Load(ReadLine());
        

            //4)
            WriteLine("Enter the name of the file from which you want to read the object data:");
            Student.Load(ReadLine(), student);
            student.AddFromConsole();
            WriteLine("Enter the name of the file in which you want to write the data about the object:");
            Student.Save(ReadLine(), student);
            WriteLine("Enter the name of the file from which you want to read the object data:");
            Student.Load(ReadLine(), student);



        }
    }
}
