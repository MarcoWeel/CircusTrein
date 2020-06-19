namespace circustrein
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
            this.BTNAnimal = new System.Windows.Forms.Button();
            this.LBAnimals = new System.Windows.Forms.ListBox();
            this.BTNSort = new System.Windows.Forms.Button();
            this.CBSize = new System.Windows.Forms.ComboBox();
            this.CBType = new System.Windows.Forms.ComboBox();
            this.WagonTextBox = new System.Windows.Forms.TextBox();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTNAnimal
            // 
            this.BTNAnimal.Location = new System.Drawing.Point(33, 122);
            this.BTNAnimal.Name = "BTNAnimal";
            this.BTNAnimal.Size = new System.Drawing.Size(120, 23);
            this.BTNAnimal.TabIndex = 0;
            this.BTNAnimal.Text = "Create animal";
            this.BTNAnimal.UseVisualStyleBackColor = true;
            this.BTNAnimal.Click += new System.EventHandler(this.BTNAnimal_Click);
            // 
            // LBAnimals
            // 
            this.LBAnimals.FormattingEnabled = true;
            this.LBAnimals.ItemHeight = 16;
            this.LBAnimals.Location = new System.Drawing.Point(33, 181);
            this.LBAnimals.Name = "LBAnimals";
            this.LBAnimals.ScrollAlwaysVisible = true;
            this.LBAnimals.Size = new System.Drawing.Size(179, 244);
            this.LBAnimals.TabIndex = 4;
            // 
            // BTNSort
            // 
            this.BTNSort.Location = new System.Drawing.Point(160, 122);
            this.BTNSort.Name = "BTNSort";
            this.BTNSort.Size = new System.Drawing.Size(97, 23);
            this.BTNSort.TabIndex = 8;
            this.BTNSort.Text = "Sort animals";
            this.BTNSort.UseVisualStyleBackColor = true;
            this.BTNSort.Click += new System.EventHandler(this.BTNSort_Click);
            // 
            // CBSize
            // 
            this.CBSize.FormattingEnabled = true;
            this.CBSize.Location = new System.Drawing.Point(33, 92);
            this.CBSize.Name = "CBSize";
            this.CBSize.Size = new System.Drawing.Size(121, 24);
            this.CBSize.TabIndex = 9;
            // 
            // CBType
            // 
            this.CBType.FormattingEnabled = true;
            this.CBType.Items.AddRange(new object[] {
            "Carnivore",
            "Herbivore"});
            this.CBType.Location = new System.Drawing.Point(160, 92);
            this.CBType.Name = "CBType";
            this.CBType.Size = new System.Drawing.Size(121, 24);
            this.CBType.TabIndex = 10;
            this.CBType.Text = "AnimalType";
            // 
            // WagonTextBox
            // 
            this.WagonTextBox.Location = new System.Drawing.Point(288, 12);
            this.WagonTextBox.Multiline = true;
            this.WagonTextBox.Name = "WagonTextBox";
            this.WagonTextBox.ReadOnly = true;
            this.WagonTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.WagonTextBox.Size = new System.Drawing.Size(500, 426);
            this.WagonTextBox.TabIndex = 11;
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(33, 152);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(120, 23);
            this.ClearBtn.TabIndex = 12;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.WagonTextBox);
            this.Controls.Add(this.CBType);
            this.Controls.Add(this.CBSize);
            this.Controls.Add(this.BTNSort);
            this.Controls.Add(this.LBAnimals);
            this.Controls.Add(this.BTNAnimal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNAnimal;
        private System.Windows.Forms.ListBox LBAnimals;
        private System.Windows.Forms.Button BTNSort;
        private System.Windows.Forms.ComboBox CBSize;
        private System.Windows.Forms.ComboBox CBType;
        private System.Windows.Forms.TextBox WagonTextBox;
        private System.Windows.Forms.Button ClearBtn;
    }
}

