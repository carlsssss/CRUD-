namespace ACT_1C_CRUD_CMC
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            txtUsername = new TextBox();
            label3 = new Label();
            txtPassword = new TextBox();
            btnSignIn = new Button();
            chbShowPassword = new CheckBox();
            label4 = new Label();
            LinkSignUp = new LinkLabel();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(34, 60);
            label1.Name = "label1";
            label1.Size = new Size(126, 32);
            label1.TabIndex = 0;
            label1.Text = "Sign In ";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(194, 106);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(137, 141);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(110, 264);
            label2.Name = "label2";
            label2.Size = new Size(73, 17);
            label2.TabIndex = 2;
            label2.Text = "Username:";
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Location = new Point(110, 284);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Enter your username";
            txtUsername.Size = new Size(308, 27);
            txtUsername.TabIndex = 3;
            txtUsername.TextAlign = HorizontalAlignment.Center;
            txtUsername.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(110, 331);
            label3.Name = "label3";
            label3.Size = new Size(70, 17);
            label3.TabIndex = 4;
            label3.Text = "Password:";
            label3.Click += label3_Click;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Location = new Point(110, 362);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Enter your password";
            txtPassword.Size = new Size(308, 27);
            txtPassword.TabIndex = 5;
            txtPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = SystemColors.Highlight;
            btnSignIn.FlatStyle = FlatStyle.Popup;
            btnSignIn.Font = new Font("Stencil", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignIn.ForeColor = SystemColors.Control;
            btnSignIn.Location = new Point(110, 415);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(309, 45);
            btnSignIn.TabIndex = 6;
            btnSignIn.Text = "Sign In ";
            btnSignIn.UseVisualStyleBackColor = false;
            // 
            // chbShowPassword
            // 
            chbShowPassword.AutoSize = true;
            chbShowPassword.Location = new Point(110, 479);
            chbShowPassword.Name = "chbShowPassword";
            chbShowPassword.Size = new Size(122, 21);
            chbShowPassword.TabIndex = 7;
            chbShowPassword.Text = "Show password";
            chbShowPassword.UseVisualStyleBackColor = true;
            chbShowPassword.CheckedChanged += chbShowPassword_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F);
            label4.Location = new Point(110, 524);
            label4.Name = "label4";
            label4.Size = new Size(153, 17);
            label4.TabIndex = 8;
            label4.Text = "Don't have any account? ";
            label4.Click += label4_Click;
            // 
            // LinkSignUp
            // 
            LinkSignUp.AutoSize = true;
            LinkSignUp.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LinkSignUp.Location = new Point(259, 524);
            LinkSignUp.Name = "LinkSignUp";
            LinkSignUp.Size = new Size(56, 17);
            LinkSignUp.TabIndex = 9;
            LinkSignUp.TabStop = true;
            LinkSignUp.Text = "Sign Up";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Brown;
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Font = new Font("Stencil", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = SystemColors.ControlText;
            btnClose.Location = new Point(110, 570);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(315, 31);
            btnClose.TabIndex = 10;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(498, 725);
            Controls.Add(btnClose);
            Controls.Add(LinkSignUp);
            Controls.Add(label4);
            Controls.Add(chbShowPassword);
            Controls.Add(btnSignIn);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            ForeColor = SystemColors.Highlight;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox txtUsername;
        private Label label3;
        private TextBox txtPassword;
        private Button btnSignIn;
        private CheckBox chbShowPassword;
        private Label label4;
        private LinkLabel LinkSignUp;
        private Button btnClose;
    }
}
