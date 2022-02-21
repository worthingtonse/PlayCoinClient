using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Text;
using System.IO;

namespace CoinPlay
{
    public class DetectionAgent
    {
        //Each Detection Agent represents one RAIDA

        public string ipAddress;
        public int portNumber;
        
        //Other bytes
        public byte[16] encryptionKey;
        public string encryptionType;  //none or aes128

      

        //Constructor
        public DetectionAgent(string ipAddress, int portNumber, Request request)
        {
           
            this.ipAddress = ipAddress;
            this.portNumber = portNumber;
            //etc..and response
     

        }//Detection Agent Constructor

        public async Task<Response> issueCommand(int raidaID)
        {
       
            DateTime before = DateTime.Now;
            Response response = new Response();


            try (using upd)?
            {
  
                if (EchoLog.ready[raidaID] ) //The status should be success
                {
                    //Send the myRequest using UPD to the raida
                    
                }
                else
                {
                    //Return the response with the RAIDA Error "Untried" code 2
                    //Log Problem to main.log file
                    return
                }
            }
            catch (Exception ex)
            {
                //Update 
                //Log Problem to main.log file
                //Add error code to response object
                //Return response
            }
            catch (Timeout ex)//This means it timed out
            {

                after = DateTime.Now;
                ts = after.Subtract(before);//end the timer
                //put error code for timeout and total time in response
                //Log Problem to main.log file
                return response;/
            }

           


            DateTime after = DateTime.Now; TimeSpan ts = after.Subtract(before);
            //Add totalTime to response
          
            return response;
        }//end detect

       
