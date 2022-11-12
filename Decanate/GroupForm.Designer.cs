namespace Decanate
{
    partial class GroupForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxGroupNum = new System.Windows.Forms.TextBox();
            this.textBoxStartYear = new System.Windows.Forms.TextBox();
            this.textBoxEndYear = new System.Windows.Forms.TextBox();
            this.textBoxDecanatNum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Окно добавления новых данных о группе";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Укажите номер группы:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Укажите год начала обучения:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Укажите год окончания обучения:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Укажите номер деканата:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 42);
            this.button1.TabIndex = 5;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(347, 230);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 42);
            this.button2.TabIndex = 6;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxGroupNum
            // 
            this.textBoxGroupNum.Location = new System.Drawing.Point(157, 45);
            this.textBoxGroupNum.Name = "textBoxGroupNum";
            this.textBoxGroupNum.Size = new System.Drawing.Size(100, 23);
            this.textBoxGroupNum.TabIndex = 7;
            this.textBoxGroupNum.TextChanged += new System.EventHandler(this.textBoxGroupNum_TextChanged);
            // 
            // textBoxStartYear
            // 
            this.textBoxStartYear.Location = new System.Drawing.Point(193, 74);
            this.textBoxStartYear.Name = "textBoxStartYear";
            this.textBoxStartYear.Size = new System.Drawing.Size(100, 23);
            this.textBoxStartYear.TabIndex = 8;
            this.textBoxStartYear.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxEndYear
            // 
            this.textBoxEndYear.Location = new System.Drawing.Point(214, 106);
            this.textBoxEndYear.Name = "textBoxEndYear";
            this.textBoxEndYear.Size = new System.Drawing.Size(100, 23);
            this.textBoxEndYear.TabIndex = 9;
            // 
            // textBoxDecanatNum
            // 
            this.textBoxDecanatNum.Location = new System.Drawing.Point(164, 136);
            this.textBoxDecanatNum.Name = "textBoxDecanatNum";
            this.textBoxDecanatNum.Size = new System.Drawing.Size(100, 23);
            this.textBoxDecanatNum.TabIndex = 10;
            // 
            // GroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 284);
            this.Controls.Add(this.textBoxDecanatNum);
            this.Controls.Add(this.textBoxEndYear);
            this.Controls.Add(this.textBoxStartYear);
            this.Controls.Add(this.textBoxGroupNum);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GroupForm";
            this.Text = "GroupForm";
            this.Load += new System.EventHandler(this.GroupForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private Button button2;
        public TextBox textBoxGroupNum;
        public TextBox textBoxStartYear;
        public TextBox textBoxEndYear;
        public TextBox textBoxDecanatNum;
    }
}