using System;

namespace Tom.NETCpuAnalyzer
{

    class Program
    {
        // Expects 1 arg, the pid as a decimal string
        private static void Main(string[] args)
        {
            try
            {
                int pid = 0;
                if (args.Length > 0)
                {
                    pid = int.Parse(args[0]);
                }
                else
                {
                    Console.WriteLine("请输入要分析的PID：");
                    var strpid = Console.ReadLine();
                    pid = int.Parse(strpid);
                }
                var analyzer = new CpuAnalyzer();
                analyzer.Analyse(pid);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }


    }
}
