namespace CLASS_Project
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
            newB = new Button();
            FirstNametxt = new TextBox();
            label1 = new Label();
            LastNametxt = new TextBox();
            Phonetxt = new TextBox();
            IDtxt = new TextBox();
            LastNameL = new Label();
            PhoneL = new Label();
            IDL = new Label();
            SaveB = new Button();
            FindB = new Button();
            DeleteB = new Button();
            Contacts = new DataGridView();
            EditB = new Button();
            ((System.ComponentModel.ISupportInitialize)Contacts).BeginInit();
            SuspendLayout();
            // 
            // newB
            // 
            newB.Font = new Font("Segoe UI", 10F);
            newB.Location = new Point(584, 24);
            newB.Name = "newB";
            newB.Size = new Size(115, 23);
            newB.TabIndex = 0;
            newB.Text = "New";
            newB.UseVisualStyleBackColor = true;
            newB.Click += newB_Click;
            // 
            // FirstNametxt
            // 
            FirstNametxt.Location = new Point(124, 24);
            FirstNametxt.Name = "FirstNametxt";
            FirstNametxt.Size = new Size(434, 23);
            FirstNametxt.TabIndex = 1;
            FirstNametxt.TextChanged += FirstNametxt_TextChanged;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(30, 25);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 2;
            label1.Text = "First Name";
            label1.Click += label1_Click;
            // 
            // LastNametxt
            // 
            LastNametxt.Location = new Point(124, 53);
            LastNametxt.Name = "LastNametxt";
            LastNametxt.Size = new Size(434, 23);
            LastNametxt.TabIndex = 3;
            LastNametxt.TextChanged += textBox1_TextChanged;
            // 
            // Phonetxt
            // 
            Phonetxt.Location = new Point(124, 82);
            Phonetxt.Name = "Phonetxt";
            Phonetxt.Size = new Size(434, 23);
            Phonetxt.TabIndex = 4;
            Phonetxt.TextChanged += Phonetxt_TextChanged;
            // 
            // IDtxt
            // 
            IDtxt.Location = new Point(124, 111);
            IDtxt.Name = "IDtxt";
            IDtxt.Size = new Size(434, 23);
            IDtxt.TabIndex = 5;
            IDtxt.TextChanged += IDtxt_TextChanged;
            // 
            // LastNameL
            // 
            LastNameL.Font = new Font("Segoe UI", 10F);
            LastNameL.Location = new Point(30, 54);
            LastNameL.Name = "LastNameL";
            LastNameL.Size = new Size(88, 20);
            LastNameL.TabIndex = 6;
            LastNameL.Text = "Last Name";
            // 
            // PhoneL
            // 
            PhoneL.Font = new Font("Segoe UI", 10F);
            PhoneL.Location = new Point(30, 83);
            PhoneL.Name = "PhoneL";
            PhoneL.Size = new Size(88, 20);
            PhoneL.TabIndex = 7;
            PhoneL.Text = "Phone";
            PhoneL.Click += label3_Click;
            // 
            // IDL
            // 
            IDL.Font = new Font("Segoe UI", 10F);
            IDL.Location = new Point(30, 112);
            IDL.Name = "IDL";
            IDL.Size = new Size(88, 20);
            IDL.TabIndex = 8;
            IDL.Text = "ID";
            // 
            // SaveB
            // 
            SaveB.Font = new Font("Segoe UI", 10F);
            SaveB.Location = new Point(583, 140);
            SaveB.Name = "SaveB";
            SaveB.Size = new Size(115, 23);
            SaveB.TabIndex = 9;
            SaveB.Text = "Save";
            SaveB.UseVisualStyleBackColor = true;
            SaveB.Click += SaveB_Click;
            // 
            // FindB
            // 
            FindB.Font = new Font("Segoe UI", 10F);
            FindB.Location = new Point(583, 54);
            FindB.Name = "FindB";
            FindB.Size = new Size(115, 23);
            FindB.TabIndex = 10;
            FindB.Text = "Find";
            FindB.UseVisualStyleBackColor = true;
            FindB.Click += button2_Click;
            // 
            // DeleteB
            // 
            DeleteB.Font = new Font("Segoe UI", 10F);
            DeleteB.Location = new Point(583, 111);
            DeleteB.Name = "DeleteB";
            DeleteB.Size = new Size(115, 23);
            DeleteB.TabIndex = 11;
            DeleteB.Text = "Delete";
            DeleteB.UseVisualStyleBackColor = true;
            DeleteB.Click += DeleteB_Click;
            // 
            // Contacts
            // 
            Contacts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Contacts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Contacts.Location = new Point(30, 188);
            Contacts.Name = "Contacts";
            Contacts.Size = new Size(669, 291);
            Contacts.TabIndex = 12;
            // 
            // EditB
            // 
            EditB.Font = new Font("Segoe UI", 10F);
            EditB.Location = new Point(583, 83);
            EditB.Name = "EditB";
            EditB.Size = new Size(115, 23);
            EditB.TabIndex = 13;
            EditB.Text = "Edit";
            EditB.UseVisualStyleBackColor = true;
            EditB.Click += EditB_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(735, 514);
            Controls.Add(EditB);
            Controls.Add(Contacts);
            Controls.Add(DeleteB);
            Controls.Add(FindB);
            Controls.Add(SaveB);
            Controls.Add(IDL);
            Controls.Add(PhoneL);
            Controls.Add(LastNameL);
            Controls.Add(IDtxt);
            Controls.Add(Phonetxt);
            Controls.Add(LastNametxt);
            Controls.Add(label1);
            Controls.Add(FirstNametxt);
            Controls.Add(newB);
            Name = "Form1";
            Text = "Phonebook";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)Contacts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button newB;
        private TextBox FirstNametxt;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label LastNameL;
        private Label PhoneL;
        private Label IDL;
        private Button SaveB;
        private Button FindB;
        private Button DeleteB;
        private DataGridView Contacts;
        private Button EditB;
        private TextBox LastNametxt;
        private TextBox Phonetxt;
        private TextBox IDtxt;
    }
}
