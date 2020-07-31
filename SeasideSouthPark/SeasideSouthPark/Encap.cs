using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeasideSouthPark
{
    class Encap
    {
        private string path;

        public void setPath(string username)
        {
            path = @"d:\"+username+".txt";
        }

        public string getPath()
        {
            return path;
        }
    }
}
