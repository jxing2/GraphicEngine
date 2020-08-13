namespace PaintPanel
{
    partial class GraphView
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

        #region 组件设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // GraphView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "GraphView";
            this.Size = new System.Drawing.Size(800, 450);
            this.Load += new System.EventHandler(this.PaintPanel_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintPanel_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GraphView_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GraphView_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GraphView_KeyUp);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PaintPanel_MouseClick);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PaintPanel_MouseDoubleClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GraphView_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PaintPanel_MouseMove);
            this.Resize += new System.EventHandler(this.PaintPanel_Resize);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
