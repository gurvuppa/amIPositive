
namespace amIPositive
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
            this.inputBox = new System.Windows.Forms.TextBox();
            this.integerLabel = new System.Windows.Forms.Label();
            this.enterButton = new System.Windows.Forms.Button();
            this.numberSignLabel = new System.Windows.Forms.Label();
            this.divisbleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(171, 60);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(49, 20);
            this.inputBox.TabIndex = 0;
            // 
            // integerLabel
            // 
            this.integerLabel.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.integerLabel.Location = new System.Drawing.Point(52, 61);
            this.integerLabel.Name = "integerLabel";
            this.integerLabel.Size = new System.Drawing.Size(113, 23);
            this.integerLabel.TabIndex = 1;
            this.integerLabel.Text = "Input an Integer";
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(171, 101);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(49, 40);
            this.enterButton.TabIndex = 2;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // numberSignLabel
            // 
            this.numberSignLabel.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberSignLabel.Location = new System.Drawing.Point(52, 165);
            this.numberSignLabel.Name = "numberSignLabel";
            this.numberSignLabel.Size = new System.Drawing.Size(250, 23);
            this.numberSignLabel.TabIndex = 3;
            // 
            // divisbleLabel
            // 
            this.divisbleLabel.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divisbleLabel.Location = new System.Drawing.Point(52, 210);
            this.divisbleLabel.Name = "divisbleLabel";
            this.divisbleLabel.Size = new System.Drawing.Size(250, 23);
            this.divisbleLabel.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 374);
            this.Controls.Add(this.divisbleLabel);
            this.Controls.Add(this.numberSignLabel);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.integerLabel);
            this.Controls.Add(this.inputBox);
            this.Name = "Form1";
            this.Text = "Am I Positive?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Label integerLabel;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Label numberSignLabel;
        private System.Windows.Forms.Label divisbleLabel;
    }
}

