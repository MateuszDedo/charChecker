
namespace CharDetector
{
    partial class McDetector
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tvblackList = new System.Windows.Forms.TreeView();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtBlackList = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.txtTimeout = new System.Windows.Forms.TextBox();
            this.tvExpChanged = new System.Windows.Forms.TreeView();
            this.btnExp = new System.Windows.Forms.Button();
            this.btnSaveExp = new System.Windows.Forms.Button();
            this.btnLoadExp = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btnPlayer = new System.Windows.Forms.Button();
            this.btnRemoveBlack = new System.Windows.Forms.Button();
            this.btnRemoveChar = new System.Windows.Forms.Button();
            this.btnPlayerAnalyze = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(229, 546);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.DoubleClick += new System.EventHandler(this.treeView1_DoubleClick);
            // 
            // tvblackList
            // 
            this.tvblackList.Location = new System.Drawing.Point(256, 147);
            this.tvblackList.Name = "tvblackList";
            this.tvblackList.Size = new System.Drawing.Size(313, 407);
            this.tvblackList.TabIndex = 1;
            this.tvblackList.DoubleClick += new System.EventHandler(this.tvblackList_DoubleClick);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(575, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(145, 39);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(575, 57);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(145, 37);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtBlackList
            // 
            this.txtBlackList.Location = new System.Drawing.Point(256, 12);
            this.txtBlackList.Multiline = true;
            this.txtBlackList.Name = "txtBlackList";
            this.txtBlackList.Size = new System.Drawing.Size(313, 129);
            this.txtBlackList.TabIndex = 4;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(575, 100);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(145, 41);
            this.btnLoad.TabIndex = 5;
            this.btnLoad.Text = "load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtTimeout
            // 
            this.txtTimeout.Location = new System.Drawing.Point(726, 12);
            this.txtTimeout.Name = "txtTimeout";
            this.txtTimeout.Size = new System.Drawing.Size(149, 20);
            this.txtTimeout.TabIndex = 6;
            this.txtTimeout.Text = "5000";
            // 
            // tvExpChanged
            // 
            this.tvExpChanged.Location = new System.Drawing.Point(582, 150);
            this.tvExpChanged.Name = "tvExpChanged";
            this.tvExpChanged.Size = new System.Drawing.Size(293, 407);
            this.tvExpChanged.TabIndex = 7;
            this.tvExpChanged.DoubleClick += new System.EventHandler(this.tvExpChanged_DoubleClick);
            // 
            // btnExp
            // 
            this.btnExp.Location = new System.Drawing.Point(726, 38);
            this.btnExp.Name = "btnExp";
            this.btnExp.Size = new System.Drawing.Size(93, 37);
            this.btnExp.TabIndex = 8;
            this.btnExp.Text = "experience";
            this.btnExp.UseVisualStyleBackColor = true;
            this.btnExp.Click += new System.EventHandler(this.btnExp_Click);
            // 
            // btnSaveExp
            // 
            this.btnSaveExp.Location = new System.Drawing.Point(726, 79);
            this.btnSaveExp.Name = "btnSaveExp";
            this.btnSaveExp.Size = new System.Drawing.Size(145, 28);
            this.btnSaveExp.TabIndex = 9;
            this.btnSaveExp.Text = "save exp";
            this.btnSaveExp.UseVisualStyleBackColor = true;
            this.btnSaveExp.Click += new System.EventHandler(this.btnSaveExp_Click);
            // 
            // btnLoadExp
            // 
            this.btnLoadExp.Location = new System.Drawing.Point(726, 113);
            this.btnLoadExp.Name = "btnLoadExp";
            this.btnLoadExp.Size = new System.Drawing.Size(145, 28);
            this.btnLoadExp.TabIndex = 10;
            this.btnLoadExp.Text = "load exp";
            this.btnLoadExp.UseVisualStyleBackColor = true;
            this.btnLoadExp.Click += new System.EventHandler(this.btnLoadExp_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // btnPlayer
            // 
            this.btnPlayer.Location = new System.Drawing.Point(825, 38);
            this.btnPlayer.Name = "btnPlayer";
            this.btnPlayer.Size = new System.Drawing.Size(42, 36);
            this.btnPlayer.TabIndex = 11;
            this.btnPlayer.Text = "P";
            this.btnPlayer.UseVisualStyleBackColor = true;
            this.btnPlayer.Click += new System.EventHandler(this.btnPlayer_Click);
            // 
            // btnRemoveBlack
            // 
            this.btnRemoveBlack.Location = new System.Drawing.Point(256, 563);
            this.btnRemoveBlack.Name = "btnRemoveBlack";
            this.btnRemoveBlack.Size = new System.Drawing.Size(312, 22);
            this.btnRemoveBlack.TabIndex = 12;
            this.btnRemoveBlack.Text = "Remove";
            this.btnRemoveBlack.UseVisualStyleBackColor = true;
            this.btnRemoveBlack.Click += new System.EventHandler(this.btnRemoveBlack_Click);
            // 
            // btnRemoveChar
            // 
            this.btnRemoveChar.Location = new System.Drawing.Point(12, 564);
            this.btnRemoveChar.Name = "btnRemoveChar";
            this.btnRemoveChar.Size = new System.Drawing.Size(229, 22);
            this.btnRemoveChar.TabIndex = 13;
            this.btnRemoveChar.Text = "Remove";
            this.btnRemoveChar.UseVisualStyleBackColor = true;
            this.btnRemoveChar.Click += new System.EventHandler(this.btnRemoveChar_Click);
            // 
            // btnPlayerAnalyze
            // 
            this.btnPlayerAnalyze.Location = new System.Drawing.Point(586, 563);
            this.btnPlayerAnalyze.Name = "btnPlayerAnalyze";
            this.btnPlayerAnalyze.Size = new System.Drawing.Size(213, 22);
            this.btnPlayerAnalyze.TabIndex = 14;
            this.btnPlayerAnalyze.Text = "Player analyze";
            this.btnPlayerAnalyze.UseVisualStyleBackColor = true;
            this.btnPlayerAnalyze.Click += new System.EventHandler(this.btnPlayerAnalyze_Click);
            // 
            // McDetector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 619);
            this.Controls.Add(this.btnPlayerAnalyze);
            this.Controls.Add(this.btnRemoveChar);
            this.Controls.Add(this.btnRemoveBlack);
            this.Controls.Add(this.btnPlayer);
            this.Controls.Add(this.btnLoadExp);
            this.Controls.Add(this.btnSaveExp);
            this.Controls.Add(this.btnExp);
            this.Controls.Add(this.tvExpChanged);
            this.Controls.Add(this.txtTimeout);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtBlackList);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.tvblackList);
            this.Controls.Add(this.treeView1);
            this.Name = "McDetector";
            this.Text = "MCDetector";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TreeView tvblackList;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtBlackList;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox txtTimeout;
        private System.Windows.Forms.TreeView tvExpChanged;
        private System.Windows.Forms.Button btnExp;
        private System.Windows.Forms.Button btnSaveExp;
        private System.Windows.Forms.Button btnLoadExp;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btnPlayer;
        private System.Windows.Forms.Button btnRemoveBlack;
        private System.Windows.Forms.Button btnRemoveChar;
        private System.Windows.Forms.Button btnPlayerAnalyze;
    }
}

