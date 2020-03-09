using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Server_Client
{
    public class AsyncObject
    {
        public readonly int buffer_size;
        public Byte[] received_buffer;
        public Socket working_socket;
        public AsyncObject(int _buffer_size)
        {
            buffer_size = _buffer_size;
            received_buffer = new Byte[buffer_size];
        }
    }
}
