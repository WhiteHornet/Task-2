using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;


namespace GameDevPOE2ndAttempt
{
    class RangesUnit : Unit
    {


        public int Xpos
        {
            get { return xpos; }
            set { xpos = value; }
        }



        public int Ypos
        {
            get { return ypos; }
            set { ypos = value; }
        }



        public int Health
        {
            get { return health; }
            set { health = value; }
        }



        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }



        public int Attack
        {
            get { return attack; }
            set { attack = value; }
        }



        public int Attackrange
        {
            get { return attackrange; }
            set { attackrange = value; }
        }



        public string Faction
        {
            get { return faction; }
            set { faction = value; }
        }



        public int symbol
        {
            get { return symbol; }
            set { symbol = value; }
        }

        public override int combat()
        {
            return combat();
        }

        public override int Death()
        {
            return Death();
        }

        public override int CalcRange()
        {
            return CalcRange();
        }

        public override int RestartPos()
        {
            return RestartPos();
        }
        public override int newPosition()
        {
            return newPosition();
        }
        public override int toString()
        {
            return toString();
        }
        public override int getHashCode()
        {
            return getHashCode();
        }
    }
}
