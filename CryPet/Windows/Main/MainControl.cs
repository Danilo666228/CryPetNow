using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryPet.Windows.Main
{
    public partial class MainControl : UserControl
    {
        public MainControl()
        {
            InitializeComponent();
        }
        public void FillCoinPanel()
        {
            CoinPanelBTC.FillCoinPanel();
            CoinPanelETH.FillCoinPanel();
            CoinPanelBNB.FillCoinPanel();
        }

        private void MainControl_Load(object sender, EventArgs e)
        {
            UpdatePriceCoin.Start();
        }

        private void UpdatePriceCoin_Tick(object sender, EventArgs e)
        {
            FillCoinPanel();
        }
    }
}
