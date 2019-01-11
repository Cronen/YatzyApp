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
            GenerateDices();
            GenerateScoreBoard();
        }
        private void GenerateDices()
        {
            int counter = 0;
            foreach (Dice d in DH.DiceList)
            {
                gr_dice.Children.Add(GenerateDiceBtn(d), counter, 0);
                counter++;
            }
        }
        private void OnRoll(object sender, EventArgs e)
        {
            try
            {
                DH.RollDices();
                gr_dice.Children.Clear();
                GenerateDices();
                lb_Rolls.Text = string.Format("Rolls {0}/3", DH.Rolls);
            }
            catch (Exception ex)
            {
                DisplayAlert("Alert", ex.Message, "OK");
            }
        
        }
        private Button GenerateDiceBtn(Dice d)
        {
            var btn = new Button();
            btn.Style = (Style)Application.Current.Resources["Dice"];
            btn.Text = d.CurrentValue.ToString();
            btn.BackgroundColor = d.GetBgColor();
            btn.Clicked += (sender, args) => HoldDice(d, btn);
            return btn;
        }

        private void HoldDice(Dice d, Button btn)
        {
            d.Hold();
            btn.BackgroundColor = d.GetBgColor();
        }

        private void GenerateScoreBoard()
        {
            for (int i = 0; i < 10; i++)
            {
                var lb = new Label();
                lb.Text = i + " Pair";
                lb.Style = (Style)Application.Current.Resources["TextNorm"];
                lb.HorizontalTextAlignment = TextAlignment.Center;
                var btn = new Button();
                btn.Text = i.ToString();
                btn.HorizontalOptions = LayoutOptions.Center;
                gr_ScoreBoard.Children.Add(lb, 0, i);
                gr_ScoreBoard.Children.Add(btn, 1, i);
            }
        }
    }
}
