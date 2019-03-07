using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIFLess.Host
{
    public class MessageEventArgs :EventArgs
    {
        public string Message { get; set; }
    }
}
