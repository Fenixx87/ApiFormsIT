using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.IO;

namespace WebApiArchivo.Controllers
{
    public class ArchivoController : ApiController
    {
        public HttpResponseMessage Get(string nombreArchivo)
        {
            HttpResponseMessage resultado = null;
            string directorioDescarga = ConfigurationManager.AppSettings["DirectorioDescarga"];
            //string directorioDescarga = nombreArchivo;
            int tipoRespuesta = 2;
            string mensajeRespuesta = "";
            byte[] arrContenido = null;
            try
            {
                if (Directory.Exists(directorioDescarga))
                {
                    string nombreCompletoArchivo = Path.Combine(directorioDescarga, nombreArchivo);
                    if (File.Exists(nombreCompletoArchivo))
                    {
                        long tamanioArchivo = new FileInfo(nombreCompletoArchivo).Length;
                        arrContenido = new byte[tamanioArchivo];
                        using (FileStream fs = new FileStream(nombreCompletoArchivo, FileMode.Open, FileAccess.Read, FileShare.Read))
                        {
                            fs.Read(arrContenido, 0, arrContenido.Length);
                            tipoRespuesta = 1;
                        }
                    }
                    else
                        mensajeRespuesta = "No existe el archivo " + nombreArchivo;
                }
                else
                    mensajeRespuesta = "No existe el directorio de descarga" + directorioDescarga;
            }
            catch (Exception ex)
            {
                tipoRespuesta = 3;
                mensajeRespuesta = ex.Message;
            }

            if (tipoRespuesta == 1)
                resultado = Request.CreateResponse(HttpStatusCode.OK, arrContenido);
            else
            {
                if (tipoRespuesta == 2)
                    resultado = new HttpResponseMessage(HttpStatusCode.BadRequest);
                else
                    resultado = new HttpResponseMessage(HttpStatusCode.InternalServerError);
                resultado.Content = new StringContent(mensajeRespuesta);
            }
            return resultado;
        }
    }
}
