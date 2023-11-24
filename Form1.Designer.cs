namespace AreaVolumeCalculator
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
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RadiusTextBox = new System.Windows.Forms.TextBox();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.SurfaceAreaTextBox = new System.Windows.Forms.TextBox();
            this.VolumeTextBox = new System.Windows.Forms.TextBox();
            this.CylinderRadioButton = new System.Windows.Forms.RadioButton();
            this.SphereRadioButton = new System.Windows.Forms.RadioButton();
            this.ConeRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(96, 220);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(66, 23);
            this.CalculateButton.TabIndex = 0;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(168, 220);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(52, 23);
            this.ClearButton.TabIndex = 1;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Radius";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Height";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "SurfaceArea";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Volume";
            // 
            // RadiusTextBox
            // 
            this.RadiusTextBox.Location = new System.Drawing.Point(108, 55);
            this.RadiusTextBox.Name = "RadiusTextBox";
            this.RadiusTextBox.Size = new System.Drawing.Size(100, 20);
            this.RadiusTextBox.TabIndex = 6;
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Location = new System.Drawing.Point(108, 87);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(100, 20);
            this.HeightTextBox.TabIndex = 7;
            // 
            // SurfaceAreaTextBox
            // 
            this.SurfaceAreaTextBox.Location = new System.Drawing.Point(108, 153);
            this.SurfaceAreaTextBox.Name = "SurfaceAreaTextBox";
            this.SurfaceAreaTextBox.Size = new System.Drawing.Size(100, 20);
            this.SurfaceAreaTextBox.TabIndex = 8;
            // 
            // VolumeTextBox
            // 
            this.VolumeTextBox.Location = new System.Drawing.Point(108, 187);
            this.VolumeTextBox.Name = "VolumeTextBox";
            this.VolumeTextBox.Size = new System.Drawing.Size(100, 20);
            this.VolumeTextBox.TabIndex = 9;
            // 
            // CylinderRadioButton
            // 
            this.CylinderRadioButton.AutoSize = true;
            this.CylinderRadioButton.Location = new System.Drawing.Point(34, 127);
            this.CylinderRadioButton.Name = "CylinderRadioButton";
            this.CylinderRadioButton.Size = new System.Drawing.Size(62, 17);
            this.CylinderRadioButton.TabIndex = 10;
            this.CylinderRadioButton.TabStop = true;
            this.CylinderRadioButton.Text = "Cylinder";
            this.CylinderRadioButton.UseVisualStyleBackColor = true;
            // 
            // SphereRadioButton
            // 
            this.SphereRadioButton.AutoSize = true;
            this.SphereRadioButton.Location = new System.Drawing.Point(102, 127);
            this.SphereRadioButton.Name = "SphereRadioButton";
            this.SphereRadioButton.Size = new System.Drawing.Size(59, 17);
            this.SphereRadioButton.TabIndex = 11;
            this.SphereRadioButton.TabStop = true;
            this.SphereRadioButton.Text = "Sphere";
            this.SphereRadioButton.UseVisualStyleBackColor = true;
            // 
            // ConeRadioButton
            // 
            this.ConeRadioButton.AutoSize = true;
            this.ConeRadioButton.Location = new System.Drawing.Point(168, 127);
            this.ConeRadioButton.Name = "ConeRadioButton";
            this.ConeRadioButton.Size = new System.Drawing.Size(50, 17);
            this.ConeRadioButton.TabIndex = 12;
            this.ConeRadioButton.TabStop = true;
            this.ConeRadioButton.Text = "Cone";
            this.ConeRadioButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 304);
            this.Controls.Add(this.ConeRadioButton);
            this.Controls.Add(this.SphereRadioButton);
            this.Controls.Add(this.CylinderRadioButton);
            this.Controls.Add(this.VolumeTextBox);
            this.Controls.Add(this.SurfaceAreaTextBox);
            this.Controls.Add(this.HeightTextBox);
            this.Controls.Add(this.RadiusTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.CalculateButton);
            this.Name = "Form1";
            this.Text = "Surface Area & Volume Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox RadiusTextBox;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.TextBox SurfaceAreaTextBox;
        private System.Windows.Forms.TextBox VolumeTextBox;
        private System.Windows.Forms.RadioButton CylinderRadioButton;
        private System.Windows.Forms.RadioButton SphereRadioButton;
        private System.Windows.Forms.RadioButton ConeRadioButton;
    }
}

