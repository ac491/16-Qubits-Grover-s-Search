using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace _16Q_Grover
{
    class Driver
    {
        
        static void Main(string[] args)
        {
            int num=5;
            int count=0,flag=0;
             using (var sim =new QuantumSimulator())
            {
                for(int i=0;i<num;i++){
                    flag=0;
                    var res =Search.Run(sim).Result;
                    var register=res;
                    System.Console.WriteLine($"{register.ToString()} \n");
                    foreach(Result r in register){
                        if(r.Equals(Result.Zero)){
                            flag=1;
                            break;
                        }
                    }
                    if(flag==0){
                        count++;
                    }
                }
            }
            System.Console.WriteLine($"Probability= {(double)count/num}");
            System.Console.WriteLine("Press any key to continue..");
            System.Console.ReadKey();
        }
    }
}