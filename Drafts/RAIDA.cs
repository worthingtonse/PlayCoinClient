
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Founders4
{
    public class RAIDA
    {
        /* INSTANCE VARIABLE */
        public DetectionAgent[] agent;
        public Response[] responseArray = new Response[25];
        public Request[] requestArray = new Request[25];
        public string[] ipnumbers = new string[25];
        public int[] portNumbers = new int[25];

        /* CONSTRUCTOR */
        public RAIDA( Request[] requestArray)
        { 
            
            //Initialise instance variables

            //Create 25 objects that will talk to the 25 RAIDA
            this.agent = new DetectionAgent[25];
            this.requestArray = requestArray;

            for (int i = 0; (i < 25); i++)
            {
                this.agent[i] = new DetectionAgent(ipAddress[i], portNumber[i], request[i]);
              

            } // end for each Raida

        }//End Constructor

        public DetectionAgent DetectionAgent
        {
            get => default;
            set
            {
            }
        }

        public async Task callOneRAIDA(int raida_id)
        {
            DetectionAgent da = new DetectionAgent(raida_id);
            responseArray[raida_id] = await da.issueCommand(raida_id);

        }//end echo 



        public Response[] echoAll(int milliSecondsToTimeOut)
        {

            //Create threads
            Response[] results = new Response[25];
            var t00 = callOneRAIDA(00);
            var t01 = callOneRAIDA(01);
            var t02 = callOneRAIDA(02);
            var t03 = callOneRAIDA(03);
            var t04 = callOneRAIDA(04);
            var t05 = callOneRAIDA(05);
            var t06 = callOneRAIDA(06);
            var t07 = callOneRAIDA(07);
            var t08 = callOneRAIDA(08);
            var t09 = callOneRAIDA(09);
            var t10 = callOneRAIDA(10);
            var t11 = callOneRAIDA(11);
            var t12 = callOneRAIDA(12);
            var t13 = callOneRAIDA(13);
            var t14 = callOneRAIDA(14);
            var t15 = callOneRAIDA(15);
            var t16 = callOneRAIDA(16);
            var t17 = callOneRAIDA(17);
            var t18 = callOneRAIDA(18);
            var t19 = callOneRAIDA(19);
            var t20 = callOneRAIDA(20);
            var t21 = callOneRAIDA(21);
            var t22 = callOneRAIDA(22);
            var t23 = callOneRAIDA(23);
            var t24 = callOneRAIDA(24);

            var taskList = new List<Task> { t00, t01, t02, t03, t04, t05, t06, t07, t08, t09, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22, t23, t24 };
         
            Task.WaitAll(taskList.ToArray(), milliSecondsToTimeOut);
         
            return results;
        }//end echo
    }//end RAIDA Class
}// End Namespace
