using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA230110
{
    public partial class FrmColorChanger : Form
    {
        public PictureBox MainFormPictureBox { get; set; }

        public FrmColorChanger(PictureBox pictureBox)
        {
            InitializeComponent();
            MainFormPictureBox = pictureBox;
            btnApply.Click += OnBtnApplyClick;
        }

        private void OnBtnApplyClick(object? sender, EventArgs e)
        {
            int red = tbR.Value;
            int green = tbG.Value;
            int blue = tbB.Value;
            MainFormPictureBox.BackColor = Color.FromArgb(red, green, blue);
        }
    }
}
