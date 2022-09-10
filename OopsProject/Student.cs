using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace OopsProject
{
    public class Student : IFileOperaions
    {
		private string _StudentName;

		public string StudentName
		{
			get { return _StudentName; }
			set { _StudentName = value; }
		}

		private int _Class;

		public int Class
		{
			get { return _Class; }
			set { _Class = value; }
		}
		//private char _Section;

		//public char Section
		//{
		//	get { return _Section; }
		//	set { _Section = value; }
		//}
		public static List<Student> StudentList = new List<Student>();
		public void PrintStudent()
		{
			foreach (var item in StudentList)
			{
				Console.WriteLine($"Student Name : {item.StudentName}  Class : {item.Class}");
			}
			Console.WriteLine("========================================");
		}
		public void FileWrite()
		{
			FileStream fs = new FileStream("Student.txt", FileMode.Append, FileAccess.Write);
			StreamWriter sr = null;
			try
			{
				sr = new StreamWriter(fs);
				Console.WriteLine("Enter Student Name :");
				string name = Console.ReadLine();
				Console.WriteLine("Enter Class :" );
				string Class = Console.ReadLine();
				sr.WriteLine(name + "-" + Class);
            }
			finally
			{
				sr.Close();
				fs.Close();
			}
		}
        public void FileRead()
        {
            FileStream fs1 = new FileStream("Student.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = null;

            try
            {
                sr = new StreamReader(fs1);
                bool LastLine = false;
                while (!LastLine)
                {
                    Student s = new Student();
                    String temp = sr.ReadLine();
                    if (temp == null)
                    {
                        Console.WriteLine("Last Data reached...");
                        break;
                    }
                    s.StudentName = temp.Split('-')[0];
                    s.Class = Convert.ToInt32(temp.Split('-')[1]);
                    Student.StudentList.Add(s);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Message = " + ex.Message);

            }
            finally
            {
                sr.Close();
                fs1.Close();

            }
        }
    }
}
