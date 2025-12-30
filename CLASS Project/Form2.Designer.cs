namespace CLASS_Project
{
    partial class Form2
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
            Usertxt = new TextBox();
            Passtxt = new TextBox();
            User = new Label();
            SignInB = new Button();
            Pass = new Label();
            SuspendLayout();
            // 
            // Usertxt
            // 
            Usertxt.Location = new Point(134, 32);
            Usertxt.Name = "Usertxt";
            Usertxt.Size = new Size(154, 23);
            Usertxt.TabIndex = 0;
            // 
            // Passtxt
            // 
            Passtxt.Location = new Point(134, 61);
            Passtxt.Name = "Passtxt";
            Passtxt.Size = new Size(154, 23);
            Passtxt.TabIndex = 1;
            // 
            // User
            // 
            User.AutoSize = true;
            User.Location = new Point(65, 35);
            User.Name = "User";
            User.Size = new Size(63, 15);
            User.TabIndex = 2;
            User.Text = "Username:";
            // 
            // SignInB
            // 
            SignInB.Location = new Point(157, 101);
            SignInB.Name = "SignInB";
            SignInB.Size = new Size(75, 23);
            SignInB.TabIndex = 3;
            SignInB.Text = "Sign In";
            SignInB.UseVisualStyleBackColor = true;
            SignInB.Click += SignInB_Click;
            // 
            // Pass
            // 
            Pass.AutoSize = true;
            Pass.Location = new Point(68, 67);
            Pass.Name = "Pass";
            Pass.Size = new Size(60, 15);
            Pass.TabIndex = 4;
            Pass.Text = "Password:";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(373, 149);
            Controls.Add(Pass);
            Controls.Add(SignInB);
            Controls.Add(User);
            Controls.Add(Passtxt);
            Controls.Add(Usertxt);
            Name = "Form2";
            Text = "Sign In";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Usertxt;
        private TextBox Passtxt;
        private Label User;
        private Button SignInB;
        private Label Pass;
    }
}