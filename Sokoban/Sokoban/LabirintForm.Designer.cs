namespace Sokoban
{
    partial class LabirintForm
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
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolPrevLevel = new System.Windows.Forms.ToolStripButton();
            this.toolNextLevel = new System.Windows.Forms.ToolStripButton();
            this.toolLevelText = new System.Windows.Forms.ToolStripLabel();
            this.toolLevel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStatText = new System.Windows.Forms.ToolStripLabel();
            this.toolStat = new System.Windows.Forms.ToolStripLabel();
            this.toolDone = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolRestart = new System.Windows.Forms.ToolStripButton();
            this.panel = new System.Windows.Forms.Panel();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolPrevLevel,
            this.toolNextLevel,
            this.toolLevelText,
            this.toolLevel,
            this.toolStripSeparator1,
            this.toolStatText,
            this.toolStat,
            this.toolDone,
            this.toolStripSeparator3,
            this.toolRestart});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(852, 25);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolPrevLevel
            // 
            this.toolPrevLevel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolPrevLevel.Image = global::Sokoban.Properties.Resources.Prev;
            this.toolPrevLevel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolPrevLevel.Name = "toolPrevLevel";
            this.toolPrevLevel.Size = new System.Drawing.Size(23, 22);
            this.toolPrevLevel.Text = "toolStripButton1";
            this.toolPrevLevel.ToolTipText = "на предидущий уровень";
            this.toolPrevLevel.Click += new System.EventHandler(this.ToolPrevLevel_Click);
            // 
            // toolNextLevel
            // 
            this.toolNextLevel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolNextLevel.Image = global::Sokoban.Properties.Resources.Next;
            this.toolNextLevel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolNextLevel.Name = "toolNextLevel";
            this.toolNextLevel.Size = new System.Drawing.Size(23, 22);
            this.toolNextLevel.Text = "toolStripButton2";
            this.toolNextLevel.ToolTipText = "на следующий уровень";
            this.toolNextLevel.Click += new System.EventHandler(this.toolNextLevel_Click);
            // 
            // toolLevelText
            // 
            this.toolLevelText.Name = "toolLevelText";
            this.toolLevelText.Size = new System.Drawing.Size(69, 22);
            this.toolLevelText.Text = "Уровень №";
            // 
            // toolLevel
            // 
            this.toolLevel.Name = "toolLevel";
            this.toolLevel.Size = new System.Drawing.Size(13, 22);
            this.toolLevel.Text = "1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStatText
            // 
            this.toolStatText.Name = "toolStatText";
            this.toolStatText.Size = new System.Drawing.Size(134, 22);
            this.toolStatText.Text = "Установленно ящиков:";
            // 
            // toolStat
            // 
            this.toolStat.Name = "toolStat";
            this.toolStat.Size = new System.Drawing.Size(37, 22);
            this.toolStat.Text = "0 из 5";
            // 
            // toolDone
            // 
            this.toolDone.Name = "toolDone";
            this.toolDone.Size = new System.Drawing.Size(106, 22);
            this.toolDone.Text = "Уровень пройден!";
            this.toolDone.Visible = false;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolRestart
            // 
            this.toolRestart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolRestart.Image = global::Sokoban.Properties.Resources.restart;
            this.toolRestart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolRestart.Name = "toolRestart";
            this.toolRestart.Size = new System.Drawing.Size(23, 22);
            this.toolRestart.Text = "toolStripButton3";
            this.toolRestart.ToolTipText = "переиграть уровень";
            this.toolRestart.Click += new System.EventHandler(this.ToolRestart_Click);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 25);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(852, 617);
            this.panel.TabIndex = 1;
            this.panel.Resize += new System.EventHandler(this.Panel_Resize);
            // 
            // LabirintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 642);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.toolStrip);
            this.KeyPreview = true;
            this.Name = "LabirintForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Лабиринт";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LabirintForm_KeyDown);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripLabel toolLevelText;
        private System.Windows.Forms.ToolStripButton toolPrevLevel;
        private System.Windows.Forms.ToolStripButton toolNextLevel;
        private System.Windows.Forms.ToolStripLabel toolLevel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStatText;
        private System.Windows.Forms.ToolStripLabel toolStat;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolDone;
        private System.Windows.Forms.ToolStripButton toolRestart;
        private System.Windows.Forms.Panel panel;
    }
}