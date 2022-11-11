using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComprasVista
{
    public partial class central_Compra : Form
    {
       Seguridad_Controlador.Controlador cnseg = new Seguridad_Controlador.Controlador();
        public central_Compra()
        {
            InitializeComponent();
            customizeDesing();

            Button [] apps = { btnCliente, btnProveedores, btnPedidos,btnVentas, btnFactura, btnComisiones, btnCompraOrden, btnCompra,
                btnListado, btnMovientosClientes, btnMoviemientosProveedor, btnCotizaciones,btnClientesCaja, btnProveedorCaja
            };
            cnseg.deshabilitarApps(apps);

            cnseg.getAccesoApp(3001, apps[0]);
            cnseg.getAccesoApp(3002, apps[1]);
            cnseg.getAccesoApp(3111, apps[2]);
            cnseg.getAccesoApp(3108, apps[3]);
            cnseg.getAccesoApp(3107, apps[4]);
            cnseg.getAccesoApp(3106, apps[5]);
            cnseg.getAccesoApp(3109, apps[6]);
            cnseg.getAccesoApp(3110, apps[7]);
            cnseg.getAccesoApp(3102, apps[8]);
            cnseg.getAccesoApp(3112, apps[9]);
            cnseg.getAccesoApp(3113, apps[10]);
            cnseg.getAccesoApp(3114, apps[11]);
            cnseg.getAccesoApp(3103, apps[12]);
            cnseg.getAccesoApp(3104, apps[13]);


        }
        private void customizeDesing()
        {
            //Metodo para cubrir los paneles
            panelCompras.Visible = false;
            panelClientes.Visible = false;
            panel1.Visible = false;
           
        }

        private void hideSubMenu()
        {
            if (panelCompras.Visible == true)
                panelCompras.Visible = false;
            if (panelClientes.Visible == true)
                panelClientes.Visible = false;
            if (panel1.Visible == true)
                panel1.Visible = false;
            

        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = true;
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            
            showSubMenu(panelCompras);

        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            //Codigo
            Clientes cl = new Clientes();
            cl.MdiParent = this;
            cl.Show();
            pictureBox2.Visible = false;
            //Ocultar submenu
            hideSubMenu();


 
        }

        private void btnRecepción_Click(object sender, EventArgs e)
        {
            //Codigo
           
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnOrdenes_Click(object sender, EventArgs e)
        {
            //Codigo
            Proveedores p = new Proveedores();
            p.MdiParent = this;
            p.Show();
            pictureBox2.Visible = false;
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnRequisiciones_Click(object sender, EventArgs e)
        {
            //Codigo
           
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnDevoluciones_Click(object sender, EventArgs e)
        {
            //Codigo
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnReporteCompras_Click(object sender, EventArgs e)
        {
            //Codigo
          
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnComprobantesCompras_Click(object sender, EventArgs e)
        {
            //Codigo
           
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            showSubMenu(panelClientes);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            //Codigo
            ListadoPrecios p = new ListadoPrecios();
            p.MdiParent = this;
            p.Show();
            pictureBox2.Visible = false;
            //Ocultar submenu
            hideSubMenu();

        }
            private void btnContactoClientes_Click(object sender, EventArgs e)
        {
            //Codigo
            Caja_Clientes p = new Caja_Clientes();
            p.MdiParent = this;
            p.Show();
            pictureBox2.Visible = false;
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnDay_Click(object sender, EventArgs e)
        {
            //Codigo
            Caja_Proveedores p = new Caja_Proveedores();
            p.MdiParent = this;
            p.Show();
            pictureBox2.Visible = false;
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnReporteCliente_Click(object sender, EventArgs e)
        {
            //Codigo
          
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnComprobantesClientes_Click(object sender, EventArgs e)
        {
            //Codigo
            Cotizaciones p = new Cotizaciones();
            p.MdiParent = this;
            p.Show();
            pictureBox2.Visible = false;
            //Ocultar submenu
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnMovimientosCLientes_Click(object sender, EventArgs e)
        {
            //Codigo
            Pedidos lp = new Pedidos();
            lp.MdiParent = this;
            lp.Show();
            pictureBox2.Visible = false;
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnCajaClientes_Click(object sender, EventArgs e)
        {
            //Codigo
            FacturaVentas lp = new FacturaVentas();
            lp.MdiParent = this;
            lp.Show();
            pictureBox2.Visible = false;
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            showSubMenu(panel1);
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            //Codigo
            
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnContactosProveedores_Click(object sender, EventArgs e)
        {
            //Codigo
            MovimientosClientes lp = new MovimientosClientes();
            lp.MdiParent = this;
            lp.Show();
            pictureBox2.Visible = false;
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnPagosDia_Click(object sender, EventArgs e)
        {
            //Codigo
            MovimientosProveedores lp = new MovimientosProveedores();
            lp.MdiParent = this;
            lp.Show();
            pictureBox2.Visible = false;
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnReportesProveedores_Click(object sender, EventArgs e)
        {
            //Codigo
           
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnComprobantesProveedores_Click(object sender, EventArgs e)
        {
            //Codigo
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnMovimientosProveedores_Click(object sender, EventArgs e)
        {
            //Codigo
            Form formMovimientosProveedores = new MovimientosProveedores();
            formMovimientosProveedores.ShowDialog();
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnCajaProveedores_Click(object sender, EventArgs e)
        {
            //Codigo
            //Ocultar submenu
            hideSubMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*showSubMenu(panel2);*/
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            //Codigo
          
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnDevolucionesVentas_Click(object sender, EventArgs e)
        {
            //Codigo
           
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnCotizaciones_Click(object sender, EventArgs e)
        {
            //Codigo
            Form formCotizacionesVentas = new Form();
            formCotizacionesVentas.ShowDialog();
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnVendedores_Click(object sender, EventArgs e)
        {
            //Codigo
            Form formVendedoresVentas = new VendedoresVentas();
            formVendedoresVentas.ShowDialog();
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnMovimientos_Click(object sender, EventArgs e)
        {
            //Codigo
           /* Form formMovimientosVentas = new Pedidos();
            formMovimientosVentas.ShowDialog();*/
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            //Codigo
           
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnPrecios_Click(object sender, EventArgs e)
        {
            Form formListadoPrecios = new ListadoPrecios();
            formListadoPrecios.ShowDialog();
            hideSubMenu();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
           // showSubMenu(panel3);
        }

        private void btnComisiones_Click(object sender, EventArgs e)
        {
            VendedoresVentas lp = new VendedoresVentas();
            lp.MdiParent = this;
            lp.Show();
            pictureBox2.Visible = false;
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnCompraOrden_Click(object sender, EventArgs e)
        {
            OrdenesCompras lp = new OrdenesCompras();
            lp.MdiParent = this;
            lp.Show();
            pictureBox2.Visible = false;
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnCompra_Click_1(object sender, EventArgs e)
        {
            Compras lp = new Compras();
            lp.MdiParent = this;
            lp.Show();
            pictureBox2.Visible = false;
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnVentas_Click_1(object sender, EventArgs e)
        {
            Ventas lp = new Ventas();
            lp.MdiParent = this;
            lp.Show();
            pictureBox2.Visible = false;
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnMoviemientosProveedor_Click(object sender, EventArgs e)
        {
            MovimientosProveedores lp = new MovimientosProveedores();
            lp.MdiParent = this;
            lp.Show();
            pictureBox2.Visible = false;
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnMovientosClientes_Click(object sender, EventArgs e)
        {
            MovimientosClientes lp = new MovimientosClientes();
            lp.MdiParent = this;
            lp.Show();
            pictureBox2.Visible = false;
            //Ocultar submenu
            hideSubMenu();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
           


            CapaVistaReporteria.menu_reporteria lp = new CapaVistaReporteria.menu_reporteria();
            
            lp.Show();
            
            //Ocultar submenu
            hideSubMenu();
        }
    }
}
