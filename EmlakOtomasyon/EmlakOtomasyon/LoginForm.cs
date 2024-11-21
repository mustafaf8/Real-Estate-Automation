namespace EmlakOtomasyon
   
{
    public partial class Login : Form
    {
        public class User
        {
            public string name;
            public string password;

            public User(string name, string password)
            {
                this.name = name;
                this.password = password;
            }
        }

        private const string yol = "Users.txt";
        private string kullanicilar = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, yol);

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // Login button
        {
            if (PasswordControl())
            {
                HomeForm homeForm = new HomeForm();
                homeForm.Show();
                this.Hide();
            }
            else
            {
                label4.Visible = true; 
            }
        }

        private void button2_Click(object sender, EventArgs e) // Sign Up button
        {
            if (!UserExists(name.Text))
            {
                SignUp();
                MessageBox.Show("Kullanıcı başarıyla kaydedildi!");
            }
            else
            {
                MessageBox.Show("Bu kullanıcı zaten mevcut!");
            }
        }

        public bool PasswordControl()
        {
            List<User> users = ReadUsersFromFile();
            foreach (var user in users)
            {
                if (user.name == name.Text && user.password == password.Text)
                {
                    return true;
                }
            }
            return false;
        }

        public bool UserExists(string userName)
        {
            List<User> users = ReadUsersFromFile();
            foreach (var user in users)
            {
                if (user.name == userName)
                {
                    return true;
                }
            }
            return false;
        }

        public void UsersVarMi()
        {
            if (!File.Exists(kullanicilar))
            {
                File.Create(kullanicilar).Close();
            }
        }

        public List<User> ReadUsersFromFile()
        {
            List<User> userList = new List<User>();

            using (StreamReader reader = new StreamReader(kullanicilar))
            {
                string satir;
                while ((satir = reader.ReadLine()) != null)
                {
                    string[] split = satir.Split(',');
                    if (split.Length == 2)
                    {
                        User user = new User(split[0], split[1]);
                        userList.Add(user);
                    }
                }
            }
            return userList;
        }

        private void SignUp()
        {
            using (StreamWriter writer = new StreamWriter(kullanicilar, true))
            {
                writer.WriteLine($"{name.Text},{password.Text}");
            }
        }

        private void Giriş_Load(object sender, EventArgs e)
        {
            UsersVarMi();
        }
    }
}
