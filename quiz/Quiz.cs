using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz
{
    public class Quiz
    {
        public string domain = " ";
        public string subdomain = " ";
        public string authorname = "";
        public string authorprename = "";
        public List<question> questionlist = new List<question>();
        public void gotonext() { }
        public void gotoprev() { }
        public void gotofirst() { }
        public void gotolast() { }
        public void verify() { }
        public person p = new person();
    }
}
