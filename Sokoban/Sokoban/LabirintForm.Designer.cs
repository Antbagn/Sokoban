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
            this.toolNextLevel = new System.Windows.Forms.ToolStrip();
            this.toolLevelText = new System.Windows.Forms.ToolStripLabel();
            this.toolLevel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStatText = new System.Windows.Forms.ToolStripLabel();
            this.toolStat = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolDone = new System.Windows.Forms.ToolStripLabel();
            this.panel = new System.Windows.Forms.Panel();
            this.toolPrevLevel = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolRestart = new System.Windows.Forms.ToolStripButton();
            this.toolNextLevel.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolNextLevel
            // 
            this.toolNextLevel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolPrevLevel,
            this.toolStripButton2,
            this.toolLevelText,
            this.toolLevel,
            this.toolStripSeparator1,
            this.toolStatText,
            this.toolStat,
            this.toolDone,
            this.toolStripSeparator3,
            this.toolRestart});
            this.toolNextLevel.Location = new System.Drawing.Point(0, 0);
            this.toolNextLevel.Name = "toolNextLevel";
            this.toolNextLevel.Size = new System.Drawing.Size(852, 25);
            this.toolNextLevel.TabIndex = 0;
            this.toolNextLevel.Text = "toolStrip1";
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
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolDone
            // 
            this.toolDone.Name = "toolDone";
            this.toolDone.Size = new System.Drawing.Size(106, 22);
            this.toolDone.Text = "Уровень пройден!";
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 25);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(852, 617);
            this.panel.TabIndex = 1;
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
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::Sokoban.Properties.Resources.Next;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.ToolTipText = "на следующий уровень";
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
            // 
            // LabirintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 642);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.toolNextLevel);
            this.Name = "LabirintForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Лабиринт";
            this.toolNextLevel.ResumeLayout(false);
            this.toolNextLevel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolNextLevel;
        private System.Windows.Forms.ToolStripLabel toolLevelText;
        private System.Windows.Forms.ToolStripButton toolPrevLevel;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
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