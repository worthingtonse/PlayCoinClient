using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinPlay
{
    class Request
    {
        public byte cloudID;
        public byte Split ID;
        public byte[] body;
        //Header Fields add 22 fields from the standard header  https://github.com/worthingtonse/RAIDAX/blob/main/Request_Response_Headers.md#-requests
        //Body fields

        public Request( receive all parmeters needed to initiate object) { 
        
            //Initialize fields
        }

        public byte[] getHeader() { 
            return //All bytes in the header
        }

        public byte[] getBody() { 
            return //all bytes in the body
        }
        
        public byte[] getRequest()
        {
            return //all bytes in the header and body with E3 E3 at the end. 
        }

    }
}
