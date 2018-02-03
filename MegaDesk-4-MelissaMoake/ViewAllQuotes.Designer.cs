namespace MegaDesk_4_MelissaMoake
{
    partial class ViewAllQuotes
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
            this.cancelViewButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cancelViewButton
            // 
            this.cancelViewButton.AutoSize = true;
            this.cancelViewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelViewButton.Location = new System.Drawing.Point(306, 231);
            this.cancelViewButton.Name = "cancelViewButton";
            this.cancelViewButton.Size = new System.Drawing.Size(75, 27);
            this.cancelViewButton.TabIndex = 1;
            this.cancelViewButton.Text = "Cancel";
            this.cancelViewButton.UseVisualStyleBackColor = true;
            this.cancelViewButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cancelViewAllQuotesButton_Click);
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 270);
            this.Controls.Add(this.cancelViewButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ViewAllQuotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewAllQuotes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelViewButton;
    }
}