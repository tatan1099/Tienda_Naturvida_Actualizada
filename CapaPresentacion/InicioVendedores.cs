using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class InicioVendedores : Form
    {
        public InicioVendedores()
        {
            InitializeComponent();
        }

        private void Abrir(Form hijo) //Craga los formularios en el panel
        {
            
            this.panel1.Controls.Clear(); //limpia el panel
            //Form2 hijo = new Form2(); //Instancia
            hijo.TopLevel = false; //Para que no sea mas grande que el panel
            hijo.Dock = DockStyle.Fill; //Da formato completo
            this.panel1.Controls.Add(hijo); //Agrega el formulario que está en hijo
            hijo.Show(); //Abre el formulario en el panel
        }
        private void BtnDetallesFactura_Click(object sender, EventArgs e)
        {
            Form detalle = new dF();
            this.Hide();
            detalle.Show();
        }

        private void BtnVendedores_Click(object sender, EventArgs e)
        {

        }

        private void vendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

     

        private void produuctosToolStripMenuItem_Click(object sender, EventArgs e)
        {          
            Abrir(new Productos());
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void backeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrir(new Backe());
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
            Abrir(new Clientes());

        }


        private void vendedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            Abrir(new Vendedoresp());
        }

        private void facturaToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
              
            Abrir(new Factura());
        }

        private void inventarioToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
      
            Abrir(new Inventario());
        }

        private void naturvidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            Abrir(new naturvida());
        }

        private void InicioVendedores_Load(object sender, EventArgs e)
        {
            Abrir(new naturvida());
        }



    }
}
