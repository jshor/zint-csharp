namespace zintcsharp.Symbologies
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
            this.option1 = new zintcsharp.Symbologies.OptionBox();
            this.option1Label = new System.Windows.Forms.Label();
            this.primaryTextLabel = new System.Windows.Forms.Label();
            this.primaryText = new System.Windows.Forms.TextBox();
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
            // option1Label
            // 
            this.option1Label.AutoSize = true;
            this.option1Label.Location = new System.Drawing.Point(17, 22);
            this.option1Label.Name = "option1Label";
            this.option1Label.Size = new System.Drawing.Size(84, 13);
            this.option1Label.TabIndex = 1;
            this.option1Label.Text = "Encoding mode:";
            // 
            // primaryTextLabel
            // 
            this.primaryTextLabel.AutoSize = true;
            this.primaryTextLabel.Location = new System.Drawing.Point(17, 57);
            this.primaryTextLabel.Name = "primaryTextLabel";
            this.primaryTextLabel.Size = new System.Drawing.Size(64, 13);
            this.primaryTextLabel.TabIndex = 2;
            this.primaryTextLabel.Text = "Primary text:";
            // 
            // primaryText
            // 
            this.primaryText.Location = new System.Drawing.Point(189, 54);
            this.primaryText.Name = "primaryText";
            this.primaryText.Size = new System.Drawing.Size(222, 20);
            this.primaryText.TabIndex = 3;
            this.primaryText.TextChanged += new System.EventHandler(this.optionElement_OptionsChanged);
            // 
            // MaxiCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.primaryText);
            this.Controls.Add(this.primaryTextLabel);
            this.Controls.Add(this.option1Label);
            this.Controls.Add(this.option1);
            this.Name = "MaxiCode";
            this.Size = new System.Drawing.Size(428, 243);
            this.Load += new System.EventHandler(this.MaxiCode_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OptionBox option1;
        private System.Windows.Forms.Label option1Label;
        private System.Windows.Forms.Label primaryTextLabel;
        private System.Windows.Forms.TextBox primaryText;
    }
}
