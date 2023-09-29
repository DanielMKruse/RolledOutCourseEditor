namespace RolledOutDevTool
{
    partial class FormCourse
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.stagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scanStageFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parametersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateNewCourseUUIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateNewCreatorUUIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textCreator = new System.Windows.Forms.TextBox();
            this.labelCreator = new System.Windows.Forms.Label();
            this.richTextDesc = new System.Windows.Forms.RichTextBox();
            this.labelDesc = new System.Windows.Forms.Label();
            this.textUUID = new System.Windows.Forms.TextBox();
            this.labelUUID = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textDiff = new System.Windows.Forms.TextBox();
            this.labelDiff = new System.Windows.Forms.Label();
            this.textConfVer = new System.Windows.Forms.TextBox();
            this.labelConfVer = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearStageListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.stagesToolStripMenuItem,
            this.parametersToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(362, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(114, 22);
            this.toolStripMenuItem2.Text = "Save";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(114, 22);
            this.toolStripMenuItem3.Text = "Save As";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // stagesToolStripMenuItem
            // 
            this.stagesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStagesToolStripMenuItem,
            this.scanStageFolderToolStripMenuItem,
            this.clearStageListToolStripMenuItem});
            this.stagesToolStripMenuItem.Name = "stagesToolStripMenuItem";
            this.stagesToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.stagesToolStripMenuItem.Text = "Stages";
            // 
            // addStagesToolStripMenuItem
            // 
            this.addStagesToolStripMenuItem.Name = "addStagesToolStripMenuItem";
            this.addStagesToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.addStagesToolStripMenuItem.Text = "Add Stages";
            this.addStagesToolStripMenuItem.Click += new System.EventHandler(this.addStagesToolStripMenuItem_Click);
            // 
            // scanStageFolderToolStripMenuItem
            // 
            this.scanStageFolderToolStripMenuItem.Name = "scanStageFolderToolStripMenuItem";
            this.scanStageFolderToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.scanStageFolderToolStripMenuItem.Text = "Scan Stages Folder";
            this.scanStageFolderToolStripMenuItem.Click += new System.EventHandler(this.scanStageFolderToolStripMenuItem_Click);
            // 
            // parametersToolStripMenuItem
            // 
            this.parametersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateNewCourseUUIDToolStripMenuItem,
            this.generateNewCreatorUUIDToolStripMenuItem});
            this.parametersToolStripMenuItem.Name = "parametersToolStripMenuItem";
            this.parametersToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.parametersToolStripMenuItem.Text = "UUIDs";
            // 
            // generateNewCourseUUIDToolStripMenuItem
            // 
            this.generateNewCourseUUIDToolStripMenuItem.Name = "generateNewCourseUUIDToolStripMenuItem";
            this.generateNewCourseUUIDToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.generateNewCourseUUIDToolStripMenuItem.Text = "Generate New Course UUID";
            this.generateNewCourseUUIDToolStripMenuItem.Click += new System.EventHandler(this.generateNewCourseUUIDToolStripMenuItem_Click);
            // 
            // generateNewCreatorUUIDToolStripMenuItem
            // 
            this.generateNewCreatorUUIDToolStripMenuItem.Name = "generateNewCreatorUUIDToolStripMenuItem";
            this.generateNewCreatorUUIDToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.generateNewCreatorUUIDToolStripMenuItem.Text = "Generate New Creator UUID";
            this.generateNewCreatorUUIDToolStripMenuItem.Click += new System.EventHandler(this.generateNewCreatorUUIDToolStripMenuItem_Click);
            // 
            // textCreator
            // 
            this.textCreator.Location = new System.Drawing.Point(12, 118);
            this.textCreator.Name = "textCreator";
            this.textCreator.Size = new System.Drawing.Size(338, 20);
            this.textCreator.TabIndex = 37;
            // 
            // labelCreator
            // 
            this.labelCreator.AutoSize = true;
            this.labelCreator.Location = new System.Drawing.Point(9, 102);
            this.labelCreator.Name = "labelCreator";
            this.labelCreator.Size = new System.Drawing.Size(71, 13);
            this.labelCreator.TabIndex = 36;
            this.labelCreator.Text = "Creator UUID";
            // 
            // richTextDesc
            // 
            this.richTextDesc.Location = new System.Drawing.Point(12, 157);
            this.richTextDesc.Name = "richTextDesc";
            this.richTextDesc.Size = new System.Drawing.Size(338, 73);
            this.richTextDesc.TabIndex = 35;
            this.richTextDesc.Text = "";
            // 
            // labelDesc
            // 
            this.labelDesc.AutoSize = true;
            this.labelDesc.Location = new System.Drawing.Point(9, 141);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(60, 13);
            this.labelDesc.TabIndex = 34;
            this.labelDesc.Text = "Description";
            // 
            // textUUID
            // 
            this.textUUID.Location = new System.Drawing.Point(12, 79);
            this.textUUID.Name = "textUUID";
            this.textUUID.Size = new System.Drawing.Size(338, 20);
            this.textUUID.TabIndex = 33;
            // 
            // labelUUID
            // 
            this.labelUUID.AutoSize = true;
            this.labelUUID.Location = new System.Drawing.Point(9, 63);
            this.labelUUID.Name = "labelUUID";
            this.labelUUID.Size = new System.Drawing.Size(70, 13);
            this.labelUUID.TabIndex = 32;
            this.labelUUID.Text = "Course UUID";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(12, 40);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(142, 20);
            this.textName.TabIndex = 31;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(9, 24);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 30;
            this.labelName.Text = "Name";
            // 
            // textDiff
            // 
            this.textDiff.Location = new System.Drawing.Point(160, 40);
            this.textDiff.Name = "textDiff";
            this.textDiff.Size = new System.Drawing.Size(92, 20);
            this.textDiff.TabIndex = 27;
            // 
            // labelDiff
            // 
            this.labelDiff.AutoSize = true;
            this.labelDiff.Location = new System.Drawing.Point(157, 24);
            this.labelDiff.Name = "labelDiff";
            this.labelDiff.Size = new System.Drawing.Size(47, 13);
            this.labelDiff.TabIndex = 26;
            this.labelDiff.Text = "Difficulty";
            // 
            // textConfVer
            // 
            this.textConfVer.Location = new System.Drawing.Point(258, 40);
            this.textConfVer.Name = "textConfVer";
            this.textConfVer.Size = new System.Drawing.Size(92, 20);
            this.textConfVer.TabIndex = 25;
            // 
            // labelConfVer
            // 
            this.labelConfVer.AutoSize = true;
            this.labelConfVer.Location = new System.Drawing.Point(255, 24);
            this.labelConfVer.Name = "labelConfVer";
            this.labelConfVer.Size = new System.Drawing.Size(59, 13);
            this.labelConfVer.TabIndex = 24;
            this.labelConfVer.Text = "Config Ver.";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 236);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(338, 412);
            this.dataGridView1.TabIndex = 38;
            this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDown);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseMove);
            this.dataGridView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseUp);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // clearStageListToolStripMenuItem
            // 
            this.clearStageListToolStripMenuItem.Name = "clearStageListToolStripMenuItem";
            this.clearStageListToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clearStageListToolStripMenuItem.Text = "Clear Stage List";
            this.clearStageListToolStripMenuItem.Click += new System.EventHandler(this.clearStageListToolStripMenuItem_Click);
            // 
            // FormCourse
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 656);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textCreator);
            this.Controls.Add(this.labelCreator);
            this.Controls.Add(this.richTextDesc);
            this.Controls.Add(this.labelDesc);
            this.Controls.Add(this.textUUID);
            this.Controls.Add(this.labelUUID);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textDiff);
            this.Controls.Add(this.labelDiff);
            this.Controls.Add(this.textConfVer);
            this.Controls.Add(this.labelConfVer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormCourse";
            this.Load += new System.EventHandler(this.FormChild_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.TextBox textCreator;
        private System.Windows.Forms.Label labelCreator;
        private System.Windows.Forms.RichTextBox richTextDesc;
        private System.Windows.Forms.Label labelDesc;
        private System.Windows.Forms.TextBox textUUID;
        private System.Windows.Forms.Label labelUUID;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textDiff;
        private System.Windows.Forms.Label labelDiff;
        private System.Windows.Forms.TextBox textConfVer;
        private System.Windows.Forms.Label labelConfVer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem parametersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateNewCourseUUIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateNewCreatorUUIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scanStageFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearStageListToolStripMenuItem;
    }
}