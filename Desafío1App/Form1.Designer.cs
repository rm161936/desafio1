namespace Desafío1App
{
    partial class WelcomeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.WelcomeFormPanel = new System.Windows.Forms.Panel();
            this.LblPoweredBy = new System.Windows.Forms.Label();
            this.LblWelcomeFormMsg = new System.Windows.Forms.Label();
            this.CountDownWelcome = new System.Windows.Forms.Timer(this.components);
            this.WelcomeFormPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // WelcomeFormPanel
            // 
            this.WelcomeFormPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(172)))));
            this.WelcomeFormPanel.Controls.Add(this.LblPoweredBy);
            this.WelcomeFormPanel.Controls.Add(this.LblWelcomeFormMsg);
            this.WelcomeFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WelcomeFormPanel.Location = new System.Drawing.Point(0, 0);
            this.WelcomeFormPanel.Name = "WelcomeFormPanel";
            this.WelcomeFormPanel.Size = new System.Drawing.Size(400, 250);
            this.WelcomeFormPanel.TabIndex = 0;
            // 
            // LblPoweredBy
            // 
            this.LblPoweredBy.AutoSize = true;
            this.LblPoweredBy.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblPoweredBy.ForeColor = System.Drawing.Color.White;
            this.LblPoweredBy.Location = new System.Drawing.Point(192, 148);
            this.LblPoweredBy.Name = "LblPoweredBy";
            this.LblPoweredBy.Size = new System.Drawing.Size(138, 21);
            this.LblPoweredBy.TabIndex = 1;
            this.LblPoweredBy.Text = "Powered by UDB";
            // 
            // LblWelcomeFormMsg
            // 
            this.LblWelcomeFormMsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblWelcomeFormMsg.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblWelcomeFormMsg.ForeColor = System.Drawing.Color.White;
            this.LblWelcomeFormMsg.Location = new System.Drawing.Point(0, 0);
            this.LblWelcomeFormMsg.Name = "LblWelcomeFormMsg";
            this.LblWelcomeFormMsg.Size = new System.Drawing.Size(400, 250);
            this.LblWelcomeFormMsg.TabIndex = 0;
            this.LblWelcomeFormMsg.Text = "Bienvenido";
            this.LblWelcomeFormMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CountDownWelcome
            // 
            this.CountDownWelcome.Tick += new System.EventHandler(this.CountDownWelcome_Tick);
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.WelcomeFormPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WelcomeForm";
            this.Load += new System.EventHandler(this.WelcomeForm_Load);
            this.WelcomeFormPanel.ResumeLayout(false);
            this.WelcomeFormPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel WelcomeFormPanel;
        private Label LblWelcomeFormMsg;
        private Label LblPoweredBy;
        private System.Windows.Forms.Timer CountDownWelcome;
    }
}