using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace OopsProject
{
    public class Student
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
		}
	}
}
