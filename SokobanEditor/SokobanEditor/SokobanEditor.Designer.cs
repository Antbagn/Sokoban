namespace SokobanEditor
{
    partial class SokobanEditor
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SokobanEditor));
            this.panel = new System.Windows.Forms.Panel();
            this.toolWall = new System.Windows.Forms.ToolStripButton();
            this.toolAbox = new System.Windows.Forms.ToolStripButton();
            this.toolHere = new System.Windows.Forms.ToolStripButton();
            this.toolDone = new System.Windows.Forms.ToolStripButton();
            this.toolNone = new System.Windows.Forms.ToolStripButton();
            this.toolUser = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 39);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(593, 329);
            this.panel.TabIndex = 1;
            // 
            // toolWall
            // 
            this.toolWall.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolWall.Image = global::SokobanEditor.Properties.Resources.wall;
            this.toolWall.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolWall.Name = "toolWall";
            this.toolWall.Size = new System.Drawing.Size(36, 36);
            this.toolWall.Text = "toolStripButton1";
            // 
            // toolAbox
            // 
            this.toolAbox.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolAbox.Image = global::SokobanEditor.Properties.Resources.abox;
            this.toolAbox.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAbox.Name = "toolAbox";
            this.toolAbox.Size = new System.Drawing.Size(36, 36);
            this.toolAbox.Text = "toolStripButton2";
            // 
            // toolHere
            // 
            this.toolHere.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolHere.Image = global::SokobanEditor.Properties.Resources.here;
            this.toolHere.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolHere.Name = "toolHere";
            this.toolHere.Size = new System.Drawing.Size(36, 36);
            this.toolHere.Text = "toolStripButton3";
            // 
            // toolDone
            // 
            this.toolDone.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolDone.Image = global::SokobanEditor.Properties.Resources.done;
            this.toolDone.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolDone.Name = "toolDone";
            this.toolDone.Size = new System.Drawing.Size(36, 36);
            this.toolDone.Text = "toolStripButton4";
            // 
            // toolNone
            // 
            this.toolNone.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolNone.Image = global::SokobanEditor.Properties.Resources.none;
            this.toolNone.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolNone.Name = "toolNone";
            this.toolNone.Size = new System.Drawing.Size(36, 36);
            this.toolNone.Text = "toolStripButton5";
            // 
            // toolUser
            // 
            this.toolUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolUser.Image = global::SokobanEditor.Properties.Resources.user1;
            this.toolUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolUser.Name = "toolUser";
            this.toolUser.Size = new System.Drawing.Size(36, 36);
            this.toolUser.Text = "toolStripButton6";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolWall,
            this.toolAbox,
            this.toolHere,
            this.toolDone,
            this.toolNone,
            this.toolUser,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(593, 39);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ToolStrip1_ItemClicked);
            // 
            // SokobanEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 368);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SokobanEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактор уровней игры sokoban";
            this.Load += new System.EventHandler(this.SokobanEditor_Load);
            this.Resize += new System.EventHandler(this.SokobanEditor_Resize);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ToolStripButton toolWall;
        private System.Windows.Forms.ToolStripButton toolAbox;
        private System.Windows.Forms.ToolStripButton toolHere;
        private System.Windows.Forms.ToolStripButton toolDone;
        private System.Windows.Forms.ToolStripButton toolNone;
        private System.Windows.Forms.ToolStripButton toolUser;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}

