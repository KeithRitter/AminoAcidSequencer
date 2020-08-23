namespace AminoAcidSequencer
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class AcidModel
    {
        [JsonProperty("BaseSequence")]
        public string BaseSequence { get; set; }

        [JsonProperty("CheckSequences")]
        public List<string> CheckSequences { get; set; }
    }
}