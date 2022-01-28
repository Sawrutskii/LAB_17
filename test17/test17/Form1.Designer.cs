namespace test17
{
    partial class Form1
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
            this.XnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.YnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.AddButton = new System.Windows.Forms.Button();
            this.SolveButton = new System.Windows.Forms.Button();
            this.DelButton = new System.Windows.Forms.Button();
            this.SortButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.ч = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.x = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.XnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // XnumericUpDown
            // 
            this.XnumericUpDown.DecimalPlaces = 1;
            this.XnumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.XnumericUpDown.Location = new System.Drawing.Point(52, 44);
            this.XnumericUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.XnumericUpDown.Name = "XnumericUpDown";
            this.XnumericUpDown.Size = new System.Drawing.Size(69, 20);
            this.XnumericUpDown.TabIndex = 0;
            // 
            // YnumericUpDown
            // 
            this.YnumericUpDown.DecimalPlaces = 1;
            this.YnumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.YnumericUpDown.Location = new System.Drawing.Point(52, 83);
            this.YnumericUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.YnumericUpDown.Name = "YnumericUpDown";
            this.YnumericUpDown.Size = new System.Drawing.Size(69, 20);
            this.YnumericUpDown.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ч,
            this.y});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(57, 178);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(297, 189);
            this.dataGridView1.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.x,
            this.dataGridViewTextBoxColumn1});
            this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView2.Location = new System.Drawing.Point(440, 178);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(297, 189);
            this.dataGridView2.TabIndex = 3;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(136, 80);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // SolveButton
            // 
            this.SolveButton.Location = new System.Drawing.Point(526, 80);
            this.SolveButton.Name = "SolveButton";
            this.SolveButton.Size = new System.Drawing.Size(115, 23);
            this.SolveButton.TabIndex = 5;
            this.SolveButton.Text = "Решить задачу";
            this.SolveButton.UseVisualStyleBackColor = true;
            // 
            // DelButton
            // 
            this.DelButton.Location = new System.Drawing.Point(96, 373);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(206, 23);
            this.DelButton.TabIndex = 6;
            this.DelButton.Text = "Удалить выбранную точку";
            this.DelButton.UseVisualStyleBackColor = true;
            // 
            // SortButton
            // 
            this.SortButton.Location = new System.Drawing.Point(515, 373);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(153, 23);
            this.SortButton.TabIndex = 7;
            this.SortButton.Text = "Отсортировать";
            this.SortButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "x = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "y = ";
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(342, 415);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(105, 23);
            this.CloseButton.TabIndex = 10;
            this.CloseButton.Text = "Закрыть";
            this.CloseButton.UseVisualStyleBackColor = true;
            // 
            // ч
            // 
            this.ч.HeaderText = "x";
            this.ч.Name = "ч";
            // 
            // y
            // 
            this.y.HeaderText = "y";
            this.y.Name = "y";
            // 
            // x
            // 
            this.x.HeaderText = "x";
            this.x.Name = "x";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "y";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SortButton);
            this.Controls.Add(this.DelButton);
            this.Controls.Add(this.SolveButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.YnumericUpDown);
            this.Controls.Add(this.XnumericUpDown);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.XnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown XnumericUpDown;
        private System.Windows.Forms.NumericUpDown YnumericUpDown;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button SolveButton;
        private System.Windows.Forms.Button DelButton;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ч;
        private System.Windows.Forms.DataGridViewTextBoxColumn y;
        private System.Windows.Forms.DataGridViewTextBoxColumn x;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}

