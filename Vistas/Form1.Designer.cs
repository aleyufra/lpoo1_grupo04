namespace Vistas
{
    partial class FrmLogin
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
            this.btnAccept_Click = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.Label();
            this.txtUserPassword = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxUserPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAccept_Click
            // 
            this.btnAccept_Click.Location = new System.Drawing.Point(139, 157);
            this.btnAccept_Click.Name = "btnAccept_Click";
            this.btnAccept_Click.Size = new System.Drawing.Size(75, 23);
            this.btnAccept_Click.TabIndex = 0;
            this.btnAccept_Click.Text = "Aceptar";
            this.btnAccept_Click.UseVisualStyleBackColor = true;
            this.btnAccept_Click.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.AutoSize = true;
            this.txtUserName.Location = new System.Drawing.Point(46, 23);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(43, 13);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.Text = "Usuario";
            this.txtUserName.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.AutoSize = true;
            this.txtUserPassword.Location = new System.Drawing.Point(46, 89);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.Size = new System.Drawing.Size(61, 13);
            this.txtUserPassword.TabIndex = 2;
            this.txtUserPassword.Text = "Contraseña";
            this.txtUserPassword.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(49, 50);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(165, 20);
            this.textBoxUserName.TabIndex = 3;
            this.textBoxUserName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxUserPassword
            // 
            this.textBoxUserPassword.Location = new System.Drawing.Point(49, 116);
            this.textBoxUserPassword.Name = "textBoxUserPassword";
            this.textBoxUserPassword.Size = new System.Drawing.Size(165, 20);
            this.textBoxUserPassword.TabIndex = 4;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 192);
            this.Controls.Add(this.textBoxUserPassword);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.txtUserPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.btnAccept_Click);
            this.Name = "FrmLogin";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAccept_Click;
        private System.Windows.Forms.Label txtUserName;
        private System.Windows.Forms.Label txtUserPassword;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxUserPassword;
    }
}

