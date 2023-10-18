using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace SocketCliente
{
    internal class Program
    {
        static bool primero = true;
        static void Main(string[] args)
        {
            mandarMensaje();   
        }
        public static void mandarMensaje()
        {
            // configuracion para conectarse al servidor
            IPHostEntry host = Dns.GetHostEntry("localhost");

            IPAddress ipAddress = host.AddressList[0];

            IPEndPoint remoteEP = new IPEndPoint(ipAddress, 11200);

            try
            {
                // crear socket para enviar datos
                Socket sender = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                
                // socket le indicamos conectarse con el servidor
                sender.Connect(remoteEP);

                // mensaje de confirmacion de conexion
                if (primero)
                {
                    Console.WriteLine("Conectado con el servidor");
                    primero = false;
                }             
                

                // pedimos al usuario que ingrese un texto para enviar al servidor
                bool enviado = false;
                while (enviado == false)
                {
                    Console.WriteLine("Ingrese un texto para enviar");
                    string texto = Console.ReadLine();
                
                    // convertir el texto a un arreglo de bytes
                    byte[] msg = Encoding.ASCII.GetBytes(texto + "<EOF>");
                    // enviar al servidor el mensaje
                    int byteSent = sender.Send(msg);
                    enviado = true;
                    // cerrar la conexion con el servidor
                    //sender.Shutdown(SocketShutdown.Both);
                    //sender.Close();
                }
                
            }
            catch (Exception e)
            {

                Console.WriteLine(e.ToString());
            }
            mandarMensaje();
        }
    }
}
