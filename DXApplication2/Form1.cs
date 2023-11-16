using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DXApplication2
{
    public partial class Form1 : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fluentDesignFormContainer1_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void xtraTabPage1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            try
            {
                string RB = rB.Text.ToString();
                string RS = Rs.Text.ToString();
                string GB = gB.Text.ToString();

                if (string.IsNullOrEmpty(RB) || string.IsNullOrEmpty(RS) || string.IsNullOrEmpty(GB))
                {
                    MessageBox.Show("ko đc trống", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Nhap đc r", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        
    }
}
