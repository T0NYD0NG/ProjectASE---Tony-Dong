namespace ProjectASE___Tony_Dong
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
            this.outputBox = new System.Windows.Forms.PictureBox();
            this.commandBox = new System.Windows.Forms.TextBox();
            this.programBox = new System.Windows.Forms.RichTextBox();
            this.runButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.outputBox)).BeginInit();
            this.SuspendLayout();
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(535, 12);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(490, 495);
            this.outputBox.TabIndex = 0;
            this.outputBox.TabStop = false;
            this.outputBox.Paint += new System.Windows.Forms.PaintEventHandler(this.outputBox_Paint);
            // 
            // commandBox
            // 
            this.commandBox.BackColor = System.Drawing.Color.Turquoise;
            this.commandBox.Location = new System.Drawing.Point(12, 454);
            this.commandBox.Name = "commandBox";
            this.commandBox.Size = new System.Drawing.Size(517, 22);
            this.commandBox.TabIndex = 1;
            this.commandBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.commandBox_KeyDown);
            // 
            // programBox
            // 
            this.programBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.programBox.Location = new System.Drawing.Point(12, 12);
            this.programBox.Name = "programBox";
            this.programBox.Size = new System.Drawing.Size(517, 418);
            this.programBox.TabIndex = 2;
            this.programBox.Text = "";
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(454, 482);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(75, 23);
            this.runButton.TabIndex = 3;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(373, 482);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1037, 519);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.programBox);
            this.Controls.Add(this.commandBox);
            this.Controls.Add(this.outputBox);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.outputBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.PictureBox outputBox;
        private System.Windows.Forms.RichTextBox programBox;
        private System.Windows.Forms.TextBox commandBox;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Button   clearButton;
    }
}

