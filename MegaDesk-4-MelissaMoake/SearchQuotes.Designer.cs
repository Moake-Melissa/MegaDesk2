namespace MegaDesk_4_MelissaMoake
{
    partial class DeskQuoteView
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
            this.cancelSearchButton = new System.Windows.Forms.Button();
            this.materialSearchBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchResults = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cancelSearchButton
            // 
            this.cancelSearchButton.AutoSize = true;
            this.cancelSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelSearchButton.Location = new System.Drawing.Point(476, 340);
            this.cancelSearchButton.Name = "cancelSearchButton";
            this.cancelSearchButton.Size = new System.Drawing.Size(75, 27);
            this.cancelSearchButton.TabIndex = 1;
            this.cancelSearchButton.Text = "Cancel";
            this.cancelSearchButton.UseVisualStyleBackColor = true;
            this.cancelSearchButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cancelSearchQuotesButton_Click);
            // 
            // materialSearchBox
            // 
            this.materialSearchBox.FormattingEnabled = true;
            this.materialSearchBox.Location = new System.Drawing.Point(273, 34);
            this.materialSearchBox.Name = "materialSearchBox";
            this.materialSearchBox.Size = new System.Drawing.Size(145, 21);
            this.materialSearchBox.TabIndex = 2;
            this.materialSearchBox.TextChanged += new System.EventHandler(this.searchByMaterial);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search By Material Type";
            // 
            // searchResults
            // 
            this.searchResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchResults.FormattingEnabled = true;
            this.searchResults.ItemHeight = 16;
            this.searchResults.Location = new System.Drawing.Point(12, 120);
            this.searchResults.Name = "searchResults";
            this.searchResults.Size = new System.Drawing.Size(539, 196);
            this.searchResults.TabIndex = 4;
            // 
            // DeskQuoteView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 379);
            this.ControlBox = false;
            this.Controls.Add(this.searchResults);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.materialSearchBox);
            this.Controls.Add(this.cancelSearchButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "DeskQuoteView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchQuotes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelSearchButton;
        private System.Windows.Forms.ComboBox materialSearchBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox searchResults;
    }
}