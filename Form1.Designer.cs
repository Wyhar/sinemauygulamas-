namespace sinemauygulaması
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
            textBox1 = new TextBox();
            button1 = new Button();
            groupBox1 = new GroupBox();
            button3 = new Button();
            button2 = new Button();
            checkBox1 = new CheckBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            button4 = new Button();
            button6 = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(131, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(280, 15);
            button1.Name = "button1";
            button1.Size = new Size(167, 64);
            button1.TabIndex = 1;
            button1.Text = "OLUŞTUR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Location = new Point(12, 129);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 188);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "SATIŞ-İPTAL";
            // 
            // button3
            // 
            button3.Location = new Point(119, 133);
            button3.Name = "button3";
            button3.Size = new Size(75, 49);
            button3.TabIndex = 6;
            button3.Text = "BİLET İPTAL";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(19, 133);
            button2.Name = "button2";
            button2.Size = new Size(75, 49);
            button2.TabIndex = 5;
            button2.Text = "BİLET SAT";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(19, 87);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(70, 19);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "İndirimli";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 15);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "SALON";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button6);
            groupBox2.Location = new Point(247, 129);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 188);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "RAPOR";
            // 
            // button4
            // 
            button4.Location = new Point(6, 133);
            button4.Name = "button4";
            button4.Size = new Size(75, 49);
            button4.TabIndex = 7;
            button4.Text = "BAKİYE";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button6
            // 
            button6.Location = new Point(103, 133);
            button6.Name = "button6";
            button6.Size = new Size(75, 49);
            button6.TabIndex = 8;
            button6.Text = "BOŞ KOLTUK";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(131, 56);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 59);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 5;
            label2.Text = "KOLTUK SAYISI";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(42, 362);
            label3.Name = "label3";
            label3.Size = new Size(19, 30);
            label3.TabIndex = 6;
            label3.Text = " ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private GroupBox groupBox1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Label label1;
        private CheckBox checkBox1;
        private GroupBox groupBox2;
        private Button button6;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
    }
}
