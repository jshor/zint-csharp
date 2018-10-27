namespace zintcsharp.Symbologies
{
    partial class Code49
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
            this.gs1DataMode = new System.Windows.Forms.RadioButton();
            this.stdRadio = new System.Windows.Forms.RadioButton();
            this.encodingOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // encodingOptions
            // 
            this.encodingOptions.Controls.Add(this.gs1DataMode);
            this.encodingOptions.Controls.Add(this.stdRadio);
            this.encodingOptions.Location = new System.Drawing.Point(13, 12);
            this.encodingOptions.Name = "encodingOptions";
            this.encodingOptions.Size = new System.Drawing.Size(403, 76);
            this.encodingOptions.TabIndex = 2;
            this.encodingOptions.TabStop = false;
            this.encodingOptions.Text = "Encoding options";
            // 
            // gs1DataMode
            // 
            this.gs1DataMode.AutoSize = true;
            this.gs1DataMode.Location = new System.Drawing.Point(248, 33);
            this.gs1DataMode.Name = "gs1DataMode";
            this.gs1DataMode.Size = new System.Drawing.Size(99, 17);
            this.gs1DataMode.TabIndex = 2;
            this.gs1DataMode.Text = "GS1 data mode";
            this.gs1DataMode.UseVisualStyleBackColor = true;
            this.gs1DataMode.CheckedChanged += new System.EventHandler(this.encodingRadioButton_OptionsChanged);
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
            // Code49
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.encodingOptions);
            this.Name = "Code49";
            this.Size = new System.Drawing.Size(428, 243);
            this.encodingOptions.ResumeLayout(false);
            this.encodingOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox encodingOptions;
        private System.Windows.Forms.RadioButton gs1DataMode;
        private System.Windows.Forms.RadioButton stdRadio;
    }
}
