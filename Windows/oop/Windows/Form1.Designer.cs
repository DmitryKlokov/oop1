namespace Windows
{
    partial class GuiAtm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_InputSum = new System.Windows.Forms.TextBox();
            this.button_Enter = new System.Windows.Forms.Button();
            this.buttonLangEn = new System.Windows.Forms.Button();
            this.buttonLangRu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView_sums = new System.Windows.Forms.DataGridView();
            this.Sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_Back = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label_Dateload = new System.Windows.Forms.Label();
            this.label_load = new System.Windows.Forms.Label();
            this.textBox_Out = new System.Windows.Forms.TextBox();
            this.label_unloaded = new System.Windows.Forms.Label();
            this.textBox_Load = new System.Windows.Forms.TextBox();
            this.textBox_dateload = new System.Windows.Forms.TextBox();
            this.label_stat = new System.Windows.Forms.Label();
            this.button_stat = new System.Windows.Forms.Button();
            this.button_Num1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button_Num2 = new System.Windows.Forms.Button();
            this.button_Num3 = new System.Windows.Forms.Button();
            this.button_Num4 = new System.Windows.Forms.Button();
            this.button_Num5 = new System.Windows.Forms.Button();
            this.button_Num6 = new System.Windows.Forms.Button();
            this.button_Num7 = new System.Windows.Forms.Button();
            this.button_Num8 = new System.Windows.Forms.Button();
            this.button_Num9 = new System.Windows.Forms.Button();
            this.button_Num0 = new System.Windows.Forms.Button();
            this.button_Correction = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox_maxsum = new System.Windows.Forms.TextBox();
            this.label_maxsum = new System.Windows.Forms.Label();
            this.button_Load = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_sums)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_InputSum
            // 
            this.textBox_InputSum.Enabled = false;
            this.textBox_InputSum.Location = new System.Drawing.Point(86, 209);
            this.textBox_InputSum.Name = "textBox_InputSum";
            this.textBox_InputSum.Size = new System.Drawing.Size(315, 20);
            this.textBox_InputSum.TabIndex = 1;
            // 
            // button_Enter
            // 
            this.button_Enter.Location = new System.Drawing.Point(422, 553);
            this.button_Enter.Name = "button_Enter";
            this.button_Enter.Size = new System.Drawing.Size(100, 100);
            this.button_Enter.TabIndex = 2;
            this.button_Enter.Text = "Enter";
            this.button_Enter.UseVisualStyleBackColor = true;
            this.button_Enter.Click += new System.EventHandler(this.button_Enter_Click);
            // 
            // buttonLangEn
            // 
            this.buttonLangEn.Location = new System.Drawing.Point(422, 12);
            this.buttonLangEn.Name = "buttonLangEn";
            this.buttonLangEn.Size = new System.Drawing.Size(100, 23);
            this.buttonLangEn.TabIndex = 3;
            this.buttonLangEn.Text = "EN";
            this.buttonLangEn.UseVisualStyleBackColor = true;
            this.buttonLangEn.Click += new System.EventHandler(this.buttonLangEn_Click);
            // 
            // buttonLangRu
            // 
            this.buttonLangRu.Location = new System.Drawing.Point(422, 41);
            this.buttonLangRu.Name = "buttonLangRu";
            this.buttonLangRu.Size = new System.Drawing.Size(100, 23);
            this.buttonLangRu.TabIndex = 4;
            this.buttonLangRu.Text = "RU";
            this.buttonLangRu.UseVisualStyleBackColor = true;
            this.buttonLangRu.Click += new System.EventHandler(this.buttonLangRu_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView_sums);
            this.panel1.Controls.Add(this.button_Back);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.label_stat);
            this.panel1.Location = new System.Drawing.Point(5, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(516, 659);
            this.panel1.TabIndex = 5;
            this.panel1.Visible = false;
            // 
            // dataGridView_sums
            // 
            this.dataGridView_sums.AllowUserToAddRows = false;
            this.dataGridView_sums.AllowUserToDeleteRows = false;
            this.dataGridView_sums.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_sums.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_sums.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sum,
            this.Date});
            this.dataGridView_sums.Location = new System.Drawing.Point(35, 310);
            this.dataGridView_sums.Name = "dataGridView_sums";
            this.dataGridView_sums.ReadOnly = true;
            this.dataGridView_sums.RowHeadersVisible = false;
            this.dataGridView_sums.Size = new System.Drawing.Size(444, 317);
            this.dataGridView_sums.TabIndex = 7;
            // 
            // Sum
            // 
            this.Sum.HeaderText = "Sum";
            this.Sum.Name = "Sum";
            this.Sum.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // button_Back
            // 
            this.button_Back.Location = new System.Drawing.Point(3, 633);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(509, 23);
            this.button_Back.TabIndex = 6;
            this.button_Back.Text = "Back";
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.label_Dateload, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label_load, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox_Out, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label_unloaded, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBox_Load, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox_dateload, 1, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(138, 223);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(235, 81);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // label_Dateload
            // 
            this.label_Dateload.AutoSize = true;
            this.label_Dateload.Location = new System.Drawing.Point(3, 55);
            this.label_Dateload.Margin = new System.Windows.Forms.Padding(3);
            this.label_Dateload.Name = "label_Dateload";
            this.label_Dateload.Size = new System.Drawing.Size(71, 13);
            this.label_Dateload.TabIndex = 7;
            this.label_Dateload.Text = "Date Loading";
            // 
            // label_load
            // 
            this.label_load.AutoSize = true;
            this.label_load.Dock = System.Windows.Forms.DockStyle.Right;
            this.label_load.Location = new System.Drawing.Point(31, 3);
            this.label_load.Margin = new System.Windows.Forms.Padding(3);
            this.label_load.Name = "label_load";
            this.label_load.Size = new System.Drawing.Size(43, 20);
            this.label_load.TabIndex = 2;
            this.label_load.Text = "Loaded";
            // 
            // textBox_Out
            // 
            this.textBox_Out.Enabled = false;
            this.textBox_Out.Location = new System.Drawing.Point(80, 29);
            this.textBox_Out.Name = "textBox_Out";
            this.textBox_Out.Size = new System.Drawing.Size(144, 20);
            this.textBox_Out.TabIndex = 1;
            // 
            // label_unloaded
            // 
            this.label_unloaded.AutoSize = true;
            this.label_unloaded.Dock = System.Windows.Forms.DockStyle.Right;
            this.label_unloaded.Location = new System.Drawing.Point(21, 29);
            this.label_unloaded.Margin = new System.Windows.Forms.Padding(3);
            this.label_unloaded.Name = "label_unloaded";
            this.label_unloaded.Size = new System.Drawing.Size(53, 20);
            this.label_unloaded.TabIndex = 3;
            this.label_unloaded.Text = "Unloaded";
            // 
            // textBox_Load
            // 
            this.textBox_Load.Enabled = false;
            this.textBox_Load.Location = new System.Drawing.Point(80, 3);
            this.textBox_Load.Name = "textBox_Load";
            this.textBox_Load.Size = new System.Drawing.Size(144, 20);
            this.textBox_Load.TabIndex = 0;
            // 
            // textBox_dateload
            // 
            this.textBox_dateload.Enabled = false;
            this.textBox_dateload.Location = new System.Drawing.Point(80, 55);
            this.textBox_dateload.Name = "textBox_dateload";
            this.textBox_dateload.Size = new System.Drawing.Size(144, 20);
            this.textBox_dateload.TabIndex = 8;
            // 
            // label_stat
            // 
            this.label_stat.AutoSize = true;
            this.label_stat.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_stat.Location = new System.Drawing.Point(168, 173);
            this.label_stat.Name = "label_stat";
            this.label_stat.Size = new System.Drawing.Size(174, 44);
            this.label_stat.TabIndex = 5;
            this.label_stat.Text = "Statistics";
            // 
            // button_stat
            // 
            this.button_stat.Location = new System.Drawing.Point(5, 12);
            this.button_stat.Name = "button_stat";
            this.button_stat.Size = new System.Drawing.Size(75, 23);
            this.button_stat.TabIndex = 6;
            this.button_stat.Text = "Statistic";
            this.button_stat.UseVisualStyleBackColor = true;
            this.button_stat.Click += new System.EventHandler(this.button_stat_Click);
            // 
            // button_Num1
            // 
            this.button_Num1.Location = new System.Drawing.Point(3, 3);
            this.button_Num1.Name = "button_Num1";
            this.button_Num1.Size = new System.Drawing.Size(100, 100);
            this.button_Num1.TabIndex = 7;
            this.button_Num1.Text = "1";
            this.button_Num1.UseVisualStyleBackColor = true;
            this.button_Num1.Click += new System.EventHandler(this.button_Num1_Click_1);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.button_Num2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_Num3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_Num1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_Num4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button_Num5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button_Num6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.button_Num7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button_Num8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.button_Num9, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.button_Num0, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(86, 232);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(319, 425);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // button_Num2
            // 
            this.button_Num2.Location = new System.Drawing.Point(109, 3);
            this.button_Num2.Name = "button_Num2";
            this.button_Num2.Size = new System.Drawing.Size(100, 100);
            this.button_Num2.TabIndex = 8;
            this.button_Num2.Text = "2";
            this.button_Num2.UseVisualStyleBackColor = true;
            this.button_Num2.Click += new System.EventHandler(this.button_Num1_Click_1);
            // 
            // button_Num3
            // 
            this.button_Num3.Location = new System.Drawing.Point(215, 3);
            this.button_Num3.Name = "button_Num3";
            this.button_Num3.Size = new System.Drawing.Size(100, 100);
            this.button_Num3.TabIndex = 9;
            this.button_Num3.Text = "3";
            this.button_Num3.UseVisualStyleBackColor = true;
            this.button_Num3.Click += new System.EventHandler(this.button_Num1_Click_1);
            // 
            // button_Num4
            // 
            this.button_Num4.Location = new System.Drawing.Point(3, 109);
            this.button_Num4.Name = "button_Num4";
            this.button_Num4.Size = new System.Drawing.Size(100, 100);
            this.button_Num4.TabIndex = 10;
            this.button_Num4.Text = "4";
            this.button_Num4.UseVisualStyleBackColor = true;
            this.button_Num4.Click += new System.EventHandler(this.button_Num1_Click_1);
            // 
            // button_Num5
            // 
            this.button_Num5.Location = new System.Drawing.Point(109, 109);
            this.button_Num5.Name = "button_Num5";
            this.button_Num5.Size = new System.Drawing.Size(100, 100);
            this.button_Num5.TabIndex = 11;
            this.button_Num5.Text = "5";
            this.button_Num5.UseVisualStyleBackColor = true;
            this.button_Num5.Click += new System.EventHandler(this.button_Num1_Click_1);
            // 
            // button_Num6
            // 
            this.button_Num6.Location = new System.Drawing.Point(215, 109);
            this.button_Num6.Name = "button_Num6";
            this.button_Num6.Size = new System.Drawing.Size(100, 100);
            this.button_Num6.TabIndex = 12;
            this.button_Num6.Text = "6";
            this.button_Num6.UseVisualStyleBackColor = true;
            this.button_Num6.Click += new System.EventHandler(this.button_Num1_Click_1);
            // 
            // button_Num7
            // 
            this.button_Num7.Location = new System.Drawing.Point(3, 215);
            this.button_Num7.Name = "button_Num7";
            this.button_Num7.Size = new System.Drawing.Size(100, 100);
            this.button_Num7.TabIndex = 13;
            this.button_Num7.Text = "7";
            this.button_Num7.UseVisualStyleBackColor = true;
            this.button_Num7.Click += new System.EventHandler(this.button_Num1_Click_1);
            // 
            // button_Num8
            // 
            this.button_Num8.Location = new System.Drawing.Point(109, 215);
            this.button_Num8.Name = "button_Num8";
            this.button_Num8.Size = new System.Drawing.Size(100, 100);
            this.button_Num8.TabIndex = 14;
            this.button_Num8.Text = "8";
            this.button_Num8.UseVisualStyleBackColor = true;
            this.button_Num8.Click += new System.EventHandler(this.button_Num1_Click_1);
            // 
            // button_Num9
            // 
            this.button_Num9.Location = new System.Drawing.Point(215, 215);
            this.button_Num9.Name = "button_Num9";
            this.button_Num9.Size = new System.Drawing.Size(100, 100);
            this.button_Num9.TabIndex = 15;
            this.button_Num9.Text = "9";
            this.button_Num9.UseVisualStyleBackColor = true;
            this.button_Num9.Click += new System.EventHandler(this.button_Num1_Click_1);
            // 
            // button_Num0
            // 
            this.button_Num0.Location = new System.Drawing.Point(109, 321);
            this.button_Num0.Name = "button_Num0";
            this.button_Num0.Size = new System.Drawing.Size(100, 100);
            this.button_Num0.TabIndex = 16;
            this.button_Num0.Text = "0";
            this.button_Num0.UseVisualStyleBackColor = true;
            this.button_Num0.Click += new System.EventHandler(this.button_Num1_Click_1);
            // 
            // button_Correction
            // 
            this.button_Correction.Location = new System.Drawing.Point(422, 341);
            this.button_Correction.Name = "button_Correction";
            this.button_Correction.Size = new System.Drawing.Size(100, 100);
            this.button_Correction.TabIndex = 9;
            this.button_Correction.Text = "Correction";
            this.button_Correction.UseVisualStyleBackColor = true;
            this.button_Correction.Click += new System.EventHandler(this.button_Correction_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(422, 235);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(100, 100);
            this.button_Cancel.TabIndex = 11;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(422, 94);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(100, 23);
            this.button_Clear.TabIndex = 12;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Value,
            this.Count});
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(89, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(312, 191);
            this.dataGridView1.TabIndex = 13;
            // 
            // Value
            // 
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            // 
            // Count
            // 
            this.Count.HeaderText = "Count";
            this.Count.Name = "Count";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox_maxsum
            // 
            this.textBox_maxsum.Enabled = false;
            this.textBox_maxsum.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_maxsum.Location = new System.Drawing.Point(407, 140);
            this.textBox_maxsum.Name = "textBox_maxsum";
            this.textBox_maxsum.Size = new System.Drawing.Size(114, 18);
            this.textBox_maxsum.TabIndex = 14;
            // 
            // label_maxsum
            // 
            this.label_maxsum.AutoSize = true;
            this.label_maxsum.Location = new System.Drawing.Point(422, 124);
            this.label_maxsum.Name = "label_maxsum";
            this.label_maxsum.Size = new System.Drawing.Size(49, 13);
            this.label_maxsum.TabIndex = 15;
            this.label_maxsum.Text = "Max sum";
            // 
            // button_Load
            // 
            this.button_Load.Location = new System.Drawing.Point(5, 50);
            this.button_Load.Name = "button_Load";
            this.button_Load.Size = new System.Drawing.Size(75, 23);
            this.button_Load.TabIndex = 16;
            this.button_Load.Text = "Load";
            this.button_Load.UseVisualStyleBackColor = true;
            this.button_Load.Click += new System.EventHandler(this.button_Load_Click);
            // 
            // GuiAtm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(528, 683);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonLangRu);
            this.Controls.Add(this.buttonLangEn);
            this.Controls.Add(this.textBox_InputSum);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Correction);
            this.Controls.Add(this.button_Enter);
            this.Controls.Add(this.button_stat);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox_maxsum);
            this.Controls.Add(this.label_maxsum);
            this.Controls.Add(this.button_Load);
            this.Name = "GuiAtm";
            this.Text = "GuiAtm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_sums)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_InputSum;
        private System.Windows.Forms.Button button_Enter;
        private System.Windows.Forms.Button buttonLangEn;
        private System.Windows.Forms.Button buttonLangRu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_unloaded;
        private System.Windows.Forms.Label label_load;
        private System.Windows.Forms.TextBox textBox_Out;
        private System.Windows.Forms.TextBox textBox_Load;
        private System.Windows.Forms.Button button_stat;
        private System.Windows.Forms.Label label_stat;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button_Num1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button_Num2;
        private System.Windows.Forms.Button button_Num3;
        private System.Windows.Forms.Button button_Num4;
        private System.Windows.Forms.Button button_Num5;
        private System.Windows.Forms.Button button_Num6;
        private System.Windows.Forms.Button button_Num7;
        private System.Windows.Forms.Button button_Num8;
        private System.Windows.Forms.Button button_Num9;
        private System.Windows.Forms.Button button_Num0;
        private System.Windows.Forms.Button button_Correction;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label_Dateload;
        private System.Windows.Forms.TextBox textBox_dateload;
        private System.Windows.Forms.TextBox textBox_maxsum;
        private System.Windows.Forms.Label label_maxsum;
        private System.Windows.Forms.DataGridView dataGridView_sums;
        private System.Windows.Forms.Button button_Load;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
    }
}

