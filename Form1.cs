namespace Inventaire
{
    public partial class connexion : Form
    {
        public connexion()
        {
            InitializeComponent();
            
            txt_mdp.PasswordChar = '*';  // The password character is an asterisk.
            txt_mdp.MaxLength = 14;      // The control will allow no more than 14 characters.
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chbox_affichemdp.Checked == false)
                txt_mdp.UseSystemPasswordChar = false;
            else
                txt_mdp.UseSystemPasswordChar = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            txt_mdp.Clear();
            txt_user.Clear();
        }

        private void connexion_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}