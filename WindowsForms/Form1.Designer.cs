
namespace PasswordGenerator
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelPasswordLength = new System.Windows.Forms.Label();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.textBoxPasswordOutput = new System.Windows.Forms.TextBox();
            this.lblAppTitle = new System.Windows.Forms.Label();
            this.checkBoxUseNumbers = new System.Windows.Forms.CheckBox();
            this.textBoxPasswordLength = new System.Windows.Forms.TextBox();
            this.checkBoxUseSymbols = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // labelPasswordLength
            // 
            this.labelPasswordLength.AutoSize = true;
            this.labelPasswordLength.Location = new System.Drawing.Point(216, 89);
            this.labelPasswordLength.Name = "labelPasswordLength";
            this.labelPasswordLength.Size = new System.Drawing.Size(89, 13);
            this.labelPasswordLength.TabIndex = 1;
            this.labelPasswordLength.Text = "Password Length";
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(311, 205);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirm.TabIndex = 2;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // textBoxPasswordOutput
            // 
            this.textBoxPasswordOutput.Location = new System.Drawing.Point(12, 259);
            this.textBoxPasswordOutput.Multiline = true;
            this.textBoxPasswordOutput.Name = "textBoxPasswordOutput";
            this.textBoxPasswordOutput.Size = new System.Drawing.Size(776, 179);
            this.textBoxPasswordOutput.TabIndex = 3;
            // 
            // lblAppTitle
            // 
            this.lblAppTitle.AutoSize = true;
            this.lblAppTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppTitle.Location = new System.Drawing.Point(259, 9);
            this.lblAppTitle.Name = "lblAppTitle";
            this.lblAppTitle.Size = new System.Drawing.Size(311, 37);
            this.lblAppTitle.TabIndex = 6;
            this.lblAppTitle.Text = "Password Generator";
            // 
            // checkBoxUseNumbers
            // 
            this.checkBoxUseNumbers.AutoSize = true;
            this.checkBoxUseNumbers.Checked = true;
            this.checkBoxUseNumbers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxUseNumbers.Location = new System.Drawing.Point(311, 128);
            this.checkBoxUseNumbers.Name = "checkBoxUseNumbers";
            this.checkBoxUseNumbers.Size = new System.Drawing.Size(90, 17);
            this.checkBoxUseNumbers.TabIndex = 8;
            this.checkBoxUseNumbers.Text = "Use Numbers";
            this.checkBoxUseNumbers.UseVisualStyleBackColor = true;
            // 
            // textBoxPasswordLength
            // 
            this.textBoxPasswordLength.Location = new System.Drawing.Point(311, 86);
            this.textBoxPasswordLength.Name = "textBoxPasswordLength";
            this.textBoxPasswordLength.Size = new System.Drawing.Size(129, 20);
            this.textBoxPasswordLength.TabIndex = 9;
            // 
            // checkBoxUseSymbols
            // 
            this.checkBoxUseSymbols.AutoSize = true;
            this.checkBoxUseSymbols.Checked = true;
            this.checkBoxUseSymbols.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxUseSymbols.Location = new System.Drawing.Point(311, 161);
            this.checkBoxUseSymbols.Name = "checkBoxUseSymbols";
            this.checkBoxUseSymbols.Size = new System.Drawing.Size(87, 17);
            this.checkBoxUseSymbols.TabIndex = 11;
            this.checkBoxUseSymbols.Text = "Use Symbols";
            this.checkBoxUseSymbols.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBoxUseSymbols);
            this.Controls.Add(this.textBoxPasswordLength);
            this.Controls.Add(this.checkBoxUseNumbers);
            this.Controls.Add(this.lblAppTitle);
            this.Controls.Add(this.textBoxPasswordOutput);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.labelPasswordLength);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelPasswordLength;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.TextBox textBoxPasswordOutput;
        private System.Windows.Forms.Label lblAppTitle;
        private System.Windows.Forms.CheckBox checkBoxUseNumbers;
        private System.Windows.Forms.TextBox textBoxPasswordLength;
        private System.Windows.Forms.CheckBox checkBoxUseSymbols;
    }
}

