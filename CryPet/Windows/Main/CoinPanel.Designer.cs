namespace CryPet.Windows.Main
{
    partial class CoinPanel
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.pcbIcon = new Guna.UI2.WinForms.Guna2PictureBox();
            this.GradientPanel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.lblFullName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcon)).BeginInit();
            this.GradientPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.Location = new System.Drawing.Point(24, 99);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(40, 21);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Имя";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPrice.Location = new System.Drawing.Point(213, 62);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(50, 21);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.Text = "Цена";
            // 
            // pcbIcon
            // 
            this.pcbIcon.BackColor = System.Drawing.Color.Transparent;
            this.pcbIcon.FillColor = System.Drawing.Color.Silver;
            this.pcbIcon.ImageRotate = 0F;
            this.pcbIcon.Location = new System.Drawing.Point(22, 18);
            this.pcbIcon.Name = "pcbIcon";
            this.pcbIcon.Size = new System.Drawing.Size(42, 38);
            this.pcbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbIcon.TabIndex = 1;
            this.pcbIcon.TabStop = false;
            this.pcbIcon.UseTransparentBackground = true;
            // 
            // GradientPanel
            // 
            this.GradientPanel.Controls.Add(this.lblPrice);
            this.GradientPanel.Controls.Add(this.pcbIcon);
            this.GradientPanel.Controls.Add(this.lblFullName);
            this.GradientPanel.Controls.Add(this.lblName);
            this.GradientPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GradientPanel.Location = new System.Drawing.Point(0, 0);
            this.GradientPanel.Name = "GradientPanel";
            this.GradientPanel.Size = new System.Drawing.Size(343, 145);
            this.GradientPanel.TabIndex = 2;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.BackColor = System.Drawing.Color.Transparent;
            this.lblFullName.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFullName.Location = new System.Drawing.Point(82, 26);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(40, 21);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = "Имя";
            // 
            // CoinPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GradientPanel);
            this.Name = "CoinPanel";
            this.Size = new System.Drawing.Size(343, 145);
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcon)).EndInit();
            this.GradientPanel.ResumeLayout(false);
            this.GradientPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblName;
        private Guna.UI2.WinForms.Guna2PictureBox pcbIcon;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel GradientPanel;
        private System.Windows.Forms.Label lblFullName;
    }
}
