using Android.App;
using Android.Widget;
using Android.OS;
using Android.Views;
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
            var video = FindViewById<VideoView>(Resource.Id.gachiVid);
            string vidpath = string.Format("android.resource://{0}/{1}", Application.PackageName, Resource.Raw.gachibass);
            video.SetOnPreparedListener(new VideoLooper());
            video.Visibility = ViewStates.Gone;
            button.Click += delegate
            {
                video.SetVideoPath(vidpath);
                video.Start();
                FindViewById<ImageView>(Resource.Id.image).Visibility = ViewStates.Gone;
                video.Visibility = ViewStates.Visible;

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

