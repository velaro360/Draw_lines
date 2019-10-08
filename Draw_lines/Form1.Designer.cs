namespace Draw_lines
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
            this.pictureBoxIncremental = new System.Windows.Forms.PictureBox();
            this.draw1_btn = new System.Windows.Forms.Button();
            this.incremental_lbl = new System.Windows.Forms.Label();
            this.bresenham_lbl = new System.Windows.Forms.Label();
            this.clear1_btn = new System.Windows.Forms.Button();
            this.draw2_btn = new System.Windows.Forms.Button();
            this.pictureBoxBersenham = new System.Windows.Forms.PictureBox();
            this.clear2_btn = new System.Windows.Forms.Button();
            this.point1Start_lbl = new System.Windows.Forms.Label();
            this.point1End_lbl = new System.Windows.Forms.Label();
            this.point2Start_lbl = new System.Windows.Forms.Label();
            this.point2End_lbl = new System.Windows.Forms.Label();
            this.xPoint1Start = new System.Windows.Forms.NumericUpDown();
            this.yPoint1Start = new System.Windows.Forms.NumericUpDown();
            this.yPoint1End = new System.Windows.Forms.NumericUpDown();
            this.xPoint1End = new System.Windows.Forms.NumericUpDown();
            this.xPoint2Start = new System.Windows.Forms.NumericUpDown();
            this.yPoint2Start = new System.Windows.Forms.NumericUpDown();
            this.yPoint2End = new System.Windows.Forms.NumericUpDown();
            this.xPoint2End = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIncremental)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBersenham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xPoint1Start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yPoint1Start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yPoint1End)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xPoint1End)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xPoint2Start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yPoint2Start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yPoint2End)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xPoint2End)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxIncremental
            // 
            this.pictureBoxIncremental.BackColor = System.Drawing.Color.White;
            this.pictureBoxIncremental.Location = new System.Drawing.Point(45, 143);
            this.pictureBoxIncremental.Name = "pictureBoxIncremental";
            this.pictureBoxIncremental.Size = new System.Drawing.Size(400, 400);
            this.pictureBoxIncremental.TabIndex = 0;
            this.pictureBoxIncremental.TabStop = false;
            // 
            // draw1_btn
            // 
            this.draw1_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.draw1_btn.Location = new System.Drawing.Point(45, 57);
            this.draw1_btn.Name = "draw1_btn";
            this.draw1_btn.Size = new System.Drawing.Size(75, 36);
            this.draw1_btn.TabIndex = 1;
            this.draw1_btn.Text = "Rysuj";
            this.draw1_btn.UseVisualStyleBackColor = true;
            this.draw1_btn.Click += new System.EventHandler(this.Draw1_btn_Click);
            // 
            // incremental_lbl
            // 
            this.incremental_lbl.AutoSize = true;
            this.incremental_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.incremental_lbl.Location = new System.Drawing.Point(37, 3);
            this.incremental_lbl.Name = "incremental_lbl";
            this.incremental_lbl.Size = new System.Drawing.Size(385, 44);
            this.incremental_lbl.TabIndex = 2;
            this.incremental_lbl.Text = "Algorytm przyrostowy";
            // 
            // bresenham_lbl
            // 
            this.bresenham_lbl.AutoSize = true;
            this.bresenham_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bresenham_lbl.Location = new System.Drawing.Point(544, 3);
            this.bresenham_lbl.Name = "bresenham_lbl";
            this.bresenham_lbl.Size = new System.Drawing.Size(398, 44);
            this.bresenham_lbl.TabIndex = 3;
            this.bresenham_lbl.Text = "Algorytm Bresenhama";
            // 
            // clear1_btn
            // 
            this.clear1_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clear1_btn.Location = new System.Drawing.Point(45, 99);
            this.clear1_btn.Name = "clear1_btn";
            this.clear1_btn.Size = new System.Drawing.Size(75, 38);
            this.clear1_btn.TabIndex = 4;
            this.clear1_btn.Text = "Czyść";
            this.clear1_btn.UseVisualStyleBackColor = true;
            this.clear1_btn.Click += new System.EventHandler(this.Clear1_btn_Click);
            // 
            // draw2_btn
            // 
            this.draw2_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.draw2_btn.Location = new System.Drawing.Point(552, 57);
            this.draw2_btn.Name = "draw2_btn";
            this.draw2_btn.Size = new System.Drawing.Size(75, 36);
            this.draw2_btn.TabIndex = 5;
            this.draw2_btn.Text = "Rysuj";
            this.draw2_btn.UseVisualStyleBackColor = true;
            this.draw2_btn.Click += new System.EventHandler(this.Draw2_btn_Click);
            // 
            // pictureBoxBersenham
            // 
            this.pictureBoxBersenham.BackColor = System.Drawing.Color.White;
            this.pictureBoxBersenham.Location = new System.Drawing.Point(552, 143);
            this.pictureBoxBersenham.Name = "pictureBoxBersenham";
            this.pictureBoxBersenham.Size = new System.Drawing.Size(400, 400);
            this.pictureBoxBersenham.TabIndex = 6;
            this.pictureBoxBersenham.TabStop = false;
            // 
            // clear2_btn
            // 
            this.clear2_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clear2_btn.Location = new System.Drawing.Point(552, 99);
            this.clear2_btn.Name = "clear2_btn";
            this.clear2_btn.Size = new System.Drawing.Size(75, 38);
            this.clear2_btn.TabIndex = 7;
            this.clear2_btn.Text = "Czyść";
            this.clear2_btn.UseVisualStyleBackColor = true;
            this.clear2_btn.Click += new System.EventHandler(this.Clear2_btn_Click);
            // 
            // point1Start_lbl
            // 
            this.point1Start_lbl.AutoSize = true;
            this.point1Start_lbl.Location = new System.Drawing.Point(135, 68);
            this.point1Start_lbl.Name = "point1Start_lbl";
            this.point1Start_lbl.Size = new System.Drawing.Size(156, 17);
            this.point1Start_lbl.TabIndex = 8;
            this.point1Start_lbl.Text = "Punkt początkowy (x,y):";
            // 
            // point1End_lbl
            // 
            this.point1End_lbl.AutoSize = true;
            this.point1End_lbl.Location = new System.Drawing.Point(135, 111);
            this.point1End_lbl.Name = "point1End_lbl";
            this.point1End_lbl.Size = new System.Drawing.Size(137, 17);
            this.point1End_lbl.TabIndex = 9;
            this.point1End_lbl.Text = "Punkt końcowy (x,y):";
            // 
            // point2Start_lbl
            // 
            this.point2Start_lbl.AutoSize = true;
            this.point2Start_lbl.Location = new System.Drawing.Point(642, 68);
            this.point2Start_lbl.Name = "point2Start_lbl";
            this.point2Start_lbl.Size = new System.Drawing.Size(156, 17);
            this.point2Start_lbl.TabIndex = 10;
            this.point2Start_lbl.Text = "Punkt początkowy (x,y):";
            // 
            // point2End_lbl
            // 
            this.point2End_lbl.AutoSize = true;
            this.point2End_lbl.Location = new System.Drawing.Point(642, 111);
            this.point2End_lbl.Name = "point2End_lbl";
            this.point2End_lbl.Size = new System.Drawing.Size(137, 17);
            this.point2End_lbl.TabIndex = 11;
            this.point2End_lbl.Text = "Punkt końcowy (x,y):";
            // 
            // xPoint1Start
            // 
            this.xPoint1Start.Location = new System.Drawing.Point(297, 66);
            this.xPoint1Start.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.xPoint1Start.Minimum = new decimal(new int[] {
            120,
            0,
            0,
            -2147483648});
            this.xPoint1Start.Name = "xPoint1Start";
            this.xPoint1Start.Size = new System.Drawing.Size(67, 22);
            this.xPoint1Start.TabIndex = 12;
            // 
            // yPoint1Start
            // 
            this.yPoint1Start.Location = new System.Drawing.Point(379, 66);
            this.yPoint1Start.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.yPoint1Start.Minimum = new decimal(new int[] {
            120,
            0,
            0,
            -2147483648});
            this.yPoint1Start.Name = "yPoint1Start";
            this.yPoint1Start.Size = new System.Drawing.Size(66, 22);
            this.yPoint1Start.TabIndex = 13;
            // 
            // yPoint1End
            // 
            this.yPoint1End.Location = new System.Drawing.Point(379, 109);
            this.yPoint1End.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.yPoint1End.Minimum = new decimal(new int[] {
            120,
            0,
            0,
            -2147483648});
            this.yPoint1End.Name = "yPoint1End";
            this.yPoint1End.Size = new System.Drawing.Size(66, 22);
            this.yPoint1End.TabIndex = 14;
            // 
            // xPoint1End
            // 
            this.xPoint1End.Location = new System.Drawing.Point(297, 109);
            this.xPoint1End.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.xPoint1End.Minimum = new decimal(new int[] {
            120,
            0,
            0,
            -2147483648});
            this.xPoint1End.Name = "xPoint1End";
            this.xPoint1End.Size = new System.Drawing.Size(67, 22);
            this.xPoint1End.TabIndex = 15;
            // 
            // xPoint2Start
            // 
            this.xPoint2Start.Location = new System.Drawing.Point(804, 66);
            this.xPoint2Start.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.xPoint2Start.Minimum = new decimal(new int[] {
            120,
            0,
            0,
            -2147483648});
            this.xPoint2Start.Name = "xPoint2Start";
            this.xPoint2Start.Size = new System.Drawing.Size(66, 22);
            this.xPoint2Start.TabIndex = 16;
            // 
            // yPoint2Start
            // 
            this.yPoint2Start.Location = new System.Drawing.Point(886, 66);
            this.yPoint2Start.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.yPoint2Start.Minimum = new decimal(new int[] {
            120,
            0,
            0,
            -2147483648});
            this.yPoint2Start.Name = "yPoint2Start";
            this.yPoint2Start.Size = new System.Drawing.Size(66, 22);
            this.yPoint2Start.TabIndex = 17;
            // 
            // yPoint2End
            // 
            this.yPoint2End.Location = new System.Drawing.Point(886, 109);
            this.yPoint2End.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.yPoint2End.Minimum = new decimal(new int[] {
            120,
            0,
            0,
            -2147483648});
            this.yPoint2End.Name = "yPoint2End";
            this.yPoint2End.Size = new System.Drawing.Size(66, 22);
            this.yPoint2End.TabIndex = 18;
            // 
            // xPoint2End
            // 
            this.xPoint2End.Location = new System.Drawing.Point(804, 109);
            this.xPoint2End.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.xPoint2End.Minimum = new decimal(new int[] {
            120,
            0,
            0,
            -2147483648});
            this.xPoint2End.Name = "xPoint2End";
            this.xPoint2End.Size = new System.Drawing.Size(66, 22);
            this.xPoint2End.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(998, 561);
            this.Controls.Add(this.xPoint2End);
            this.Controls.Add(this.yPoint2End);
            this.Controls.Add(this.yPoint2Start);
            this.Controls.Add(this.xPoint2Start);
            this.Controls.Add(this.xPoint1End);
            this.Controls.Add(this.yPoint1End);
            this.Controls.Add(this.yPoint1Start);
            this.Controls.Add(this.xPoint1Start);
            this.Controls.Add(this.point2End_lbl);
            this.Controls.Add(this.point2Start_lbl);
            this.Controls.Add(this.point1End_lbl);
            this.Controls.Add(this.point1Start_lbl);
            this.Controls.Add(this.clear2_btn);
            this.Controls.Add(this.pictureBoxBersenham);
            this.Controls.Add(this.draw2_btn);
            this.Controls.Add(this.clear1_btn);
            this.Controls.Add(this.bresenham_lbl);
            this.Controls.Add(this.incremental_lbl);
            this.Controls.Add(this.draw1_btn);
            this.Controls.Add(this.pictureBoxIncremental);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIncremental)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBersenham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xPoint1Start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yPoint1Start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yPoint1End)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xPoint1End)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xPoint2Start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yPoint2Start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yPoint2End)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xPoint2End)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxIncremental;
        private System.Windows.Forms.Button draw1_btn;
        private System.Windows.Forms.Label incremental_lbl;
        private System.Windows.Forms.Label bresenham_lbl;
        private System.Windows.Forms.Button clear1_btn;
        private System.Windows.Forms.Button draw2_btn;
        private System.Windows.Forms.PictureBox pictureBoxBersenham;
        private System.Windows.Forms.Button clear2_btn;
        private System.Windows.Forms.Label point1Start_lbl;
        private System.Windows.Forms.Label point1End_lbl;
        private System.Windows.Forms.Label point2Start_lbl;
        private System.Windows.Forms.Label point2End_lbl;
        private System.Windows.Forms.NumericUpDown xPoint1Start;
        private System.Windows.Forms.NumericUpDown yPoint1Start;
        private System.Windows.Forms.NumericUpDown yPoint1End;
        private System.Windows.Forms.NumericUpDown xPoint1End;
        private System.Windows.Forms.NumericUpDown xPoint2Start;
        private System.Windows.Forms.NumericUpDown yPoint2Start;
        private System.Windows.Forms.NumericUpDown yPoint2End;
        private System.Windows.Forms.NumericUpDown xPoint2End;
    }
}

