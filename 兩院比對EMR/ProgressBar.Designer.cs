namespace 兩院比對EMR
{
    partial class ProgressBar
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.bgw = new System.ComponentModel.BackgroundWorker();
            this.lb1 = new System.Windows.Forms.Label();
            this.lb_total = new System.Windows.Forms.Label();
            this.lb_cnt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_filename = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 32);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(672, 52);
            this.progressBar1.TabIndex = 0;
            // 
            // bgw
            // 
            this.bgw.WorkerSupportsCancellation = true;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("新細明體", 12F);
            this.lb1.Location = new System.Drawing.Point(552, 9);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(72, 16);
            this.lb1.TabIndex = 1;
            this.lb1.Text = "檔案總量";
            // 
            // lb_total
            // 
            this.lb_total.AutoSize = true;
            this.lb_total.Font = new System.Drawing.Font("新細明體", 12F);
            this.lb_total.Location = new System.Drawing.Point(648, 9);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(16, 16);
            this.lb_total.TabIndex = 2;
            this.lb_total.Text = "0";
            // 
            // lb_cnt
            // 
            this.lb_cnt.AutoSize = true;
            this.lb_cnt.Font = new System.Drawing.Font("新細明體", 12F);
            this.lb_cnt.ForeColor = System.Drawing.Color.Red;
            this.lb_cnt.Location = new System.Drawing.Point(492, 9);
            this.lb_cnt.Name = "lb_cnt";
            this.lb_cnt.Size = new System.Drawing.Size(16, 16);
            this.lb_cnt.TabIndex = 4;
            this.lb_cnt.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F);
            this.label2.Location = new System.Drawing.Point(405, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "已比對";
            // 
            // lb_filename
            // 
            this.lb_filename.AutoSize = true;
            this.lb_filename.Font = new System.Drawing.Font("新細明體", 12F);
            this.lb_filename.Location = new System.Drawing.Point(21, 9);
            this.lb_filename.Name = "lb_filename";
            this.lb_filename.Size = new System.Drawing.Size(46, 16);
            this.lb_filename.TabIndex = 5;
            this.lb_filename.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "取消";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProgressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 129);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_filename);
            this.Controls.Add(this.lb_cnt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_total);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.progressBar1);
            this.MaximizeBox = false;
            this.Name = "ProgressBar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "比對中....";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker bgw;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb_total;
        private System.Windows.Forms.Label lb_cnt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_filename;
        private System.Windows.Forms.Button button1;
    }
}