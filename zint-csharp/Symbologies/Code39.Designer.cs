namespace zintcsharp.Symbologies
{
    partial class Code39
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
            this.hibc39 = new System.Windows.Forms.RadioButton();
            this.mod43ChkDigit = new System.Windows.Forms.RadioButton();
            this.stdRadio = new System.Windows.Forms.RadioButton();
            this.encodingOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // encodingOptions
            // 
            this.encodingOptions.Controls.Add(this.hibc39);
            this.encodingOptions.Controls.Add(this.mod43ChkDigit);
            this.encodingOptions.Controls.Add(this.stdRadio);
            this.encodingOptions.Location = new System.Drawing.Point(13, 13);
            this.encodingOptions.Name = "encodingOptions";
            this.encodingOptions.Size = new System.Drawing.Size(403, 115);
            this.encodingOptions.TabIndex = 2;
            this.encodingOptions.TabStop = false;
            this.encodingOptions.Text = "Encoding options";
            // 
            // hibc39
            // 
            this.hibc39.AutoSize = true;
            this.hibc39.Location = new System.Drawing.Point(26, 74);
            this.hibc39.Name = "hibc39";
            this.hibc39.Size = new System.Drawing.Size(65, 17);
            this.hibc39.TabIndex = 3;
            this.hibc39.Text = "HIBC 39";
            this.hibc39.UseVisualStyleBackColor = true;
            this.hibc39.CheckedChanged += new System.EventHandler(this.encodingRadioButton_OptionsChanged);
            // 
            // mod43ChkDigit
            // 
            this.mod43ChkDigit.AutoSize = true;
            this.mod43ChkDigit.Location = new System.Drawing.Point(248, 33);
            this.mod43ChkDigit.Name = "mod43ChkDigit";
            this.mod43ChkDigit.Size = new System.Drawing.Size(116, 17);
            this.mod43ChkDigit.TabIndex = 2;
            this.mod43ChkDigit.Text = "Mod-43 check digit";
            this.mod43ChkDigit.UseVisualStyleBackColor = true;
            this.mod43ChkDigit.CheckedChanged += new System.EventHandler(this.encodingRadioButton_OptionsChanged);
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
            // Code39
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.encodingOptions);
            this.Name = "Code39";
            this.Size = new System.Drawing.Size(428, 243);
            this.encodingOptions.ResumeLayout(false);
            this.encodingOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox encodingOptions;
        private System.Windows.Forms.RadioButton hibc39;
        private System.Windows.Forms.RadioButton mod43ChkDigit;
        private System.Windows.Forms.RadioButton stdRadio;
    }
}
