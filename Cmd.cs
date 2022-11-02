using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejecutor_de_scripts_de_python
{
    public  class Cmd
    {
        public string[] rutas { get; set; }
        public string args { get; set; }

        public string rutaPython { get; set; }
        public Cmd()
        {
            rutas = new string[] { };
        }
        private void EjecutarEnCmd (string ruta)
        {
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = rutaPython;
            start.Arguments = string.Format("{0} {1}", ruta, args);
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            using (Process process = Process.Start(start))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    Console.Write(result);
                }
            }
        }
        public List<Mensaje> EjecutarScripts ()
        {
            List<Mensaje> results = new List<Mensaje>();
            
            foreach (string ruta in rutas)
            {
                try
                {
                    EjecutarEnCmd(ruta);
                    results.Add(
                        new Mensaje
                        {
                            ArchivoNombre = ruta
                            ,
                            ArchivoRuta = ruta
                            ,
                            Estado = Estado.Exitoso
                            ,
                            Descripcion = "Ejecucion Exitosa"
                        });
                }
                catch (Exception ex)
                {

                    results.Add(
                         new Mensaje
                         {
                             ArchivoNombre = ruta
                             ,
                             ArchivoRuta = ruta
                             ,
                             Estado = Estado.Error
                             ,
                             Descripcion = ex.Message
                         });
                }
                
            }

            return results;
        }
    }
}
