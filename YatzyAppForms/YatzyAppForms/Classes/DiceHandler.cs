using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;


namespace YatzyAppForms.Classes
{
    class DiceHandler
    {
        public int Rolls;
        public List<Dice> DiceList;
        protected Random rnd;
        public DiceHandler()
        {
            rnd = new Random();
            DiceList = new List<Dice>() { new Dice(rnd), new Dice(rnd), new Dice(rnd), new Dice(rnd), new Dice(rnd) };
            Rolls = 0;
        }
        public void RollDices()
        {
            if (Rolls !=3)
            {
                foreach (Dice d in DiceList)
                {
                    if (!d.Held)
                    {
                        d.Roll();
                    }
                }
                Rolls++;
            }
            else
            {
                throw new Exception("Out of rolls");
            }
        }
    }
}
