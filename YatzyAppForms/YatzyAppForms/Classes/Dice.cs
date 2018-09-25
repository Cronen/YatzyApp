using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;


namespace YatzyAppForms.Classes
{
    class Dice
    {
        Button dice;
        private int MinValue = 1;
        private int MaxValue = 6;
        private Random rnd;
        public bool Held { get; set; }
        public int CurrentValue { get; set; }

        public Dice(Random RND, Button d)
        {
            dice = d;
            rnd = RND;
            Held = false;
            CurrentValue = 0;
        }

        public void Roll()
        {
            //Random.next includes min value, but not max value. Therefore +1 on the max value. 
            CurrentValue = rnd.Next(MinValue, MaxValue + 1);
            dice.Text =  CurrentValue.ToString();
        }
    }
}
