
namespace serverDevice
{
    partial class Server
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Server));
            this._ASstart = new System.Windows.Forms.Button();
            this._AScolose = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.label1 = new System.Windows.Forms.Label();
            this.lblshowWord = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _ASstart
            // 
            this._ASstart.BackColor = System.Drawing.Color.DarkSlateBlue;
            this._ASstart.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this._ASstart.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this._ASstart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateBlue;
            this._ASstart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this._ASstart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ASstart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ASstart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this._ASstart.Location = new System.Drawing.Point(400, 320);
            this._ASstart.Name = "_ASstart";
            this._ASstart.Size = new System.Drawing.Size(565, 51);
            this._ASstart.TabIndex = 0;
            this._ASstart.Text = "Start Connection";
            this._ASstart.UseVisualStyleBackColor = false;
            this._ASstart.Click += new System.EventHandler(this._ASstart_Click);
            // 
            // _AScolose
            // 
            this._AScolose.BackColor = System.Drawing.Color.DarkSlateBlue;
            this._AScolose.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this._AScolose.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this._AScolose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateBlue;
            this._AScolose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this._AScolose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._AScolose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._AScolose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this._AScolose.Location = new System.Drawing.Point(400, 377);
            this._AScolose.Name = "_AScolose";
            this._AScolose.Size = new System.Drawing.Size(565, 53);
            this._AScolose.TabIndex = 1;
            this._AScolose.Text = "Close Connection";
            this._AScolose.UseVisualStyleBackColor = false;
            this._AScolose.Click += new System.EventHandler(this._AScolose_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateBlue;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(400, 436);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(565, 48);
            this.button2.TabIndex = 4;
            this.button2.Text = "start";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandText = "SELECT        Words.*\r\nFROM            Words";
            this.sqlCommand1.Connection = this.sqlConnection1;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=.;Initial Catalog=\"C# Project\";Integrated Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Location = new System.Drawing.Point(551, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 52);
            this.label1.TabIndex = 5;
            this.label1.Text = "Welcome !";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.btnA_Click_1);
            // 
            // lblshowWord
            // 
            this.lblshowWord.BackColor = System.Drawing.Color.DarkRed;
            this.lblshowWord.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblshowWord.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblshowWord.Location = new System.Drawing.Point(156, 317);
            this.lblshowWord.Name = "lblshowWord";
            this.lblshowWord.Size = new System.Drawing.Size(901, 93);
            this.lblshowWord.TabIndex = 7;
            this.lblshowWord.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblshowWord.Visible = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Maroon;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(210, 58);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 70);
            this.button3.TabIndex = 32;
            this.button3.Text = "C";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.btnA_Click_1);
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.Color.Transparent;
            this.button23.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button23.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.button23.FlatAppearance.BorderSize = 2;
            this.button23.FlatAppearance.CheckedBackColor = System.Drawing.Color.Maroon;
            this.button23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button23.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button23.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button23.Location = new System.Drawing.Point(607, 210);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(70, 70);
            this.button23.TabIndex = 56;
            this.button23.Text = "Y";
            this.button23.UseVisualStyleBackColor = false;
            this.button23.Visible = false;
            this.button23.Click += new System.EventHandler(this.btnA_Click_1);
            // 
            // button24
            // 
            this.button24.BackColor = System.Drawing.Color.Transparent;
            this.button24.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button24.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.button24.FlatAppearance.BorderSize = 2;
            this.button24.FlatAppearance.CheckedBackColor = System.Drawing.Color.Maroon;
            this.button24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button24.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button24.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button24.Location = new System.Drawing.Point(708, 210);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(70, 70);
            this.button24.TabIndex = 55;
            this.button24.Text = "Z";
            this.button24.UseVisualStyleBackColor = false;
            this.button24.Visible = false;
            this.button24.Click += new System.EventHandler(this.btnA_Click_1);
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.Transparent;
            this.button20.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button20.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.button20.FlatAppearance.BorderSize = 2;
            this.button20.FlatAppearance.CheckedBackColor = System.Drawing.Color.Maroon;
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button20.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button20.Location = new System.Drawing.Point(311, 210);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(70, 70);
            this.button20.TabIndex = 53;
            this.button20.Text = "V";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Visible = false;
            this.button20.Click += new System.EventHandler(this.btnA_Click_1);
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.Transparent;
            this.button21.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button21.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.button21.FlatAppearance.BorderSize = 2;
            this.button21.FlatAppearance.CheckedBackColor = System.Drawing.Color.Maroon;
            this.button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button21.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button21.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button21.Location = new System.Drawing.Point(411, 210);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(70, 70);
            this.button21.TabIndex = 52;
            this.button21.Text = "W";
            this.button21.UseVisualStyleBackColor = false;
            this.button21.Visible = false;
            this.button21.Click += new System.EventHandler(this.btnA_Click_1);
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.Transparent;
            this.button22.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button22.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.button22.FlatAppearance.BorderSize = 2;
            this.button22.FlatAppearance.CheckedBackColor = System.Drawing.Color.Maroon;
            this.button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button22.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button22.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button22.Location = new System.Drawing.Point(508, 210);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(70, 70);
            this.button22.TabIndex = 51;
            this.button22.Text = "X";
            this.button22.UseVisualStyleBackColor = false;
            this.button22.Visible = false;
            this.button22.Click += new System.EventHandler(this.btnA_Click_1);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.Transparent;
            this.button17.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button17.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.button17.FlatAppearance.BorderSize = 2;
            this.button17.FlatAppearance.CheckedBackColor = System.Drawing.Color.Maroon;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button17.Location = new System.Drawing.Point(846, 134);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(70, 70);
            this.button17.TabIndex = 50;
            this.button17.Text = "S";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Visible = false;
            this.button17.Click += new System.EventHandler(this.btnA_Click_1);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.Transparent;
            this.button18.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button18.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.button18.FlatAppearance.BorderSize = 2;
            this.button18.FlatAppearance.CheckedBackColor = System.Drawing.Color.Maroon;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button18.Location = new System.Drawing.Point(113, 210);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(70, 70);
            this.button18.TabIndex = 49;
            this.button18.Text = "T";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Visible = false;
            this.button18.Click += new System.EventHandler(this.btnA_Click_1);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.Transparent;
            this.button19.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button19.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.button19.FlatAppearance.BorderSize = 2;
            this.button19.FlatAppearance.CheckedBackColor = System.Drawing.Color.Maroon;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button19.Location = new System.Drawing.Point(210, 210);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(70, 70);
            this.button19.TabIndex = 48;
            this.button19.Text = "U";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Visible = false;
            this.button19.Click += new System.EventHandler(this.btnA_Click_1);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Transparent;
            this.button14.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button14.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.button14.FlatAppearance.BorderSize = 2;
            this.button14.FlatAppearance.CheckedBackColor = System.Drawing.Color.Maroon;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button14.Location = new System.Drawing.Point(564, 134);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(70, 70);
            this.button14.TabIndex = 47;
            this.button14.Text = "P";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Visible = false;
            this.button14.Click += new System.EventHandler(this.btnA_Click_1);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.Transparent;
            this.button15.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button15.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.button15.FlatAppearance.BorderSize = 2;
            this.button15.FlatAppearance.CheckedBackColor = System.Drawing.Color.Maroon;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button15.Location = new System.Drawing.Point(665, 134);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(70, 70);
            this.button15.TabIndex = 46;
            this.button15.Text = "Q";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Visible = false;
            this.button15.Click += new System.EventHandler(this.btnA_Click_1);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.Transparent;
            this.button16.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button16.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.button16.FlatAppearance.BorderSize = 2;
            this.button16.FlatAppearance.CheckedBackColor = System.Drawing.Color.Maroon;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button16.Location = new System.Drawing.Point(752, 134);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(70, 70);
            this.button16.TabIndex = 45;
            this.button16.Text = "R";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Visible = false;
            this.button16.Click += new System.EventHandler(this.btnA_Click_1);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Transparent;
            this.button11.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button11.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.button11.FlatAppearance.BorderSize = 2;
            this.button11.FlatAppearance.CheckedBackColor = System.Drawing.Color.Maroon;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button11.Location = new System.Drawing.Point(259, 134);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(70, 70);
            this.button11.TabIndex = 44;
            this.button11.Text = "M";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Visible = false;
            this.button11.Click += new System.EventHandler(this.btnA_Click_1);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Transparent;
            this.button12.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button12.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.button12.FlatAppearance.BorderSize = 2;
            this.button12.FlatAppearance.CheckedBackColor = System.Drawing.Color.Maroon;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button12.Location = new System.Drawing.Point(357, 134);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(70, 70);
            this.button12.TabIndex = 43;
            this.button12.Text = "N";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Visible = false;
            this.button12.Click += new System.EventHandler(this.btnA_Click_1);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Transparent;
            this.button13.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button13.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.button13.FlatAppearance.BorderSize = 2;
            this.button13.FlatAppearance.CheckedBackColor = System.Drawing.Color.Maroon;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button13.Location = new System.Drawing.Point(462, 134);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(70, 70);
            this.button13.TabIndex = 42;
            this.button13.Text = "O";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Visible = false;
            this.button13.Click += new System.EventHandler(this.btnA_Click_1);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.button8.FlatAppearance.BorderSize = 2;
            this.button8.FlatAppearance.CheckedBackColor = System.Drawing.Color.Maroon;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button8.Location = new System.Drawing.Point(896, 58);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(70, 70);
            this.button8.TabIndex = 41;
            this.button8.Text = "J";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Visible = false;
            this.button8.Click += new System.EventHandler(this.btnA_Click_1);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Transparent;
            this.button9.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button9.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.button9.FlatAppearance.BorderSize = 2;
            this.button9.FlatAppearance.CheckedBackColor = System.Drawing.Color.Maroon;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button9.Location = new System.Drawing.Point(59, 134);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(70, 70);
            this.button9.TabIndex = 40;
            this.button9.Text = "K";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Visible = false;
            this.button9.Click += new System.EventHandler(this.btnA_Click_1);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Transparent;
            this.button10.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button10.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.button10.FlatAppearance.BorderSize = 2;
            this.button10.FlatAppearance.CheckedBackColor = System.Drawing.Color.Maroon;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button10.Location = new System.Drawing.Point(162, 134);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(70, 70);
            this.button10.TabIndex = 39;
            this.button10.Text = "L";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Visible = false;
            this.button10.Click += new System.EventHandler(this.btnA_Click_1);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.button5.FlatAppearance.BorderSize = 2;
            this.button5.FlatAppearance.CheckedBackColor = System.Drawing.Color.Maroon;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(607, 58);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(70, 70);
            this.button5.TabIndex = 38;
            this.button5.Text = "G";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.btnA_Click_1);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.button6.FlatAppearance.BorderSize = 2;
            this.button6.FlatAppearance.CheckedBackColor = System.Drawing.Color.Maroon;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Location = new System.Drawing.Point(708, 58);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(70, 70);
            this.button6.TabIndex = 37;
            this.button6.Text = "H";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Visible = false;
            this.button6.Click += new System.EventHandler(this.btnA_Click_1);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.button7.FlatAppearance.BorderSize = 2;
            this.button7.FlatAppearance.CheckedBackColor = System.Drawing.Color.Maroon;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button7.Location = new System.Drawing.Point(800, 58);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(70, 70);
            this.button7.TabIndex = 36;
            this.button7.Text = "I";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Visible = false;
            this.button7.Click += new System.EventHandler(this.btnA_Click_1);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.button4.FlatAppearance.BorderSize = 2;
            this.button4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Maroon;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(311, 58);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(70, 70);
            this.button4.TabIndex = 35;
            this.button4.Text = "D";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.btnA_Click_1);
            // 
            // button26
            // 
            this.button26.BackColor = System.Drawing.Color.Transparent;
            this.button26.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button26.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.button26.FlatAppearance.BorderSize = 2;
            this.button26.FlatAppearance.CheckedBackColor = System.Drawing.Color.Maroon;
            this.button26.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button26.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button26.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button26.Location = new System.Drawing.Point(411, 58);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(70, 70);
            this.button26.TabIndex = 34;
            this.button26.Text = "E";
            this.button26.UseVisualStyleBackColor = false;
            this.button26.Visible = false;
            this.button26.Click += new System.EventHandler(this.btnA_Click_1);
            // 
            // button27
            // 
            this.button27.BackColor = System.Drawing.Color.Transparent;
            this.button27.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button27.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.button27.FlatAppearance.BorderSize = 2;
            this.button27.FlatAppearance.CheckedBackColor = System.Drawing.Color.Maroon;
            this.button27.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button27.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button27.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button27.Location = new System.Drawing.Point(508, 58);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(70, 70);
            this.button27.TabIndex = 33;
            this.button27.Text = "F";
            this.button27.UseVisualStyleBackColor = false;
            this.button27.Visible = false;
            this.button27.Click += new System.EventHandler(this.btnA_Click_1);
            // 
            // btnB
            // 
            this.btnB.BackColor = System.Drawing.Color.Transparent;
            this.btnB.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnB.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.btnB.FlatAppearance.BorderSize = 2;
            this.btnB.FlatAppearance.CheckedBackColor = System.Drawing.Color.Maroon;
            this.btnB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnB.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnB.Location = new System.Drawing.Point(113, 58);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(70, 70);
            this.btnB.TabIndex = 31;
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = false;
            this.btnB.Visible = false;
            this.btnB.Click += new System.EventHandler(this.btnA_Click_1);
            // 
            // btnA
            // 
            this.btnA.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnA.BackColor = System.Drawing.Color.Transparent;
            this.btnA.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnA.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.btnA.FlatAppearance.BorderSize = 2;
            this.btnA.FlatAppearance.CheckedBackColor = System.Drawing.Color.Maroon;
            this.btnA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnA.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnA.Location = new System.Drawing.Point(14, 58);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(70, 70);
            this.btnA.TabIndex = 30;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = false;
            this.btnA.Visible = false;
            this.btnA.Click += new System.EventHandler(this.btnA_Click_1);
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1300, 549);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.button27);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.lblshowWord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this._AScolose);
            this.Controls.Add(this._ASstart);
            this.Name = "Server";
            this.Text = "Server";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _ASstart;
        private System.Windows.Forms.Button _AScolose;
        private System.Windows.Forms.Button button2;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblshowWord;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnA;
    }
}

