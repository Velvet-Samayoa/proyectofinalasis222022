using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComprasControlador;

namespace ComprasVista
{
    public partial class Ventas : Form
    {
        csControladort cn = new csControladort();
        public Ventas()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Gbo_tipopago_Enter(object sender, EventArgs e)
        {

        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            cn.eliminarpedidocaducado();
            cn.inicioventa(Txt_idventa, Txt_idpedido, Gpo_venta, Txt_total, Txt_subtotal);
        }

        private void Txt_idpedido_TextChanged(object sender, EventArgs e)
        {
            DateTimePicker[] fechas = { Dtp_fechavencimiento, Dtp_fechapedido };
            if(Txt_idpedido.Text.Length != 0)
            {
                cn.llenarventaydetalle(Txt_idpedido.Text, Txt_nombrecliente,  fechas, Dgvdetalleventa, Txt_subtotal, Txt_nit);
            }
            else
            {
                GroupBox[] group = { Gpo_venta,  Gbo_tipopago };
                cn.preestablecido(group, Txt_idventa, Txt_abono, Txt_idpedido, Dgvdetalleventa, Txt_nit); 
            }
        }

        private void btnpedido_Click(object sender, EventArgs e)
        {
            AyudaVenta a = new AyudaVenta("tblencabezadopedido", "PkId_EncabezadoPedido");
            


            if (cn.IDS == null && Txt_idpedido.Text.Length == 0)
            {
                cn.IDS = null;
                a.Show();
            }
            else
            {
                Txt_idpedido.Text = cn.IDS;
                cn.IDS = null;
                
            }
        }

        private void btneliminarpedido_Click(object sender, EventArgs e)
        {
            cn.eliminarpedido(Txt_idpedido);
            GroupBox[] group = { Gpo_venta,  Gbo_tipopago };
            cn.preestablecido(group, Txt_idventa, Txt_abono, Txt_idpedido, Dgvdetalleventa, Txt_nit);

        }

        private void btncancelarventa_Click(object sender, EventArgs e)
        {
            GroupBox[] group = { Gpo_venta,  Gbo_tipopago, Gbo_pago };
            cn.limpiarventa(group, Dgvdetalleventa);
            cn.preestablecido(group, Txt_idventa, Txt_abono, Txt_idpedido, Dgvdetalleventa, Txt_nit);
       
        }

        private void Cbo_tipopago_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBox[] text = { Txt_subtotal, Txt_total };
            if(Cbo_tipopago.SelectedItem.Equals("Plazos"))
            {
                lbl_tipoplazo.Enabled = true;
                Cbo_tipoplazo.Enabled = true;
                lbl_tipoplazo.Visible = true;
                Cbo_tipoplazo.Visible = true;
                
            }
            else if(Cbo_tipopago.SelectedItem.Equals("Contado"))
            {
                lbl_tipoplazo.Enabled = false;
                Cbo_tipoplazo.Enabled = false;
                lbl_tipoplazo.Visible = false;
                Cbo_tipoplazo.Visible = false;
                cn.calculototalventa(Cbo_tipopago.SelectedItem.ToString(),text);
            }
            
        }

        private void Cbo_formapago_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Cbo_moneda_SelectedIndexChanged(object sender, EventArgs e)
        {

            /*if(Txt_subtotal.Text.Length != 0 && Cbo_moneda.SelectedItem.ToString() != "")
            {
                cn.convertirmoneda(Txt_subtotal, Cbo_moneda.SelectedItem.ToString(), Txt_total);
            }*/
            
        }

        private void Cbo_tipoplazo_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBox[] text = { Txt_subtotal, Txt_total };
            cn.calculototalventa(Cbo_tipopago.SelectedItem.ToString(), text, Cbo_tipoplazo.SelectedItem.ToString());
        }

        private void btnventa_Click(object sender, EventArgs e)
        {
            TextBox[] textbox = {Txt_idventa, Txt_idpedido,  Txt_nombrecliente, Txt_total, Txt_nit, Txt_abono};
            GroupBox[] groupBoxes = { Gpo_venta, Gbo_pago, Gbo_tipopago};
            cn.insertarventa(textbox, groupBoxes, Cbo_tipopago);
            cn.limpiarventa(groupBoxes, Dgvdetalleventa);
            cn.preestablecido(groupBoxes, Txt_idventa, Txt_abono, Txt_idpedido, Dgvdetalleventa, Txt_nit);
           
        }

        private void Gpo_venta_Enter(object sender, EventArgs e)
        {

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"C:\Users\Developer\Desktop\proyectofinalasis222022\Codigo\Modulos\Administracion\Ayudast\ayudast.chm", "AyudaVenta.html");
           
        }
       
    }
}
