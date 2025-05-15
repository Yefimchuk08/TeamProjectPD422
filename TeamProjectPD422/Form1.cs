namespace TeamProjectPD422
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void Checknotrobot_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            string username = UserName.Text;
            string password = Password.Text;

            if (Checknotrobot.Checked)
            {
                if (File.Exists("users.txt"))
                {
                    string[] lines = File.ReadAllLines("users.txt");
                    bool found = lines.Any(line =>
                    {
                        string[] parts = line.Split('|');
                        return parts[0] == username && parts[2] == password;
                    });

                    if (found)
                    {
                        MessageBox.Show("Успішний вхід!");
                        Form2 form = new Form2();
                        this.Hide();
                        form.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("Невірне ім’я користувача або пароль.");
                    }
                }
                else
                {
                    MessageBox.Show("База користувачів не знайдена.");
                }
            }
            else
            {
                MessageBox.Show("Підтвердіть, що ви не робот.");
            }
        }


        private void CreateLogin_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            this.Hide();
            form.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
