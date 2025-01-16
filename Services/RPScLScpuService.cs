
namespace Rock_Paper_Scissor_Lizard_Spock___CPU.Services
{
    public class RPScLScpuService
    {
        public string cpuResposne;

        public RPScLScpuService(){
            cpuResposne = "Hasn't been set yet";
        }

        public string GetCpuResponse(){
            string[] cpuOptions = {"rock", "paper", "scissors", "lizard", "spock"};
            Random random = new Random();
            int index = random.Next(cpuOptions.Length);
            cpuResposne = cpuOptions[index];
            
            return cpuResposne;
        }

    }
}