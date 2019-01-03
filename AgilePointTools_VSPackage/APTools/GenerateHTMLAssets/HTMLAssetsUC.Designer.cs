namespace AgilePointTools_VSPackage.APTools.GenerateHTMLAssets
{
    partial class HTMLAssetsUC
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
            this.btnGenerateHTMLAssets = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.picBox_HTMLAssestsDesti = new System.Windows.Forms.PictureBox();
            this.txtHTMLDestination = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picBoxFolderDialog_HTMLSource = new System.Windows.Forms.PictureBox();
            this.picBoxFileDialog_SourceXml = new System.Windows.Forms.PictureBox();
            this.txtHTMLSource = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSourceXML = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnReset = new System.Windows.Forms.Button();
            this.toolTipHTMLAssets = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_HTMLAssestsDesti)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFolderDialog_HTMLSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFileDialog_SourceXml)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerateHTMLAssets
            // 
            this.btnGenerateHTMLAssets.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerateHTMLAssets.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateHTMLAssets.Location = new System.Drawing.Point(781, 496);
            this.btnGenerateHTMLAssets.Name = "btnGenerateHTMLAssets";
            this.btnGenerateHTMLAssets.Size = new System.Drawing.Size(111, 33);
            this.btnGenerateHTMLAssets.TabIndex = 4;
            this.btnGenerateHTMLAssets.Text = "Generate";
            this.btnGenerateHTMLAssets.UseVisualStyleBackColor = true;
            this.btnGenerateHTMLAssets.Click += new System.EventHandler(this.btnGenerateHTMLAssets_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(200, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(692, 337);
            this.panel1.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.picBox_HTMLAssestsDesti);
            this.groupBox2.Controls.Add(this.txtHTMLDestination);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(33, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(621, 101);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "OUTPUT";
            // 
            // picBox_HTMLAssestsDesti
            // 
            this.picBox_HTMLAssestsDesti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBox_HTMLAssestsDesti.Image = global::AgilePointTools.APToolsResource.open_folder;
            this.picBox_HTMLAssestsDesti.Location = new System.Drawing.Point(565, 47);
            this.picBox_HTMLAssestsDesti.Name = "picBox_HTMLAssestsDesti";
            this.picBox_HTMLAssestsDesti.Size = new System.Drawing.Size(25, 25);
            this.picBox_HTMLAssestsDesti.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_HTMLAssestsDesti.TabIndex = 6;
            this.picBox_HTMLAssestsDesti.TabStop = false;
            this.picBox_HTMLAssestsDesti.Click += new System.EventHandler(this.picBox_HTMLAssestsDesti_Click);
            // 
            // txtHTMLDestination
            // 
            this.txtHTMLDestination.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHTMLDestination.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtHTMLDestination.Location = new System.Drawing.Point(33, 50);
            this.txtHTMLDestination.Name = "txtHTMLDestination";
            this.txtHTMLDestination.Size = new System.Drawing.Size(516, 24);
            this.txtHTMLDestination.TabIndex = 1;
            this.toolTipHTMLAssets.SetToolTip(this.txtHTMLDestination, "E.g. - \"D:\\TFS\\Main\\Src\\Common\\Scripts\\HTMLAssets\"");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "HTML Assets Destination";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.picBoxFolderDialog_HTMLSource);
            this.groupBox1.Controls.Add(this.picBoxFileDialog_SourceXml);
            this.groupBox1.Controls.Add(this.txtHTMLSource);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSourceXML);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(33, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(621, 166);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INPUT";
            // 
            // picBoxFolderDialog_HTMLSource
            // 
            this.picBoxFolderDialog_HTMLSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBoxFolderDialog_HTMLSource.Image = global::AgilePointTools.APToolsResource.open_folder;
            this.picBoxFolderDialog_HTMLSource.Location = new System.Drawing.Point(565, 106);
            this.picBoxFolderDialog_HTMLSource.Name = "picBoxFolderDialog_HTMLSource";
            this.picBoxFolderDialog_HTMLSource.Size = new System.Drawing.Size(25, 25);
            this.picBoxFolderDialog_HTMLSource.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxFolderDialog_HTMLSource.TabIndex = 5;
            this.picBoxFolderDialog_HTMLSource.TabStop = false;
            this.picBoxFolderDialog_HTMLSource.Click += new System.EventHandler(this.picBoxFolderDialog_HTMLSource_Click);
            // 
            // picBoxFileDialog_SourceXml
            // 
            this.picBoxFileDialog_SourceXml.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBoxFileDialog_SourceXml.Image = global::AgilePointTools.APToolsResource.open_file;
            this.picBoxFileDialog_SourceXml.Location = new System.Drawing.Point(565, 47);
            this.picBoxFileDialog_SourceXml.Name = "picBoxFileDialog_SourceXml";
            this.picBoxFileDialog_SourceXml.Size = new System.Drawing.Size(25, 25);
            this.picBoxFileDialog_SourceXml.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxFileDialog_SourceXml.TabIndex = 4;
            this.picBoxFileDialog_SourceXml.TabStop = false;
            this.picBoxFileDialog_SourceXml.Click += new System.EventHandler(this.picBoxFileDialog_Click);
            // 
            // txtHTMLSource
            // 
            this.txtHTMLSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHTMLSource.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtHTMLSource.Location = new System.Drawing.Point(33, 110);
            this.txtHTMLSource.Name = "txtHTMLSource";
            this.txtHTMLSource.Size = new System.Drawing.Size(516, 24);
            this.txtHTMLSource.TabIndex = 3;
            this.toolTipHTMLAssets.SetToolTip(this.txtHTMLSource, "E.g. - \"D:\\TFS\\Main\\Src\\NXCore\\NX Portal\\modules\\ConfigurationDialogues\"");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "HTML Source";
            // 
            // txtSourceXML
            // 
            this.txtSourceXML.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSourceXML.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtSourceXML.Location = new System.Drawing.Point(33, 50);
            this.txtSourceXML.Name = "txtSourceXML";
            this.txtSourceXML.Size = new System.Drawing.Size(516, 24);
            this.txtSourceXML.TabIndex = 1;
            this.toolTipHTMLAssets.SetToolTip(this.txtSourceXML, "Provide \"OOTBAgileShapesManifest.xml\" file Path");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source XML";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(211, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(280, 29);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Generate HTML Assets";
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(200, 52);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(692, 34);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnReset.Location = new System.Drawing.Point(655, 497);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(111, 33);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // HTMLAssetsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnGenerateHTMLAssets);
            this.Controls.Add(this.panel1);
            this.Name = "HTMLAssetsUC";
            this.Size = new System.Drawing.Size(1110, 621);
            this.Load += new System.EventHandler(this.HTMLAssetsUC_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_HTMLAssestsDesti)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFolderDialog_HTMLSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFileDialog_SourceXml)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGenerateHTMLAssets;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtHTMLDestination;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtHTMLSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSourceXML;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox picBoxFileDialog_SourceXml;
        private System.Windows.Forms.PictureBox picBox_HTMLAssestsDesti;
        private System.Windows.Forms.PictureBox picBoxFolderDialog_HTMLSource;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ToolTip toolTipHTMLAssets;
    }
}
