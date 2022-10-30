using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OopsProject;
using System.Runtime.InteropServices;

namespace OopsProject.Test
{
    
    public class SchoolTest
    {
        Student s = new Student();
        Teacher t = new Teacher();
        Subject sub = new Subject();
        public SchoolTest()
        {
            s.FileRead();
        }
        [TestCase("Anand", ExpectedResult =true)]
        [TestCase("anand", ExpectedResult =true)]
        [TestCase("Varun", ExpectedResult =true)]
        [TestCase("varun", ExpectedResult =false)]
        public bool FindStudent(string ans)
        {
            return s.SearchByName(ans);
        } 
        [TestCase("Sakthi", ExpectedResult =true)]
        [TestCase("Varun", ExpectedResult =true)]
        [TestCase("Geetha", ExpectedResult =true)]
        [TestCase("Nithya", ExpectedResult =false)]
        public bool FindTeacher(string ans)
        {
            return t.SearchByName(ans);
        } 
        [TestCase("Maths", ExpectedResult =true)]
        [TestCase("anand", ExpectedResult =false)]
        [TestCase("Tamizh", ExpectedResult =true)]
        [TestCase("Physics", ExpectedResult =false)]
        public bool FindSubject(string ans)
        {
            return sub.SearchByName(ans);
        }
        
       
       
    }
}
