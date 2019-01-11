using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;


namespace YatzyAppForms.Classes
{
    public class Dice
    {
        private readonly int MinValue = 1;
        private readonly int MaxValue = 6;
        private Random rnd;
        public bool Held { get; set; }
        public int CurrentValue { get; set; }
        public Dice(Random RND)
        {
            rnd = RND;
            Held = false;
            CurrentValue = 0;
        }
        public void Roll()
        {
            //Random.next includes min value, but not max value. Therefore +1 on the max value. 
            CurrentValue = rnd.Next(MinValue, MaxValue + 1);
        }
        public void Hold()
        {
            if (Held)
            {
                Held = false;
            }
            else
            {
                Held = true;
            }
        }
        public Color bgColor { get => GetBgColor(); set { } }
        public Color GetBgColor()
        {
            var reColor = Color.Red;
            if (Held)
                reColor = Color.DarkGreen;
            else
                reColor = Color.White;
            return reColor;
        }
    }
}
