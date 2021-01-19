using Randomizer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Randomizer
{
    public partial class ParticipantInput : Form
    {
        public ParticipantInput()
        {
            InitializeComponent();
            LoadParticipants().ConfigureAwait(false);
            ValidateForm();
        }

        public Participants Participants { get; private set; } = new Participants();

        private void AddItemToListBox(KeyEventArgs e = null)
        {
            input_listBox.Items.Add(new ListBoxItem { Index = input_listBox.Items.Count, Name = input_textBox.Text });

            if (e != null)
            {
                e.SuppressKeyPress = e.Handled = true;
            }

            input_textBox.Text = null;
            ValidateForm();
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(input_textBox.Text) && DoesNotExist())
            {
                AddItemToListBox();
            }
        }

        private bool DoesNotExist()
        {
            foreach (ListBoxItem item in input_listBox.Items)
            {
                if (item.Name.Equals(input_textBox.Text))
                {
                    return false;
                }
            }

            return true;
        }

        private static IEnumerable<IEnumerable<T>> GetPermutations<T>(IEnumerable<T> items, int count)
        {
            int i = 0;
            foreach (var item in items)
            {
                if (count == 1)
                {
                    yield return new T[] { item };
                }
                else
                {
                    foreach (var result in GetPermutations(items.Skip(i + 1), count - 1))
                    {
                        yield return new T[] { item }.Concat(result);
                    }
                }

                ++i;
            }
        }

        private void Input_listBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var itemIndex = input_listBox.IndexFromPoint(e.Location);

                if (itemIndex != ListBox.NoMatches)
                {
                    input_listBox.SetSelected(itemIndex, true);
                }
                else
                {
                    input_listBox.ClearSelected();
                }
            }
        }

        private void Input_listBox_contextMenuStrip_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (input_listBox.SelectedIndex == ListBox.NoMatches)
            {
                e.Cancel = true;
            }
        }

        private void Input_textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrEmpty(input_textBox.Text) && DoesNotExist())
            {
                AddItemToListBox(e);
            }
        }

        private async Task LoadParticipants()
        {
            try
            {
                var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                var jsonParticipants = await JSONHelper<Participants>.Load(@$"{path}\participants.bin");
                foreach (var item in jsonParticipants.ParticipantList)
                {
                    input_listBox.Items.Add(item);
                }
            }
            catch
            {
            }
        }

        private void Ok_button_Click(object sender, EventArgs e)
        {
            var inputList = input_listBox.Items.Cast<ListBoxItem>();

            var pairList = GetPermutations(inputList, 2).Select((pair, index) => new PairItem
            {
                Index = index,
                PairParticipants = pair,
                Deleted = false,
                Selectable = true,
            });

            var participants = new Participants
            {
                ParticipantList = inputList,
                PairList = pairList
            };

            SaveParticipants(participants).ConfigureAwait(false);

            Participants = participants;

            DialogResult = DialogResult.OK;
        }

        private void RemoveItemFromListBox(int index)
        {
            input_listBox.Items.RemoveAt(index);
            ValidateForm();
        }

        private void Remove_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (input_listBox.SelectedIndex != ListBox.NoMatches)
            {
                RemoveItemFromListBox(input_listBox.SelectedIndex);
            }
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

        private void ValidateForm()
        {
            input_textBox.Focus();
            ok_button.Enabled = input_listBox.Items.Count % 2 == 0;
        }
    }
}
