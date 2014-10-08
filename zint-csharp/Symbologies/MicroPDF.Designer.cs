namespace ZintWrapper.Symbologies
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.option2 = new ZintWrapper.Symbologies.OptionBox();
            this.groupBox1.SuspendLayout();
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
            this.stdRadio.Location = new System.Drawing.Point(21, 34);
            this.stdRadio.Name = "stdRadio";
            this.stdRadio.Size = new System.Drawing.Size(67, 17);
            this.stdRadio.TabIndex = 2;
            this.stdRadio.TabStop = true;
            this.stdRadio.Text = "stdRadio";
            this.stdRadio.UseVisualStyleBackColor = true;
            this.stdRadio.CheckedChanged += new System.EventHandler(this.optionElement_OptionsChanged);
            // 
            // hibcRadio
            // 
            this.hibcRadio.AutoSize = true;
            this.hibcRadio.Location = new System.Drawing.Point(38, 57);
            this.hibcRadio.Name = "hibcRadio";
            this.hibcRadio.Size = new System.Drawing.Size(73, 17);
            this.hibcRadio.TabIndex = 3;
            this.hibcRadio.TabStop = true;
            this.hibcRadio.Text = "hibcRadio";
            this.hibcRadio.UseVisualStyleBackColor = true;
            this.hibcRadio.CheckedChanged += new System.EventHandler(this.optionElement_OptionsChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hibcRadio);
            this.groupBox1.Controls.Add(this.stdRadio);
            this.groupBox1.Location = new System.Drawing.Point(19, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 164);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
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
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.option2Label);
            this.Controls.Add(this.option2);
            this.Name = "MicroPDF";
            this.Size = new System.Drawing.Size(428, 243);
            this.Load += new System.EventHandler(this.MicroPDF_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OptionBox option2;
        private System.Windows.Forms.Label option2Label;
        private System.Windows.Forms.RadioButton stdRadio;
        private System.Windows.Forms.RadioButton hibcRadio;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
