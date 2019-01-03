namespace AgilePointTools.APTools.GenerateShapeProperties
{
    partial class ShapeProperties
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnReset = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnGenerateShapeProps = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.picBoxFolderDialog_ArchiveDir = new System.Windows.Forms.PictureBox();
            this.txtArchiveDirectory = new System.Windows.Forms.TextBox();
            this.lblArchiveDirectory = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picBoxFolderDialog_Source = new System.Windows.Forms.PictureBox();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.lblSource = new System.Windows.Forms.Label();
            this.toolTipShapeProps = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFolderDialog_ArchiveDir)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFolderDialog_Source)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnReset.Location = new System.Drawing.Point(655, 500);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(111, 33);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.53179F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.52601F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.86223F));
            this.tableLayoutPanel1.Controls.Add(this.lblTitle, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(200, 53);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(692, 34);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(185, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(332, 29);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Generate Shape Properties";
            // 
            // btnGenerateShapeProps
            // 
            this.btnGenerateShapeProps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerateShapeProps.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateShapeProps.Location = new System.Drawing.Point(781, 499);
            this.btnGenerateShapeProps.Name = "btnGenerateShapeProps";
            this.btnGenerateShapeProps.Size = new System.Drawing.Size(111, 33);
            this.btnGenerateShapeProps.TabIndex = 9;
            this.btnGenerateShapeProps.Text = "Generate";
            this.btnGenerateShapeProps.UseVisualStyleBackColor = true;
            this.btnGenerateShapeProps.Click += new System.EventHandler(this.btnGenerateShapeProps_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(200, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(692, 337);
            this.panel1.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.picBoxFolderDialog_ArchiveDir);
            this.groupBox2.Controls.Add(this.txtArchiveDirectory);
            this.groupBox2.Controls.Add(this.lblArchiveDirectory);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(33, 187);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(621, 101);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "OUTPUT";
            // 
            // picBoxFolderDialog_ArchiveDir
            // 
            this.picBoxFolderDialog_ArchiveDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBoxFolderDialog_ArchiveDir.Image = global::AgilePointTools.APToolsResource.open_folder;
            this.picBoxFolderDialog_ArchiveDir.Location = new System.Drawing.Point(565, 47);
            this.picBoxFolderDialog_ArchiveDir.Name = "picBoxFolderDialog_ArchiveDir";
            this.picBoxFolderDialog_ArchiveDir.Size = new System.Drawing.Size(25, 25);
            this.picBoxFolderDialog_ArchiveDir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxFolderDialog_ArchiveDir.TabIndex = 6;
            this.picBoxFolderDialog_ArchiveDir.TabStop = false;
            this.picBoxFolderDialog_ArchiveDir.Click += new System.EventHandler(this.picBoxFolderDialog_ArchiveDir_Click);
            // 
            // txtArchiveDirectory
            // 
            this.txtArchiveDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArchiveDirectory.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtArchiveDirectory.Location = new System.Drawing.Point(33, 50);
            this.txtArchiveDirectory.Name = "txtArchiveDirectory";
            this.txtArchiveDirectory.Size = new System.Drawing.Size(516, 24);
            this.txtArchiveDirectory.TabIndex = 1;
            this.toolTipShapeProps.SetToolTip(this.txtArchiveDirectory, "E.g. - \"D:\\TFS\\Main\\Src\\Common\\Scripts\\ShapeProperties\"");
            // 
            // lblArchiveDirectory
            // 
            this.lblArchiveDirectory.AutoSize = true;
            this.lblArchiveDirectory.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArchiveDirectory.Location = new System.Drawing.Point(30, 33);
            this.lblArchiveDirectory.Name = "lblArchiveDirectory";
            this.lblArchiveDirectory.Size = new System.Drawing.Size(105, 16);
            this.lblArchiveDirectory.TabIndex = 0;
            this.lblArchiveDirectory.Text = "Archive Directory";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.picBoxFolderDialog_Source);
            this.groupBox1.Controls.Add(this.txtSource);
            this.groupBox1.Controls.Add(this.lblSource);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(33, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(621, 101);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INPUT";
            // 
            // picBoxFolderDialog_Source
            // 
            this.picBoxFolderDialog_Source.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBoxFolderDialog_Source.Image = global::AgilePointTools.APToolsResource.open_folder;
            this.picBoxFolderDialog_Source.Location = new System.Drawing.Point(565, 49);
            this.picBoxFolderDialog_Source.Name = "picBoxFolderDialog_Source";
            this.picBoxFolderDialog_Source.Size = new System.Drawing.Size(25, 25);
            this.picBoxFolderDialog_Source.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxFolderDialog_Source.TabIndex = 5;
            this.picBoxFolderDialog_Source.TabStop = false;
            this.picBoxFolderDialog_Source.Click += new System.EventHandler(this.picBoxFolderDialog_Source_Click);
            // 
            // txtSource
            // 
            this.txtSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSource.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtSource.Location = new System.Drawing.Point(33, 50);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(516, 24);
            this.txtSource.TabIndex = 1;
            this.toolTipShapeProps.SetToolTip(this.txtSource, "E.g. - \"D:\\TFS\\Main\\Src\"");
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSource.Location = new System.Drawing.Point(30, 33);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(48, 16);
            this.lblSource.TabIndex = 0;
            this.lblSource.Text = "Source";
            // 
            // ShapeProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnGenerateShapeProps);
            this.Controls.Add(this.panel1);
            this.Name = "ShapeProperties";
            this.Size = new System.Drawing.Size(1110, 621);
            this.Load += new System.EventHandler(this.ShapeProperties_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFolderDialog_ArchiveDir)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFolderDialog_Source)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnGenerateShapeProps;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox picBoxFolderDialog_ArchiveDir;
        private System.Windows.Forms.TextBox txtArchiveDirectory;
        private System.Windows.Forms.Label lblArchiveDirectory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picBoxFolderDialog_Source;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.ToolTip toolTipShapeProps;
    }
}
