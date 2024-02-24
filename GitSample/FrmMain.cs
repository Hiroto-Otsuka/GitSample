using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitSample
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //txtExpression1.Text = "";
            string a = txtExpression1.Text;//txtExpression1の値を取得

            //txtExpression2.Text = "";
            string b = txtExpression2.Text;

            int c = int.Parse(a);

            int d = int.Parse(b);

            //c + d = txtResult
            txtResult.Text = (c + d).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string a = txtExpression1.Text;//txtExpression1の値を取得

            //txtExpression2.Text = "";
            string b = txtExpression2.Text;

            int c = int.Parse(a);

            int d = int.Parse(b);

            //c + d = txtResult
            txtResult.Text = (c * d).ToString();
        }
    }
}
