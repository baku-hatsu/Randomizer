namespace Randomizer
{
    partial class ParticipantInput
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.input_textBox = new System.Windows.Forms.TextBox();
            this.ok_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.input_listBox = new System.Windows.Forms.ListBox();
            this.input_listBox_contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.remove_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.add_button = new System.Windows.Forms.Button();
            this.input_listBox_contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // input_textBox
            // 
            this.input_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.input_textBox.Location = new System.Drawing.Point(12, 12);
            this.input_textBox.Name = "input_textBox";
            this.input_textBox.PlaceholderText = "Enter name ...";
            this.input_textBox.Size = new System.Drawing.Size(259, 23);
            this.input_textBox.TabIndex = 0;
            this.input_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Input_textBox_KeyDown);
            // 
            // ok_button
            // 
            this.ok_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ok_button.Location = new System.Drawing.Point(277, 266);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(75, 23);
            this.ok_button.TabIndex = 2;
            this.ok_button.Text = "OK";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.Ok_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel_button.Location = new System.Drawing.Point(196, 266);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 3;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            // 
            // input_listBox
            // 
            this.input_listBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.input_listBox.ContextMenuStrip = this.input_listBox_contextMenuStrip;
            this.input_listBox.DisplayMember = "Name";
            this.input_listBox.FormattingEnabled = true;
            this.input_listBox.ItemHeight = 15;
            this.input_listBox.Location = new System.Drawing.Point(12, 41);
            this.input_listBox.Name = "input_listBox";
            this.input_listBox.Size = new System.Drawing.Size(340, 214);
            this.input_listBox.TabIndex = 1;
            this.input_listBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Input_listBox_MouseDown);
            // 
            // input_listBox_contextMenuStrip
            // 
            this.input_listBox_contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.remove_toolStripMenuItem});
            this.input_listBox_contextMenuStrip.Name = "input_listBox_contextMenuStrip";
            this.input_listBox_contextMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.input_listBox_contextMenuStrip.ShowImageMargin = false;
            this.input_listBox_contextMenuStrip.Size = new System.Drawing.Size(93, 26);
            this.input_listBox_contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.Input_listBox_contextMenuStrip_Opening);
            // 
            // remove_toolStripMenuItem
            // 
            this.remove_toolStripMenuItem.AccessibleName = "Remove Tool Strip Menu Item";
            this.remove_toolStripMenuItem.Name = "remove_toolStripMenuItem";
            this.remove_toolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.remove_toolStripMenuItem.Text = "Remove";
            this.remove_toolStripMenuItem.Click += new System.EventHandler(this.Remove_toolStripMenuItem_Click);
            // 
            // add_button
            // 
            this.add_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.add_button.Location = new System.Drawing.Point(277, 12);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(75, 23);
            this.add_button.TabIndex = 4;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // ParticipantInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancel_button;
            this.ClientSize = new System.Drawing.Size(364, 301);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.input_listBox);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.input_textBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(250, 250);
            this.Name = "ParticipantInput";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Input window";
            this.input_listBox_contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input_textBox;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.ListBox input_listBox;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.ContextMenuStrip input_listBox_contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem remove_toolStripMenuItem;
    }
}