using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Practiva_VII
{
    class ftp
    {
        private string usuario = null;
        private string host = null;
        private string password = null;
        private FtpWebRequest request = null;
        //private FtpWebResponse ftpResponse = null;
        private Stream ftpStream = null;
        private int bufferSize = 2048;

        public ftp(string IP, string userName, string pass)
        {
            usuario = userName;
            host = IP;
            password = pass;
        }

        public bool conectado()
        {
            bool conectado = false;
            try
            {
                request = (FtpWebRequest)WebRequest.Create(host);
                request.Method = WebRequestMethods.Ftp.ListDirectory;
                request.Credentials = new NetworkCredential(usuario, password);
                request.GetResponse();
                conectado = true;
            }
            catch (WebException ex)
            {
                Console.WriteLine($"No se ha podido establacer la conexion debido al siguiente error: {ex}");
            }
            return conectado;
        }

        public void upload(string remoteFile, string localFile)
        {
            try
            {
                /* Create an FTP Request */
                request = (FtpWebRequest)FtpWebRequest.Create(host + "/" + remoteFile);
                /* Log in to the FTP Server with the User Name and Password Provided */
                request.Credentials = new NetworkCredential(usuario, password);
                /* When in doubt, use these options */
                request.UseBinary = true;
                request.UsePassive = true;
                request.KeepAlive = true;
                /* Specify the Type of FTP Request */
                request.Method = WebRequestMethods.Ftp.UploadFile;
                /* Establish Return Communication with the FTP Server */
                ftpStream = request.GetRequestStream();
                /* Open a File Stream to Read the File for Upload */
                FileStream localFileStream = new FileStream(localFile, FileMode.Create);
                /* Buffer for the Downloaded Data */
                byte[] byteBuffer = new byte[bufferSize];
                int bytesSent = localFileStream.Read(byteBuffer, 0, byteBuffer.Length);
                /* Upload the File by Sending the Buffered Data Until the Transfer is Complete */
                try
                {
                    while (bytesSent != 0)
                    {
                        ftpStream.Write(byteBuffer, 0, bytesSent);
                        bytesSent = localFileStream.Read(byteBuffer, 0, byteBuffer.Length);
                    }
                }
                catch (Exception ex) { Console.WriteLine(ex.ToString()); }
                /* Resource Cleanup */
                localFileStream.Close();
                ftpStream.Close();
                request = null;
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
            return;
        }
    }
}