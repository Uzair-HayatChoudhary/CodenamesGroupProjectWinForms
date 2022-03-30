using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodenamesGroupProjectWinForms.Model
{
    public enum Role
    {
        spymaster,
        fieldAgent
    }

    public class Player
    {
        private Role role;

        public Player()
        {
            role = Role.spymaster;
        }

        public Role Role
        {
            get { return role; }
            set { role = value; }
        }

        public static void changeRole(Player currentPlayer)
        {
          

            if (currentPlayer.Role == 0)
            {
                currentPlayer.Role = (Role)1;
            }
            else
            {
                currentPlayer.Role = (Role)0;
            }
        }
    }
}
