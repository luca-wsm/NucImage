
namespace NucImage
{
    partial class Panel
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Panel));
            this.targetUrlBox = new System.Windows.Forms.TextBox();
            this.outputBttn = new System.Windows.Forms.Button();
            this.startBttn = new System.Windows.Forms.Button();
            this.saveDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.targetAttribute = new System.Windows.Forms.TextBox();
            this.urlLabelLabel = new System.Windows.Forms.Label();
            this.attributeLabel = new System.Windows.Forms.Label();
            this.targetAttributeHelpLabel = new System.Windows.Forms.LinkLabel();
            this.logBox = new System.Windows.Forms.ListBox();
            this.saveVideo = new System.Windows.Forms.CheckBox();
            this.targetTag = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // targetUrlBox
            // 
            this.targetUrlBox.Location = new System.Drawing.Point(8, 26);
            this.targetUrlBox.Name = "targetUrlBox";
            this.targetUrlBox.PlaceholderText = "Target-URL";
            this.targetUrlBox.Size = new System.Drawing.Size(411, 23);
            this.targetUrlBox.TabIndex = 1;
            // 
            // outputBttn
            // 
            this.outputBttn.Location = new System.Drawing.Point(8, 466);
            this.outputBttn.Name = "outputBttn";
            this.outputBttn.Size = new System.Drawing.Size(145, 44);
            this.outputBttn.TabIndex = 2;
            this.outputBttn.Text = "› Select Output Folder";
            this.outputBttn.UseVisualStyleBackColor = true;
            this.outputBttn.Click += new System.EventHandler(this.outputBttn_Click);
            // 
            // startBttn
            // 
            this.startBttn.Location = new System.Drawing.Point(274, 466);
            this.startBttn.Name = "startBttn";
            this.startBttn.Size = new System.Drawing.Size(145, 44);
            this.startBttn.TabIndex = 4;
            this.startBttn.Text = "› Start";
            this.startBttn.UseVisualStyleBackColor = true;
            this.startBttn.Click += new System.EventHandler(this.startBttn_Click);
            // 
            // targetAttribute
            // 
            this.targetAttribute.Location = new System.Drawing.Point(8, 117);
            this.targetAttribute.Name = "targetAttribute";
            this.targetAttribute.PlaceholderText = "Target-Attribute";
            this.targetAttribute.Size = new System.Drawing.Size(411, 23);
            this.targetAttribute.TabIndex = 6;
            this.targetAttribute.Text = "src";
            // 
            // urlLabelLabel
            // 
            this.urlLabelLabel.AutoSize = true;
            this.urlLabelLabel.Location = new System.Drawing.Point(8, 8);
            this.urlLabelLabel.Name = "urlLabelLabel";
            this.urlLabelLabel.Size = new System.Drawing.Size(68, 15);
            this.urlLabelLabel.TabIndex = 7;
            this.urlLabelLabel.Text = "Target-URL:";
            // 
            // attributeLabel
            // 
            this.attributeLabel.AutoSize = true;
            this.attributeLabel.Location = new System.Drawing.Point(8, 96);
            this.attributeLabel.Name = "attributeLabel";
            this.attributeLabel.Size = new System.Drawing.Size(94, 15);
            this.attributeLabel.TabIndex = 8;
            this.attributeLabel.Text = "Target-Attribute:";
            // 
            // targetAttributeHelpLabel
            // 
            this.targetAttributeHelpLabel.AutoSize = true;
            this.targetAttributeHelpLabel.Location = new System.Drawing.Point(407, 99);
            this.targetAttributeHelpLabel.Name = "targetAttributeHelpLabel";
            this.targetAttributeHelpLabel.Size = new System.Drawing.Size(12, 15);
            this.targetAttributeHelpLabel.TabIndex = 9;
            this.targetAttributeHelpLabel.TabStop = true;
            this.targetAttributeHelpLabel.Text = "?";
            this.targetAttributeHelpLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.targetAttributeHelpLabel_LinkClicked);
            // 
            // logBox
            // 
            this.logBox.FormattingEnabled = true;
            this.logBox.HorizontalScrollbar = true;
            this.logBox.ItemHeight = 15;
            this.logBox.Items.AddRange(new object[] {
            "——————— { NucImage } ———————",
            "",
            "» Welcome to NucImage, a simple Data Scraper. ",
            "» Please enter a url and select a output folder to start.",
            "» You can copy any item by a double click.",
            "",
            "» Developed by Luca Wesemann ¯\\_(ツ)_/¯",
            "",
            "——————— { NucImage } ———————"});
            this.logBox.Location = new System.Drawing.Point(8, 171);
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(411, 289);
            this.logBox.TabIndex = 5;
            this.logBox.DoubleClick += new System.EventHandler(this.logBox_DoubleClick);
            // 
            // saveVideo
            // 
            this.saveVideo.AutoSize = true;
            this.saveVideo.Location = new System.Drawing.Point(8, 146);
            this.saveVideo.Name = "saveVideo";
            this.saveVideo.Size = new System.Drawing.Size(139, 19);
            this.saveVideo.TabIndex = 10;
            this.saveVideo.Text = "Enable Video Support";
            this.saveVideo.UseVisualStyleBackColor = true;
            // 
            // targetTag
            // 
            this.targetTag.Location = new System.Drawing.Point(8, 70);
            this.targetTag.Name = "targetTag";
            this.targetTag.PlaceholderText = "Target-Attribute";
            this.targetTag.Size = new System.Drawing.Size(411, 23);
            this.targetTag.TabIndex = 11;
            this.targetTag.Text = "img";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Target-Tag:";
            // 
            // Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 517);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.targetTag);
            this.Controls.Add(this.saveVideo);
            this.Controls.Add(this.targetAttributeHelpLabel);
            this.Controls.Add(this.attributeLabel);
            this.Controls.Add(this.urlLabelLabel);
            this.Controls.Add(this.targetAttribute);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.startBttn);
            this.Controls.Add(this.outputBttn);
            this.Controls.Add(this.targetUrlBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Panel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "» NucImage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox targetUrlBox;
        private System.Windows.Forms.Button outputBttn;
        public System.Windows.Forms.Button startBttn;
        private System.Windows.Forms.FolderBrowserDialog saveDialog;
        private System.Windows.Forms.TextBox targetAttribute;
        private System.Windows.Forms.Label urlLabelLabel;
        private System.Windows.Forms.Label attributeLabel;
        private System.Windows.Forms.LinkLabel targetAttributeHelpLabel;
        private System.Windows.Forms.ListBox logBox;
        private System.Windows.Forms.CheckBox saveVideo;
        private System.Windows.Forms.TextBox targetTag;
        private System.Windows.Forms.Label label1;
    }
}

