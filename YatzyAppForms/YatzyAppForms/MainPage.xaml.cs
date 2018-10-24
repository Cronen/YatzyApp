using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using YatzyAppForms.Classes;

namespace YatzyAppForms
{
    public partial class MainPage : ContentPage
    {
        DiceHandler DH;
        public MainPage()
        {
            InitializeComponent();
            DH = new DiceHandler();
            UpdateListview();
        }
        void OnRoll(object sender, EventArgs e)
        {
            DH.RollDices();
            UpdateListview();
        }
        private void diceView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Dice d = (Dice)e.Item;
            d.Hold();
            d.CurrentValue = 9;
            Button btn = (Button)sender;
            btn.BackgroundColor = Color.Red;
            UpdateListview();
        }
        private void UpdateListview()
        {
            diceView.ItemsSource = null;
            diceView.ItemsSource = DH.DiceList;
        }
    }
}
