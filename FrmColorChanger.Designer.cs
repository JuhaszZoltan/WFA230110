namespace WFA230110
{
    partial class FrmColorChanger
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
            this.tbR = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.tbG = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.tbB = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbB)).BeginInit();
            this.SuspendLayout();
            // 
            // tbR
            // 
            this.tbR.Location = new System.Drawing.Point(117, 28);
            this.tbR.Margin = new System.Windows.Forms.Padding(5);
            this.tbR.Maximum = 255;
            this.tbR.Name = "tbR";
            this.tbR.Size = new System.Drawing.Size(346, 45);
            this.tbR.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(32, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Red:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbG
            // 
            this.tbG.Location = new System.Drawing.Point(117, 83);
            this.tbG.Margin = new System.Windows.Forms.Padding(5);
            this.tbG.Maximum = 255;
            this.tbG.Name = "tbG";
            this.tbG.Size = new System.Drawing.Size(346, 45);
            this.tbG.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(32, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "Green:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(117, 138);
            this.tbB.Margin = new System.Windows.Forms.Padding(5);
            this.tbB.Maximum = 255;
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(346, 45);
            this.tbB.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(32, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 45);
            this.label3.TabIndex = 1;
            this.label3.Text = "Blue:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnApply
            // 
            this.btnApply.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnApply.Location = new System.Drawing.Point(32, 191);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(431, 53);
            this.btnApply.TabIndex = 2;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            // 
            // FrmColorChanger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 256);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbG);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbR);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmColorChanger";
            this.Text = "FrmColorChanger";
            ((System.ComponentModel.ISupportInitialize)(this.tbR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TrackBar tbR;
        private Label label1;
        private TrackBar tbG;
        private Label label2;
        private TrackBar tbB;
        private Label label3;
        private Button btnApply;
    }
}