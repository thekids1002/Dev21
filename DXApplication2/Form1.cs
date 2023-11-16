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
        Function _function = new Function();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            try
            {
                string RB = rB.Text.ToString();
                string RS = Rs.Text.ToString();
                string GB = gB.Text.ToString();

                string mMaxDais = mMaxDai.Text.ToString();
                string bDais = bDai.Text.ToString();
                string hDais = hDai.Text.ToString();
                string aDais = aDai.Text.ToString();
                string phiDais = phiDai.Text.ToString();

                string mMaxNgans = mMaxNgan.Text.ToString();
                string bNgans = bNgan.Text.ToString();
                string hNgans = hNgan.Text.ToString();
                string aNgans = aNgan.Text.ToString();
                string phiNgans = phiNgan.Text.ToString();



                if (string.IsNullOrEmpty(RB) || string.IsNullOrEmpty(RS) || string.IsNullOrEmpty(GB))
                {
                    MessageBox.Show("ko đc trống", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
                else if (!Function.isNumber(RB) || !Function.isNumber(RS) || !Function.isNumber(GB) ||
                         !Function.isNumber(mMaxDais) || !Function.isNumber(bDais) || !Function.isNumber(hDais) ||
                         !Function.isNumber(aDais) || !Function.isNumber(phiDais) || !Function.isNumber(mMaxNgans)
                         || !Function.isNumber(mMaxNgans) || !Function.isNumber(bNgans) || !Function.isNumber(hNgans)
                         || !Function.isNumber(aNgans) || !Function.isNumber(phiNgans))
                {

                    //tính slot Dài
                    double tinhAMd = Function.Calculateam(parseNum(mMaxDais), parseNum(GB), parseNum(RB), parseNum(bDais), parseNum(hDais));
                    double tinhXd = Function.CalculateX(tinhAMd);
                    double tinhASd = Function.CalculateAs(tinhXd, parseNum(GB), parseNum(RB), parseNum(bDais), parseNum(hDais), parseNum(RS));
                    double tinhNd = Function.CalculateN(tinhASd, parseNum(phiDais));
                    double tinhAd = Function.CalculateA(parseNum(bDais), tinhNd);

                    //tinh Shot Ngắn
                    double tinhAMn = Function.Calculateam(parseNum(mMaxNgans), parseNum(GB), parseNum(RB), parseNum(bNgans), parseNum(hNgans));
                    double tinhXn = Function.CalculateX(tinhAMn);
                    double tinhASn = Function.CalculateAs(tinhXn, parseNum(GB), parseNum(RB), parseNum(bNgans), parseNum(hNgans), parseNum(RS));
                    double tinhNn = Function.CalculateN(tinhASn, parseNum(phiNgans));
                    double tinhAn = Function.CalculateA(parseNum(bNgans), tinhNn);

                }
            }
            catch (Exception)
            {

            }
        }

        private double parseNum(string d)
        {
            return double.Parse(d);
        }

    }
}
