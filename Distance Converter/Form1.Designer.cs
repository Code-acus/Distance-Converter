namespace Distance_Converter
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
            this.distanceLabel = new System.Windows.Forms.Label();
            this.convertedDistanceLabel = new System.Windows.Forms.Label();
            this.convertedDistanceDisplayLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.convertFromListBox = new System.Windows.Forms.ListBox();
            this.ConvertToListBox = new System.Windows.Forms.ListBox();
            this.converFromGroup = new System.Windows.Forms.GroupBox();
            this.convertToGroup = new System.Windows.Forms.GroupBox();
            this.converFromGroup.SuspendLayout();
            this.convertToGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // distanceLabel
            // 
            this.distanceLabel.AutoSize = true;
            this.distanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distanceLabel.Location = new System.Drawing.Point(82, 53);
            this.distanceLabel.Name = "distanceLabel";
            this.distanceLabel.Size = new System.Drawing.Size(167, 16);
            this.distanceLabel.TabIndex = 0;
            this.distanceLabel.Text = "Enter a distance to convert:";
            // 
            // convertedDistanceLabel
            // 
            this.convertedDistanceLabel.AutoSize = true;
            this.convertedDistanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertedDistanceLabel.Location = new System.Drawing.Point(82, 279);
            this.convertedDistanceLabel.Name = "convertedDistanceLabel";
            this.convertedDistanceLabel.Size = new System.Drawing.Size(126, 16);
            this.convertedDistanceLabel.TabIndex = 1;
            this.convertedDistanceLabel.Text = "Converted distance:";
            // 
            // convertedDistanceDisplayLabel
            // 
            this.convertedDistanceDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.convertedDistanceDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertedDistanceDisplayLabel.Location = new System.Drawing.Point(214, 262);
            this.convertedDistanceDisplayLabel.Name = "convertedDistanceDisplayLabel";
            this.convertedDistanceDisplayLabel.Size = new System.Drawing.Size(197, 33);
            this.convertedDistanceDisplayLabel.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(255, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(85, 357);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(90, 40);
            this.convertButton.TabIndex = 4;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(321, 357);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(90, 40);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // convertFromListBox
            // 
            this.convertFromListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertFromListBox.FormattingEnabled = true;
            this.convertFromListBox.ItemHeight = 16;
            this.convertFromListBox.Items.AddRange(new object[] {
            "Inches",
            "Feet",
            "Yards"});
            this.convertFromListBox.Location = new System.Drawing.Point(6, 35);
            this.convertFromListBox.Name = "convertFromListBox";
            this.convertFromListBox.Size = new System.Drawing.Size(152, 84);
            this.convertFromListBox.TabIndex = 6;
            // 
            // ConvertToListBox
            // 
            this.ConvertToListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConvertToListBox.FormattingEnabled = true;
            this.ConvertToListBox.ItemHeight = 16;
            this.ConvertToListBox.Items.AddRange(new object[] {
            "Inches",
            "Feet",
            "Yards"});
            this.ConvertToListBox.Location = new System.Drawing.Point(6, 35);
            this.ConvertToListBox.Name = "ConvertToListBox";
            this.ConvertToListBox.Size = new System.Drawing.Size(144, 84);
            this.ConvertToListBox.TabIndex = 7;
            // 
            // converFromGroup
            // 
            this.converFromGroup.Controls.Add(this.convertFromListBox);
            this.converFromGroup.Location = new System.Drawing.Point(85, 88);
            this.converFromGroup.Name = "converFromGroup";
            this.converFromGroup.Size = new System.Drawing.Size(164, 136);
            this.converFromGroup.TabIndex = 8;
            this.converFromGroup.TabStop = false;
            this.converFromGroup.Text = "From";
            // 
            // convertToGroup
            // 
            this.convertToGroup.Controls.Add(this.ConvertToListBox);
            this.convertToGroup.Location = new System.Drawing.Point(255, 88);
            this.convertToGroup.Name = "convertToGroup";
            this.convertToGroup.Size = new System.Drawing.Size(156, 136);
            this.convertToGroup.TabIndex = 9;
            this.convertToGroup.TabStop = false;
            this.convertToGroup.Text = "To";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 438);
            this.Controls.Add(this.convertToGroup);
            this.Controls.Add(this.converFromGroup);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.convertedDistanceDisplayLabel);
            this.Controls.Add(this.convertedDistanceLabel);
            this.Controls.Add(this.distanceLabel);
            this.Name = "Form1";
            this.Text = "Distance Converter";
            this.converFromGroup.ResumeLayout(false);
            this.convertToGroup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label distanceLabel;
        private System.Windows.Forms.Label convertedDistanceLabel;
        private System.Windows.Forms.Label convertedDistanceDisplayLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ListBox convertFromListBox;
        private System.Windows.Forms.ListBox ConvertToListBox;
        private System.Windows.Forms.GroupBox converFromGroup;
        private System.Windows.Forms.GroupBox convertToGroup;
    }
}

