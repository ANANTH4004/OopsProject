using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsProject
{
    public class Teacher
    {
		private string _TeacherName;

		public string TeacherName
		{
			get { return _TeacherName; }
			set { _TeacherName = value; }
		}
		private int _Class;

		public int Class
		{
			get { return _Class; }
			set { _Class = value; }
		}
		private string _Subject;

		public string Subject
		{
			get { return _Subject; }
			set { _Subject = value; }
		}
		public static List<Teacher> TeacherList = new List<Teacher>();



	}
}
