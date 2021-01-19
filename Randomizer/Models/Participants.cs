using System.Collections.Generic;

namespace Randomizer.Models
{
    public class Participants
    {
        public IEnumerable<ListBoxItem> ParticipantList { get; set; }
        public IEnumerable<PairItem> PairList { get; set; }
    }
}
