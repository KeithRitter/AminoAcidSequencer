using System.Threading.Tasks;

namespace AminoAcidSequencer
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            await new Sequencer().BeginTasks();
        }
    }
}
