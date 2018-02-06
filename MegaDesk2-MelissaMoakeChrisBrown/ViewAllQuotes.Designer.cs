namespace MegaDesk2_MelissaMoakeChrisBrown
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
            this.viewAllQuotesBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelViewButton
            // 
            this.cancelViewButton.AutoSize = true;
            this.cancelViewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelViewButton.Location = new System.Drawing.Point(437, 328);
            this.cancelViewButton.Name = "cancelViewButton";
            this.cancelViewButton.Size = new System.Drawing.Size(75, 27);
            this.cancelViewButton.TabIndex = 1;
            this.cancelViewButton.Text = "Cancel";
            this.cancelViewButton.UseVisualStyleBackColor = true;
            this.cancelViewButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cancelViewAllQuotesButton_Click);
            // 
            // viewAllQuotesBox
            // 
            this.viewAllQuotesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAllQuotesBox.FormattingEnabled = true;
            this.viewAllQuotesBox.ItemHeight = 18;
            this.viewAllQuotesBox.Location = new System.Drawing.Point(12, 72);
            this.viewAllQuotesBox.Margin = new System.Windows.Forms.Padding(25);
            this.viewAllQuotesBox.Name = "viewAllQuotesBox";
            this.viewAllQuotesBox.Size = new System.Drawing.Size(500, 238);
            this.viewAllQuotesBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Here are all the desk quotes to date:";
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 367);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewAllQuotesBox);
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
        private System.Windows.Forms.ListBox viewAllQuotesBox;
        private System.Windows.Forms.Label label1;
    }
}