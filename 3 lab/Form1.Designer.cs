namespace _3_lab
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
            this.AnT = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Z = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Цвет = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lightB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.HBox = new System.Windows.Forms.TextBox();
            this.CBox = new System.Windows.Forms.TextBox();
            this.RBox = new System.Windows.Forms.TextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // AnT
            // 
            this.AnT.AccumBits = ((byte)(0));
            this.AnT.AutoCheckErrors = false;
            this.AnT.AutoFinish = false;
            this.AnT.AutoMakeCurrent = true;
            this.AnT.AutoSwapBuffers = true;
            this.AnT.BackColor = System.Drawing.Color.Black;
            this.AnT.ColorBits = ((byte)(32));
            this.AnT.DepthBits = ((byte)(16));
            this.AnT.Location = new System.Drawing.Point(2, 12);
            this.AnT.Name = "AnT";
            this.AnT.Size = new System.Drawing.Size(896, 602);
            this.AnT.StencilBits = ((byte)(0));
            this.AnT.TabIndex = 0;
            this.AnT.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AnT_MouseMove);
            // 
            // Grid
            // 
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.AllowUserToResizeColumns = false;
            this.Grid.AllowUserToResizeRows = false;
            this.Grid.ColumnHeadersHeight = 29;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y,
            this.Z,
            this.Цвет});
            this.Grid.Location = new System.Drawing.Point(927, 13);
            this.Grid.Margin = new System.Windows.Forms.Padding(4);
            this.Grid.Name = "Grid";
            this.Grid.RowHeadersWidth = 51;
            this.Grid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Grid.Size = new System.Drawing.Size(315, 61);
            this.Grid.TabIndex = 3;
            this.Grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellContentClick);
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.MinimumWidth = 6;
            this.X.Name = "X";
            this.X.Width = 40;
            // 
            // Y
            // 
            this.Y.HeaderText = "Y";
            this.Y.MinimumWidth = 6;
            this.Y.Name = "Y";
            this.Y.Width = 40;
            // 
            // Z
            // 
            this.Z.HeaderText = "Z";
            this.Z.MinimumWidth = 6;
            this.Z.Name = "Z";
            this.Z.Width = 40;
            // 
            // Цвет
            // 
            this.Цвет.HeaderText = "Цвет";
            this.Цвет.MinimumWidth = 6;
            this.Цвет.Name = "Цвет";
            this.Цвет.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Цвет.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Цвет.Text = "Цвет...";
            this.Цвет.Width = 125;
            // 
            // lightB
            // 
            this.lightB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lightB.Location = new System.Drawing.Point(1012, 119);
            this.lightB.Margin = new System.Windows.Forms.Padding(4);
            this.lightB.Name = "lightB";
            this.lightB.Size = new System.Drawing.Size(167, 53);
            this.lightB.TabIndex = 4;
            this.lightB.Text = "Осветить";
            this.lightB.UseVisualStyleBackColor = true;
            this.lightB.Click += new System.EventHandler(this.lightB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(923, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Высота";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(923, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Радиус основания";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(923, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Количество б. г.";
            // 
            // HBox
            // 
            this.HBox.Location = new System.Drawing.Point(1110, 200);
            this.HBox.Margin = new System.Windows.Forms.Padding(4);
            this.HBox.Name = "HBox";
            this.HBox.Size = new System.Drawing.Size(132, 22);
            this.HBox.TabIndex = 8;
            this.HBox.TextChanged += new System.EventHandler(this.HBox_TextChanged);
            // 
            // CBox
            // 
            this.CBox.Location = new System.Drawing.Point(1110, 303);
            this.CBox.Margin = new System.Windows.Forms.Padding(4);
            this.CBox.Name = "CBox";
            this.CBox.Size = new System.Drawing.Size(132, 22);
            this.CBox.TabIndex = 8;
            this.CBox.TextChanged += new System.EventHandler(this.CBox_TextChanged);
            // 
            // RBox
            // 
            this.RBox.Location = new System.Drawing.Point(1110, 253);
            this.RBox.Margin = new System.Windows.Forms.Padding(4);
            this.RBox.Name = "RBox";
            this.RBox.Size = new System.Drawing.Size(132, 22);
            this.RBox.TabIndex = 9;
            this.RBox.TextChanged += new System.EventHandler(this.RBox_TextChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(1019, 385);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(160, 56);
            this.trackBar1.TabIndex = 10;
            this.trackBar1.Value = 10;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 664);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.RBox);
            this.Controls.Add(this.CBox);
            this.Controls.Add(this.HBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lightB);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.AnT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl AnT;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.DataGridViewTextBoxColumn Z;
        private System.Windows.Forms.DataGridViewButtonColumn Цвет;
        private System.Windows.Forms.Button lightB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox HBox;
        private System.Windows.Forms.TextBox CBox;
        private System.Windows.Forms.TextBox RBox;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

