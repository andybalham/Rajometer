namespace RoM2UI
{
    partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.lastSavedLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.mainTabControl = new System.Windows.Forms.TabControl();
			this.Time = new System.Windows.Forms.TabPage();
			this.timeTextBox = new System.Windows.Forms.TextBox();
			this.Notes = new System.Windows.Forms.TabPage();
			this.notesTextBox = new System.Windows.Forms.TextBox();
			this.Report = new System.Windows.Forms.TabPage();
			this.reportTextBox = new System.Windows.Forms.TextBox();
			this.saveTimer = new System.Windows.Forms.Timer(this.components);
			this.statusStrip.SuspendLayout();
			this.mainTabControl.SuspendLayout();
			this.Time.SuspendLayout();
			this.Notes.SuspendLayout();
			this.Report.SuspendLayout();
			this.SuspendLayout();
			// 
			// statusStrip
			// 
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lastSavedLabel});
			this.statusStrip.Location = new System.Drawing.Point(0, 474);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
			this.statusStrip.Size = new System.Drawing.Size(737, 22);
			this.statusStrip.TabIndex = 1;
			this.statusStrip.Text = "statusStrip1";
			// 
			// lastSavedLabel
			// 
			this.lastSavedLabel.Name = "lastSavedLabel";
			this.lastSavedLabel.Size = new System.Drawing.Size(102, 17);
			this.lastSavedLabel.Text = "Last Saved: HH:mm";
			// 
			// mainTabControl
			// 
			this.mainTabControl.Controls.Add(this.Time);
			this.mainTabControl.Controls.Add(this.Notes);
			this.mainTabControl.Controls.Add(this.Report);
			this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainTabControl.Location = new System.Drawing.Point(0, 0);
			this.mainTabControl.Margin = new System.Windows.Forms.Padding(2);
			this.mainTabControl.Name = "mainTabControl";
			this.mainTabControl.SelectedIndex = 0;
			this.mainTabControl.Size = new System.Drawing.Size(737, 474);
			this.mainTabControl.TabIndex = 2;
			// 
			// Time
			// 
			this.Time.Controls.Add(this.timeTextBox);
			this.Time.Location = new System.Drawing.Point(4, 22);
			this.Time.Margin = new System.Windows.Forms.Padding(2);
			this.Time.Name = "Time";
			this.Time.Padding = new System.Windows.Forms.Padding(2);
			this.Time.Size = new System.Drawing.Size(729, 448);
			this.Time.TabIndex = 0;
			this.Time.Text = "Time";
			this.Time.UseVisualStyleBackColor = true;
			// 
			// timeTextBox
			// 
			this.timeTextBox.AcceptsReturn = true;
			this.timeTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.timeTextBox.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.timeTextBox.Location = new System.Drawing.Point(2, 2);
			this.timeTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.timeTextBox.Multiline = true;
			this.timeTextBox.Name = "timeTextBox";
			this.timeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.timeTextBox.Size = new System.Drawing.Size(725, 444);
			this.timeTextBox.TabIndex = 0;
			this.timeTextBox.WordWrap = false;
			this.timeTextBox.TextChanged += new System.EventHandler(this.textChanged);
			this.timeTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.timeTextBox_KeyDown);
			// 
			// Notes
			// 
			this.Notes.Controls.Add(this.notesTextBox);
			this.Notes.Location = new System.Drawing.Point(4, 22);
			this.Notes.Margin = new System.Windows.Forms.Padding(2);
			this.Notes.Name = "Notes";
			this.Notes.Padding = new System.Windows.Forms.Padding(2);
			this.Notes.Size = new System.Drawing.Size(729, 448);
			this.Notes.TabIndex = 1;
			this.Notes.Text = "Notes";
			this.Notes.UseVisualStyleBackColor = true;
			// 
			// notesTextBox
			// 
			this.notesTextBox.AcceptsReturn = true;
			this.notesTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.notesTextBox.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.notesTextBox.Location = new System.Drawing.Point(2, 2);
			this.notesTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.notesTextBox.Multiline = true;
			this.notesTextBox.Name = "notesTextBox";
			this.notesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.notesTextBox.Size = new System.Drawing.Size(725, 444);
			this.notesTextBox.TabIndex = 1;
			this.notesTextBox.WordWrap = false;
			this.notesTextBox.TextChanged += new System.EventHandler(this.textChanged);
			// 
			// Report
			// 
			this.Report.Controls.Add(this.reportTextBox);
			this.Report.Location = new System.Drawing.Point(4, 22);
			this.Report.Margin = new System.Windows.Forms.Padding(2);
			this.Report.Name = "Report";
			this.Report.Padding = new System.Windows.Forms.Padding(2);
			this.Report.Size = new System.Drawing.Size(729, 448);
			this.Report.TabIndex = 2;
			this.Report.Text = "Report";
			this.Report.UseVisualStyleBackColor = true;
			// 
			// reportTextBox
			// 
			this.reportTextBox.AcceptsReturn = true;
			this.reportTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.reportTextBox.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.reportTextBox.Location = new System.Drawing.Point(2, 2);
			this.reportTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.reportTextBox.Multiline = true;
			this.reportTextBox.Name = "reportTextBox";
			this.reportTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.reportTextBox.Size = new System.Drawing.Size(725, 444);
			this.reportTextBox.TabIndex = 1;
			this.reportTextBox.WordWrap = false;
			// 
			// saveTimer
			// 
			this.saveTimer.Interval = 1000;
			this.saveTimer.Tick += new System.EventHandler(this.saveTimer_Tick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(737, 496);
			this.Controls.Add(this.mainTabControl);
			this.Controls.Add(this.statusStrip);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "RoM2";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.mainTabControl.ResumeLayout(false);
			this.Time.ResumeLayout(false);
			this.Time.PerformLayout();
			this.Notes.ResumeLayout(false);
			this.Notes.PerformLayout();
			this.Report.ResumeLayout(false);
			this.Report.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage Time;
        private System.Windows.Forms.TabPage Notes;
        private System.Windows.Forms.TabPage Report;
        private System.Windows.Forms.ToolStripStatusLabel lastSavedLabel;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.Timer saveTimer;
        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.TextBox reportTextBox;
    }
}

