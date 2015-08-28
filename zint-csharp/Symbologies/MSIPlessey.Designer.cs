namespace zintcsharp.Symbologies
{
    partial class MSIPlessey
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
            this.channelLabel = new System.Windows.Forms.Label();
            this.option2 = new zintcsharp.Symbologies.OptionBox();
            this.SuspendLayout();
            // 
            // channelLabel
            // 
            this.channelLabel.AutoSize = true;
            this.channelLabel.Location = new System.Drawing.Point(20, 33);
            this.channelLabel.Name = "channelLabel";
            this.channelLabel.Size = new System.Drawing.Size(63, 13);
            this.channelLabel.TabIndex = 3;
            this.channelLabel.Text = "Check digit:";
            // 
            // option2
            // 
            this.option2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.option2.FormattingEnabled = true;
            this.option2.Location = new System.Drawing.Point(190, 29);
            this.option2.Name = "option2";
            this.option2.Size = new System.Drawing.Size(195, 21);
            this.option2.TabIndex = 0;
            this.option2.SelectedIndexChanged += new System.EventHandler(this.option2_OptionsChanged);
            // 
            // MSIPlessey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.channelLabel);
            this.Controls.Add(this.option2);
            this.Name = "MSIPlessey";
            this.Size = new System.Drawing.Size(428, 243);
            this.Load += new System.EventHandler(this.MSIPlessey_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OptionBox option2;
        private System.Windows.Forms.Label channelLabel;
    }
}
