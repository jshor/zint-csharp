namespace zintcsharp.Symbologies
{
    partial class Code128
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
            this.encodingOptions = new System.Windows.Forms.GroupBox();
            this.stdRadio = new System.Windows.Forms.RadioButton();
            this.subsetCSuppression = new System.Windows.Forms.RadioButton();
            this.hibc128 = new System.Windows.Forms.RadioButton();
            this.encodingOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // encodingOptions
            // 
            this.encodingOptions.Controls.Add(this.hibc128);
            this.encodingOptions.Controls.Add(this.subsetCSuppression);
            this.encodingOptions.Controls.Add(this.stdRadio);
            this.encodingOptions.Location = new System.Drawing.Point(13, 9);
            this.encodingOptions.Name = "encodingOptions";
            this.encodingOptions.Size = new System.Drawing.Size(403, 115);
            this.encodingOptions.TabIndex = 0;
            this.encodingOptions.TabStop = false;
            this.encodingOptions.Text = "Encoding options";
            // 
            // stdRadio
            // 
            this.stdRadio.AutoSize = true;
            this.stdRadio.Checked = true;
            this.stdRadio.Location = new System.Drawing.Point(26, 33);
            this.stdRadio.Name = "stdRadio";
            this.stdRadio.Size = new System.Drawing.Size(68, 17);
            this.stdRadio.TabIndex = 0;
            this.stdRadio.TabStop = true;
            this.stdRadio.Text = "Standard";
            this.stdRadio.UseVisualStyleBackColor = true;
            this.stdRadio.CheckedChanged += new System.EventHandler(this.encodingRadioButton_OptionsChanged);
            // 
            // subsetCSuppression
            // 
            this.subsetCSuppression.AutoSize = true;
            this.subsetCSuppression.Location = new System.Drawing.Point(218, 33);
            this.subsetCSuppression.Name = "subsetCSuppression";
            this.subsetCSuppression.Size = new System.Drawing.Size(127, 17);
            this.subsetCSuppression.TabIndex = 1;
            this.subsetCSuppression.Text = "Subset C suppression";
            this.subsetCSuppression.UseVisualStyleBackColor = true;
            this.subsetCSuppression.CheckedChanged += new System.EventHandler(this.encodingRadioButton_OptionsChanged);
            // 
            // hibc128
            // 
            this.hibc128.AutoSize = true;
            this.hibc128.Location = new System.Drawing.Point(26, 71);
            this.hibc128.Name = "hibc128";
            this.hibc128.Size = new System.Drawing.Size(71, 17);
            this.hibc128.TabIndex = 2;
            this.hibc128.Text = "HIBC 128";
            this.hibc128.UseVisualStyleBackColor = true;
            this.hibc128.CheckedChanged += new System.EventHandler(this.encodingRadioButton_OptionsChanged);
            // 
            // Code128
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.encodingOptions);
            this.Name = "Code128";
            this.Size = new System.Drawing.Size(428, 243);
            this.encodingOptions.ResumeLayout(false);
            this.encodingOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox encodingOptions;
        private System.Windows.Forms.RadioButton hibc128;
        private System.Windows.Forms.RadioButton subsetCSuppression;
        private System.Windows.Forms.RadioButton stdRadio;
    }
}
