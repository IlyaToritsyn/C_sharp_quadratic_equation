namespace Quadratic_equation
{
    partial class QuadraticEquationForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_a = new System.Windows.Forms.TextBox();
            this.label_a = new System.Windows.Forms.Label();
            this.textBox_b = new System.Windows.Forms.TextBox();
            this.label_b = new System.Windows.Forms.Label();
            this.textBox_c = new System.Windows.Forms.TextBox();
            this.button_solve = new System.Windows.Forms.Button();
            this.label_answer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_a
            // 
            this.textBox_a.Location = new System.Drawing.Point(13, 13);
            this.textBox_a.Name = "textBox_a";
            this.textBox_a.Size = new System.Drawing.Size(100, 20);
            this.textBox_a.TabIndex = 0;
            this.textBox_a.Enter += new System.EventHandler(this.TextBox_a_Enter);
            this.textBox_a.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_a_KeyPress);
            // 
            // label_a
            // 
            this.label_a.AutoSize = true;
            this.label_a.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_a.Location = new System.Drawing.Point(120, 13);
            this.label_a.Name = "label_a";
            this.label_a.Size = new System.Drawing.Size(52, 21);
            this.label_a.TabIndex = 1;
            this.label_a.Text = "x^2 +";

            // 
            // textBox_b
            // 
            this.textBox_b.Location = new System.Drawing.Point(182, 13);
            this.textBox_b.Name = "textBox_b";
            this.textBox_b.Size = new System.Drawing.Size(100, 20);
            this.textBox_b.TabIndex = 2;
            this.textBox_b.Enter += new System.EventHandler(this.TextBox_b_Enter);
            this.textBox_b.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_b_KeyPress);
            // 
            // label_b
            // 
            this.label_b.AutoSize = true;
            this.label_b.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_b.Location = new System.Drawing.Point(289, 13);
            this.label_b.Name = "label_b";
            this.label_b.Size = new System.Drawing.Size(35, 21);
            this.label_b.TabIndex = 3;
            this.label_b.Text = "x +";
            // 
            // textBox_c
            // 
            this.textBox_c.Location = new System.Drawing.Point(332, 13);
            this.textBox_c.Name = "textBox_c";
            this.textBox_c.Size = new System.Drawing.Size(100, 20);
            this.textBox_c.TabIndex = 4;
            this.textBox_c.Enter += new System.EventHandler(this.TextBox_c_Enter);
            this.textBox_c.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_c_KeyPress);
            // 
            // button_solve
            // 
            this.button_solve.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_solve.Location = new System.Drawing.Point(13, 40);
            this.button_solve.Name = "button_solve";
            this.button_solve.Size = new System.Drawing.Size(419, 33);
            this.button_solve.TabIndex = 5;
            this.button_solve.Text = "Решить";
            this.button_solve.UseVisualStyleBackColor = true;
            this.button_solve.Click += new System.EventHandler(this.Button_solve_Click);
            // 
            // label_answer
            // 
            this.label_answer.AutoSize = true;
            this.label_answer.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_answer.Location = new System.Drawing.Point(13, 80);
            this.label_answer.Name = "label_answer";
            this.label_answer.Size = new System.Drawing.Size(0, 21);
            this.label_answer.TabIndex = 6;
            this.label_answer.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 114);
            this.Controls.Add(this.label_answer);
            this.Controls.Add(this.button_solve);
            this.Controls.Add(this.textBox_c);
            this.Controls.Add(this.label_b);
            this.Controls.Add(this.textBox_b);
            this.Controls.Add(this.label_a);
            this.Controls.Add(this.textBox_a);
            this.Name = "QuadraticEquationForm";
            this.Text = "Квадратное уравнение";
            this.Load += new System.EventHandler(this.QuadraticEquationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_a;
        private System.Windows.Forms.Label label_a;
        private System.Windows.Forms.TextBox textBox_b;
        private System.Windows.Forms.Label label_b;
        private System.Windows.Forms.TextBox textBox_c;
        private System.Windows.Forms.Button button_solve;
        private System.Windows.Forms.Label label_answer;
    }
}

