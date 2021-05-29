
namespace clientDevice
{
    partial class GameSettingDetails
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
            this.GameDetail = new System.Windows.Forms.Label();
            this.reject = new System.Windows.Forms.Button();
            this.accept = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GameDetail
            // 
            this.GameDetail.Font = new System.Drawing.Font("Tahoma", 14F);
            this.GameDetail.Location = new System.Drawing.Point(26, 69);
            this.GameDetail.Name = "GameDetail";
            this.GameDetail.Size = new System.Drawing.Size(247, 178);
            this.GameDetail.TabIndex = 6;
            this.GameDetail.Click += new System.EventHandler(this.GameDetail_Click);
            // 
            // reject
            // 
            this.reject.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reject.Location = new System.Drawing.Point(179, 370);
            this.reject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reject.Name = "reject";
            this.reject.Size = new System.Drawing.Size(106, 39);
            this.reject.TabIndex = 5;
            this.reject.Text = "Reject";
            this.reject.UseVisualStyleBackColor = true;
            this.reject.Click += new System.EventHandler(this.reject_Click_1);
            // 
            // accept
            // 
            this.accept.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accept.Location = new System.Drawing.Point(40, 370);
            this.accept.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.accept.Name = "accept";
            this.accept.Size = new System.Drawing.Size(105, 39);
            this.accept.TabIndex = 4;
            this.accept.Text = "Accept";
            this.accept.UseVisualStyleBackColor = true;
            this.accept.Click += new System.EventHandler(this.accept_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GameDetail);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 281);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Game Setting Details";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // GameSettingDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(359, 499);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reject);
            this.Controls.Add(this.accept);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GameSettingDetails";
            this.Text = "GameSettingDetails";
            this.Load += new System.EventHandler(this.GameSettingDetails_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label GameDetail;
        private System.Windows.Forms.Button reject;
        private System.Windows.Forms.Button accept;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}