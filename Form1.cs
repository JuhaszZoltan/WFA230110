using MySql.Data.MySqlClient;

namespace WFA230110
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnColorChange.Click += OnBtnColorChangeClick;
            btnAuth.Click += OnBtnAuthClick;
        }

        private void OnBtnAuthClick(object? sender, EventArgs e)
        {
            string connectionStrng =
                "Server=linsql.verebely.dc;" +
                $"Database={tbUserName.Text};" +
                $"Uid={tbUserName.Text};" +
                $"Pwd={tbPassword.Text};";

            using MySqlConnection connection = new(connectionStrng);
            connection.Open();
            MySqlDataReader reader = new MySqlCommand(
                cmdText: "SELECT * FROM csharpExample;",
                connection).ExecuteReader();
            while (reader.Read())
            {
                dgv.Rows.Add(
                    reader[0],
                    reader[1],
                    reader.GetDateTime(2).ToString("yyyy-MM-dd"));
            }
        }

        private void OnBtnColorChangeClick(object? sender, EventArgs e)
        {
            _ = new FrmColorChanger(pb).ShowDialog();
        }
    }
}