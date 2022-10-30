
namespace CharDetector
{
    partial class frmPlayerAnalyze
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
            this.btnGo = new System.Windows.Forms.Button();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.txtFullAnalyze = new System.Windows.Forms.RichTextBox();
            this.txtUniqueCount = new System.Windows.Forms.RichTextBox();
            this.txtDepth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(667, 9);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 0;
            this.btnGo.Text = "go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(57, 10);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(171, 20);
            this.txtPlayerName.TabIndex = 2;
            // 
            // txtFullAnalyze
            // 
            this.txtFullAnalyze.Location = new System.Drawing.Point(12, 56);
            this.txtFullAnalyze.Name = "txtFullAnalyze";
            this.txtFullAnalyze.Size = new System.Drawing.Size(362, 709);
            this.txtFullAnalyze.TabIndex = 3;
            this.txtFullAnalyze.Text = "";
            // 
            // txtUniqueCount
            // 
            this.txtUniqueCount.Location = new System.Drawing.Point(380, 56);
            this.txtUniqueCount.Name = "txtUniqueCount";
            this.txtUniqueCount.Size = new System.Drawing.Size(362, 709);
            this.txtUniqueCount.TabIndex = 4;
            this.txtUniqueCount.Text = "";
            // 
            // txtDepth
            // 
            this.txtDepth.Location = new System.Drawing.Point(286, 10);
            this.txtDepth.Name = "txtDepth";
            this.txtDepth.Size = new System.Drawing.Size(65, 20);
            this.txtDepth.TabIndex = 5;
            this.txtDepth.Text = "10";
            this.txtDepth.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "depth:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Player:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "path:";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(400, 10);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(247, 20);
            this.txtPath.TabIndex = 8;
            this.txtPath.Text = "C:\\Users\\Fudjitsu P500\\Desktop\\CharChecker\\PlayersHistory";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(15, 777);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(729, 14);
            this.progressBar1.TabIndex = 10;
            // 
            // frmPlayerAnalyze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 807);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDepth);
            this.Controls.Add(this.txtUniqueCount);
            this.Controls.Add(this.txtFullAnalyze);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.btnGo);
            this.Name = "frmPlayerAnalyze";
            this.Text = "frmPlayerAnalyze";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.RichTextBox txtFullAnalyze;
        private System.Windows.Forms.RichTextBox txtUniqueCount;
        private System.Windows.Forms.TextBox txtDepth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}