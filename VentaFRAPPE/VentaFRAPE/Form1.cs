using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentaFRAPE
{
    public partial class Form1 : Form
    {
        int totalAPagar = 0;
        int importeTotal, cambioT = 0;
       public int cant_fresa;
       public int cant_moka;
       public int cant_cafe;
       public int cant_caramelo;
       public int cant_oreo;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void rbdchoco_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void rbdchispas_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void rbdbarquillo_CheckedChanged(object sender, EventArgs e)
        {
        }
        //COMBOBOX METODO DE PAGO
        private void cmbtamaño_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtpago.Text = cmbmetodo.Text;           
        }
        //METODOS FRAPPE
        private void chkfresa_CheckedChanged(object sender, EventArgs e)
        {
            if (chkfresa.Checked)
            {
                maskfresa.Text = "";
                maskfresa.Visible = true;
                maskfresa.Focus();
            }        
        }

        private void chkmoka_CheckedChanged(object sender, EventArgs e)
        {
            if (chkmoka.Checked)
            {
                maskmoka.Text = "";
                maskmoka.Visible = true;
                maskmoka.Focus();
            }           
        }

        private void chkcaramelo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkcaramelo.Checked)
            {
                maskcaramelo.Text = "";
                maskcaramelo.Visible = true;
                maskcaramelo.Focus();
            }           
        }

        private void chkcafe_CheckedChanged(object sender, EventArgs e)
        {
            if (chkcafe.Checked)
            {
                maskcafe.Text = "";
                maskcafe.Visible = true;
                maskcafe.Focus();
            }          
        }   

        private void chkoreo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkoreo.Checked)
            {
                maskoreo.Text = "";
                maskoreo.Visible = true;
                maskoreo.Focus();
            }           
        }

        private void btnpedido_Click(object sender, EventArgs e)
        {
            int[] pedido = new int[5];
            int frappe = 0;
            //FRAPE DE FRESA
            if (chkfresa.Checked)
            {
                if (chkfresa.Checked == true)
                {
                    listeleccion.Items.Add(chkfresa.Text);
                }

                cant_fresa = int.Parse(maskfresa.Text);

                //Suma de Radiobutton

                if (rbdchoco.Checked)
                {
                    totalAPagar = totalAPagar + 5 * cant_fresa;
                }
                if (rbdchispas.Checked)
                {
                    totalAPagar = totalAPagar + 7 * cant_fresa;
                }
                if (rbdbarquillo.Checked)
                {
                    totalAPagar = totalAPagar + 8 * cant_fresa;
                }

                totalAPagar = totalAPagar + 25 * cant_fresa;

                pedido[frappe++] = (totalAPagar);
            }
            //FRAPPE DE MOKA
            if (chkmoka.Checked)
            {
                if (chkmoka.Checked == true)
                {
                    listeleccion.Items.Add(chkmoka.Text);
                }

                cant_moka = int.Parse(maskmoka.Text);

                //Suma de Radiobutton
                if (rbdchoco.Checked)
                {
                    totalAPagar = totalAPagar + 5 * cant_moka;
                }
                if (rbdchispas.Checked)
                {
                    totalAPagar = totalAPagar + 7 * cant_moka;
                }
                if (rbdbarquillo.Checked)
                {
                    totalAPagar = totalAPagar + 8 * cant_moka;
                }

                totalAPagar = totalAPagar + 30 * cant_moka;
                pedido[frappe++] = (totalAPagar);
            }
            //FRAPPE DE CAFE
            if (chkcafe.Checked)
            {
                if (chkcafe.Checked == true)
                {
                    listeleccion.Items.Add(chkcafe.Text);
                }

                cant_cafe = int.Parse(maskcafe.Text);

                //Suma de Radiobutton
                if (rbdchoco.Checked)
                {
                    totalAPagar = totalAPagar + 5 * cant_cafe;
                }
                if (rbdchispas.Checked)
                {
                    totalAPagar = totalAPagar + 7 * cant_cafe;
                }
                if (rbdbarquillo.Checked)
                {
                    totalAPagar = totalAPagar + 8 * cant_cafe;
                }

                totalAPagar = totalAPagar + 24 * cant_cafe;
                pedido[frappe++] = (totalAPagar);
            }
            //FRAPPE DE CARAMELO
            if (chkcaramelo.Checked)
            {
                if (this.chkcaramelo.Checked == true)
                {
                    listeleccion.Items.Add(chkcaramelo.Text);
                }

                cant_caramelo = int.Parse(maskcaramelo.Text);

                //Suma de Radiobutton
                if (rbdchoco.Checked)
                {
                    totalAPagar = totalAPagar + 5 * cant_caramelo;
                }
                if (rbdchispas.Checked)
                {
                    totalAPagar = totalAPagar + 7 * cant_caramelo;
                }
                if (rbdbarquillo.Checked)
                {
                    totalAPagar = totalAPagar + 8 * cant_caramelo;
                }

                totalAPagar = totalAPagar + 20 * cant_caramelo;
                pedido[frappe++] = (totalAPagar);
            }
            //FRAPPE DE OREO
            if (chkoreo.Checked)
            {
                if (this.chkoreo.Checked == true)
                {
                    listeleccion.Items.Add(chkoreo.Text);
                }

                cant_oreo = int.Parse(maskoreo.Text);

                if (rbdchoco.Checked)
                {
                    totalAPagar = totalAPagar + 5 * cant_oreo;
                }
                if (rbdchispas.Checked)
                {
                    totalAPagar = totalAPagar + 7 * cant_oreo;
                }
                if (rbdbarquillo.Checked)
                {
                    totalAPagar = totalAPagar + 8 * cant_oreo;
                }

                totalAPagar = totalAPagar + 35 * cant_oreo;
                pedido[frappe++] = (totalAPagar);
            }

            //ARREGLO
            for (int i = 0; i < frappe; i++)
            {
                txttotal.Text = pedido[i].ToString();
            }
        }
            //BOTON COMPRAR
        private void btncomprar_Click(object sender, EventArgs e)
        {
            importeTotal = int.Parse(txtimporte.Text);
            cambioT = importeTotal -totalAPagar;
            txtcambio.Text = cambioT.ToString();
        }
        //BOTON ELEGIR DE NUEVO
        private void btnelegirnuevo_Click(object sender, EventArgs e)
        {
            totalAPagar = 0;
           
            this.listeleccion.Items.Clear();
            txtpago.Clear();
            txtimporte.Clear();
            maskcafe.Clear();
            maskcaramelo.Clear();
            maskfresa.Clear();
            maskmoka.Clear();
            maskoreo.Clear();
            txtcambio.Clear();
            txttotal.Clear();
            this.chkcaramelo.Checked = false;
            this.chkfresa.Checked = false;
            this.chkmoka.Checked = false;
            this.chkoreo.Checked = false;
            this.chkcafe.Checked = false;
            this.rbdbarquillo.Checked = false;
            this.rbdchispas.Checked = false;
            this.rbdchoco.Checked = false;           
        }            
    }
}
