
namespace Lab2
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
            this._addBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._absBtn = new System.Windows.Forms.Button();
            this._resLbl = new System.Windows.Forms.Label();
            this._sbtrBtn = new System.Windows.Forms.Button();
            this._multBtn = new System.Windows.Forms.Button();
            this._divBtn = new System.Windows.Forms.Button();
            this._powBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _addBtn
            // 
            this._addBtn.Location = new System.Drawing.Point(9, 221);
            this._addBtn.Name = "_addBtn";
            this._addBtn.Size = new System.Drawing.Size(75, 23);
            this._addBtn.TabIndex = 0;
            this._addBtn.Text = "Додавання";
            this._addBtn.UseVisualStyleBackColor = true;
            this._addBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this._normBtn_MouseClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(177, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(68, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(177, 86);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(68, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox2_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введіть дійсну частину а:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введіть уявну частину bi:\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Програма працює з комплексними числами.\r\n";
            // 
            // _absBtn
            // 
            this._absBtn.Location = new System.Drawing.Point(333, 221);
            this._absBtn.Name = "_absBtn";
            this._absBtn.Size = new System.Drawing.Size(75, 23);
            this._absBtn.TabIndex = 0;
            this._absBtn.Text = "Модуль";
            this._absBtn.UseVisualStyleBackColor = true;
            this._absBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this._AbsBtn_MouseClick);
            // 
            // _resLbl
            // 
            this._resLbl.AutoSize = true;
            this._resLbl.Location = new System.Drawing.Point(27, 181);
            this._resLbl.Name = "_resLbl";
            this._resLbl.Size = new System.Drawing.Size(0, 13);
            this._resLbl.TabIndex = 4;
            // 
            // _sbtrBtn
            // 
            this._sbtrBtn.Location = new System.Drawing.Point(90, 221);
            this._sbtrBtn.Name = "_sbtrBtn";
            this._sbtrBtn.Size = new System.Drawing.Size(75, 23);
            this._sbtrBtn.TabIndex = 0;
            this._sbtrBtn.Text = "Віднімання";
            this._sbtrBtn.UseVisualStyleBackColor = true;
            this._sbtrBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this._AbsBtn_MouseClick);
            // 
            // _multBtn
            // 
            this._multBtn.Location = new System.Drawing.Point(171, 221);
            this._multBtn.Name = "_multBtn";
            this._multBtn.Size = new System.Drawing.Size(75, 23);
            this._multBtn.TabIndex = 0;
            this._multBtn.Text = "Множення";
            this._multBtn.UseVisualStyleBackColor = true;
            this._multBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this._AbsBtn_MouseClick);
            // 
            // _divBtn
            // 
            this._divBtn.Location = new System.Drawing.Point(252, 221);
            this._divBtn.Name = "_divBtn";
            this._divBtn.Size = new System.Drawing.Size(75, 23);
            this._divBtn.TabIndex = 0;
            this._divBtn.Text = "Ділення";
            this._divBtn.UseVisualStyleBackColor = true;
            this._divBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this._AbsBtn_MouseClick);
            // 
            // _powBtn
            // 
            this._powBtn.Location = new System.Drawing.Point(414, 221);
            this._powBtn.Name = "_powBtn";
            this._powBtn.Size = new System.Drawing.Size(75, 23);
            this._powBtn.TabIndex = 0;
            this._powBtn.Text = "Степінь";
            this._powBtn.UseVisualStyleBackColor = true;
            this._powBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this._AbsBtn_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 256);
            this.Controls.Add(this._resLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this._powBtn);
            this.Controls.Add(this._divBtn);
            this.Controls.Add(this._multBtn);
            this.Controls.Add(this._sbtrBtn);
            this.Controls.Add(this._absBtn);
            this.Controls.Add(this._addBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _addBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button _absBtn;
        private System.Windows.Forms.Label _resLbl;
        private System.Windows.Forms.Button _sbtrBtn;
        private System.Windows.Forms.Button _multBtn;
        private System.Windows.Forms.Button _divBtn;
        private System.Windows.Forms.Button _powBtn;
    }
}

