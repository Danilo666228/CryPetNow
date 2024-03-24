using CryPet.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryPet.Windows.Main
{
    public partial class CoinPanel : UserControl
    {

        public CoinPanel()
        {
            InitializeComponent();
        }
        public Image IconCoin
        {
            get { return pcbIcon.Image; }
            set { pcbIcon.Image = value; }

        }
        public string ShortName
        {
            get { return lblName.Text; }
            set { lblName.Text = value; }
        }
        public string FullName
        {
            get { return lblFullName.Text; }
            set { lblFullName.Text = value; }
        }
        public Color FillColor1
        {
            get { return GradientPanel.FillColor; }
            set { GradientPanel.FillColor = value; }
        }
        public Color FillColor2
        {
            get { return GradientPanel.FillColor2; }
            set { GradientPanel.FillColor2 = value; }
        }
        public Color FillColor3
        {
            get { return GradientPanel.FillColor3; }
            set { GradientPanel.FillColor3 = value; }
        }
        public Color FillColor4
        {
            get { return GradientPanel.FillColor4; }
            set { GradientPanel.FillColor4 = value; }
        }
        public void FillCoinPanel()
        {
            Coin coin = new Coin();
            lblPrice.Text = coin.GetPriceCoin(lblName.Text).ToString() + " $";
        }

    }
}
