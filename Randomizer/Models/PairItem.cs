using System.Collections.Generic;

namespace Randomizer.Models
{
    public class PairItem
    {
        public int Index { get; set; }
        public bool Deleted { get; set; }
        public bool Selectable { get; set; }
        public IEnumerable<ListBoxItem> PairParticipants { get; set; }
    }
}
