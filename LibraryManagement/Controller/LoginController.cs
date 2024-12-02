using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagement.Model;

namespace LibraryManagement.Controller
{
    public class LoginController
    {
        private  DataClasses1DataContext db = new DataClasses1DataContext();

        public bool ValidateUser(string username, string password)
        {
            var user = db.Users.FirstOrDefault(u => u.Email == username && u.Password == password);
            return user != null;
        }
    }
}
