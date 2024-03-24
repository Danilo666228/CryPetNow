namespace CryPet.Windows.Main
{
    partial class MainControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainControl));
            this.label1 = new System.Windows.Forms.Label();
            this.UpdatePriceCoin = new System.Windows.Forms.Timer(this.components);
            this.CoinPanelBTC = new CryPet.Windows.Main.CoinPanel();
            this.CoinPanelETH = new CryPet.Windows.Main.CoinPanel();
            this.CoinPanelBNB = new CryPet.Windows.Main.CoinPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("JetBrains Mono", 47.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 84);
            this.label1.TabIndex = 0;
            this.label1.Text = "Главная";
            // 
            // UpdatePriceCoin
            // 
            this.UpdatePriceCoin.Tick += new System.EventHandler(this.UpdatePriceCoin_Tick);
            // 
            // CoinPanelBTC
            // 
            this.CoinPanelBTC.FillColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CoinPanelBTC.FillColor2 = System.Drawing.Color.White;
            this.CoinPanelBTC.FillColor3 = System.Drawing.Color.Yellow;
            this.CoinPanelBTC.FillColor4 = System.Drawing.Color.White;
            this.CoinPanelBTC.FullName = "Bitcoin";
            this.CoinPanelBTC.IconCoin = ((System.Drawing.Image)(resources.GetObject("CoinPanelBTC.IconCoin")));
            this.CoinPanelBTC.Location = new System.Drawing.Point(46, 159);
            this.CoinPanelBTC.Name = "CoinPanelBTC";
            this.CoinPanelBTC.ShortName = "BTC";
            this.CoinPanelBTC.Size = new System.Drawing.Size(343, 145);
            this.CoinPanelBTC.TabIndex = 1;
            // 
            // CoinPanelETH
            // 
            this.CoinPanelETH.FillColor1 = System.Drawing.Color.White;
            this.CoinPanelETH.FillColor2 = System.Drawing.Color.White;
            this.CoinPanelETH.FillColor3 = System.Drawing.Color.White;
            this.CoinPanelETH.FillColor4 = System.Drawing.Color.White;
            this.CoinPanelETH.FullName = "Etherium";
            this.CoinPanelETH.IconCoin = null;
            this.CoinPanelETH.Location = new System.Drawing.Point(480, 159);
            this.CoinPanelETH.Name = "CoinPanelETH";
            this.CoinPanelETH.ShortName = "ETH";
            this.CoinPanelETH.Size = new System.Drawing.Size(343, 145);
            this.CoinPanelETH.TabIndex = 2;
            // 
            // CoinPanelBNB
            // 
            this.CoinPanelBNB.FillColor1 = System.Drawing.Color.White;
            this.CoinPanelBNB.FillColor2 = System.Drawing.Color.White;
            this.CoinPanelBNB.FillColor3 = System.Drawing.Color.White;
            this.CoinPanelBNB.FillColor4 = System.Drawing.Color.White;
            this.CoinPanelBNB.FullName = "BNB";
            this.CoinPanelBNB.IconCoin = null;
            this.CoinPanelBNB.Location = new System.Drawing.Point(930, 159);
            this.CoinPanelBNB.Name = "CoinPanelBNB";
            this.CoinPanelBNB.ShortName = "BNB";
            this.CoinPanelBNB.Size = new System.Drawing.Size(343, 145);
            this.CoinPanelBNB.TabIndex = 3;
            // 
            // MainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.CoinPanelBNB);
            this.Controls.Add(this.CoinPanelETH);
            this.Controls.Add(this.CoinPanelBTC);
            this.Controls.Add(this.label1);
            this.Name = "MainControl";
            this.Size = new System.Drawing.Size(1324, 756);
            this.Load += new System.EventHandler(this.MainControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private CoinPanel CoinPanelBTC;
        private System.Windows.Forms.Timer UpdatePriceCoin;
        private CoinPanel CoinPanelETH;
        private CoinPanel CoinPanelBNB;
    }
}
