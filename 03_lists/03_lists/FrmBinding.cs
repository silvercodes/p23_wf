using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_lists
{
    public partial class FrmBinding : Form
    {
        private List<User> users;
        public FrmBinding()
        {
            InitializeComponent();

            users = new List<User>()
            {
                new User() {Id = 101, Name = "Chack", Email = "chack@mail.com" },
                //new User() {Id = 102, Name = "Vasia", Email = "vasia@mail.com" },
                //new User() {Id = 104, Name = "Petya", Email = "petya@mail.com" },
                //new User() {Id = 111, Name = "Brus", Email = "brus@mail.com" },
            };

            cbxOne.DataSource = users;
            cbxOne.DisplayMember = "Email";
            cbxOne.ValueMember = "Id";

            users.Add(new User() { Id = 120, Name = "Dima", Email = "dima@mail.com" });
        }

        private void cbxOne_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int index = cbxOne.SelectedIndex;
            //MessageBox.Show(index.ToString());

            //User user = cbxOne.SelectedItem as User;
            //MessageBox.Show(user.ToString());

            //int id = (int)cbxOne.SelectedValue;
            //User user = users.Find(u => u.Id == id);
            //MessageBox.Show(user.ToString());

            // TODO: empty string ???
            //string val = cbxOne.SelectedText;
            //MessageBox.Show(val);

        }
    }
}

