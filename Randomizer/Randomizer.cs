using Randomizer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Randomizer
{
    public partial class Randomizer : Form
    {
        public Participants Participants { get; private set; } = new Participants();
        private readonly Random _random;

        public Randomizer()
        {
            InitializeComponent();

            menuStrip.Items.Add("Participants", null, New_Randomizer);
            randomize_button.Enabled = false;
            LoadParticipants().ConfigureAwait(false);
            _random = new Random();
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async Task LoadParticipants()
        {
            try
            {
                var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                var jsonParticipants = await JSONHelper<Participants>.Load(@$"{path}\participants.bin");
                if (jsonParticipants.PairList != null && jsonParticipants.PairList.Count() > 0)
                {
                    Participants = jsonParticipants;
                    randomize_button.Enabled = true;
                }
            }
            catch
            {
            }
        }

        private void New_Randomizer(object sender, EventArgs e)
        {
            Participants = new Participants();

            var form2 = new ParticipantInput();

            var result = form2.ShowDialog();

            if (result == DialogResult.OK)
            {
                Participants = form2.Participants;

                if (Participants.ParticipantList != null)
                {
                    randomize_button.Enabled = true;
                }
            }
            else
            {
                LoadParticipants().ConfigureAwait(false);
            }
        }

        private void Randomize_button_Click(object sender, EventArgs e)
        {
            participantPairs_dataGridView.Rows.Clear();

            var selectedPairs = SelectPairs();

            if (selectedPairs.Count == 0)
            {
                var message = @"There are no more possible pairs. Go to Participants => OK to reset the list. Optionally add or remove participants.";
                MessageBox.Show(this, message, "No Pairs", MessageBoxButtons.OK, MessageBoxIcon.Information);
                randomize_button.Enabled = false;
            }

            var i = 1;
            foreach (var pair in selectedPairs)
            {
                // TODO: Make this not only for two, but dynamic
                var pairParticipants = pair.PairParticipants.ToList();
                participantPairs_dataGridView.Rows.Add(i++, pairParticipants[0].Name, pairParticipants[1].Name);
            }

            SaveParticipants(Participants).ConfigureAwait(false);
        }

        private async Task SaveParticipants(Participants model)
        {
            try
            {
                var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                await JSONHelper<Participants>.Save(model, @$"{path}\participants.bin");
            }
            catch
            {
            }
        }

        private List<PairItem> SelectPairs()
        {
            List<PairItem> selectedPairList = new List<PairItem>();
            var pairList = Participants.PairList.ToList();

            for (int i = 0; i < Participants.ParticipantList.Count() / 2; i++)
            {
                var selectablePairs = pairList.Where(x => x.Selectable && !x.Deleted).ToList();

                if (selectablePairs.Count == 0)
                {
                    return new List<PairItem>();
                }

                var selectablePairIndexes = selectablePairs.Select(x => x.Index).ToList();
                var randomPairIndex = _random.Next(0, selectablePairIndexes.Count);

                var selectedPair = selectablePairs[randomPairIndex];
                selectedPairList.Add(selectedPair);

                selectablePairs[randomPairIndex].Deleted = true;

                foreach (var selectablePair in selectablePairs)
                {
                    if (selectablePair.PairParticipants.Any(selectablePairParticipant => selectedPair.PairParticipants.Any(selectedPairParticipant => selectedPairParticipant.Index == selectablePairParticipant.Index)))
                    {
                        selectablePair.Selectable = false;
                    }
                }
            }

            pairList.RemoveAll(pair => selectedPairList.Contains(pair));

            foreach (var pair in pairList)
            {
                pair.Selectable = true;
            }

            Participants.PairList = pairList;

            return selectedPairList;
        }
    }
}
