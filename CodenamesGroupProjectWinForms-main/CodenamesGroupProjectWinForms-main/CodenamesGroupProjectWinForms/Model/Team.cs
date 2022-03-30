using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodenamesGroupProjectWinForms.Model
{
    public class Team
    {
        private int points;

        public Team()
        {
            points = 0;
        }

        public int Points
        {
            get { return points; }
            set { points = value; }
        }

        public void addPoint()
        {
            Points++;
        }
    }
}
