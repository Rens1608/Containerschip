namespace Containerschip
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
            this.Length = new System.Windows.Forms.TextBox();
            this.Width = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Sort = new System.Windows.Forms.Button();
            this.CreateContainer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Weight = new System.Windows.Forms.TextBox();
            this.Normal = new System.Windows.Forms.CheckBox();
            this.Cooled = new System.Windows.Forms.CheckBox();
            this.Valuable = new System.Windows.Forms.CheckBox();
            this.Output = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Length
            // 
            this.Length.Location = new System.Drawing.Point(619, 45);
            this.Length.Name = "Length";
            this.Length.Size = new System.Drawing.Size(100, 22);
            this.Length.TabIndex = 0;
            // 
            // Width
            // 
            this.Width.Location = new System.Drawing.Point(619, 89);
            this.Width.Name = "Width";
            this.Width.Size = new System.Drawing.Size(100, 22);
            this.Width.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(537, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Length";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(537, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Width";
            // 
            // Sort
            // 
            this.Sort.Location = new System.Drawing.Point(540, 142);
            this.Sort.Name = "Sort";
            this.Sort.Size = new System.Drawing.Size(75, 23);
            this.Sort.TabIndex = 4;
            this.Sort.Text = "Sort";
            this.Sort.UseVisualStyleBackColor = true;
            this.Sort.Click += new System.EventHandler(this.Sort_Click);
            // 
            // CreateContainer
            // 
            this.CreateContainer.Location = new System.Drawing.Point(34, 195);
            this.CreateContainer.Name = "CreateContainer";
            this.CreateContainer.Size = new System.Drawing.Size(75, 23);
            this.CreateContainer.TabIndex = 5;
            this.CreateContainer.Text = "Add";
            this.CreateContainer.UseVisualStyleBackColor = true;
            this.CreateContainer.Click += new System.EventHandler(this.CreateContainer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Weight";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cargo";
            // 
            // Weight
            // 
            this.Weight.Location = new System.Drawing.Point(113, 142);
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(100, 22);
            this.Weight.TabIndex = 7;
            // 
            // Normal
            // 
            this.Normal.AutoSize = true;
            this.Normal.Location = new System.Drawing.Point(113, 48);
            this.Normal.Name = "Normal";
            this.Normal.Size = new System.Drawing.Size(75, 21);
            this.Normal.TabIndex = 12;
            this.Normal.Text = "Normal";
            this.Normal.UseVisualStyleBackColor = true;
            // 
            // Cooled
            // 
            this.Cooled.AutoSize = true;
            this.Cooled.Location = new System.Drawing.Point(113, 75);
            this.Cooled.Name = "Cooled";
            this.Cooled.Size = new System.Drawing.Size(74, 21);
            this.Cooled.TabIndex = 13;
            this.Cooled.Text = "Cooled";
            this.Cooled.UseVisualStyleBackColor = true;
            // 
            // Valuable
            // 
            this.Valuable.AutoSize = true;
            this.Valuable.Location = new System.Drawing.Point(113, 104);
            this.Valuable.Name = "Valuable";
            this.Valuable.Size = new System.Drawing.Size(85, 21);
            this.Valuable.TabIndex = 14;
            this.Valuable.Text = "Valuable";
            this.Valuable.UseVisualStyleBackColor = true;
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(12, 242);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(776, 196);
            this.Output.TabIndex = 15;
            this.Output.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Valuable);
            this.Controls.Add(this.Cooled);
            this.Controls.Add(this.Normal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Weight);
            this.Controls.Add(this.CreateContainer);
            this.Controls.Add(this.Sort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Width);
            this.Controls.Add(this.Length);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Length;
        private System.Windows.Forms.TextBox Width;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Sort;
        private System.Windows.Forms.Button CreateContainer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Weight;
        private System.Windows.Forms.CheckBox Normal;
        private System.Windows.Forms.CheckBox Cooled;
        private System.Windows.Forms.CheckBox Valuable;
        private System.Windows.Forms.RichTextBox Output;
    }
}

