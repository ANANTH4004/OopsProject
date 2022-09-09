using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region CreateFile
            //File.Create("Student.txt");
            //File.Create("Teacher.txt");
            //File.Create("Subject.txt"); 
            #endregion
            FileRead f = new FileRead();
            f.ReadFile();
            Student s = new Student();
            s.PrintStudent();
        }
    }
}
