using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;


namespace YatzyAppForms.Classes
{
    class DiceHandler
    {
        public List<Dice> DiceList;
        protected Random rnd;
        public DiceHandler(Button d0, Button d1, Button d2, Button d3, Button d4)
        {
            rnd = new Random();
            DiceList = new List<Dice>() { new Dice(rnd, d0), new Dice(rnd, d1), new Dice(rnd, d2), new Dice(rnd, d3), new Dice(rnd, d4) };
        }
        public DiceHandler()
        {
            rnd = new Random();
            DiceList = new List<Dice>() { new Dice(rnd), new Dice(rnd), new Dice(rnd), new Dice(rnd), new Dice(rnd) };
        }
        public void HoldDice(int index)
        {
            //May need replacement depending on how dice object is bound
            if (DiceList.Count < index || index < 0)
                throw new Exception("Dice index not in list - index less than zero or greater than 5");

            if (DiceList[index].Held)
                DiceList[index].Held = false;
            else
                DiceList[index].Held = true;
        }
        public void RollDices()
        {
            foreach (Dice d in DiceList)
            {
                d.Roll();
            }
        }
    }
}
