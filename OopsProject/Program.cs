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
            Student s = new Student();
            s.FileWrite();
            s.FileRead();
            s.PrintStudent();
            Teacher t = new Teacher();
            t.FileWrite();
            t.FileRead();
            t.ShowList();
            Subject ss = new Subject();
            ss.FileWrite();
            ss.FileRead();
            ss.PrintData();
        }
    }
}
