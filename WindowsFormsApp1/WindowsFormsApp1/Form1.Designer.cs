namespace WindowsFormsApp1
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
            this.generateIntButton = new System.Windows.Forms.Button();
            this.generateDoubleButton = new System.Windows.Forms.Button();
            this.userInput = new System.Windows.Forms.RichTextBox();
            this.arrayList = new System.Windows.Forms.RichTextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchResult = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // generateIntButton
            // 
            this.generateIntButton.Location = new System.Drawing.Point(66, 38);
            this.generateIntButton.Name = "generateIntButton";
            this.generateIntButton.Size = new System.Drawing.Size(159, 71);
            this.generateIntButton.TabIndex = 0;
            this.generateIntButton.Text = "Int";
            this.generateIntButton.UseVisualStyleBackColor = true;
            this.generateIntButton.Click += new System.EventHandler(this.generateIntButton_Click);
            // 
            // generateDoubleButton
            // 
            this.generateDoubleButton.Location = new System.Drawing.Point(469, 47);
            this.generateDoubleButton.Name = "generateDoubleButton";
            this.generateDoubleButton.Size = new System.Drawing.Size(159, 71);
            this.generateDoubleButton.TabIndex = 1;
            this.generateDoubleButton.Text = "Double";
            this.generateDoubleButton.UseVisualStyleBackColor = true;
            this.generateDoubleButton.Click += new System.EventHandler(this.generateDoubleButton_Click);
            // 
            // userInput
            // 
            this.userInput.Location = new System.Drawing.Point(33, 252);
            this.userInput.Name = "userInput";
            this.userInput.Size = new System.Drawing.Size(235, 88);
            this.userInput.TabIndex = 3;
            this.userInput.Text = "";
            // 
            // arrayList
            // 
            this.arrayList.Location = new System.Drawing.Point(32, 132);
            this.arrayList.Name = "arrayList";
            this.arrayList.ReadOnly = true;
            this.arrayList.Size = new System.Drawing.Size(699, 88);
            this.arrayList.TabIndex = 4;
            this.arrayList.Text = "";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(452, 252);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(159, 71);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchResult
            // 
            this.searchResult.Location = new System.Drawing.Point(231, 365);
            this.searchResult.Name = "searchResult";
            this.searchResult.ReadOnly = true;
            this.searchResult.Size = new System.Drawing.Size(296, 55);
            this.searchResult.TabIndex = 6;
            this.searchResult.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchResult);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.arrayList);
            this.Controls.Add(this.userInput);
            this.Controls.Add(this.generateDoubleButton);
            this.Controls.Add(this.generateIntButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button generateIntButton;
        private System.Windows.Forms.Button generateDoubleButton;
        private System.Windows.Forms.RichTextBox userInput;
        private System.Windows.Forms.RichTextBox arrayList;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.RichTextBox searchResult;
    }
}

