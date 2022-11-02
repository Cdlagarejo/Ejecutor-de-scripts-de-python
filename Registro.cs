using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejecutor_de_scripts_de_python
{
    public class Registro
    {
        private RegistryKey BaseRegister;
        public string registro { get; set; }
        public Exception Exception { get; private set; }
        public string clave { get; set; }
        public bool TieneError => Exception != null;
        public Registro()
        {

        }
        public void RegistroParaUsuarioActual ()
        {
            BaseRegister = Registry.CurrentUser;
        }
        public void RegistroParaMaquinaLocal()
        {
            BaseRegister = Registry.LocalMachine;
        }

        private bool ExisteRegistro(string registro) => BaseRegister.OpenSubKey(registro) != null;
        private bool TieneSubRegistros(string registro) => BaseRegister.OpenSubKey(registro).GetSubKeyNames() != null;
        private string[] ObteniendoSubRegistros (string registro) => BaseRegister.OpenSubKey(registro).GetSubKeyNames();

        private bool ExisteClave(string registro, string clave) => BaseRegister.OpenSubKey(registro).GetValue(clave) != null;

        private string ObteniendoValorPorClave(string registro, string clave) => BaseRegister.OpenSubKey(registro).GetValue(clave).ToString();

        public List<VersionesPython> VersionesPython ()
        {
            Exception = null;
            List<VersionesPython> Versiones = new List<VersionesPython>();
            try
            {
                if (!ExisteRegistro(this.registro))
                {
                    Exception = new Exception($"No existe el registro con el que se busca {this.registro}");
                    return Versiones;
                } 
                if (!TieneSubRegistros(this.registro))
                {
                    Exception = new Exception($"No tiene subregistros {this.registro}");
                    return Versiones;
                }
                foreach(string subregistro in ObteniendoSubRegistros(this.registro)) 
                {
                    string ruta = $"{this.registro}\\{subregistro}\\InstallPath";
                    if (!ExisteRegistro(ruta))
                    {
                        Exception = new Exception($"No existe el registro con el que se busca {ruta}");
                        continue;
                    }
                    if (!TieneSubRegistros(ruta))
                    {
                        Exception = new Exception($"No tiene subregistros {ruta}");
                        continue;
                    }
                    if (!ExisteClave(ruta, clave))
                    {
                        Exception = new Exception($"No existe la clave {clave} en el registro {ruta}");
                        continue;
                    }
                    string RutaEjecutablePythob = ObteniendoValorPorClave(ruta, "ExecutablePath");
                    Versiones.Add(new VersionesPython() { ruta = RutaEjecutablePythob, version = subregistro });
                }
            }
            catch (Exception ex)  
            {
                Exception = ex;
            }
            return Versiones;
        }
    }
}
