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
            this.toolResize = new System.Windows.Forms.ToolStripDropDownButton();
            this.ToolResizeAddRow = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolResizeDelRow = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolResizeAddCol = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolResizeDelCol = new System.Windows.Forms.ToolStripMenuItem();
            this.toolSave = new System.Windows.Forms.ToolStripButton();
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
            this.toolWall.Click += new System.EventHandler(this.ToolWall_Click);
            // 
            // toolAbox
            // 
            this.toolAbox.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolAbox.Image = global::SokobanEditor.Properties.Resources.abox;
            this.toolAbox.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAbox.Name = "toolAbox";
            this.toolAbox.Size = new System.Drawing.Size(36, 36);
            this.toolAbox.Text = "toolStripButton2";
            this.toolAbox.Click += new System.EventHandler(this.ToolAbox_Click);
            // 
            // toolHere
            // 
            this.toolHere.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolHere.Image = global::SokobanEditor.Properties.Resources.here;
            this.toolHere.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolHere.Name = "toolHere";
            this.toolHere.Size = new System.Drawing.Size(36, 36);
            this.toolHere.Text = "toolStripButton3";
            this.toolHere.Click += new System.EventHandler(this.ToolHere_Click);
            // 
            // toolDone
            // 
            this.toolDone.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolDone.Image = global::SokobanEditor.Properties.Resources.done;
            this.toolDone.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolDone.Name = "toolDone";
            this.toolDone.Size = new System.Drawing.Size(36, 36);
            this.toolDone.Text = "toolStripButton4";
            this.toolDone.Click += new System.EventHandler(this.ToolDone_Click);
            // 
            // toolNone
            // 
            this.toolNone.Checked = true;
            this.toolNone.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolNone.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolNone.Image = global::SokobanEditor.Properties.Resources.none;
            this.toolNone.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolNone.Name = "toolNone";
            this.toolNone.Size = new System.Drawing.Size(36, 36);
            this.toolNone.Text = "toolStripButton5";
            this.toolNone.Click += new System.EventHandler(this.ToolNone_Click);
            // 
            // toolUser
            // 
            this.toolUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolUser.Image = global::SokobanEditor.Properties.Resources.user1;
            this.toolUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolUser.Name = "toolUser";
            this.toolUser.Size = new System.Drawing.Size(36, 36);
            this.toolUser.Text = "toolStripButton6";
            this.toolUser.Click += new System.EventHandler(this.ToolUser_Click);
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
            this.toolStripSeparator1,
            this.toolResize,
            this.toolSave});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(593, 39);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ToolStrip1_ItemClicked);
            // 
            // toolResize
            // 
            this.toolResize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolResize.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolResizeAddRow,
            this.ToolResizeDelRow,
            this.ToolResizeAddCol,
            this.ToolResizeDelCol});
            this.toolResize.Image = ((System.Drawing.Image)(resources.GetObject("toolResize.Image")));
            this.toolResize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolResize.Name = "toolResize";
            this.toolResize.Size = new System.Drawing.Size(45, 36);
            this.toolResize.Text = "toolStripDropDownButton1";
            // 
            // ToolResizeAddRow
            // 
            this.ToolResizeAddRow.Name = "ToolResizeAddRow";
            this.ToolResizeAddRow.Size = new System.Drawing.Size(180, 22);
            this.ToolResizeAddRow.Text = "+1 строка";
            this.ToolResizeAddRow.Click += new System.EventHandler(this.ToolResizeAddRow_Click);
            // 
            // ToolResizeDelRow
            // 
            this.ToolResizeDelRow.Name = "ToolResizeDelRow";
            this.ToolResizeDelRow.Size = new System.Drawing.Size(180, 22);
            this.ToolResizeDelRow.Text = "-1 строка";
            this.ToolResizeDelRow.Click += new System.EventHandler(this.ToolResizeDelRow_Click);
            // 
            // ToolResizeAddCol
            // 
            this.ToolResizeAddCol.Name = "ToolResizeAddCol";
            this.ToolResizeAddCol.Size = new System.Drawing.Size(180, 22);
            this.ToolResizeAddCol.Text = "+1 столбец";
            this.ToolResizeAddCol.Click += new System.EventHandler(this.ToolResizeAddCol_Click);
            // 
            // ToolResizeDelCol
            // 
            this.ToolResizeDelCol.Name = "ToolResizeDelCol";
            this.ToolResizeDelCol.Size = new System.Drawing.Size(180, 22);
            this.ToolResizeDelCol.Text = "-1 столбец";
            this.ToolResizeDelCol.Click += new System.EventHandler(this.ToolResizeDelCol_Click);
            // 
            // toolSave
            // 
            this.toolSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolSave.Image = ((System.Drawing.Image)(resources.GetObject("toolSave.Image")));
            this.toolSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSave.Name = "toolSave";
            this.toolSave.Size = new System.Drawing.Size(36, 36);
            this.toolSave.Text = "toolStripButton1";
            this.toolSave.Click += new System.EventHandler(this.ToolSave_Click);
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
        private System.Windows.Forms.ToolStripDropDownButton toolResize;
        private System.Windows.Forms.ToolStripMenuItem ToolResizeAddRow;
        private System.Windows.Forms.ToolStripMenuItem ToolResizeDelRow;
        private System.Windows.Forms.ToolStripMenuItem ToolResizeAddCol;
        private System.Windows.Forms.ToolStripMenuItem ToolResizeDelCol;
        private System.Windows.Forms.ToolStripButton toolSave;
    }
}

