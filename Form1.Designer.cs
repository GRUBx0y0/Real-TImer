namespace Timer
{
    partial class MForm
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sec_butt = new System.Windows.Forms.RadioButton();
            this.tim_butt = new System.Windows.Forms.RadioButton();
            this.wathc_butt = new System.Windows.Forms.RadioButton();
            this.H_text = new System.Windows.Forms.TextBox();
            this.M_text = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.S_text = new System.Windows.Forms.TextBox();
            this.ML_text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.sec_turn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.sec_abort = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.disc = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightYellow;
            this.panel1.Controls.Add(this.tim_butt);
            this.panel1.Controls.Add(this.sec_butt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 345);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(481, 46);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(105, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Секундомер";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(318, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Таймер";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(445, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Часы";
            this.label3.Visible = false;
            // 
            // sec_butt
            // 
            this.sec_butt.AutoSize = true;
            this.sec_butt.Checked = true;
            this.sec_butt.Location = new System.Drawing.Point(140, 25);
            this.sec_butt.Name = "sec_butt";
            this.sec_butt.Size = new System.Drawing.Size(14, 13);
            this.sec_butt.TabIndex = 3;
            this.sec_butt.TabStop = true;
            this.sec_butt.UseVisualStyleBackColor = true;
            this.sec_butt.CheckedChanged += new System.EventHandler(this.sec_butt_CheckedChanged);
            // 
            // tim_butt
            // 
            this.tim_butt.AutoSize = true;
            this.tim_butt.Location = new System.Drawing.Point(339, 25);
            this.tim_butt.Name = "tim_butt";
            this.tim_butt.Size = new System.Drawing.Size(14, 13);
            this.tim_butt.TabIndex = 4;
            this.tim_butt.UseVisualStyleBackColor = true;
            this.tim_butt.CheckedChanged += new System.EventHandler(this.tim_butt_CheckedChanged);
            // 
            // wathc_butt
            // 
            this.wathc_butt.AutoSize = true;
            this.wathc_butt.Location = new System.Drawing.Point(457, 316);
            this.wathc_butt.Name = "wathc_butt";
            this.wathc_butt.Size = new System.Drawing.Size(14, 13);
            this.wathc_butt.TabIndex = 5;
            this.wathc_butt.UseVisualStyleBackColor = true;
            this.wathc_butt.Visible = false;
            this.wathc_butt.CheckedChanged += new System.EventHandler(this.wathc_butt_CheckedChanged);
            // 
            // H_text
            // 
            this.H_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.H_text.Location = new System.Drawing.Point(20, 41);
            this.H_text.Name = "H_text";
            this.H_text.ReadOnly = true;
            this.H_text.Size = new System.Drawing.Size(65, 62);
            this.H_text.TabIndex = 1;
            this.H_text.Text = "0";
            // 
            // M_text
            // 
            this.M_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.M_text.Location = new System.Drawing.Point(144, 41);
            this.M_text.Name = "M_text";
            this.M_text.ReadOnly = true;
            this.M_text.Size = new System.Drawing.Size(65, 62);
            this.M_text.TabIndex = 2;
            this.M_text.Text = "0";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.ML_text);
            this.panel2.Controls.Add(this.S_text);
            this.panel2.Controls.Add(this.M_text);
            this.panel2.Controls.Add(this.H_text);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(460, 120);
            this.panel2.TabIndex = 3;
            // 
            // S_text
            // 
            this.S_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.S_text.Location = new System.Drawing.Point(276, 41);
            this.S_text.Name = "S_text";
            this.S_text.ReadOnly = true;
            this.S_text.Size = new System.Drawing.Size(65, 62);
            this.S_text.TabIndex = 3;
            this.S_text.Text = "0";
            // 
            // ML_text
            // 
            this.ML_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ML_text.Location = new System.Drawing.Point(399, 41);
            this.ML_text.Name = "ML_text";
            this.ML_text.ReadOnly = true;
            this.ML_text.Size = new System.Drawing.Size(34, 62);
            this.ML_text.TabIndex = 4;
            this.ML_text.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(30, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Часы:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(141, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Минуты:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(273, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Секунды:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(377, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Мили сек:\r\n";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // sec_turn
            // 
            this.sec_turn.BackColor = System.Drawing.Color.Green;
            this.sec_turn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sec_turn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sec_turn.Location = new System.Drawing.Point(69, 19);
            this.sec_turn.Name = "sec_turn";
            this.sec_turn.Size = new System.Drawing.Size(146, 46);
            this.sec_turn.TabIndex = 4;
            this.sec_turn.Text = "Запуск / Остановка";
            this.sec_turn.UseVisualStyleBackColor = false;
            this.sec_turn.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PaleGreen;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.sec_abort);
            this.panel3.Controls.Add(this.sec_turn);
            this.panel3.Location = new System.Drawing.Point(103, 158);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(283, 171);
            this.panel3.TabIndex = 5;
            // 
            // sec_abort
            // 
            this.sec_abort.BackColor = System.Drawing.Color.Black;
            this.sec_abort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sec_abort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sec_abort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sec_abort.Location = new System.Drawing.Point(69, 106);
            this.sec_abort.Name = "sec_abort";
            this.sec_abort.Size = new System.Drawing.Size(146, 46);
            this.sec_abort.TabIndex = 5;
            this.sec_abort.Text = "Сброс";
            this.sec_abort.UseVisualStyleBackColor = false;
            this.sec_abort.Click += new System.EventHandler(this.sec_abort_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // disc
            // 
            this.disc.AutoSize = true;
            this.disc.BackColor = System.Drawing.Color.Olive;
            this.disc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.disc.Location = new System.Drawing.Point(115, 135);
            this.disc.Name = "disc";
            this.disc.Size = new System.Drawing.Size(261, 13);
            this.disc.TabIndex = 6;
            this.disc.Text = "Введите значения для таймера и нажмите заупск\r\n";
            this.disc.Visible = false;
            // 
            // MForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(484, 394);
            this.Controls.Add(this.wathc_butt);
            this.Controls.Add(this.disc);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MForm";
            this.ShowIcon = false;
            this.Text = "Секундомер";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton wathc_butt;
        private System.Windows.Forms.RadioButton tim_butt;
        private System.Windows.Forms.RadioButton sec_butt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox H_text;
        private System.Windows.Forms.TextBox M_text;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ML_text;
        private System.Windows.Forms.TextBox S_text;
        private System.Windows.Forms.Button sec_turn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button sec_abort;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label disc;
    }
}

