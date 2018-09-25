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
            DH = new DiceHandler(this.Dice0, this.Dice1, this.Dice2, this.Dice3, this.Dice4);
        }
        void OnRoll(object sender, EventArgs e)
        {
            DH.RollDices();
        }
        void HoldDice(object sender, EventArgs e)
        {
            Button DiceBtn = (Button)sender;
            int index = DiceBtn.Id;
        }
    }
}
