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
    public partial class Exercicio1 : Form
    {
        public Exercicio1()
        {
            InitializeComponent();
        }

        private void cmbInicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbInicio.SelectedIndex != 0)
            {

                if (cmbInicio.SelectedIndex < cmbFim.SelectedIndex)
                {
                    for (int i = cmbInicio.SelectedIndex; i < cmbFim.SelectedIndex; i++)
                    {
                        lstNumeros.Items.Add(i.ToString());
                    }
                }
                else
                {
                    if (cmbInicio.SelectedIndex > cmbFim.SelectedIndex)
                    {
                        for (int i = cmbInicio.SelectedIndex; i > cmbFim.SelectedIndex; i--)
                        {
                            lstNumeros.Items.Add(i.ToString());
                        }

                    }
                }
            }
        }

        private void cmbFim_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                if (cmbInicio.SelectedIndex < cmbFim.SelectedIndex)
                {
                    for (int i = cmbInicio.SelectedIndex; i < cmbFim.SelectedIndex; i++)
                    {
                        lstNumeros.Items.Add(i.ToString());
                    }
                }
                else
                {
                    if (cmbInicio.SelectedIndex > cmbFim.SelectedIndex)
                    {
                        for (int i = cmbInicio.SelectedIndex; i > cmbFim.SelectedIndex; i--)
                        {
                            lstNumeros.Items.Add(i.ToString());
                        }

                    }
                }
            
        }
    }
}
