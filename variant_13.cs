using System.Net;
using System.Net.Sockets;
using System.Text;

var server = new TcpListener(IPAddress.Loopback, 5000);
server.Start();

while (true)
{
    var client = await server.AcceptTcpClientAsync();
    await client.GetStream().WriteAsync(Encoding.UTF8.GetBytes("Hello from TCP server!"));
    client.Close();
}