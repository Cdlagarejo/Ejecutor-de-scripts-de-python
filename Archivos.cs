

namespace Ejecutor_de_scripts_de_python
{
    public class Archivos
    {
        public Archivos()
        {

        }

        public string[] SeleccionarArchivos()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Python Files (*.py;*.PY;*.py2)|*.py;*.PY;*.py2";
            openFileDialog.Multiselect = true;
            openFileDialog.Title = "Selección de archivos";
            string[] archivos = new string[] { };
            DialogResult dr = openFileDialog.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                archivos = openFileDialog.FileNames;
            }
            return archivos;
        }
    }
    
}
