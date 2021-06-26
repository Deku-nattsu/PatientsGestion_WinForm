
namespace WindowsFormsApp4
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_password1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_showpass1 = new System.Windows.Forms.Button();
            this.btn_showpass = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(22, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mot de pass:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(65, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Email:";
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(117, 235);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(249, 27);
            this.txt_password.TabIndex = 10;
            this.txt_password.UseSystemPasswordChar = true;
            this.txt_password.TextChanged += new System.EventHandler(this.txt_password_TextChanged);
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(117, 199);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(249, 27);
            this.txt_email.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(22, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Confirmation";
            // 
            // txt_password1
            // 
            this.txt_password1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password1.Location = new System.Drawing.Point(117, 268);
            this.txt_password1.Name = "txt_password1";
            this.txt_password1.PasswordChar = '*';
            this.txt_password1.Size = new System.Drawing.Size(249, 27);
            this.txt_password1.TabIndex = 14;
            this.txt_password1.UseSystemPasswordChar = true;
            this.txt_password1.TextChanged += new System.EventHandler(this.txt_password1_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(93)))), ((int)(((byte)(141)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Snow;
            this.button2.Location = new System.Drawing.Point(157, 301);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 50);
            this.button2.TabIndex = 17;
            this.button2.Text = "S\'INSCRIRE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.www1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(139, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 150);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // btn_showpass1
            // 
            this.btn_showpass1.BackColor = System.Drawing.Color.White;
            this.btn_showpass1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_showpass1.BackgroundImage")));
            this.btn_showpass1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_showpass1.FlatAppearance.BorderSize = 0;
            this.btn_showpass1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_showpass1.Location = new System.Drawing.Point(340, 272);
            this.btn_showpass1.Name = "btn_showpass1";
            this.btn_showpass1.Size = new System.Drawing.Size(22, 20);
            this.btn_showpass1.TabIndex = 16;
            this.btn_showpass1.UseVisualStyleBackColor = false;
            this.btn_showpass1.Visible = false;
            this.btn_showpass1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_showpass1_MouseDown);
            this.btn_showpass1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_showpass1_MouseUp);
            // 
            // btn_showpass
            // 
            this.btn_showpass.BackColor = System.Drawing.Color.White;
            this.btn_showpass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_showpass.BackgroundImage")));
            this.btn_showpass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_showpass.FlatAppearance.BorderSize = 0;
            this.btn_showpass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_showpass.Location = new System.Drawing.Point(340, 239);
            this.btn_showpass.Name = "btn_showpass";
            this.btn_showpass.Size = new System.Drawing.Size(22, 20);
            this.btn_showpass.TabIndex = 13;
            this.btn_showpass.UseVisualStyleBackColor = false;
            this.btn_showpass.Visible = false;
            this.btn_showpass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_showpass_MouseDown);
            this.btn_showpass.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_showpass_MouseUp);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 383);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_showpass1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_password1);
            this.Controls.Add(this.btn_showpass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_email);
            this.Name = "Form7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form7";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_showpass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Button btn_showpass1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_password1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}