namespace Bingo
{
    partial class frmHistorico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHistorico));
            this.lbxHistoric = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbxHistoric
            // 
            this.lbxHistoric.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxHistoric.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lbxHistoric.FormattingEnabled = true;
            this.lbxHistoric.Location = new System.Drawing.Point(76, 62);
            this.lbxHistoric.Name = "lbxHistoric";
            this.lbxHistoric.Size = new System.Drawing.Size(167, 277);
            this.lbxHistoric.TabIndex = 0;
            this.lbxHistoric.SelectedIndexChanged += new System.EventHandler(this.lbxHistoric_SelectedIndexChanged);
            // 
            // frmHistorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbxHistoric);
            this.Name = "frmHistorico";
            this.Text = "frmHistorico";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxHistoric;
    }
}