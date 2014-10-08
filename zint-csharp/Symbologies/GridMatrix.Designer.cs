namespace ZintWrapper.Symbologies
{
    partial class GridMatrix
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
            this.option2Selected = new System.Windows.Forms.RadioButton();
            this.autoResize = new System.Windows.Forms.RadioButton();
            this.option1Selected = new System.Windows.Forms.RadioButton();
            this.option2 = new ZintWrapper.Symbologies.OptionBox();
            this.option1 = new ZintWrapper.Symbologies.OptionBox();
            this.sizeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // sizeGroupBox
            // 
            this.sizeGroupBox.Controls.Add(this.option2);
            this.sizeGroupBox.Controls.Add(this.option1);
            this.sizeGroupBox.Controls.Add(this.option2Selected);
            this.sizeGroupBox.Controls.Add(this.autoResize);
            this.sizeGroupBox.Controls.Add(this.option1Selected);
            this.sizeGroupBox.Location = new System.Drawing.Point(12, 12);
            this.sizeGroupBox.Name = "sizeGroupBox";
            this.sizeGroupBox.Size = new System.Drawing.Size(403, 123);
            this.sizeGroupBox.TabIndex = 7;
            this.sizeGroupBox.TabStop = false;
            this.sizeGroupBox.Text = "Symbology size";
            // 
            // option2Selected
            // 
            this.option2Selected.AutoSize = true;
            this.option2Selected.Location = new System.Drawing.Point(20, 84);
            this.option2Selected.Name = "option2Selected";
            this.option2Selected.Size = new System.Drawing.Size(164, 17);
            this.option2Selected.TabIndex = 2;
            this.option2Selected.TabStop = true;
            this.option2Selected.Text = "Add minimum error correction:";
            this.option2Selected.UseVisualStyleBackColor = true;
            this.option2Selected.CheckedChanged += new System.EventHandler(this.option_SelectedIndexChanged);
            // 
            // autoResize
            // 
            this.autoResize.AutoSize = true;
            this.autoResize.Checked = true;
            this.autoResize.Location = new System.Drawing.Point(20, 24);
            this.autoResize.Name = "autoResize";
            this.autoResize.Size = new System.Drawing.Size(110, 17);
            this.autoResize.TabIndex = 0;
            this.autoResize.TabStop = true;
            this.autoResize.Text = "Automatic resizing";
            this.autoResize.UseVisualStyleBackColor = true;
            this.autoResize.CheckedChanged += new System.EventHandler(this.optionElement_OptionsChanged);
            // 
            // option1Selected
            // 
            this.option1Selected.AutoSize = true;
            this.option1Selected.Location = new System.Drawing.Point(20, 54);
            this.option1Selected.Name = "option1Selected";
            this.option1Selected.Size = new System.Drawing.Size(90, 17);
            this.option1Selected.TabIndex = 1;
            this.option1Selected.TabStop = true;
            this.option1Selected.Text = "Adjust size to:";
            this.option1Selected.UseVisualStyleBackColor = true;
            this.option1Selected.CheckedChanged += new System.EventHandler(this.optionElement_OptionsChanged);
            // 
            // option2
            // 
            this.option2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.option2.Enabled = false;
            this.option2.FormattingEnabled = true;
            this.option2.Location = new System.Drawing.Point(190, 84);
            this.option2.Name = "option2";
            this.option2.Size = new System.Drawing.Size(195, 21);
            this.option2.TabIndex = 4;
            this.option2.SelectedIndexChanged += new System.EventHandler(this.option_SelectedIndexChanged);
            // 
            // option1
            // 
            this.option1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.option1.Enabled = false;
            this.option1.FormattingEnabled = true;
            this.option1.Location = new System.Drawing.Point(190, 50);
            this.option1.Name = "option1";
            this.option1.Size = new System.Drawing.Size(195, 21);
            this.option1.TabIndex = 3;
            this.option1.SelectedIndexChanged += new System.EventHandler(this.option_SelectedIndexChanged);
            // 
            // GridMatrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sizeGroupBox);
            this.Name = "GridMatrix";
            this.Size = new System.Drawing.Size(428, 243);
            this.Load += new System.EventHandler(this.GridMatrix_Load);
            this.sizeGroupBox.ResumeLayout(false);
            this.sizeGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox sizeGroupBox;
        private OptionBox option2;
        private OptionBox option1;
        private System.Windows.Forms.RadioButton option2Selected;
        private System.Windows.Forms.RadioButton autoResize;
        private System.Windows.Forms.RadioButton option1Selected;
    }
}
