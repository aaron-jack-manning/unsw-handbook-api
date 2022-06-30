using System;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace UNSW_Handbook_API
{
    class Sample
    {
        static async Task Main(string[] args)
        {
            Subject subject = await UNSWHandbookAPI.GetSubject("math2621", UNSWHandbookAPI.StudyLevel.Undergraduate);
            Console.WriteLine(subject);

            Program program = await UNSWHandbookAPI.GetProgram("3956", UNSWHandbookAPI.StudyLevel.Undergraduate);
            Console.WriteLine(program);
        }
    }
}