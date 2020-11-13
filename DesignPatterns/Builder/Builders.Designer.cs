namespace DesignPatterns.Builder
{
    partial class Builders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Builders));
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.ckbA = new System.Windows.Forms.CheckBox();
            this.ckbB = new System.Windows.Forms.CheckBox();
            this.ckbC = new System.Windows.Forms.CheckBox();
            this.btnMontar = new System.Windows.Forms.Button();
            this.picCarro = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCarro)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-7, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "_________________________________________________________________________";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "A.png");
            this.imageList1.Images.SetKeyName(1, "B.png");
            this.imageList1.Images.SetKeyName(2, "C.png");
            this.imageList1.Images.SetKeyName(3, "AB.png");
            this.imageList1.Images.SetKeyName(4, "AC.png");
            this.imageList1.Images.SetKeyName(5, "BC.png");
            this.imageList1.Images.SetKeyName(6, "ABC.png");
            this.imageList1.Images.SetKeyName(7, "null.png");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(121, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Monta Carros";
            // 
            // ckbA
            // 
            this.ckbA.AutoSize = true;
            this.ckbA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ckbA.Location = new System.Drawing.Point(92, 70);
            this.ckbA.Name = "ckbA";
            this.ckbA.Size = new System.Drawing.Size(49, 17);
            this.ckbA.TabIndex = 2;
            this.ckbA.Text = "Veloz";
            this.ckbA.UseVisualStyleBackColor = true;
            // 
            // ckbB
            // 
            this.ckbB.AutoSize = true;
            this.ckbB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ckbB.Location = new System.Drawing.Point(190, 70);
            this.ckbB.Name = "ckbB";
            this.ckbB.Size = new System.Drawing.Size(53, 17);
            this.ckbB.TabIndex = 3;
            this.ckbB.Text = "Bonito";
            this.ckbB.UseVisualStyleBackColor = true;
            // 
            // ckbC
            // 
            this.ckbC.AutoSize = true;
            this.ckbC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ckbC.Location = new System.Drawing.Point(287, 70);
            this.ckbC.Name = "ckbC";
            this.ckbC.Size = new System.Drawing.Size(53, 17);
            this.ckbC.TabIndex = 4;
            this.ckbC.Text = "Antigo";
            this.ckbC.UseVisualStyleBackColor = true;
            // 
            // btnMontar
            // 
            this.btnMontar.Location = new System.Drawing.Point(179, 106);
            this.btnMontar.Name = "btnMontar";
            this.btnMontar.Size = new System.Drawing.Size(75, 23);
            this.btnMontar.TabIndex = 5;
            this.btnMontar.Text = "Montar";
            this.btnMontar.UseVisualStyleBackColor = true;
            this.btnMontar.Click += new System.EventHandler(this.btnMontar_Click);
            // 
            // picCarro
            // 
            this.picCarro.Location = new System.Drawing.Point(92, 143);
            this.picCarro.Name = "picCarro";
            this.picCarro.Size = new System.Drawing.Size(256, 256);
            this.picCarro.TabIndex = 6;
            this.picCarro.TabStop = false;
            // 
            // Builders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 136);
            this.Controls.Add(this.picCarro);
            this.Controls.Add(this.btnMontar);
            this.Controls.Add(this.ckbC);
            this.Controls.Add(this.ckbB);
            this.Controls.Add(this.ckbA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Builders";
            this.Text = "Builder";
            ((System.ComponentModel.ISupportInitialize)(this.picCarro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ckbA;
        private System.Windows.Forms.CheckBox ckbB;
        private System.Windows.Forms.CheckBox ckbC;
        private System.Windows.Forms.Button btnMontar;
        private System.Windows.Forms.PictureBox picCarro;

    }
}