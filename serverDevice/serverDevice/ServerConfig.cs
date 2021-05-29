using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace serverDevice
{
    public partial class ServerConfig : Form
    {
       string _ARbtn;
        public string _ARSelectedWord;
       public string getword;
        public string  _ARLevel,  _ARcategory; 
        public ServerConfig()
        {
            InitializeComponent();
        }

        private void easyy_Click(object sender, EventArgs e)
        {
            _ARLevel = easyy.Text;
            string select = "select top(1)Word From Words Where Difficulty='" + easyy.Text + "' and Category='" + _ARbtn + "' order by newid()";
            sqlCommand1.CommandText = select;
            SqlDataReader dReader;
            sqlConnection1.Open();
            dReader = sqlCommand1.ExecuteReader();
            DataTable dTable = new DataTable();
            dTable.Load(dReader);
            _ARSelectedWord = Convert.ToString(dTable.Rows[0].ItemArray[0]);
           // MessageBox.Show(_ARSelectedWord);
            dReader.Close();
            sqlConnection1.Close();
        }

        private void mediumm_Click(object sender, EventArgs e)
        {
            _ARLevel = mediumm.Text;
            string select = "select top(1)Word From Words Where Difficulty='" + mediumm.Text + "' and Category='" + _ARbtn + "' order by newid()";
            sqlCommand1.CommandText = select;
            SqlDataReader dReader;
            sqlConnection1.Open();
            dReader = sqlCommand1.ExecuteReader();
            DataTable dTable = new DataTable();
            dTable.Load(dReader);
            _ARSelectedWord = Convert.ToString(dTable.Rows[0].ItemArray[0]);
           //MessageBox.Show(_ARSelectedWord);
            dReader.Close();
            sqlConnection1.Close();
        }

        private void hardd_Click(object sender, EventArgs e)
        {
            _ARLevel = hardd.Text;
            string select = "select top(1)Word From Words Where Difficulty='" + hardd.Text + "' and Category='" + _ARbtn + "' order by newid()";
            sqlCommand1.CommandText = select;
            SqlDataReader dReader;
            sqlConnection1.Open();
            dReader = sqlCommand1.ExecuteReader();
            DataTable dTable = new DataTable();
            dTable.Load(dReader);
            _ARSelectedWord = Convert.ToString(dTable.Rows[0].ItemArray[0]);
           // MessageBox.Show(_ARSelectedWord);
            dReader.Close();
            sqlConnection1.Close();
        }

        private void game_Click(object sender, EventArgs e)
        {
            _ARcategory = game.Text;
            string select = "select * From Words Where Category ='" + game.Text + "'";
            _ARbtn = game.Text;
           /// MessageBox.Show(_ARbtn);
            sqlCommand1.CommandText = select;
            SqlDataReader dReader;
            sqlConnection1.Open();
            dReader = sqlCommand1.ExecuteReader();
            DataTable dTable = new DataTable();
            dTable.Load(dReader);
            dReader.Close();
            sqlConnection1.Close();


            game.Visible = false;
            animals.Visible = false;
            computerr.Visible = false;
            easyy.Visible = true;
            mediumm.Visible = true;
            hardd.Visible = true;
            label2.Visible = true;
            label3.Visible = false;
        }

        private void animals_Click(object sender, EventArgs e)
        {
            _ARcategory = animals.Text;
            string select = "select * From Words Where Category ='" + animals.Text + "'";
           _ARbtn = animals.Text;
            sqlCommand1.CommandText = select;
            SqlDataReader dReader;
            sqlConnection1.Open();
            dReader = sqlCommand1.ExecuteReader();
            DataTable dTable = new DataTable();
            dTable.Load(dReader);
            dReader.Close();
            sqlConnection1.Close();

            game.Visible = false;
            animals.Visible = false;
            computerr.Visible = false;
            easyy.Visible = true;
            mediumm.Visible = true;
            hardd.Visible = true;
            label2.Visible = true;
            label3.Visible = false;
        }

        private void computerr_Click(object sender, EventArgs e)
        {
            _ARcategory = computerr.Text;
            string select = "select * From Words Where Category ='" + computerr.Text + "'";
            _ARbtn = computerr.Text;
            sqlCommand1.CommandText = select;
            SqlDataReader dReader;
            sqlConnection1.Open();
            dReader = sqlCommand1.ExecuteReader();
            DataTable dTable = new DataTable();
            dTable.Load(dReader);
            dReader.Close();
            sqlConnection1.Close();

            game.Visible = false;
            animals.Visible = false;
            computerr.Visible = false;
            easyy.Visible = true;
            mediumm.Visible = true;
            hardd.Visible = true;
            label2.Visible = true;
            label3.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ServerConfig_Load(object sender, EventArgs e)
        {

        }

        private void startGame_Click(object sender, EventArgs e)
        {
            

            getword = _ARSelectedWord;
            this.Hide();
            //SecretWords frm = new SecretWords();
           
            
        }
    }
}
