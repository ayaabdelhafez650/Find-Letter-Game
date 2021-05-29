using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clientDevice
{
    public partial class Client : Form
    {
        TcpClient _ASclient;
        NetworkStream _ASstream;
        BinaryWriter _ASbr;
     int   _ASf=1;
        int num;
        string s;
        public string gameNamep;
        string gameLevelp;
        string gameWordp;
        string _BCopyCurrentWord = "";
        string _BcurrentWord = "";


        public Client()
        {
            InitializeComponent();
        

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void mtry()
        {
            if (InvokeRequired)
                
                {
                
                    this.Invoke(new MethodInvoker(delegate

                    {
                        _ASconnect.Visible = false;
                        _ASdisconnect.Visible = false;
                        lblshowWord.Visible = true;
                        btnA.Visible = true;
                        btnB.Visible = true;
                        button3.Visible = true;
                        button4.Visible = true;
                        button5.Visible = true;
                        button6.Visible = true;
                        button7.Visible = true;
                        button8.Visible = true;
                        button9.Visible = true;
                        button10.Visible = true;
                        button11.Visible = true;
                        button12.Visible = true;
                        button13.Visible = true;
                        button14.Visible = true;
                        button15.Visible = true;
                        button16.Visible = true;
                        button17.Visible = true;
                        button18.Visible = true;
                        button19.Visible = true;
                        button20.Visible = true;
                        button21.Visible = true;
                        button22.Visible = true;
                        button23.Visible = true;
                        button24.Visible = true;
                        button26.Visible = true;
                        button2.Visible = true;
                        _BPrepareWordInDashLine();

                    }));
                
                }
            
                else
                
                {
                
                     

                }

           
        }
        public void _ASclientserverthread()
        {
            do
            {
                _ASstream = _ASclient.GetStream();
                BinaryReader br = new BinaryReader(_ASstream);
                s = br.ReadString();

                if (s == "1")
                {
                 MessageBox.Show("CYou lose");

                }
                else if (Regex.IsMatch(s, @"^[a-zA-Z]+$"))
                {
                    if (InvokeRequired)

                    {
                        this.Invoke(new MethodInvoker(delegate

                        {

                            foreach (Control b in this.Controls)
                            {
                                if (b.Text == s)
                                {
                                    b.Visible = false;
                                    foreach (Control f in this.Controls)
                                    {
                                        if (f.Text == s)
                                        {
                                            f.Enabled = true;
                                        }
                                    }
                                }
                            }

                        }));
                    }
                }
                else if (s == "7")
                {
                    foreach (Control b in this.Controls)
                    {

                        b.Enabled = true;

                    }
                }
                else if (s.Length>=3 &&s.Length<=6)
                {
                    _BCopyCurrentWord = s;
                    _BDisplayWordInDashLine();


                }
             
                else
                {
                    if (s.Length >= 9)
                    {
                        if (InvokeRequired)

                        {
                            this.Invoke(new MethodInvoker(delegate

                            {
                                GameSettingDetails gd = new GameSettingDetails(this);
                                splitStream(s);
                                DialogResult dialogResult;
                                dialogResult = gd.ShowDialog();


                                if (dialogResult == DialogResult.OK)
                                {
                                    Thread thread = new Thread(new ThreadStart(mtry));
                                    thread.IsBackground = true;
                                    thread.Start();
                                    foreach (Control b in this.Controls)
                                    {
                                        if (b.Text == s)
                                        {
                                            b.Visible = false;
                                        }
                                    }
                                    foreach (Control i in this.Controls)
                                    {
                                        i.Enabled = false;
                                    }
                                    _idmessage("18");
                                }

                                else
                                {
                                    _idmessage("4");


                                }
                            }));
                        }
                    }
                }
            }
            while (_ASf == 1);

        }
    
    private void _ASconnect_Click(object sender, EventArgs e)
        {
            try
            {
                _ASclient = new TcpClient();
                byte[] _ASbt = new byte[] { 127, 0, 0, 1 };
                IPAddress _ASip = new IPAddress(_ASbt);
                _ASclient.Connect(_ASip, 1025);
                _ASstream = _ASclient.GetStream();
                MessageBox.Show("client connection start");
            }

            catch (Exception)
            {
                MessageBox.Show("no server connection");
            }
            
                Thread _ASreceivethread = new Thread(new ThreadStart(_ASclientserverthread));
                _ASreceivethread.IsBackground = true;
                _ASreceivethread.Start();
           

          
        }

        private void _ASdisconnect_Click(object sender, EventArgs e)
        {
            try
            {
               
                _ASstream.Close();
                MessageBox.Show("Connection End");
                _ASf = 0;
            }
            catch (Exception)
            {

                MessageBox.Show("some thing wrong");
            }
        }
        private void _idmessage(string s)
        {
            try
            {
                _ASbr = new BinaryWriter(_ASstream);
                _ASbr.Write(s);
            }
            catch (Exception)
            {

                MessageBox.Show("something went wrong");
            }
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            _idmessage("1");

        }
        public string gameName
        {
            get { return gameNamep; }
            set
            {
                gameNamep = value;
            }
        }
        public string gameLevel
        {
            get { return gameLevelp; }
            set
            {
                gameLevelp = value;
            }
        }
        public string gameWord
        {
            get { return gameWord; }
            set
            {
                gameWord = value;
            }
        }
        public void splitStream(string str)
        {
            string[] words = str.Split(',');
            num = int.Parse(words[0]);
            gameNamep = words[1];
            gameLevelp = words[2];
            gameWordp = words[3];

        }
        private void _BPrepareWordInDashLine()
        {
            gameWordp = gameWordp.Replace(" ", "").ToUpper();
            _BCopyCurrentWord = "";
            for (int i = 0; i < gameWordp.Length; i++)
            {
                _BCopyCurrentWord += "_";
            }
            _BDisplayWordInDashLine();


        }
        private void _BDisplayWordInDashLine()
        {
            lblshowWord.Text = "";

            for (int i = 0; i < _BCopyCurrentWord.Length; i++)
            {

                lblshowWord.Text += _BCopyCurrentWord.Substring(i, 1);
                lblshowWord.Text += " ";
            }

        }

        

        private void btnGuess_Click(object sender, EventArgs e)
        {
            
            Button btnChoise = sender as Button;
           
            btnChoise.Enabled = false;
            if (gameWordp.Contains(btnChoise.Text))
            {
               
                char[] _BTemp = _BCopyCurrentWord.ToCharArray();
             
                char[] _Bfind = gameWordp.ToCharArray();
              
                char _BGussChar = btnChoise.Text.ElementAt(0);
                for (int i = 0; i < _Bfind.Length; i++)
                {
                    if (_Bfind[i] == _BGussChar)
                    {
                        _BTemp[i] = _BGussChar;
                    }
                }
                
                _BCopyCurrentWord = new string(_BTemp);
                _BDisplayWordInDashLine();
                btnChoise.Visible = false;
                _idmessage(_BCopyCurrentWord);
                _idmessage(btnChoise.Text);
                if (_BCopyCurrentWord == gameWordp)
                {

                    MessageBox.Show("Ccongratulation\nYou Win");
                    _idmessage("1");
                }

            }
            else
           {
                _idmessage(btnChoise.Text);
                
                btnChoise.Visible = false;
                foreach (Control b in this.Controls)
                {

                    b.Enabled = false;

                }
                _idmessage("7");


            }
   

        }
       private void buttonmessage()
        {
            this.Enabled = false;
            this.Enabled = true;
        }
        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
           
        }

        private void lblshowWord_Click(object sender, EventArgs e)
        {

        }
    }
}
