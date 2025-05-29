namespace Bingo
{
    partial class FrmSorteador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSorteador));
            this.lblNumber = new System.Windows.Forms.Label();
            this.btCancel = new System.Windows.Forms.Button();
            this.btNext = new System.Windows.Forms.Button();
            this.btHistoric = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(382, 206);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(13, 13);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "0";
            this.lblNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(441, 332);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 1;
            this.btCancel.Text = "Cancelar";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // btNext
            // 
            this.btNext.Location = new System.Drawing.Point(167, 332);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(107, 23);
            this.btNext.TabIndex = 2;
            this.btNext.Text = "Proximo Numero";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // btHistoric
            // 
            this.btHistoric.Location = new System.Drawing.Point(320, 332);
            this.btHistoric.Name = "btHistoric";
            this.btHistoric.Size = new System.Drawing.Size(75, 23);
            this.btHistoric.TabIndex = 3;
            this.btHistoric.Text = "Histórico";
            this.btHistoric.UseVisualStyleBackColor = true;
            // 
            // FrmSorteador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btHistoric);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.lblNumber);
            this.Name = "FrmSorteador";
            this.Text = "Bingo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Button btHistoric;
    }
}