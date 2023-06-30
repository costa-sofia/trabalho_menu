using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal
{
    public partial class Exercicio4 : Form
    {
        public Exercicio4()
        {
            InitializeComponent();
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            double total=0;
            if(cbArroz.Checked) { total += 30.00; }
            if(cbFeijao.Checked) { total += 7.00;  }
            if(cbBanana.Checked) { total += 4.50; }
            if(cbCafe.Checked) { total += 14.00; }
            if(cbFarinha.Checked) { total += 6.00; }
            if(cbKiwi.Checked) { total += 14.00; }
            if(cbMaca.Checked) { total += 3.50; }
            if(cbMaracuja.Checked) { total += 9.00; }

            lblTotal.Text = total.ToString("C");

        }
    }
}
