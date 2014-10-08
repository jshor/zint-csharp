namespace ZintWrapper.Symbologies
{
    partial class MaxiCode
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
            this.option1 = new ZintWrapper.Symbologies.OptionBox();
            this.SuspendLayout();
            // 
            // option1
            // 
            this.option1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.option1.FormattingEnabled = true;
            this.option1.Location = new System.Drawing.Point(189, 19);
            this.option1.Name = "option1";
            this.option1.Size = new System.Drawing.Size(222, 21);
            this.option1.TabIndex = 0;
            this.option1.SelectedIndexChanged += new System.EventHandler(this.optionElement_OptionsChanged);
            // 
            // MaxiCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.option1);
            this.Name = "MaxiCode";
            this.Size = new System.Drawing.Size(428, 243);
            this.Load += new System.EventHandler(this.MaxiCode_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private OptionBox option1;
    }
}
