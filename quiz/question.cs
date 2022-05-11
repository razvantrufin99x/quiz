using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz
{
    public class question
    {
        public string thequestion = "....?";
        public List<pair> listofpossibleresponds = new List<pair>();
        public string answare = "The answare is ..... .";
        public List<int> corect = new List<int>();
    }
}
