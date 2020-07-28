namespace GraphicEngineTest
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.bt_rotate = new System.Windows.Forms.Button();
            this.tb_rotate = new System.Windows.Forms.TextBox();
            this.bt_path = new System.Windows.Forms.Button();
            this.bt_line = new System.Windows.Forms.Button();
            this.bt_select = new System.Windows.Forms.Button();
            this.tb_txt = new System.Windows.Forms.TextBox();
            this.bt_txt = new System.Windows.Forms.Button();
            this.bt_rect = new System.Windows.Forms.Button();
            this.bt_ellipse = new System.Windows.Forms.Button();
            this.paintPanel1 = new PaintPanel.PaintPanel();
            this.tb_scale_y = new System.Windows.Forms.TextBox();
            this.bt_scale = new System.Windows.Forms.Button();
            this.tb_rotate_x = new System.Windows.Forms.TextBox();
            this.tb_rotate_y = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_scale_x = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.tb_rotate_y);
            this.splitContainer1.Panel1.Controls.Add(this.tb_rotate_x);
            this.splitContainer1.Panel1.Controls.Add(this.bt_scale);
            this.splitContainer1.Panel1.Controls.Add(this.tb_scale_x);
            this.splitContainer1.Panel1.Controls.Add(this.tb_scale_y);
            this.splitContainer1.Panel1.Controls.Add(this.bt_rotate);
            this.splitContainer1.Panel1.Controls.Add(this.tb_rotate);
            this.splitContainer1.Panel1.Controls.Add(this.bt_path);
            this.splitContainer1.Panel1.Controls.Add(this.bt_line);
            this.splitContainer1.Panel1.Controls.Add(this.bt_select);
            this.splitContainer1.Panel1.Controls.Add(this.tb_txt);
            this.splitContainer1.Panel1.Controls.Add(this.bt_txt);
            this.splitContainer1.Panel1.Controls.Add(this.bt_rect);
            this.splitContainer1.Panel1.Controls.Add(this.bt_ellipse);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.paintPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(1305, 640);
            this.splitContainer1.SplitterDistance = 298;
            this.splitContainer1.TabIndex = 0;
            // 
            // bt_rotate
            // 
            this.bt_rotate.Location = new System.Drawing.Point(209, 393);
            this.bt_rotate.Name = "bt_rotate";
            this.bt_rotate.Size = new System.Drawing.Size(75, 23);
            this.bt_rotate.TabIndex = 9;
            this.bt_rotate.Text = "Rotate";
            this.bt_rotate.UseVisualStyleBackColor = true;
            this.bt_rotate.Click += new System.EventHandler(this.bt_rotate_Click);
            // 
            // tb_rotate
            // 
            this.tb_rotate.Location = new System.Drawing.Point(12, 395);
            this.tb_rotate.Name = "tb_rotate";
            this.tb_rotate.Size = new System.Drawing.Size(78, 21);
            this.tb_rotate.TabIndex = 8;
            this.tb_rotate.Text = "0";
            // 
            // bt_path
            // 
            this.bt_path.Location = new System.Drawing.Point(107, 325);
            this.bt_path.Name = "bt_path";
            this.bt_path.Size = new System.Drawing.Size(75, 23);
            this.bt_path.TabIndex = 7;
            this.bt_path.Text = "Path";
            this.bt_path.UseVisualStyleBackColor = true;
            this.bt_path.Click += new System.EventHandler(this.bt_path_Click);
            // 
            // bt_line
            // 
            this.bt_line.Location = new System.Drawing.Point(105, 271);
            this.bt_line.Name = "bt_line";
            this.bt_line.Size = new System.Drawing.Size(75, 23);
            this.bt_line.TabIndex = 6;
            this.bt_line.Text = "Line";
            this.bt_line.UseVisualStyleBackColor = true;
            this.bt_line.Click += new System.EventHandler(this.bt_line_Click);
            // 
            // bt_select
            // 
            this.bt_select.Location = new System.Drawing.Point(203, 593);
            this.bt_select.Name = "bt_select";
            this.bt_select.Size = new System.Drawing.Size(75, 23);
            this.bt_select.TabIndex = 5;
            this.bt_select.Text = "Select";
            this.bt_select.UseVisualStyleBackColor = true;
            this.bt_select.Click += new System.EventHandler(this.bt_select_Click);
            // 
            // tb_txt
            // 
            this.tb_txt.Location = new System.Drawing.Point(12, 227);
            this.tb_txt.Name = "tb_txt";
            this.tb_txt.Size = new System.Drawing.Size(191, 21);
            this.tb_txt.TabIndex = 4;
            // 
            // bt_txt
            // 
            this.bt_txt.Location = new System.Drawing.Point(209, 227);
            this.bt_txt.Name = "bt_txt";
            this.bt_txt.Size = new System.Drawing.Size(69, 24);
            this.bt_txt.TabIndex = 3;
            this.bt_txt.Text = "Text";
            this.bt_txt.UseVisualStyleBackColor = true;
            this.bt_txt.Click += new System.EventHandler(this.bt_txt_Click);
            // 
            // bt_rect
            // 
            this.bt_rect.Location = new System.Drawing.Point(107, 182);
            this.bt_rect.Name = "bt_rect";
            this.bt_rect.Size = new System.Drawing.Size(75, 23);
            this.bt_rect.TabIndex = 2;
            this.bt_rect.Text = "Rectangle";
            this.bt_rect.UseVisualStyleBackColor = true;
            this.bt_rect.Click += new System.EventHandler(this.bt_rect_Click);
            // 
            // bt_ellipse
            // 
            this.bt_ellipse.Location = new System.Drawing.Point(105, 133);
            this.bt_ellipse.Name = "bt_ellipse";
            this.bt_ellipse.Size = new System.Drawing.Size(75, 23);
            this.bt_ellipse.TabIndex = 0;
            this.bt_ellipse.Text = "Ellipse";
            this.bt_ellipse.UseVisualStyleBackColor = true;
            this.bt_ellipse.Click += new System.EventHandler(this.bt_ellipse_Click);
            // 
            // paintPanel1
            // 
            this.paintPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paintPanel1.Location = new System.Drawing.Point(0, 0);
            this.paintPanel1.Name = "paintPanel1";
            this.paintPanel1.Size = new System.Drawing.Size(1003, 640);
            this.paintPanel1.TabIndex = 0;
            this.paintPanel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.paintPanel1_MouseClick);
            // 
            // tb_scale_y
            // 
            this.tb_scale_y.Location = new System.Drawing.Point(138, 450);
            this.tb_scale_y.Name = "tb_scale_y";
            this.tb_scale_y.Size = new System.Drawing.Size(65, 21);
            this.tb_scale_y.TabIndex = 10;
            this.tb_scale_y.Text = "100";
            // 
            // bt_scale
            // 
            this.bt_scale.Location = new System.Drawing.Point(209, 448);
            this.bt_scale.Name = "bt_scale";
            this.bt_scale.Size = new System.Drawing.Size(75, 23);
            this.bt_scale.TabIndex = 11;
            this.bt_scale.Text = "Scale";
            this.bt_scale.UseVisualStyleBackColor = true;
            this.bt_scale.Click += new System.EventHandler(this.bt_scale_Click);
            // 
            // tb_rotate_x
            // 
            this.tb_rotate_x.Location = new System.Drawing.Point(145, 380);
            this.tb_rotate_x.Name = "tb_rotate_x";
            this.tb_rotate_x.Size = new System.Drawing.Size(58, 21);
            this.tb_rotate_x.TabIndex = 12;
            this.tb_rotate_x.Text = "0";
            // 
            // tb_rotate_y
            // 
            this.tb_rotate_y.Location = new System.Drawing.Point(145, 407);
            this.tb_rotate_y.Name = "tb_rotate_y";
            this.tb_rotate_y.Size = new System.Drawing.Size(58, 21);
            this.tb_rotate_y.TabIndex = 13;
            this.tb_rotate_y.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 383);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 410);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "Y:";
            // 
            // tb_scale_x
            // 
            this.tb_scale_x.Location = new System.Drawing.Point(38, 450);
            this.tb_scale_x.Name = "tb_scale_x";
            this.tb_scale_x.Size = new System.Drawing.Size(65, 21);
            this.tb_scale_x.TabIndex = 10;
            this.tb_scale_x.Text = "100";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 453);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "X:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 453);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "Y:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 640);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private PaintPanel.PaintPanel paintPanel1;
        private System.Windows.Forms.Button bt_ellipse;
        private System.Windows.Forms.Button bt_rect;
        private System.Windows.Forms.Button bt_txt;
        private System.Windows.Forms.TextBox tb_txt;
        private System.Windows.Forms.Button bt_select;
        private System.Windows.Forms.Button bt_line;
        private System.Windows.Forms.Button bt_path;
        private System.Windows.Forms.Button bt_rotate;
        private System.Windows.Forms.TextBox tb_rotate;
        private System.Windows.Forms.Button bt_scale;
        private System.Windows.Forms.TextBox tb_scale_y;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_rotate_y;
        private System.Windows.Forms.TextBox tb_rotate_x;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_scale_x;
    }
}

