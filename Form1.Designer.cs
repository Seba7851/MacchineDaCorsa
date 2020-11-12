namespace MacchineDaCorsa
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.BlackCarBGW = new System.ComponentModel.BackgroundWorker();
            this.RedCarBGW = new System.ComponentModel.BackgroundWorker();
            this.FinishLinePbx = new System.Windows.Forms.PictureBox();
            this.RedCarPbx = new System.Windows.Forms.PictureBox();
            this.BlackCarPbx = new System.Windows.Forms.PictureBox();
            this.RoadPbx = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FinishLinePbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedCarPbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlackCarPbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoadPbx)).BeginInit();
            this.SuspendLayout();
            // 
            // BlackCarBGW
            // 
            this.BlackCarBGW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BlackCarBGW_DoWork);
            // 
            // RedCarBGW
            // 
            this.RedCarBGW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.RedCarBGW_DoWork);
            // 
            // FinishLinePbx
            // 
            this.FinishLinePbx.Image = global::MacchineDaCorsa.Properties.Resources.Finishline;
            this.FinishLinePbx.Location = new System.Drawing.Point(377, 12);
            this.FinishLinePbx.Name = "FinishLinePbx";
            this.FinishLinePbx.Size = new System.Drawing.Size(25, 173);
            this.FinishLinePbx.TabIndex = 3;
            this.FinishLinePbx.TabStop = false;
            // 
            // RedCarPbx
            // 
            this.RedCarPbx.Image = global::MacchineDaCorsa.Properties.Resources.RedCar;
            this.RedCarPbx.Location = new System.Drawing.Point(32, 113);
            this.RedCarPbx.Name = "RedCarPbx";
            this.RedCarPbx.Size = new System.Drawing.Size(100, 50);
            this.RedCarPbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RedCarPbx.TabIndex = 2;
            this.RedCarPbx.TabStop = false;
            // 
            // BlackCarPbx
            // 
            this.BlackCarPbx.Image = global::MacchineDaCorsa.Properties.Resources.BlackCar;
            this.BlackCarPbx.Location = new System.Drawing.Point(32, 33);
            this.BlackCarPbx.Name = "BlackCarPbx";
            this.BlackCarPbx.Size = new System.Drawing.Size(100, 50);
            this.BlackCarPbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BlackCarPbx.TabIndex = 1;
            this.BlackCarPbx.TabStop = false;
            // 
            // RoadPbx
            // 
            this.RoadPbx.Image = global::MacchineDaCorsa.Properties.Resources.Road;
            this.RoadPbx.Location = new System.Drawing.Point(12, 12);
            this.RoadPbx.Name = "RoadPbx";
            this.RoadPbx.Size = new System.Drawing.Size(485, 173);
            this.RoadPbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RoadPbx.TabIndex = 0;
            this.RoadPbx.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(13, 192);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(481, 52);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 256);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.FinishLinePbx);
            this.Controls.Add(this.RedCarPbx);
            this.Controls.Add(this.BlackCarPbx);
            this.Controls.Add(this.RoadPbx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FinishLinePbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedCarPbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlackCarPbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoadPbx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox RoadPbx;
        private System.Windows.Forms.PictureBox BlackCarPbx;
        private System.Windows.Forms.PictureBox RedCarPbx;
        private System.ComponentModel.BackgroundWorker BlackCarBGW;
        private System.ComponentModel.BackgroundWorker RedCarBGW;
        private System.Windows.Forms.PictureBox FinishLinePbx;
        private System.Windows.Forms.Button btnStart;
    }
}

