namespace Randomizer
{
    partial class Randomizer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.randomize_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.participantPairs_dataGridView = new System.Windows.Forms.DataGridView();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.participant_one = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.participant_two = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.participantPairs_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // randomize_button
            // 
            this.randomize_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.randomize_button.Location = new System.Drawing.Point(477, 331);
            this.randomize_button.Name = "randomize_button";
            this.randomize_button.Size = new System.Drawing.Size(75, 23);
            this.randomize_button.TabIndex = 3;
            this.randomize_button.Text = "Randomize";
            this.randomize_button.UseVisualStyleBackColor = true;
            this.randomize_button.Click += new System.EventHandler(this.Randomize_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exit_button.Location = new System.Drawing.Point(396, 331);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(75, 23);
            this.exit_button.TabIndex = 4;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(564, 24);
            this.menuStrip.TabIndex = 5;
            this.menuStrip.Text = "menuStrip1";
            // 
            // participantPairs_dataGridView
            // 
            this.participantPairs_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.participantPairs_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.participantPairs_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.participant_one,
            this.participant_two});
            this.participantPairs_dataGridView.Location = new System.Drawing.Point(12, 27);
            this.participantPairs_dataGridView.Name = "participantPairs_dataGridView";
            this.participantPairs_dataGridView.RowTemplate.Height = 25;
            this.participantPairs_dataGridView.Size = new System.Drawing.Size(540, 298);
            this.participantPairs_dataGridView.TabIndex = 6;
            // 
            // number
            // 
            this.number.HeaderText = "No";
            this.number.MinimumWidth = 50;
            this.number.Name = "number";
            this.number.ReadOnly = true;
            this.number.Width = 50;
            // 
            // participant_one
            // 
            this.participant_one.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.participant_one.HeaderText = "Participant Nr.:1";
            this.participant_one.MinimumWidth = 200;
            this.participant_one.Name = "participant_one";
            this.participant_one.ReadOnly = true;
            // 
            // participant_two
            // 
            this.participant_two.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.participant_two.HeaderText = "Participant Nr.:2";
            this.participant_two.MinimumWidth = 200;
            this.participant_two.Name = "participant_two";
            this.participant_two.ReadOnly = true;
            // 
            // Randomizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exit_button;
            this.ClientSize = new System.Drawing.Size(564, 361);
            this.Controls.Add(this.participantPairs_dataGridView);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.randomize_button);
            this.Controls.Add(this.menuStrip);
            this.MinimumSize = new System.Drawing.Size(580, 400);
            this.Name = "Randomizer";
            this.Text = "Randomizer";
            ((System.ComponentModel.ISupportInitialize)(this.participantPairs_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button randomize_button;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.DataGridView participantPairs_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn participant_one;
        private System.Windows.Forms.DataGridViewTextBoxColumn participant_two;
    }
}

