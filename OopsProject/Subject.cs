using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsProject
{
    public class Subject
    {
        public static List<Subject> SubjectList = new List<Subject>();
		private string _SubjectName;

		public string SubjectName
		{
			get { return _SubjectName; }
			set { _SubjectName = value; }
		}

		private int _SubCode;

		public int SubCode
		{
			get { return _SubCode; }
			set { _SubCode = value; }
		}

	}
}
