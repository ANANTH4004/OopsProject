using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsProject
{
    public class FileRead
    {
        
        public void ReadFile()
        {
            FileStream fs = new FileStream("Student.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = null;
            
            try
            {
                sr = new StreamReader(fs);
                bool LastLine = false;
                while(!LastLine)
                {
                    Student s = new Student();
                    String temp = sr.ReadLine();
                    if(temp== null)
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
                fs.Close();
                
            }

        }
    }
}
