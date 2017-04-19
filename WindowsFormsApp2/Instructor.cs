using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    
     class Instructor : Users
    {
        private string username;
        
        public Instructor()
        {

        }
        public string Username { get => username; set => username = value; }

        Users us = new Users();
        int b = message();
    }
}
