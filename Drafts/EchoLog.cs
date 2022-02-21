using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Text;
using System.IO;

namespace CoinPlay
{
    public static class EchoLog
    {
	//Fields
	
		public boolean[25] ready; //Are the RAIDA ready to accept requests. 25 RAIDA.
        public int[25] responseTimes; //The time in millisecds a raida responded in
		
		 public EchoLog(){
		 //Initialize everything to zeros
		 
		 }
		 
		 //Methods
		 public int twoStandardDevations(){
		 //1. Put all response times in order from lowest to fastest.
		 //2. Create an array of differences. Do not include any RAIDA that are not ready.
		 //3. Suptract the first RAIDA's responseTime from the second RAIDA's responseTime. 
		 // Is diferance 1. Then second from 3rd, that's the second differance. And so on.
		 //4. Calculate and return the number that is two standard devations of the differances.
		
		 
		 }
		 
		 
		
		
	}
}
