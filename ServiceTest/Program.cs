using System;
using DTO.ReqInParm;
using ExchangeService;

namespace ServiceTest
{
    class Program
    {
        static void Main(string[] args)
        {
            IMainService mainservice = new MainServiceClient();
            DTO.ReqInParm.CCertificateSpcReqInParm parm1 = new DTO.ReqInParm.CCertificateSpcReqInParm();
            Console.WriteLine("Hello World!");
        }

       
    }
}
