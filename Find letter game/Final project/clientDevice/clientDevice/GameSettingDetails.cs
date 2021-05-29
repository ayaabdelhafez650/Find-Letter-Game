using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clientDevice
{
    public partial class GameSettingDetails : Form
    {
      
        Client cs;
        
        public GameSettingDetails(Client c)
        {
            InitializeComponent();
            cs = c;
        }
        public GameSettingDetails()
        {

            InitializeComponent();
        }

     

      

       

  

        private void GameSettingDetails_Load_1(object sender, EventArgs e)
        {
            GameDetail.Text = $"Game Name: {cs.gameName}\n Game Level :{ cs.gameLevel}";
        }

      

        private void reject_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void accept_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            //GameInterface gintr = new GameInterface();
            //gintr.Show();
            this.Close();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void GameDetail_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
