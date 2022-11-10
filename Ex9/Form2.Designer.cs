namespace Ex9
{
    partial class TriagleForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.CountIterTextBox = new System.Windows.Forms.TextBox();
            this.NewTriangleButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.CountIterTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.NewTriangleButton);
            this.splitContainer1.Panel1.Controls.Add(this.StartButton);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.splitContainer1_Panel2_MouseClick);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 294;
            this.splitContainer1.TabIndex = 0;
            // 
            // CountIterTextBox
            // 
            this.CountIterTextBox.Location = new System.Drawing.Point(171, 164);
            this.CountIterTextBox.Name = "CountIterTextBox";
            this.CountIterTextBox.Size = new System.Drawing.Size(100, 20);
            this.CountIterTextBox.TabIndex = 4;
            this.CountIterTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CountIterTextBox.TextChanged += new System.EventHandler(this.CountIterTextBox_TextChanged);
            // 
            // NewTriangleButton
            // 
            this.NewTriangleButton.Location = new System.Drawing.Point(110, 232);
            this.NewTriangleButton.Name = "NewTriangleButton";
            this.NewTriangleButton.Size = new System.Drawing.Size(86, 74);
            this.NewTriangleButton.TabIndex = 3;
            this.NewTriangleButton.Text = "Создать новый треугольник";
            this.NewTriangleButton.UseVisualStyleBackColor = true;
            this.NewTriangleButton.Click += new System.EventHandler(this.NewTriangleButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(110, 190);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(86, 36);
            this.StartButton.TabIndex = 2;
            this.StartButton.Text = "Старт (перезапуск)";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Количесвто итераций";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Нажмите внутри треугольника";
            // 
            // TriagleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "TriagleForm";
            this.Text = "Треугольник";
            this.Load += new System.EventHandler(this.TriagleForm_Load);
            this.Shown += new System.EventHandler(this.TriagleForm_Shown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TriagleForm_MouseClick);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox CountIterTextBox;
        private System.Windows.Forms.Button NewTriangleButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}