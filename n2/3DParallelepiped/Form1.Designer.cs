namespace KG2
{
    partial class FormMain
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
            this.pictureBoxView = new System.Windows.Forms.PictureBox();
            this.bPaint = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.udAngle = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCamDir = new System.Windows.Forms.TextBox();
            this.textBoxCamPos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxBoxSize = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxLights = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnColor = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.boxH = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udAngle)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxView
            // 
            this.pictureBoxView.BackColor = System.Drawing.Color.White;
            this.pictureBoxView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxView.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxView.Name = "pictureBoxView";
            this.pictureBoxView.Size = new System.Drawing.Size(875, 578);
            this.pictureBoxView.TabIndex = 0;
            this.pictureBoxView.TabStop = false;
            this.pictureBoxView.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxView_MouseMove);
            // 
            // bPaint
            // 
            this.bPaint.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bPaint.Location = new System.Drawing.Point(16, 412);
            this.bPaint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bPaint.Name = "bPaint";
            this.bPaint.Size = new System.Drawing.Size(85, 28);
            this.bPaint.TabIndex = 1;
            this.bPaint.Text = "Рисовать";
            this.bPaint.UseVisualStyleBackColor = true;
            this.bPaint.Click += new System.EventHandler(this.bPaint_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.udAngle);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxCamDir);
            this.groupBox1.Controls.Add(this.textBoxCamPos);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(187, 174);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Камера";
            // 
            // udAngle
            // 
            this.udAngle.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.udAngle.Location = new System.Drawing.Point(12, 142);
            this.udAngle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.udAngle.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.udAngle.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.udAngle.Name = "udAngle";
            this.udAngle.Size = new System.Drawing.Size(160, 22);
            this.udAngle.TabIndex = 5;
            this.udAngle.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Угол обзора:";
            // 
            // textBoxCamDir
            // 
            this.textBoxCamDir.Location = new System.Drawing.Point(12, 87);
            this.textBoxCamDir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCamDir.Name = "textBoxCamDir";
            this.textBoxCamDir.Size = new System.Drawing.Size(160, 22);
            this.textBoxCamDir.TabIndex = 3;
            this.textBoxCamDir.Text = "0 0 0";
            // 
            // textBoxCamPos
            // 
            this.textBoxCamPos.Location = new System.Drawing.Point(12, 39);
            this.textBoxCamPos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCamPos.Name = "textBoxCamPos";
            this.textBoxCamPos.Size = new System.Drawing.Size(160, 22);
            this.textBoxCamPos.TabIndex = 2;
            this.textBoxCamPos.Text = "7 11 3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Направление";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Положение:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxBoxSize);
            this.groupBox2.Location = new System.Drawing.Point(16, 196);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(187, 58);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Радиус основания:";
            // 
            // textBoxBoxSize
            // 
            this.textBoxBoxSize.Location = new System.Drawing.Point(12, 23);
            this.textBoxBoxSize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxBoxSize.Name = "textBoxBoxSize";
            this.textBoxBoxSize.Size = new System.Drawing.Size(160, 22);
            this.textBoxBoxSize.TabIndex = 3;
            this.textBoxBoxSize.Text = "4";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxLights);
            this.groupBox3.Location = new System.Drawing.Point(16, 340);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(187, 64);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Источник освещения:";
            // 
            // textBoxLights
            // 
            this.textBoxLights.Location = new System.Drawing.Point(8, 23);
            this.textBoxLights.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxLights.Name = "textBoxLights";
            this.textBoxLights.Size = new System.Drawing.Size(164, 22);
            this.textBoxLights.TabIndex = 4;
            this.textBoxLights.Text = "15 15 3";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox4);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.bPaint);
            this.splitContainer1.Panel1.Controls.Add(this.btnColor);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBoxView);
            this.splitContainer1.Size = new System.Drawing.Size(1105, 578);
            this.splitContainer1.SplitterDistance = 225;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 6;
            // 
            // btnColor
            // 
            this.btnColor.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnColor.Location = new System.Drawing.Point(132, 412);
            this.btnColor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(71, 28);
            this.btnColor.TabIndex = 6;
            this.btnColor.Text = "Цвет";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // colorDialog
            // 
            this.colorDialog.Color = System.Drawing.Color.RoyalBlue;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.boxH);
            this.groupBox4.Location = new System.Drawing.Point(16, 262);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(187, 58);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Высота:";
            // 
            // boxH
            // 
            this.boxH.Location = new System.Drawing.Point(12, 23);
            this.boxH.Margin = new System.Windows.Forms.Padding(4);
            this.boxH.Name = "boxH";
            this.boxH.Size = new System.Drawing.Size(160, 22);
            this.boxH.TabIndex = 3;
            this.boxH.Text = "5";
            // 
            // FormMain
            // 
            this.AcceptButton = this.bPaint;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 578);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Шар";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormMain_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udAngle)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxView;
        private System.Windows.Forms.Button bPaint;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxCamDir;
        private System.Windows.Forms.TextBox textBoxCamPos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxBoxSize;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxLights;
        private System.Windows.Forms.NumericUpDown udAngle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox boxH;
    }
}

