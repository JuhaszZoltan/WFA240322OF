using MySql.Data.MySqlClient;
using Mysqlx.Crud;

namespace WFA240322OF
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Load += MainForm_Load;
            btnDelete.Click += BtnDelete_Click;
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            if (dgvMain.SelectedRows.Count != 1) return;

            var res = MessageBox.Show(
                caption: "DELETE WARNING!",
                text: "R U sure!????",
                icon: MessageBoxIcon.Warning,
                buttons: MessageBoxButtons.YesNo);

            if (res != DialogResult.Yes) return;

            using MySqlConnection connection = new(Program.connectionString);
            connection.Open();

            MySqlDataAdapter adapter = new()
            {
                DeleteCommand = new("DELETE FROM Movies " +
                $"WHERE ID = {dgvMain.SelectedRows[0].Cells[0].Value};",
                connection),
            };
            adapter.DeleteCommand.ExecuteNonQuery();

            MainForm_Load(null, null);
        }

        private void MainForm_Load(object? sender, EventArgs e)
        {
            using MySqlConnection connection = new(Program.connectionString);
            connection.Open();

            MySqlCommand command = new(
                "SELECT Movies.ID, Movies.Title, Movies.ReleaseDate, Genres.Name " +
                "FROM Movies INNER JOIN Genres ON Movies.GenreID = Genres.ID " +
                "ORDER BY Title ASC;", connection);

            MySqlDataReader reader = command.ExecuteReader();

            dgvMain.Rows.Clear();

            while (reader.Read())
            {
                dgvMain.Rows.Add(reader[0], reader[1], reader[2], reader[3]);
            }

            dgvMain.ClearSelection();
        }
    }
}
