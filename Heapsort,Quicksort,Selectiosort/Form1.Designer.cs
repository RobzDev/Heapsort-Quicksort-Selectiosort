namespace Heapsort_Quicksort_Selectiosort
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cbOption = new ComboBox();
            tbArray = new TextBox();
            btnRandom = new Button();
            textBox1 = new TextBox();
            lboxArray = new ListBox();
            btnSort = new Button();
            lBoxunsorted = new ListBox();
            SuspendLayout();
            // 
            // cbOption
            // 
            cbOption.FormattingEnabled = true;
            cbOption.Items.AddRange(new object[] { "Selectionsort", "Heapsort", "Quicksort" });
            cbOption.Location = new Point(421, 31);
            cbOption.Name = "cbOption";
            cbOption.Size = new Size(121, 23);
            cbOption.TabIndex = 0;
           
            // 
            // tbArray
            // 
            tbArray.Location = new Point(231, 31);
            tbArray.Name = "tbArray";
            tbArray.Size = new Size(184, 23);
            tbArray.TabIndex = 1;
            // 
            // btnRandom
            // 
            btnRandom.Location = new Point(150, 85);
            btnRandom.Name = "btnRandom";
            btnRandom.Size = new Size(75, 23);
            btnRandom.TabIndex = 2;
            btnRandom.Text = "Random";
            btnRandom.UseVisualStyleBackColor = true;
            btnRandom.Click += btnRandom_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(231, 85);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(184, 23);
            textBox1.TabIndex = 3;
            // 
            // lboxArray
            // 
            lboxArray.FormattingEnabled = true;
            lboxArray.ItemHeight = 15;
            lboxArray.Location = new Point(150, 162);
            lboxArray.Name = "lboxArray";
            lboxArray.Size = new Size(120, 199);
            lboxArray.TabIndex = 5;
            // 
            // btnSort
            // 
            btnSort.Location = new Point(421, 85);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(75, 23);
            btnSort.TabIndex = 6;
            btnSort.Text = "Sort";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // lBoxunsorted
            // 
            lBoxunsorted.FormattingEnabled = true;
            lBoxunsorted.ItemHeight = 15;
            lBoxunsorted.Location = new Point(431, 162);
            lBoxunsorted.Name = "lBoxunsorted";
            lBoxunsorted.Size = new Size(120, 199);
            lBoxunsorted.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lBoxunsorted);
            Controls.Add(btnSort);
            Controls.Add(lboxArray);
            Controls.Add(textBox1);
            Controls.Add(btnRandom);
            Controls.Add(tbArray);
            Controls.Add(cbOption);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbOption;
        private TextBox tbArray;
        private Button btnRandom;
        private TextBox textBox1;
        private ListBox lboxArray;
        private Button btnSort;
        private ListBox lBoxunsorted;
    }
}
