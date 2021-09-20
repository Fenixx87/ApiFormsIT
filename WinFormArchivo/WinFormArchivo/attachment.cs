using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace WinFormArchivo
{
    class attachment
    {
      MailMessage correos = new MailMessage();

        public void enviarCorreo(string ruta)
        {
            try
            {
                if (ruta.Equals("") == false)
                {
                    System.Net.Mail.Attachment archivo = new System.Net.Mail.Attachment(ruta);
                    correos.Attachments.Add(archivo);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "No se envio el correo correctamente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
