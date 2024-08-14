namespace Langton_s_ant
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mbStart = new System.Windows.Forms.ToolStripMenuItem();
            this.mbStop = new System.Windows.Forms.ToolStripMenuItem();
            this.Counter = new System.Windows.Forms.Label();
            this.mbNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.mbNext = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mbStart,
            this.mbStop,
            this.mbNewGame,
            this.mbNext});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1082, 30);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mbStart
            // 
            this.mbStart.Name = "mbStart";
            this.mbStart.Size = new System.Drawing.Size(54, 26);
            this.mbStart.Text = "Start";
            this.mbStart.Click += new System.EventHandler(this.mbStart_Click);
            // 
            // mbStop
            // 
            this.mbStop.Name = "mbStop";
            this.mbStop.Size = new System.Drawing.Size(54, 26);
            this.mbStop.Text = "Stop";
            this.mbStop.Click += new System.EventHandler(this.mbStop_Click);
            // 
            // Counter
            // 
            this.Counter.AutoSize = true;
            this.Counter.Location = new System.Drawing.Point(12, 28);
            this.Counter.Name = "Counter";
            this.Counter.Size = new System.Drawing.Size(60, 17);
            this.Counter.TabIndex = 3;
            this.Counter.Text = "Steps: 0";
            // 
            // mbNewGame
            // 
            this.mbNewGame.Name = "mbNewGame";
            this.mbNewGame.Size = new System.Drawing.Size(96, 26);
            this.mbNewGame.Text = "New Game";
            this.mbNewGame.Click += new System.EventHandler(this.mbNewGame_Click);
            // 
            // mbNext
            // 
            this.mbNext.Name = "mbNext";
            this.mbNext.Size = new System.Drawing.Size(54, 26);
            this.mbNext.Text = "Next";
            this.mbNext.Click += new System.EventHandler(this.mbNext_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 981);
            this.Controls.Add(this.Counter);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1100, 1028);
            this.MinimumSize = new System.Drawing.Size(1100, 1028);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Langton\'s Ant";
            this.TopMost = true;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mbStart;
        private System.Windows.Forms.ToolStripMenuItem mbStop;
        private System.Windows.Forms.Label Counter;
        private System.Windows.Forms.ToolStripMenuItem mbNewGame;
        private System.Windows.Forms.ToolStripMenuItem mbNext;
    }
}

