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
using Dapper;

namespace HalloweenChagenge
{
   
    public partial class Form2 : Form
    {
        private string connectionString = "Server=localhost;Port=8080;Database=sakila;Uid=client;Pwd=3cr3t3t;";
        private string a;
        public Form2(string a)
        {
            InitializeComponent();
            this.a = a;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            List<Film> films = new List<Film>();
            MySqlConnection connection = new MySqlConnection(connectionString);
            string title = $"select title from film where title like '{a}'";
            films = connection.Query<Film>(title).ToList();
            
            string description = $"select description from film where title like '{a}'";
            FilmDescription.Text = connection.Query<Film>(description).ToString();

            string minutes = $"select length from film where title like '{a}'";
            Minutes.Text = connection.Query<Film>(minutes).ToString() + "'";

            string rating = $"select rating from film where title like '{a}'";
            FilmRating.Text = connection.Query<Film>(rating).ToString();
        }
    }
}
