using System.Security.Cryptography.X509Certificates;

namespace CLASS_Project
{
    public partial class Form1 : Form
    {
        Dictionary<string, Contact> contacts = new Dictionary<string, Contact>();
        string filePath;
        string loggedUser;
        public Form1(string username)
        {
            InitializeComponent();
            loggedUser = username;
            ApplyUserPermissions();
            filePath = Path.Combine(Application.StartupPath, "Phonebook.txt");
            LoadContacts();
            RefreshGrid();
        }
        private void ApplyUserPermissions()
        {
            if (loggedUser != "admin")
            {
                EditB.Visible = false;
                DeleteB.Visible = false;
            }
        }
        private void LoadContacts()
        {
            if (!File.Exists(filePath))
                File.Create(filePath).Close();

            contacts.Clear();

            foreach (string line in File.ReadAllLines(filePath))
            {
                var parts = line.Split(',');
                if (parts.Length == 4)
                {
                    contacts[parts[0]] = new Contact
                    {
                        ID = parts[0],
                        FirstName = parts[1],
                        LastName = parts[2],
                        Phone = parts[3]
                    };
                }
            }
        }
        private void RefreshGrid(IEnumerable<Contact> list = null)
        {
            Contacts.DataSource = null;
            Contacts.DataSource = (list ?? contacts.Values).ToList();
        }

        public class Contact
        {
            public string ID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Phone { get; set; }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var result = contacts.Values.Where(c =>
               (string.IsNullOrEmpty(IDtxt.Text) || c.ID.Contains(IDtxt.Text)) &&
               (string.IsNullOrEmpty(FirstNametxt.Text) || c.FirstName.Contains(FirstNametxt.Text)) &&
               (string.IsNullOrEmpty(LastNametxt.Text) || c.LastName.Contains(LastNametxt.Text)) &&
               (string.IsNullOrEmpty(Phonetxt.Text) || c.Phone.Contains(Phonetxt.Text))
           );

            RefreshGrid(result);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void newB_Click(object sender, EventArgs e)
        {
            if (contacts.ContainsKey(IDtxt.Text))
            {
                MessageBox.Show("ID already exists");
                return;
            }

            contacts[IDtxt.Text] = new Contact
            {
                ID = IDtxt.Text,
                FirstName = FirstNametxt.Text,
                LastName = LastNametxt.Text,
                Phone = Phonetxt.Text
            };

            RefreshGrid();
            ClearTextBoxes();
        }

        private void FirstNametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Phonetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void IDtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void EditB_Click(object sender, EventArgs e)
        {
            if (!contacts.ContainsKey(IDtxt.Text))
            {
                MessageBox.Show("Contact not found");
                return;
            }

            contacts[IDtxt.Text].FirstName = FirstNametxt.Text;
            contacts[IDtxt.Text].LastName = LastNametxt.Text;
            contacts[IDtxt.Text].Phone = Phonetxt.Text;

            RefreshGrid();
        }

        private void DeleteB_Click(object sender, EventArgs e)
        {
            if (contacts.Remove(IDtxt.Text))
            {
                RefreshGrid();
                ClearTextBoxes();
            }
            else
            {
                MessageBox.Show("Contact not found");
            }
        }

        private void SaveB_Click(object sender, EventArgs e)
        {
            File.WriteAllLines(filePath,
                contacts.Values.Select(c =>
                    $"{c.ID},{c.FirstName},{c.LastName},{c.Phone}"
                )
            );

            MessageBox.Show("Changes saved successfully");
            Application.Exit();
        }
        private void ClearTextBoxes()
        {
            IDtxt.Clear();
            FirstNametxt.Clear();
            LastNametxt.Clear();
            Phonetxt.Clear();
        }
    }
}
