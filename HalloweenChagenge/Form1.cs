using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HalloweenChagenge
{
    public partial class Form1 : Form
    {
        Boolean existsForm2 = false;
        Form2 form2 = null;
        private string connectionString = "Server=localhost;Port=8080;Database=sakila;Uid=client;Pwd=3cr3t3t;";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void FilmButton_Click(object sender, EventArgs e)
        {
            string sql = null;
            List<Film> films = new List<Film>();
            MySqlConnection connection = new MySqlConnection(connectionString);
            if (!FilmWordCheckBox.Checked)
            {
                
                sql = $"SELECT title from film" +
                    $" WHERE title LIKE '%{FilmTextBox.Text}%'";
                
            }
            else
            {
                sql = $"SELECT title from film" +
                    $" WHERE title LIKE '{FilmTextBox.Text}'" +
                    $" or title LIKE '{FilmTextBox.Text} %'" +
                    $" or title LIKE '% {FilmTextBox.Text}'" +
                    $" or title LIKE '% {FilmTextBox.Text} %'";
            }
            films = connection.Query<Film>(sql).ToList();

            FilmsListBox.DataSource = films;
            FilmsListBox.DisplayMember = "FullInfo";
            FilmsFoundLabel.Text = $"{films.Count} records found";
            connection.Close();
        }

        private void FilmWordCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FilmsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!existsForm2)
            {
                form2 = new Form2(FilmsListBox.SelectedItem.ToString());
                form2.Show();
                
                form2.Location = new Point(this.Location.X + this.Size.Width + 12, this.Location.Y);
                existsForm2 = true;
            }
            form2?.Show();
        }
    }
}
