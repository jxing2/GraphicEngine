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
            this.bt_select = new System.Windows.Forms.Button();
            this.tb_txt = new System.Windows.Forms.TextBox();
            this.bt_txt = new System.Windows.Forms.Button();
            this.bt_rect = new System.Windows.Forms.Button();
            this.bt_ellipse = new System.Windows.Forms.Button();
            this.paintPanel1 = new PaintPanel.PaintPanel();
            this.bt_line = new System.Windows.Forms.Button();
            this.bt_path = new System.Windows.Forms.Button();
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
    }
}

