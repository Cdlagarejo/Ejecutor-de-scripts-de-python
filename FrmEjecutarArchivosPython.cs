namespace Ejecutor_de_scripts_de_python
{
    public partial class FrmEjecutarArchivosPython : Form
    {
        private string[] archivosAEjecutar = new string[] { };
        public FrmEjecutarArchivosPython()
        {
            InitializeComponent();
            LlenarComboxVersionesPython();
        }
        private void LlenarComboxVersionesPython ()
        {
            Registro registro = new Registro() { registro = "Software\\Python\\PythonCore", clave = "ExecutablePath" };
            registro.RegistroParaUsuarioActual();
            List<VersionesPython> versionesPythons = registro.VersionesPython();
            CbxVersionesPython.DataSource = versionesPythons.ToList();
            CbxVersionesPython.ValueMember = "ruta";
            CbxVersionesPython.DisplayMember = "version";
        }
            
        private void BtnEjecutar_Click(object sender, EventArgs e)
        {
            if (archivosAEjecutar.Length == 0) return;
            Cmd cmd = new Cmd();
            cmd.rutaPython = CbxVersionesPython.SelectedValue.ToString();
            cmd.args = "";
            cmd.rutas = archivosAEjecutar;
            List<Mensaje> respuesta = cmd.EjecutarScripts();
        }

        private void BtnSeleccionarArchivos_Click(object sender, EventArgs e)
        {
            Archivos archivos = new Archivos();
             archivosAEjecutar =  archivos.SeleccionarArchivos();
            if (archivosAEjecutar.Length == 0)
            {
                txtRutas.ResetText(); 
            } else if (archivosAEjecutar.Length == 1)
            {
                txtRutas.Text = archivosAEjecutar[0];
            } else
            {
                txtRutas.Text = "...";
            }
        }
    }
}