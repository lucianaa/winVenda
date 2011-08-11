using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace winVenda
{
    public partial class Quant : Form
    {
        public double quant = 0;
        public Quant()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //caso o usuario digite um valor invalido
            try
            {
                quant = double.Parse(textBox1.Text);
            }
            catch
            {
                quant = 0;
            }
            Close();
        }
    }
}
