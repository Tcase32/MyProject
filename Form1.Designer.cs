namespace WindowsFormsApp1
{
    partial class Window
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Dice1txtbox = new System.Windows.Forms.TextBox();
            this.Lable = new System.Windows.Forms.Label();
            this.Lst1 = new System.Windows.Forms.ListBox();
            this.DisplayBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.textBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox1.Location = new System.Drawing.Point(407, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 27);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Text Application";
            // 
            // Dice1txtbox
            // 
            this.Dice1txtbox.Location = new System.Drawing.Point(202, 146);
            this.Dice1txtbox.Name = "Dice1txtbox";
            this.Dice1txtbox.Size = new System.Drawing.Size(100, 22);
            this.Dice1txtbox.TabIndex = 1;
            // 
            // Lable
            // 
            this.Lable.AutoSize = true;
            this.Lable.Location = new System.Drawing.Point(128, 152);
            this.Lable.Name = "Lable";
            this.Lable.Size = new System.Drawing.Size(48, 16);
            this.Lable.TabIndex = 2;
            this.Lable.Text = "Lable1";
            // 
            // Lst1
            // 
            this.Lst1.FormattingEnabled = true;
            this.Lst1.ItemHeight = 16;
            this.Lst1.Location = new System.Drawing.Point(121, 223);
            this.Lst1.Name = "Lst1";
            this.Lst1.Size = new System.Drawing.Size(664, 180);
            this.Lst1.TabIndex = 3;
            this.Lst1.SelectedIndexChanged += new System.EventHandler(this.Lst1_SelectedIndexChanged);
            // 
            // DisplayBtn
            // 
            this.DisplayBtn.Location = new System.Drawing.Point(121, 426);
            this.DisplayBtn.Name = "DisplayBtn";
            this.DisplayBtn.Size = new System.Drawing.Size(75, 23);
            this.DisplayBtn.TabIndex = 4;
            this.DisplayBtn.Text = "&Display\r\n";
            this.DisplayBtn.UseVisualStyleBackColor = true;
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(422, 426);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(75, 23);
            this.ClearBtn.TabIndex = 5;
            this.ClearBtn.Text = "&Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(710, 426);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 23);
            this.ExitBtn.TabIndex = 6;
            this.ExitBtn.Text = "&Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 526);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.DisplayBtn);
            this.Controls.Add(this.Lst1);
            this.Controls.Add(this.Lable);
            this.Controls.Add(this.Dice1txtbox);
            this.Controls.Add(this.textBox1);
            this.Name = "Window";
            this.Text = "Text App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox Dice1txtbox;
        private System.Windows.Forms.Label Lable;
        private System.Windows.Forms.ListBox Lst1;
        private System.Windows.Forms.Button DisplayBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button ExitBtn;
    }
}

