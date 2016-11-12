namespace cryptolab2
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.pyschButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.outputFileBox = new System.Windows.Forms.TextBox();
            this.inputFileBox = new System.Windows.Forms.TextBox();
            this.browseOutput = new System.Windows.Forms.Button();
            this.browseInput = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sequenceLengthDropdown = new System.Windows.Forms.NumericUpDown();
            this.statButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sequenceLengthDropdown)).BeginInit();
            this.SuspendLayout();
            // 
            // outputTextBox
            // 
            this.outputTextBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputTextBox.Location = new System.Drawing.Point(12, 134);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(812, 142);
            this.outputTextBox.TabIndex = 2;
            // 
            // pyschButton
            // 
            this.pyschButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pyschButton.BackgroundImage")));
            this.pyschButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pyschButton.Font = new System.Drawing.Font("Kristen ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pyschButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pyschButton.Location = new System.Drawing.Point(830, 134);
            this.pyschButton.Name = "pyschButton";
            this.pyschButton.Size = new System.Drawing.Size(142, 142);
            this.pyschButton.TabIndex = 5;
            this.pyschButton.UseVisualStyleBackColor = true;
            this.pyschButton.Click += new System.EventHandler(this.pyschButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Micra", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "output file:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Micra", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "input file:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // outputFileBox
            // 
            this.outputFileBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputFileBox.Location = new System.Drawing.Point(316, 12);
            this.outputFileBox.Name = "outputFileBox";
            this.outputFileBox.Size = new System.Drawing.Size(543, 26);
            this.outputFileBox.TabIndex = 8;
            // 
            // inputFileBox
            // 
            this.inputFileBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputFileBox.Location = new System.Drawing.Point(316, 45);
            this.inputFileBox.Name = "inputFileBox";
            this.inputFileBox.Size = new System.Drawing.Size(543, 26);
            this.inputFileBox.TabIndex = 9;
            // 
            // browseOutput
            // 
            this.browseOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.browseOutput.Location = new System.Drawing.Point(866, 12);
            this.browseOutput.Name = "browseOutput";
            this.browseOutput.Size = new System.Drawing.Size(106, 24);
            this.browseOutput.TabIndex = 10;
            this.browseOutput.Text = "browse";
            this.browseOutput.UseVisualStyleBackColor = true;
            this.browseOutput.Click += new System.EventHandler(this.browseOutput_Click);
            // 
            // browseInput
            // 
            this.browseInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.browseInput.Location = new System.Drawing.Point(865, 45);
            this.browseInput.Name = "browseInput";
            this.browseInput.Size = new System.Drawing.Size(107, 24);
            this.browseInput.TabIndex = 11;
            this.browseInput.Text = "browse";
            this.browseInput.UseVisualStyleBackColor = true;
            this.browseInput.Click += new System.EventHandler(this.browseInput_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Micra", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(547, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Output sequence size (in bytes):";
            // 
            // sequenceLengthDropdown
            // 
            this.sequenceLengthDropdown.Location = new System.Drawing.Point(565, 92);
            this.sequenceLengthDropdown.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.sequenceLengthDropdown.Name = "sequenceLengthDropdown";
            this.sequenceLengthDropdown.Size = new System.Drawing.Size(149, 20);
            this.sequenceLengthDropdown.TabIndex = 13;
            // 
            // statButton
            // 
            this.statButton.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statButton.Location = new System.Drawing.Point(830, 92);
            this.statButton.Name = "statButton";
            this.statButton.Size = new System.Drawing.Size(142, 36);
            this.statButton.TabIndex = 14;
            this.statButton.Text = "statistics";
            this.statButton.UseVisualStyleBackColor = true;
            this.statButton.Click += new System.EventHandler(this.statButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 291);
            this.Controls.Add(this.statButton);
            this.Controls.Add(this.sequenceLengthDropdown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.browseInput);
            this.Controls.Add(this.browseOutput);
            this.Controls.Add(this.inputFileBox);
            this.Controls.Add(this.outputFileBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pyschButton);
            this.Controls.Add(this.outputTextBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 330);
            this.MinimumSize = new System.Drawing.Size(1000, 330);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "DES CBC encoder/decoder";
            ((System.ComponentModel.ISupportInitialize)(this.sequenceLengthDropdown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Button pyschButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox outputFileBox;
        private System.Windows.Forms.TextBox inputFileBox;
        private System.Windows.Forms.Button browseOutput;
        private System.Windows.Forms.Button browseInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown sequenceLengthDropdown;
        private System.Windows.Forms.Button statButton;
    }
}

