namespace Notes
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvNotes = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.ID_Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_Insert = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_EditNote = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_DeleteNote = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Refresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_PrintNote = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Settings = new System.Windows.Forms.ToolStripDropDownButton();
            this.تمرنگیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.آبیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.نلرنجیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.صورتیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.خروجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotes)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.panel1);
            this.groupPanel1.Controls.Add(this.toolStrip1);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.DrawTitleBox = false;
            this.groupPanel1.Font = new System.Drawing.Font("Mj_Flow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(517, 356);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 4;
            this.groupPanel1.Text = "دفترچه یادداشت";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvNotes);
            this.panel1.Location = new System.Drawing.Point(-3, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(517, 265);
            this.panel1.TabIndex = 1;
            // 
            // dgvNotes
            // 
            this.dgvNotes.AllowUserToAddRows = false;
            this.dgvNotes.AllowUserToDeleteRows = false;
            this.dgvNotes.AllowUserToResizeColumns = false;
            this.dgvNotes.AllowUserToResizeRows = false;
            this.dgvNotes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNotes.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dgvNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Note,
            this.Titel,
            this.Note});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Mj_Flow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNotes.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNotes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvNotes.Location = new System.Drawing.Point(0, 0);
            this.dgvNotes.Name = "dgvNotes";
            this.dgvNotes.ReadOnly = true;
            this.dgvNotes.Size = new System.Drawing.Size(517, 265);
            this.dgvNotes.TabIndex = 0;
            this.dgvNotes.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNotes_CellClick);
            // 
            // ID_Note
            // 
            this.ID_Note.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID_Note.DataPropertyName = "ID";
            this.ID_Note.HeaderText = "کد";
            this.ID_Note.Name = "ID_Note";
            this.ID_Note.ReadOnly = true;
            this.ID_Note.Width = 47;
            // 
            // Titel
            // 
            this.Titel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Titel.DataPropertyName = "Titel";
            this.Titel.HeaderText = "عنوان";
            this.Titel.Name = "Titel";
            this.Titel.ReadOnly = true;
            this.Titel.Width = 59;
            // 
            // Note
            // 
            this.Note.DataPropertyName = "Note";
            this.Note.HeaderText = "یادداشت";
            this.Note.Name = "Note";
            this.Note.ReadOnly = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightBlue;
            this.toolStrip1.Font = new System.Drawing.Font("A Negaar", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Insert,
            this.toolStripSeparator4,
            this.btn_EditNote,
            this.toolStripSeparator3,
            this.btn_DeleteNote,
            this.toolStripSeparator6,
            this.btn_Refresh,
            this.toolStripSeparator5,
            this.btn_PrintNote,
            this.toolStripSeparator2,
            this.btn_Settings});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(511, 68);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // btn_Insert
            // 
            this.btn_Insert.Image = global::Notes.Properties.Resources._1371475930_filenew;
            this.btn_Insert.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Insert.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(46, 65);
            this.btn_Insert.Text = "افزودن";
            this.btn_Insert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Insert.ToolTipText = "اضافه کردن یادداشت";
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 68);
            // 
            // btn_EditNote
            // 
            this.btn_EditNote.Image = global::Notes.Properties.Resources._1371475973_document_edit;
            this.btn_EditNote.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_EditNote.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_EditNote.Name = "btn_EditNote";
            this.btn_EditNote.Size = new System.Drawing.Size(49, 65);
            this.btn_EditNote.Text = "ویرایش";
            this.btn_EditNote.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_EditNote.ToolTipText = "ویرایش یادداشت";
            this.btn_EditNote.Click += new System.EventHandler(this.btn_EditNote_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 68);
            // 
            // btn_DeleteNote
            // 
            this.btn_DeleteNote.Image = global::Notes.Properties.Resources._1371476007_Close_Box_Red;
            this.btn_DeleteNote.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_DeleteNote.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_DeleteNote.Name = "btn_DeleteNote";
            this.btn_DeleteNote.Size = new System.Drawing.Size(44, 65);
            this.btn_DeleteNote.Text = "حذف";
            this.btn_DeleteNote.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_DeleteNote.ToolTipText = "حذف یادداشت";
            this.btn_DeleteNote.Click += new System.EventHandler(this.btn_DeleteNote_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 68);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Image = global::Notes.Properties.Resources._1371476342_Refresh;
            this.btn_Refresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(60, 65);
            this.btn_Refresh.Text = "بروزرسانی";
            this.btn_Refresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Refresh.ToolTipText = "بروزرسانی لیست";
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 68);
            // 
            // btn_PrintNote
            // 
            this.btn_PrintNote.Image = global::Notes.Properties.Resources._1371476276_Print;
            this.btn_PrintNote.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_PrintNote.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_PrintNote.Name = "btn_PrintNote";
            this.btn_PrintNote.Size = new System.Drawing.Size(44, 65);
            this.btn_PrintNote.Text = "چاپ";
            this.btn_PrintNote.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_PrintNote.ToolTipText = "چاپ یادداشت";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 68);
            // 
            // btn_Settings
            // 
            this.btn_Settings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تمرنگیToolStripMenuItem,
            this.خروجToolStripMenuItem});
            this.btn_Settings.Image = global::Notes.Properties.Resources._1371476120_fingerprint_reader;
            this.btn_Settings.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Settings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Settings.Name = "btn_Settings";
            this.btn_Settings.Size = new System.Drawing.Size(65, 65);
            this.btn_Settings.Text = "تنظیمات";
            this.btn_Settings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // تمرنگیToolStripMenuItem
            // 
            this.تمرنگیToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.تمرنگیToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.آبیToolStripMenuItem,
            this.نلرنجیToolStripMenuItem,
            this.صورتیToolStripMenuItem});
            this.تمرنگیToolStripMenuItem.Name = "تمرنگیToolStripMenuItem";
            this.تمرنگیToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.تمرنگیToolStripMenuItem.Text = "تم رنگی";
            // 
            // آبیToolStripMenuItem
            // 
            this.آبیToolStripMenuItem.BackColor = System.Drawing.Color.LightBlue;
            this.آبیToolStripMenuItem.Name = "آبیToolStripMenuItem";
            this.آبیToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.آبیToolStripMenuItem.Text = "آبی";
            this.آبیToolStripMenuItem.Click += new System.EventHandler(this.آبیToolStripMenuItem_Click);
            // 
            // نلرنجیToolStripMenuItem
            // 
            this.نلرنجیToolStripMenuItem.BackColor = System.Drawing.Color.Orange;
            this.نلرنجیToolStripMenuItem.Name = "نلرنجیToolStripMenuItem";
            this.نلرنجیToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.نلرنجیToolStripMenuItem.Text = "نارنجی";
            this.نلرنجیToolStripMenuItem.Click += new System.EventHandler(this.نلرنجیToolStripMenuItem_Click);
            // 
            // صورتیToolStripMenuItem
            // 
            this.صورتیToolStripMenuItem.BackColor = System.Drawing.Color.Violet;
            this.صورتیToolStripMenuItem.Name = "صورتیToolStripMenuItem";
            this.صورتیToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.صورتیToolStripMenuItem.Text = "صورتی";
            this.صورتیToolStripMenuItem.Click += new System.EventHandler(this.صورتیToolStripMenuItem_Click);
            // 
            // خروجToolStripMenuItem
            // 
            this.خروجToolStripMenuItem.BackColor = System.Drawing.Color.IndianRed;
            this.خروجToolStripMenuItem.Name = "خروجToolStripMenuItem";
            this.خروجToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.خروجToolStripMenuItem.Text = "خروج";
            this.خروجToolStripMenuItem.Click += new System.EventHandler(this.خروجToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 356);
            this.Controls.Add(this.groupPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "دفترچه یادداشت";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotes)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_Insert;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btn_EditNote;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btn_PrintNote;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripDropDownButton btn_Settings;
        private System.Windows.Forms.ToolStripMenuItem تمرنگیToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem آبیToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem نلرنجیToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem صورتیToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvNotes;
        private System.Windows.Forms.ToolStripButton btn_Refresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Note;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.ToolStripButton btn_DeleteNote;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem خروجToolStripMenuItem;
    }
}

