using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StudentClassLibrary
{
   public class StudentController
    {
       List<Student>liststudent=new List<Student>();
        private string name;
        private string id;

        public void addStudent2List(string id, string name)
        {
            this.name = name;
            this.id = id;
        }
        public void addStudent2List(Student student)
        {

        }
        public string displaydata()
        {
            return id+" " + name+"\r\n" ;
        }

        public void saveFile()
        {
           return;
        }
        public int openFile() 
        {
             return string.Compare( id, name);
        }
    }
}
