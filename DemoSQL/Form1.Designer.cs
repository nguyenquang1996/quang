namespace DemoSQL
{
    partial class Form1
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
            this.server = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.bnttest = new System.Windows.Forms.Button();
            this.database = new System.Windows.Forms.ComboBox();
            this.bntcon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // server
            // 
            this.server.Location = new System.Drawing.Point(91, 29);
            this.server.Name = "server";
            this.server.Size = new System.Drawing.Size(100, 20);
            this.server.TabIndex = 0;
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(91, 85);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(100, 20);
            this.username.TabIndex = 1;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(91, 146);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(100, 20);
            this.password.TabIndex = 2;
            // 
            // bnttest
            // 
            this.bnttest.Location = new System.Drawing.Point(115, 211);
            this.bnttest.Name = "bnttest";
            this.bnttest.Size = new System.Drawing.Size(75, 23);
            this.bnttest.TabIndex = 3;
            this.bnttest.Text = "button1";
            this.bnttest.UseVisualStyleBackColor = true;
            this.bnttest.Click += new System.EventHandler(this.bnttest_Click);
            // 
            // database
            // 
            this.database.FormattingEnabled = true;
            this.database.Location = new System.Drawing.Point(351, 43);
            this.database.Name = "database";
            this.database.Size = new System.Drawing.Size(121, 21);
            this.database.TabIndex = 4;
            // 
            // bntcon
            // 
            this.bntcon.Location = new System.Drawing.Point(491, 210);
            this.bntcon.Name = "bntcon";
            this.bntcon.Size = new System.Drawing.Size(75, 23);
            this.bntcon.TabIndex = 5;
            this.bntcon.Text = "button2";
            this.bntcon.UseVisualStyleBackColor = true;
            this.bntcon.Click += new System.EventHandler(this.bntcon_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 271);
            this.Controls.Add(this.bntcon);
            this.Controls.Add(this.database);
            this.Controls.Add(this.bnttest);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.server);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox server;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button bnttest;
        private System.Windows.Forms.ComboBox database;
        private System.Windows.Forms.Button bntcon;
    }
}

