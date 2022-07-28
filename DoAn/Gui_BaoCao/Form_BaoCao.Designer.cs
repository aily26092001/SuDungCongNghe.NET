namespace DoAn.Gui_BaoCao
{
    partial class Form_BaoCao
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
            this.FromBaoCao = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // FromBaoCao
            // 
            this.FromBaoCao.ActiveViewIndex = -1;
            this.FromBaoCao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FromBaoCao.Cursor = System.Windows.Forms.Cursors.Default;
            this.FromBaoCao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FromBaoCao.Location = new System.Drawing.Point(0, 0);
            this.FromBaoCao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FromBaoCao.Name = "FromBaoCao";
            this.FromBaoCao.Size = new System.Drawing.Size(544, 414);
            this.FromBaoCao.TabIndex = 0;
            this.FromBaoCao.ToolPanelWidth = 150;
            // 
            // Form_BaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 414);
            this.Controls.Add(this.FromBaoCao);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form_BaoCao";
            this.Text = "Form_BaoCao";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer FromBaoCao;
    }
}