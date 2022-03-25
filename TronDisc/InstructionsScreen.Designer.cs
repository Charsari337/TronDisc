namespace TronDisc
{
    partial class InstructionsScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inGoalLabel = new System.Windows.Forms.Label();
            this.inGoalText = new System.Windows.Forms.Label();
            this.inControlsLabel = new System.Windows.Forms.Label();
            this.inControlsText = new System.Windows.Forms.Label();
            this.returnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // inGoalLabel
            // 
            this.inGoalLabel.BackColor = System.Drawing.Color.Black;
            this.inGoalLabel.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inGoalLabel.ForeColor = System.Drawing.Color.White;
            this.inGoalLabel.Location = new System.Drawing.Point(51, 50);
            this.inGoalLabel.Name = "inGoalLabel";
            this.inGoalLabel.Size = new System.Drawing.Size(235, 23);
            this.inGoalLabel.TabIndex = 2;
            this.inGoalLabel.Text = "inGoalLabel";
            this.inGoalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inGoalText
            // 
            this.inGoalText.BackColor = System.Drawing.Color.Black;
            this.inGoalText.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inGoalText.ForeColor = System.Drawing.Color.White;
            this.inGoalText.Location = new System.Drawing.Point(51, 94);
            this.inGoalText.Name = "inGoalText";
            this.inGoalText.Size = new System.Drawing.Size(235, 368);
            this.inGoalText.TabIndex = 3;
            this.inGoalText.Text = "inGoalText";
            this.inGoalText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // inControlsLabel
            // 
            this.inControlsLabel.BackColor = System.Drawing.Color.Black;
            this.inControlsLabel.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inControlsLabel.ForeColor = System.Drawing.Color.White;
            this.inControlsLabel.Location = new System.Drawing.Point(387, 50);
            this.inControlsLabel.Name = "inControlsLabel";
            this.inControlsLabel.Size = new System.Drawing.Size(235, 23);
            this.inControlsLabel.TabIndex = 4;
            this.inControlsLabel.Text = "inControlsLabel";
            this.inControlsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inControlsText
            // 
            this.inControlsText.BackColor = System.Drawing.Color.Black;
            this.inControlsText.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inControlsText.ForeColor = System.Drawing.Color.White;
            this.inControlsText.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inControlsText.Location = new System.Drawing.Point(387, 94);
            this.inControlsText.Name = "inControlsText";
            this.inControlsText.Size = new System.Drawing.Size(235, 368);
            this.inControlsText.TabIndex = 5;
            this.inControlsText.Text = "inControlsText";
            this.inControlsText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // returnButton
            // 
            this.returnButton.BackColor = System.Drawing.Color.Black;
            this.returnButton.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnButton.ForeColor = System.Drawing.Color.White;
            this.returnButton.Location = new System.Drawing.Point(744, 204);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(178, 107);
            this.returnButton.TabIndex = 6;
            this.returnButton.Text = "returnButton";
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // InstructionsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.inControlsText);
            this.Controls.Add(this.inControlsLabel);
            this.Controls.Add(this.inGoalText);
            this.Controls.Add(this.inGoalLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Name = "InstructionsScreen";
            this.Size = new System.Drawing.Size(1000, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label inGoalLabel;
        private System.Windows.Forms.Label inGoalText;
        private System.Windows.Forms.Label inControlsLabel;
        private System.Windows.Forms.Label inControlsText;
        private System.Windows.Forms.Button returnButton;
    }
}
