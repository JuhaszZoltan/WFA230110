namespace WFA230110
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
            this.btnColorChange = new System.Windows.Forms.Button();
            this.pb = new System.Windows.Forms.PictureBox();
            this.pnlLogIn = new System.Windows.Forms.Panel();
            this.btnAuth = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.pnlLogIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnColorChange
            // 
            this.btnColorChange.Location = new System.Drawing.Point(14, 14);
            this.btnColorChange.Margin = new System.Windows.Forms.Padding(5);
            this.btnColorChange.Name = "btnColorChange";
            this.btnColorChange.Size = new System.Drawing.Size(201, 68);
            this.btnColorChange.TabIndex = 0;
            this.btnColorChange.Text = "Change Color";
            this.btnColorChange.UseVisualStyleBackColor = true;
            // 
            // pb
            // 
            this.pb.BackColor = System.Drawing.Color.Tomato;
            this.pb.Location = new System.Drawing.Point(14, 103);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(201, 210);
            this.pb.TabIndex = 1;
            this.pb.TabStop = false;
            // 
            // pnlLogIn
            // 
            this.pnlLogIn.Controls.Add(this.btnAuth);
            this.pnlLogIn.Controls.Add(this.tbPassword);
            this.pnlLogIn.Controls.Add(this.label2);
            this.pnlLogIn.Controls.Add(this.tbUserName);
            this.pnlLogIn.Controls.Add(this.label1);
            this.pnlLogIn.Location = new System.Drawing.Point(263, 14);
            this.pnlLogIn.Name = "pnlLogIn";
            this.pnlLogIn.Size = new System.Drawing.Size(345, 102);
            this.pnlLogIn.TabIndex = 2;
            // 
            // btnAuth
            // 
            this.btnAuth.Location = new System.Drawing.Point(221, 17);
            this.btnAuth.Name = "btnAuth";
            this.btnAuth.Size = new System.Drawing.Size(106, 70);
            this.btnAuth.TabIndex = 2;
            this.btnAuth.Text = "AUTH";
            this.btnAuth.UseVisualStyleBackColor = true;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(71, 55);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(144, 32);
            this.tbPassword.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "pw:";
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(71, 17);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(144, 32);
            this.tbUserName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "un:";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgv.Location = new System.Drawing.Point(232, 122);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowTemplate.Height = 25;
            this.dgv.Size = new System.Drawing.Size(411, 191);
            this.dgv.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 1F;
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.FillWeight = 3F;
            this.Column2.HeaderText = "name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.FillWeight = 3F;
            this.Column3.HeaderText = "birth";
            this.Column3.Name = "Column3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 325);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.pnlLogIn);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.btnColorChange);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.pnlLogIn.ResumeLayout(false);
            this.pnlLogIn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnColorChange;
        public PictureBox pb;
        private Panel pnlLogIn;
        private Button btnAuth;
        private TextBox tbPassword;
        private Label label2;
        private TextBox tbUserName;
        private Label label1;
        private DataGridView dgv;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}