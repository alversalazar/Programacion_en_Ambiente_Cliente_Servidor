using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace SocketServidor
{
    internal class Program
    {
        static string texto = "";
        static void Main(string[] args)
        {
            server();
        }
        public static void server()
        {
            //localhost => 127.0.0.1
            // configuracion del servidor
            IPHostEntry host = Dns.GetHostEntry("localhost");

            IPAddress ipAddress = host.AddressList[0]; IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 11200);

            try
            {
                // creacion del socket que esta escuchando
                Socket listener = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                
                // unir el endpoint al socket
                listener.Bind(localEndPoint);
                
                // cantidad de conexiones que recibe antes de indicar que esta ocupado
                listener.Listen(10);
                
                // mensaje de pantalla
                Console.WriteLine("Esperando conexión");
                string data = null; byte[] bytes = null;
                int i = 0;
                // se recibe una conexion y se le entrega a un socket para que la maneje
                

                
                while (i < 1)
                {
                    //MessageBox.Show(listener.Accept().ToString());

                    Socket handler = listener.Accept();                  
                    bytes = new byte[1024]; 
                    // recibir datos desde el cliente
                    int byteRec = handler.Receive(bytes); 
                    // convertir los datos desde bytes a string
                    data += Encoding.ASCII.GetString(bytes, 0, byteRec);
                    // verifica cuando el cliente
                    if (data.IndexOf("<EOF>") > -1 && texto != data.Replace("<EOF>", ""))
                    {
                        texto = data.Replace("<EOF>", "");
                        // mostrar el mensaje del cliente por pantalla
                        Console.WriteLine("Texto del cliente: " + data.Replace("<EOF>", ""));
                        i++;
                        //listener = null;
                        listener.Close();
                    }                       //break;
                    }                     
                }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                MessageBox.Show(e.Message, "Error");
            }
            server();
        }
    }
}  
