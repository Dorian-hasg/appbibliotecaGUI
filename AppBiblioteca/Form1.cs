using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Biblioteca
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }


    public class DatabaseController
    {
        private static SQLiteConnection connection;

        public static SQLiteConnection GetConnection()
        {
            if (connection == null)
            {
                connection = new SQLiteConnection("Data Source=library.db;Version=3;");
            }
            return connection;
        }

        public static void OpenConnection()
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
        }

        public static void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
        }
    }


    public class MainForm : Form
    {
        private Button btnLibros;

        public MainForm()
        {
            Text = "Sistema de Biblioteca";
            Width = 400;
            Height = 200;

            btnLibros = new Button { Text = "Gestionar Libros", Width = 150, Height = 50, Top = 50, Left = 100 };
            btnLibros.Click += (sender, e) => new LibrosForm().ShowDialog();

            Controls.Add(btnLibros);
        }
    }


    public class LibrosForm : Form
    {
        private DataGridView dataGridViewLibros;
        private TextBox txtISBN, txtTitulo, txtAutor, txtEditorial, txtAño, txtGenero, txtCopias;
        private Button btnAgregar;

        public LibrosForm()
        {
            Text = "Gestión de Libros";
            Width = 800;
            Height = 600;

            dataGridViewLibros = new DataGridView { Top = 10, Left = 10, Width = 760, Height = 300 };
            Controls.Add(dataGridViewLibros);

            txtISBN = CrearTextBox("ISBN", 320);
            txtTitulo = CrearTextBox("Título", 360);
            txtAutor = CrearTextBox("Autor", 400);
            txtEditorial = CrearTextBox("Editorial", 440);
            txtAño = CrearTextBox("Año Publicación", 480);
            txtGenero = CrearTextBox("Género", 520);
            txtCopias = CrearTextBox("Copias", 560);


            btnAgregar = new Button { Text = "Agregar Libro", Top = 560, Left = 400, Width = 150 };
            btnAgregar.Click += BtnAgregar_Click;
            Controls.Add(btnAgregar);

            CargarLibros();
        }

        private TextBox CrearTextBox(string placeholder, int top)
        {
            var label = new Label { Text = placeholder, Top = top, Left = 10 };
            var textBox = new TextBox { Top = top, Left = 150, Width = 200 };
            Controls.Add(label);
            Controls.Add(textBox);
            return textBox;
        }

        private void CargarLibros()
        {
            using (var conn = DatabaseController.GetConnection())
            {
                DatabaseController.OpenConnection();
                var command = new SQLiteCommand("SELECT * FROM Libros", conn);
                var adapter = new SQLiteDataAdapter(command);
                var dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewLibros.DataSource = dt;
                DatabaseController.CloseConnection();
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            using (var conn = DatabaseController.GetConnection())
            {
                DatabaseController.OpenConnection();
                var command = new SQLiteCommand(
                    "INSERT INTO Libros (ISBN, Titulo, Autor, Editorial, AñoPublicacion, Genero, CopiasDisponibles) " +
                    "VALUES (@ISBN, @Titulo, @Autor, @Editorial, @AñoPublicacion, @Genero, @CopiasDisponibles)", conn);

                command.Parameters.AddWithValue("@ISBN", txtISBN.Text);
                command.Parameters.AddWithValue("@Titulo", txtTitulo.Text);
                command.Parameters.AddWithValue("@Autor", txtAutor.Text);
                command.Parameters.AddWithValue("@Editorial", txtEditorial.Text);
                command.Parameters.AddWithValue("@AñoPublicacion", int.Parse(txtAño.Text));
                command.Parameters.AddWithValue("@Genero", txtGenero.Text);
                command.Parameters.AddWithValue("@CopiasDisponibles", int.Parse(txtCopias.Text));

                command.ExecuteNonQuery();
                DatabaseController.CloseConnection();
                CargarLibros();
            }
        }
    }
}
