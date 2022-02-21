using System;

namespace CoinPlay
{
    //Captures the response of a RAIDA
    //https://github.com/worthingtonse/RAIDAX/blob/main/Request_Response_Headers.md#--response
    public class Response
    {
        public byte raidaID;
        public byte shardID;
        public byte status;
        public byte executionTime; //The time that the RAIDA needed to execute the command micro seconds. 
        public byte udpFrameOne;
        public byte udpFrameTwo;
        public byte echoOne;
        public byte echoTwo;
        public byte hashOne;
        public byte hashTwo;
        public byte hashThree;
        public byte hashFour;
        public byte[] Body;

        //Meta Data
        public byte udp_error; //0 =  none, 1 = timeout, 
        public int totalTime; //The time in milliseconds that the request took from start to finish



        public Response()
        {
            this.shardID = 0;
            this.status = 0;
            this.executionTime = 0;
            this.udpFrameOne = 0;
            this.udpFrameTwo = 0;
            this.echoOne = 0;
            this.echoTwo = 0;
            this.hashOne = 0;
            this.hashTwo = 0;
            this.hashThree = 0;
            this.hashFour = 0;
            this.udp_error = 0;
            this.totalTime = 0;
			

        }

        public byte[] getResponsHeader() {

            bytes[] responseBytes[];
            //Add all bytes from the response. 
            return responseBytes[];
        }
		
		  public byte[] getResponsBody() {

         
            return body[];
        }
		
        public int getTotalTime()
        {
            return totalTime;
            
        }
        public byte getError()
        {

            return udp_error;
        }
    }
}
