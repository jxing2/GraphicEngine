namespace PaintPanel
{
    partial class PaintPanel
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
            this.components = new System.ComponentModel.Container();
            this.fpsTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // fpsTimer
            // 
            this.fpsTimer.Interval = 25;
            this.fpsTimer.Tick += new System.EventHandler(this.fpsTimer_Tick);
            // 
            // PaintPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "PaintPanel";
            this.Size = new System.Drawing.Size(800, 450);
            this.Load += new System.EventHandler(this.PaintPanel_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintPanel_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PaintPanel_MouseClick);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PaintPanel_MouseDoubleClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PaintPanel_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer fpsTimer;
    }
}
