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
    class DiceHandler
    {
        private List<Dice> DiceList;
        protected Random rnd = new Random();
        public DiceHandler()
        {
            DiceList = new List<Dice>() { new Dice(rnd), new Dice(rnd), new Dice(rnd), new Dice(rnd), new Dice(rnd), new Dice(rnd) };
        }
        public void HoldDice(int index)
        {
            if (DiceList.Count < index || index < 0)
                throw new Exception("Dice index not in list - index less than zero or greater than 5");

            if (DiceList[index].Held)
                DiceList[index].Held = false;
            else
                DiceList[index].Held = true;
        }
        public List<Dice> RollDices()
        {
            foreach (Dice d in DiceList)
            {
                d.Roll();
            }
            return DiceList;
        }
    }
}