using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamProjectPD422
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void UserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Emeil_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void Checknotrobot_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CreateLogin_Click(object sender, EventArgs e)
        {
            string username = UserName.Text;
            string email = Emeil.Text;
            string password = Password.Text;

            if (Checknotrobot.Checked && !string.IsNullOrWhiteSpace(username) &&
                !string.IsNullOrWhiteSpace(email) && !string.IsNullOrWhiteSpace(password))
            {
                string userData = $"{username}|{email}|{password}";
                File.AppendAllText("users.txt", userData + Environment.NewLine);
                MessageBox.Show("Користувача створено!");
                Form1 form = new Form1();
                this.Hide();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Будь ласка, заповніть всі поля та підтвердіть, що ви не робот.");
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
