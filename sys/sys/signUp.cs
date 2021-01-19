using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sys
{
    public partial class signUp : Form
    {
        List<Users> acc;
        public signUp()
        {
            InitializeComponent();
        }
        private void addUserAccount(string fn, string ln, string un, string em, string ps, string cp)
        {
            NormalUser n;
            n = new NormalUser();
            n.Fname = fn;
            n.Lname = ln;
            n.Username = un;
            n.Email = em;
            n.Passwd = ps;
            n.Conpass = cp;

            acc.Add(n);
        }
        private void addAdminAccount(string fn, string ln, string un, string em, string ps, string cp)
        {
            AdminUser a;
            a = new AdminUser();
            a.Fname = fn;
            a.Lname = ln;
            a.Username = un;
            a.Email = em;
            a.Passwd = ps;
            a.Conpass = cp;

            acc.Add(a);
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            string fn, ln, un, em, ps, cp;
            fn = txtFname.Text;
            ln = txtLname.Text;
            un = txtUname.Text;
            em = txtEmail.Text;
            ps = txtPasswd.Text;
            cp = txtConPasswd.Text;

            addUserAccount(fn, ln, un, em, ps, cp);
        }

        private void signUp_Load(object sender, EventArgs e)
        {
            acc = new List<Users>();
            addAdminAccount("Admin", "strator", "Admin", "Admin@sys.com", "password", "password");
            addUserAccount("luka", "chaves", "jchaves", "jchaves@sys.com", "chaves", "chaves");
        }
    }
}
