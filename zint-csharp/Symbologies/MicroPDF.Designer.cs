namespace zintcsharp.Symbologies
{
    partial class MicroPDF
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
            this.option2Label = new System.Windows.Forms.Label();
            this.stdRadio = new System.Windows.Forms.RadioButton();
            this.hibcRadio = new System.Windows.Forms.RadioButton();
            this.encodingModeGroup = new System.Windows.Forms.GroupBox();
            this.option2 = new zintcsharp.Symbologies.OptionBox();
            this.encodingModeGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // option2Label
            // 
            this.option2Label.AutoSize = true;
            this.option2Label.Location = new System.Drawing.Point(16, 24);
            this.option2Label.Name = "option2Label";
            this.option2Label.Size = new System.Drawing.Size(125, 13);
            this.option2Label.TabIndex = 1;
            this.option2Label.Text = "Number of data columns:";
            // 
            // stdRadio
            // 
            this.stdRadio.AutoSize = true;
            this.stdRadio.Location = new System.Drawing.Point(25, 34);
            this.stdRadio.Name = "stdRadio";
            this.stdRadio.Size = new System.Drawing.Size(68, 17);
            this.stdRadio.TabIndex = 2;
            this.stdRadio.TabStop = true;
            this.stdRadio.Text = "Standard";
            this.stdRadio.UseVisualStyleBackColor = true;
            this.stdRadio.CheckedChanged += new System.EventHandler(this.optionElement_OptionsChanged);
            // 
            // hibcRadio
            // 
            this.hibcRadio.AutoSize = true;
            this.hibcRadio.Location = new System.Drawing.Point(220, 34);
            this.hibcRadio.Name = "hibcRadio";
            this.hibcRadio.Size = new System.Drawing.Size(100, 17);
            this.hibcRadio.TabIndex = 3;
            this.hibcRadio.TabStop = true;
            this.hibcRadio.Text = "HIBC MicroPDF";
            this.hibcRadio.UseVisualStyleBackColor = true;
            this.hibcRadio.CheckedChanged += new System.EventHandler(this.optionElement_OptionsChanged);
            // 
            // encodingModeGroup
            // 
            this.encodingModeGroup.Controls.Add(this.hibcRadio);
            this.encodingModeGroup.Controls.Add(this.stdRadio);
            this.encodingModeGroup.Location = new System.Drawing.Point(18, 59);
            this.encodingModeGroup.Name = "encodingModeGroup";
            this.encodingModeGroup.Size = new System.Drawing.Size(390, 78);
            this.encodingModeGroup.TabIndex = 4;
            this.encodingModeGroup.TabStop = false;
            this.encodingModeGroup.Text = "Encoding mode";
            // 
            // option2
            // 
            this.option2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.option2.FormattingEnabled = true;
            this.option2.Location = new System.Drawing.Point(200, 21);
            this.option2.Name = "option2";
            this.option2.Size = new System.Drawing.Size(209, 21);
            this.option2.TabIndex = 0;
            this.option2.SelectedIndexChanged += new System.EventHandler(this.optionElement_OptionsChanged);
            // 
            // MicroPDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.encodingModeGroup);
            this.Controls.Add(this.option2Label);
            this.Controls.Add(this.option2);
            this.Name = "MicroPDF";
            this.Size = new System.Drawing.Size(428, 243);
            this.Load += new System.EventHandler(this.MicroPDF_Load);
            this.encodingModeGroup.ResumeLayout(false);
            this.encodingModeGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OptionBox option2;
        private System.Windows.Forms.Label option2Label;
        private System.Windows.Forms.RadioButton stdRadio;
        private System.Windows.Forms.RadioButton hibcRadio;
        private System.Windows.Forms.GroupBox encodingModeGroup;
    }
}
