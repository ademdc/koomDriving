using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    class Users
    {
        private string fName;
        private string lName;
        private string password;
        private int id;

        public Users()
        {

        }
        public string FName { get => fName; set => fName = value; }

        public static int message()
        {
            return 5;
        }
    }
}
