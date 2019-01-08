using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proposta_de_Seguro_Auto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //fecha o formulario
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Limpa o formulario
            txtNome.Text = "";
            txtValor.Text = "";
            txtDescId.Text = "";
            txtSexDesc.Text = "";
            txtValBase.Text = string.Empty;
            txtValDescP.Text = "";
            txtValTotal.Text = "";
            rbFem.Checked = false;
            rbMas.Checked = false;
            cbRod.Checked = false;
            cbUM.Checked = false;
            cmbFaixa.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valTotal, valCar, valBase, valSexD, valDescId, valDescP;

            //recebe o valor do automovel e transforma dados txt em double
            valCar = Convert.ToDouble(txtValor.Text);
            valBase = (valCar * 10 / 100);
            txtValBase.Text = string.Format("{0:###,##0.00}", valBase);
            valTotal = valBase;

            //faz a checagem de qual radio Button foi selecionado, faz o calculo e atribui para o textbox
                    if (rbFem.Checked)
                    {
                        valSexD = (valTotal * 7.5 / 100);
                        txtSexDesc.Text = string.Format("{0:###,##00,00}", valSexD);
                valTotal = (valTotal - valSexD);
                    }
                    else
                        txtSexDesc.Text = ("Não há desconto");

             //faz a seleção da faixa de idade, o calculo de desconto e atribui o valor para o textbox
                    int selectedIndex = cmbFaixa.SelectedIndex;
                    Object selectedItem = cmbFaixa.SelectedItem;
                    MessageBox.Show("Faixa Etária: " + selectedItem.ToString() + "\n" +
        "Indice: " + selectedIndex.ToString());
                    if (selectedIndex == 0)
                        txtDescId.Text = ("Não há desconto");

                    else if (selectedIndex == 1)
                    {
                        valDescId = (valTotal * 2.5 / 100);
                        txtDescId.Text = string.Format("{0:###,##0.00}", valDescId);
                        valTotal = (valTotal - valDescId);
                    }
                    else if (selectedIndex == 2)
                    {
                        valDescId = (valTotal * 3.7 / 100);
                        txtDescId.Text = string.Format("{0:###,##0.00}", valDescId);
                        valTotal = (valTotal - valDescId);
                     }
                
            // faz a leitura dos checkbox selecionados, calcula e atribuir o valor a textbox

                    if (cbUM.Checked && cbRod.Checked)
                    {
                        valDescP = (valTotal * 3.3 / 100);
                        txtValDescP.Text = string.Format("{0:###,##0.00}", valDescP);
                        valTotal = (valTotal - valDescP);
                    }
                    else if (cbUM.Checked && cbRod.Checked != true)
                    {
                        valDescP = (valTotal * 1.5 / 100);
                        txtValDescP.Text = string.Format("{0:###,##0.00}", valDescP);
                        valTotal = (valTotal - valDescP);
                    }

                    else if (cbUM.Checked != true && cbRod.Checked)
                    {
                        valDescP = (valTotal * 1.8 / 100);
                        txtValDescP.Text = string.Format("{0:###,##0.00}", valDescP);
                        valTotal = (valTotal - valDescP);
                    }



                    //saida do valor final na textbox
                txtValTotal.Text = string.Format("{0:###,##0.00}", valTotal);
            




        }
    }
}
