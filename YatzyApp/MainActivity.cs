using Android.App;
using Android.Widget;
using Android.OS;
using YatzyApp.Classes;

namespace YatzyApp
{
    [Activity(Label = "YatzyApp", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        DiceHandler diceH = new DiceHandler();
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            Button button = FindViewById<Button>(Resource.Id.MyButton);
            var label = FindViewById<TextView>(Resource.Id.Result);

            button.Click += delegate
            {
                label.Text = "You rolled";
                foreach (Dice d in diceH.RollDices())
                {
                    label.Text = label.Text + " - " + d.CurrentValue;
                }
                //button.Text = string.Format("{0} Clicks!", count++);
                //label.Text = string.Format("{0} Clicks!", count++);
            };
        }
    }
}

