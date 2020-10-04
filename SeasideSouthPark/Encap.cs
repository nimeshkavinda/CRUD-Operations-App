using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SeasideSouthPark
{
    class Encap
    {
        private string path;

        public void setPath(string username)
        {
            string documents = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            path = documents + "/" + username + ".txt";
        }

        public string getPath()
        {
            return path;
        }
    }
}
