using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace YatzyApp.Classes
{
    class Dice
    {
        private int MinValue = 1;
        private int MaxValue = 6;
        private Random rnd;
        public bool Held { get; set; }
        public int CurrentValue{ get; set; }

        public Dice(Random RND)
        {
            rnd = RND;
            Held = false;
            CurrentValue = 0; 
        }

        public int Roll()
        {
            //Random.next includes min value, but not max value. Therefore +1 on the max value. 
            CurrentValue = rnd.Next(MinValue, MaxValue+1);
            return CurrentValue;
        }
    }
}