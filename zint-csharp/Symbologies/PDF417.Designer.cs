namespace zintcsharp.Symbologies
{
    partial class PDF417
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
            this.sizeGroupBox = new System.Windows.Forms.GroupBox();
            this.dataCols = new System.Windows.Forms.Label();
            this.encodingGroupBox = new System.Windows.Forms.GroupBox();
            this.hibcMode = new System.Windows.Forms.RadioButton();
            this.truncatedMode = new System.Windows.Forms.RadioButton();
            this.standardMode = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.option1 = new zintcsharp.Symbologies.OptionBox();
            this.option2 = new zintcsharp.Symbologies.OptionBox();
            this.sizeGroupBox.SuspendLayout();
            this.encodingGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // sizeGroupBox
            // 
            this.sizeGroupBox.Controls.Add(this.label1);
            this.sizeGroupBox.Controls.Add(this.dataCols);
            this.sizeGroupBox.Controls.Add(this.option1);
            this.sizeGroupBox.Controls.Add(this.option2);
            this.sizeGroupBox.Location = new System.Drawing.Point(13, 10);
            this.sizeGroupBox.Name = "sizeGroupBox";
            this.sizeGroupBox.Size = new System.Drawing.Size(403, 102);
            this.sizeGroupBox.TabIndex = 8;
            this.sizeGroupBox.TabStop = false;
            this.sizeGroupBox.Text = "Symbology size";
            // 
            // dataCols
            // 
            this.dataCols.AutoSize = true;
            this.dataCols.Location = new System.Drawing.Point(17, 30);
            this.dataCols.Name = "dataCols";
            this.dataCols.Size = new System.Drawing.Size(125, 13);
            this.dataCols.TabIndex = 6;
            this.dataCols.Text = "Number of data columns:";
            // 
            // encodingGroupBox
            // 
            this.encodingGroupBox.Controls.Add(this.hibcMode);
            this.encodingGroupBox.Controls.Add(this.truncatedMode);
            this.encodingGroupBox.Controls.Add(this.standardMode);
            this.encodingGroupBox.Location = new System.Drawing.Point(13, 118);
            this.encodingGroupBox.Name = "encodingGroupBox";
            this.encodingGroupBox.Size = new System.Drawing.Size(403, 118);
            this.encodingGroupBox.TabIndex = 7;
            this.encodingGroupBox.TabStop = false;
            this.encodingGroupBox.Text = "Encoding mode";
            // 
            // hibcMode
            // 
            this.hibcMode.AutoSize = true;
            this.hibcMode.Location = new System.Drawing.Point(20, 66);
            this.hibcMode.Name = "hibcMode";
            this.hibcMode.Size = new System.Drawing.Size(92, 17);
            this.hibcMode.TabIndex = 8;
            this.hibcMode.TabStop = true;
            this.hibcMode.Text = "HIBC PDF417";
            this.hibcMode.UseVisualStyleBackColor = true;
            this.hibcMode.CheckedChanged += new System.EventHandler(this.optionElement_OptionsChanged);
            // 
            // truncatedMode
            // 
            this.truncatedMode.AutoSize = true;
            this.truncatedMode.Location = new System.Drawing.Point(190, 34);
            this.truncatedMode.Name = "truncatedMode";
            this.truncatedMode.Size = new System.Drawing.Size(74, 17);
            this.truncatedMode.TabIndex = 7;
            this.truncatedMode.TabStop = true;
            this.truncatedMode.Text = "Truncated";
            this.truncatedMode.UseVisualStyleBackColor = true;
            this.truncatedMode.CheckedChanged += new System.EventHandler(this.optionElement_OptionsChanged);
            // 
            // standardMode
            // 
            this.standardMode.AutoSize = true;
            this.standardMode.Checked = true;
            this.standardMode.Location = new System.Drawing.Point(20, 34);
            this.standardMode.Name = "standardMode";
            this.standardMode.Size = new System.Drawing.Size(97, 17);
            this.standardMode.TabIndex = 6;
            this.standardMode.TabStop = true;
            this.standardMode.Text = "Standard mode";
            this.standardMode.UseVisualStyleBackColor = true;
            this.standardMode.CheckedChanged += new System.EventHandler(this.optionElement_OptionsChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Error correction capacity:";
            // 
            // option1
            // 
            this.option1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.option1.FormattingEnabled = true;
            this.option1.Location = new System.Drawing.Point(190, 27);
            this.option1.Name = "option1";
            this.option1.Size = new System.Drawing.Size(195, 21);
            this.option1.TabIndex = 5;
            this.option1.SelectedIndexChanged += new System.EventHandler(this.optionElement_OptionsChanged);
            // 
            // option2
            // 
            this.option2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.option2.FormattingEnabled = true;
            this.option2.Location = new System.Drawing.Point(190, 59);
            this.option2.Name = "option2";
            this.option2.Size = new System.Drawing.Size(195, 21);
            this.option2.TabIndex = 3;
            this.option2.SelectedIndexChanged += new System.EventHandler(this.optionElement_OptionsChanged);
            // 
            // PDF417
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sizeGroupBox);
            this.Controls.Add(this.encodingGroupBox);
            this.Name = "PDF417";
            this.Size = new System.Drawing.Size(428, 243);
            this.Load += new System.EventHandler(this.PDF417_Load);
            this.sizeGroupBox.ResumeLayout(false);
            this.sizeGroupBox.PerformLayout();
            this.encodingGroupBox.ResumeLayout(false);
            this.encodingGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox sizeGroupBox;
        private OptionBox option2;
        private System.Windows.Forms.GroupBox encodingGroupBox;
        private System.Windows.Forms.RadioButton hibcMode;
        private System.Windows.Forms.RadioButton truncatedMode;
        private System.Windows.Forms.RadioButton standardMode;
        private System.Windows.Forms.Label dataCols;
        private OptionBox option1;
        private System.Windows.Forms.Label label1;
    }
}
