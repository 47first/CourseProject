namespace WinForms
{
    partial class ModifyKeyPairForm
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
            label1 = new Label();
            label2 = new Label();
            yearTextBox = new TextBox();
            deathAmountTextBox = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 9);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 0;
            label1.Text = "Год :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 38);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 1;
            label2.Text = "Смертность :";
            // 
            // yearTextBox
            // 
            yearTextBox.Location = new Point(97, 6);
            yearTextBox.Name = "yearTextBox";
            yearTextBox.Size = new Size(232, 23);
            yearTextBox.TabIndex = 2;
            // 
            // deathAmountTextBox
            // 
            deathAmountTextBox.Location = new Point(97, 35);
            deathAmountTextBox.Name = "deathAmountTextBox";
            deathAmountTextBox.Size = new Size(232, 23);
            deathAmountTextBox.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(254, 64);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Add;
            // 
            // button2
            // 
            button2.Location = new Point(173, 64);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Удалить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Remove;
            // 
            // AddKeyPairForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(341, 96);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(deathAmountTextBox);
            Controls.Add(yearTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddKeyPairForm";
            Text = "Добавление новых значений";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox yearTextBox;
        private TextBox deathAmountTextBox;
        private Button button1;
        private Button button2;
    }
}