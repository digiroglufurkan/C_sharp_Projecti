namespace Pakkolinen_Ryhmä_Projecti
{
    partial class KirjautunutMuokkaaProfiilia
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
            this.ksEtusivuOtsikkoLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ksEtusivuOtsikkoLB
            // 
            this.ksEtusivuOtsikkoLB.AutoSize = true;
            this.ksEtusivuOtsikkoLB.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ksEtusivuOtsikkoLB.Location = new System.Drawing.Point(320, 9);
            this.ksEtusivuOtsikkoLB.Name = "ksEtusivuOtsikkoLB";
            this.ksEtusivuOtsikkoLB.Size = new System.Drawing.Size(149, 51);
            this.ksEtusivuOtsikkoLB.TabIndex = 3;
            this.ksEtusivuOtsikkoLB.Text = "Otsikko";
            // 
            // KirjautunutMuokkaaProfiilia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ksEtusivuOtsikkoLB);
            this.Name = "KirjautunutMuokkaaProfiilia";
            this.Text = "KirjautunutMuokkaaProfiilia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label ksEtusivuOtsikkoLB;
    }
}