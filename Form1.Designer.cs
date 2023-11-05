namespace Practica_7_3
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            C1 = new TextBox();
            C2 = new TextBox();
            C3 = new TextBox();
            C4 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(111, 9);
            label1.Name = "label1";
            label1.Size = new Size(104, 21);
            label1.TabIndex = 0;
            label1.Text = "Calificaciones";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 59);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 1;
            label2.Text = "Calificacion 1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 100);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 2;
            label3.Text = "Calificacion 2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 147);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 3;
            label4.Text = "Calificacion 3";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 190);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 4;
            label5.Text = "Calificacion 4";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(91, 227);
            button1.Name = "button1";
            button1.Size = new Size(139, 37);
            button1.TabIndex = 5;
            button1.Text = "Decision";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // C1
            // 
            C1.Location = new Point(130, 51);
            C1.Name = "C1";
            C1.Size = new Size(100, 23);
            C1.TabIndex = 6;
            // 
            // C2
            // 
            C2.Location = new Point(130, 92);
            C2.Name = "C2";
            C2.Size = new Size(100, 23);
            C2.TabIndex = 7;
            // 
            // C3
            // 
            C3.Location = new Point(130, 139);
            C3.Name = "C3";
            C3.Size = new Size(100, 23);
            C3.TabIndex = 8;
            // 
            // C4
            // 
            C4.Location = new Point(130, 182);
            C4.Name = "C4";
            C4.Size = new Size(100, 23);
            C4.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 287);
            Controls.Add(C4);
            Controls.Add(C3);
            Controls.Add(C2);
            Controls.Add(C1);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private TextBox C1;
        private TextBox C2;
        private TextBox C3;
        private TextBox C4;
    }
}