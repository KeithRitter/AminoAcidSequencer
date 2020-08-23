using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace AminoAcidSequencer
{
    public class Sequencer
    {
        public async Task BeginTasks()
        {
            LoadSequences();
            await Task.Delay(-1);
        }

        private async void LoadSequences()
        {
            var model = JsonConvert.DeserializeObject<AcidModel>(await File.ReadAllTextAsync("Sequences.json"));
            var baseSeq = model.BaseSequence;
            List<string> sequences = model.CheckSequences;
            for (int i = 0; i < sequences.Count; i++)
            {
                Console.WriteLine("Sequence: {0}", i);
                int badCount = 0;
                for (int c = 0; c < sequences[i].Length; c++)
                {
                    if(sequences[i][c] != baseSeq[c])
                    {
                        var testA = sequences[i][c];
                        var testB = baseSeq[c];
                        badCount++;
                    }
                }
                Console.WriteLine("Mismatched count: {0}", badCount);
            }
        }
    }
}
