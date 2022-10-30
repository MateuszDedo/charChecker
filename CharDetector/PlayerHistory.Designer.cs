
namespace CharDetector
{
    partial class PlayerHistory
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
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.lsExp = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.lsSuspect = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Location = new System.Drawing.Point(12, 45);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(1368, 348);
            this.cartesianChart1.TabIndex = 0;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // lsExp
            // 
            this.lsExp.GridLines = true;
            this.lsExp.HideSelection = false;
            this.lsExp.Location = new System.Drawing.Point(12, 401);
            this.lsExp.Name = "lsExp";
            this.lsExp.Size = new System.Drawing.Size(1364, 239);
            this.lsExp.TabIndex = 1;
            this.lsExp.UseCompatibleStateImageBehavior = false;
            this.lsExp.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1364, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // lsSuspect
            // 
            this.lsSuspect.GridLines = true;
            this.lsSuspect.HideSelection = false;
            this.lsSuspect.Location = new System.Drawing.Point(12, 646);
            this.lsSuspect.Name = "lsSuspect";
            this.lsSuspect.Size = new System.Drawing.Size(302, 165);
            this.lsSuspect.TabIndex = 3;
            this.lsSuspect.UseCompatibleStateImageBehavior = false;
            this.lsSuspect.View = System.Windows.Forms.View.Details;
            // 
            // PlayerHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 823);
            this.Controls.Add(this.lsSuspect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lsExp);
            this.Controls.Add(this.cartesianChart1);
            this.Name = "PlayerHistory";
            this.Text = "PlayerHistory";
            this.Load += new System.EventHandler(this.PlayerHistory_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.ListView lsExp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lsSuspect;
    }
}