namespace WindowsFormsApp4
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
            this.btNewMap = new System.Windows.Forms.Button();
            this.btCycle = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.lbNeighbours = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.edMinLive = new System.Windows.Forms.NumericUpDown();
            this.edMaxLive = new System.Windows.Forms.NumericUpDown();
            this.edMintoBorn = new System.Windows.Forms.NumericUpDown();
            this.edMaxtoBorn = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.edScale = new System.Windows.Forms.NumericUpDown();
            this.edHeight = new System.Windows.Forms.NumericUpDown();
            this.edWidth = new System.Windows.Forms.NumericUpDown();
            this.edNotDense = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.edMinLive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edMaxLive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edMintoBorn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edMaxtoBorn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edNotDense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btNewMap
            // 
            this.btNewMap.Location = new System.Drawing.Point(22, 12);
            this.btNewMap.Name = "btNewMap";
            this.btNewMap.Size = new System.Drawing.Size(201, 66);
            this.btNewMap.TabIndex = 0;
            this.btNewMap.Text = "Новая карта";
            this.btNewMap.UseVisualStyleBackColor = true;
            this.btNewMap.Click += new System.EventHandler(this.btNewMap_Click);
            // 
            // btCycle
            // 
            this.btCycle.Location = new System.Drawing.Point(22, 84);
            this.btCycle.Name = "btCycle";
            this.btCycle.Size = new System.Drawing.Size(201, 65);
            this.btCycle.TabIndex = 1;
            this.btCycle.Text = "Следующее поколение текущей карты";
            this.btCycle.UseVisualStyleBackColor = true;
            this.btCycle.Click += new System.EventHandler(this.btCycle_Click);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(22, 155);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(201, 61);
            this.btClear.TabIndex = 2;
            this.btClear.Text = "Очистить";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // lbNeighbours
            // 
            this.lbNeighbours.AutoSize = true;
            this.lbNeighbours.Location = new System.Drawing.Point(2, 219);
            this.lbNeighbours.Name = "lbNeighbours";
            this.lbNeighbours.Size = new System.Drawing.Size(221, 20);
            this.lbNeighbours.TabIndex = 0;
            this.lbNeighbours.Text = "Соседей для живой клетки:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Минимум";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Максимум";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Соседей для неживой клетки:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Минимум";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 414);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Максимум";
            // 
            // edMinLive
            // 
            this.edMinLive.Location = new System.Drawing.Point(123, 255);
            this.edMinLive.Name = "edMinLive";
            this.edMinLive.Size = new System.Drawing.Size(98, 26);
            this.edMinLive.TabIndex = 6;
            this.edMinLive.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // edMaxLive
            // 
            this.edMaxLive.Location = new System.Drawing.Point(123, 295);
            this.edMaxLive.Name = "edMaxLive";
            this.edMaxLive.Size = new System.Drawing.Size(100, 26);
            this.edMaxLive.TabIndex = 7;
            this.edMaxLive.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // edMintoBorn
            // 
            this.edMintoBorn.Location = new System.Drawing.Point(123, 370);
            this.edMintoBorn.Name = "edMintoBorn";
            this.edMintoBorn.Size = new System.Drawing.Size(100, 26);
            this.edMintoBorn.TabIndex = 8;
            this.edMintoBorn.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // edMaxtoBorn
            // 
            this.edMaxtoBorn.Location = new System.Drawing.Point(123, 414);
            this.edMaxtoBorn.Name = "edMaxtoBorn";
            this.edMaxtoBorn.Size = new System.Drawing.Size(100, 26);
            this.edMaxtoBorn.TabIndex = 9;
            this.edMaxtoBorn.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 458);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Настройки карты";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 493);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Ширина";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 524);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Высота";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 555);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Масштаб";
            // 
            // edScale
            // 
            this.edScale.Location = new System.Drawing.Point(123, 550);
            this.edScale.Name = "edScale";
            this.edScale.Size = new System.Drawing.Size(100, 26);
            this.edScale.TabIndex = 11;
            this.edScale.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // edHeight
            // 
            this.edHeight.Location = new System.Drawing.Point(123, 518);
            this.edHeight.Name = "edHeight";
            this.edHeight.Size = new System.Drawing.Size(100, 26);
            this.edHeight.TabIndex = 12;
            this.edHeight.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // edWidth
            // 
            this.edWidth.Location = new System.Drawing.Point(123, 487);
            this.edWidth.Name = "edWidth";
            this.edWidth.Size = new System.Drawing.Size(100, 26);
            this.edWidth.TabIndex = 13;
            this.edWidth.Value = new decimal(new int[] {
            78,
            0,
            0,
            0});
            // 
            // edNotDense
            // 
            this.edNotDense.Location = new System.Drawing.Point(123, 582);
            this.edNotDense.Name = "edNotDense";
            this.edNotDense.Size = new System.Drawing.Size(100, 26);
            this.edNotDense.TabIndex = 14;
            this.edNotDense.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 584);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "Рассеяние";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(229, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(929, 609);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 622);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.edNotDense);
            this.Controls.Add(this.edWidth);
            this.Controls.Add(this.edHeight);
            this.Controls.Add(this.edScale);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.edMaxtoBorn);
            this.Controls.Add(this.edMintoBorn);
            this.Controls.Add(this.edMaxLive);
            this.Controls.Add(this.edMinLive);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbNeighbours);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btCycle);
            this.Controls.Add(this.btNewMap);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.edMinLive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edMaxLive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edMintoBorn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edMaxtoBorn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edNotDense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btNewMap;
        private System.Windows.Forms.Button btCycle;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Label lbNeighbours;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown edMinLive;
        private System.Windows.Forms.NumericUpDown edMaxLive;
        private System.Windows.Forms.NumericUpDown edMintoBorn;
        private System.Windows.Forms.NumericUpDown edMaxtoBorn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown edScale;
        private System.Windows.Forms.NumericUpDown edHeight;
        private System.Windows.Forms.NumericUpDown edWidth;
        private System.Windows.Forms.NumericUpDown edNotDense;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

