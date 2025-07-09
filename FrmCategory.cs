using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project10_PostgreSQLToDoListApp
{
    public partial class FrmCategory: Form
    {
        public FrmCategory()
        {
            InitializeComponent();
        }
        string connectionString = ("Server=localhost;port=5432;Database=DbProject10ToDoApp;user Id=postgres;Password=Gunes123");
        private void FrmCategory_Load(object sender, EventArgs e)
        {
            var conn = new NpgsqlConnection(connectionString);
            conn.Open();
            string query = "Select * From categories";
            var command = new NpgsqlCommand(query, conn);
            var adapter = new NpgsqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DGVCategory.DataSource = dt;
        }
    }
}
