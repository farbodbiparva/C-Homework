using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLASS_Project
{
    public partial class Form2 : Form
    {
        string PassPath;
        string loggeduser;
        public Form2()
        {
            InitializeComponent();
            Passtxt.PasswordChar = '*';

            PassPath = Path.Combine(Application.StartupPath, "pass.txt");
            CreatePassFileIfNotExists();
        }

        private void CreatePassFileIfNotExists()
        {
            if (!File.Exists(PassPath))
            {
                File.WriteAllLines(PassPath, new string[]
                {
                    "admin,pleasegivemeA",
                    "farbod,pleasegivemeA"
                });
            }
        }
        private void SignInB_Click(object sender, EventArgs e)
        {
            string username = Usertxt.Text.Trim();
            string password = Passtxt.Text.Trim();

            bool loginSuccess = File.ReadAllLines(PassPath)
                .Any(line =>
                {
                    var parts = line.Split(',');
                    return parts.Length == 2 &&
                           parts[0] == username &&
                           parts[1] == password;
                });

            if (loginSuccess)
            {
                Form1 mainForm = new Form1(username);
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(
                    "Username or password incorrect",
                    "Login Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
