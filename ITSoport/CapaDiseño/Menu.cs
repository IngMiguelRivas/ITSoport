using ITSoport.CapaDiseño;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.InteropServices;

namespace ITSoport
{
    public partial class Menu : Form
    {
        private object panelContenedor;

        public Menu()
        {
            InitializeComponent();
        }
        //codigo para poder mover el formulario sin tenera la barra superior
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void btnSlider_Click(object sender, EventArgs e)
        {
            // esta condicion es si se toca el menu de 3 rallas la medida del pictures box se expande o a la inversa
            if (MenuVertical.Width == 230)
            {
                MenuVertical.Width = 85;
            }
            else
                MenuVertical.Width = 230;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea cerrar?", "Alerta!!!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Form logear = new Login();
                logear.Show();
                this.Hide(); //Ocultar aplicacion
            }

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; //para minimizar
        }

        private void AbrirFormInPanel(object Formhijoequipo) // abrir el formulario INGRESAR EQUIPO DENTRO DEL PANEL(CONTENEDOR)
        {
            //Contenedor es el panel insertado al centro del formulario menu
            //El objetivo es colocar el formulario INGREAR EQUIPO EN EL
            if (this.Contenedor.Controls.Count > 0)
                this.Contenedor.Controls.RemoveAt(0);
            Form fh = Formhijoequipo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.Contenedor.Controls.Add(fh);
            this.Contenedor.Tag = fh;
            fh.Show();
        }
        private void btnEquipo_Click(object sender, EventArgs e)
        {
            //se mostrara un formulario dentro del formulario padre dentro de un panel 
            AbrirFormInPanel(new IngresarEquipo());
        }

        private void HoraFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("h:mm:ss");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void lblHora_Click(object sender, EventArgs e)
        {

        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            //Evento para maximizar
            //this.WindowState = FormWindowState.Maximized;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;//posiciona la pantalla sin ocultar la barra de tarea
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            //Evento para restaurar
            //this.WindowState = FormWindowState.Normal;
            this.Size = new Size(900, 500);//pantalla quedara en una medida establecida
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
        }

        private void Contenedor_MouseDown(object sender, MouseEventArgs e)
        {
            //mover el formulario
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }


        protected override void WndProc(ref Message msj) //se crea este PROTECTED para manipular el formulario menu desde las esquinas
        {
            const int CoordenadaWFP = 0x84; //ubicacion de la parte derecha inferior del form
            const int DesIzquierda = 16;
            const int DesDerecha = 17;
            if (msj.Msg == CoordenadaWFP)
            {
                int x = (int)(msj.LParam.ToInt64() & 0xFFFF);
                int y = (int)((msj.LParam.ToInt64() & 0xFFFF0000) >> 16);
                Point CoordenadaArea = PointToClient(new Point(x, y));
                Size TamañoAreaForm = ClientSize;
                if (CoordenadaArea.X >= TamañoAreaForm.Width - 16 && CoordenadaArea.Y >= TamañoAreaForm.Height - 16)
                {
                    msj.Result = (IntPtr)(IsMirrored ? DesIzquierda : DesDerecha);
                    return;
                }
            }
            base.WndProc(ref msj);
        }

        private void btnServicios_Click(object sender, EventArgs e)
        {           
            PanelSubMenu.Visible = true;                      
        }

        private void btnSoporte_Click(object sender, EventArgs e)
        {
            //PanelSubMenu.Visible = false;
        }

        private void btnReparacion_Click(object sender, EventArgs e)
        {
            //PanelSubMenu.Visible = false;
        }

        private void btnPrestamo_Click(object sender, EventArgs e)
        {
            //PanelSubMenu.Visible = false;
            AbrirFormInPanel(new PrestamoEquipo());

        }
    }
}
