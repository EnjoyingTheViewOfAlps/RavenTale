using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Rrewusz.Objects
{   
    class Enemy
    {
        Random rnd = new Random();
        private int _hp;
        public Enemy(int HP)
        {
            _hp= HP;
        }
        public int GetHP()
        {
            return _hp;
        }
        public void SetHP(int newHP)
        {
            _hp = newHP;
        }
        public void PlayTurn(Player player)
        {
            int Move = rnd.Next(1,4);
            switch (Move)
            {
                case 1:
                    int Attack = rnd.Next(1,2);
                    int PlayerHP = player.GetHP();
                    PlayerHP -= Attack;
                    player.SetHP(PlayerHP);
                    break;
                case 2:
                    break;
                case 3:
                    _hp = _hp + 3;
                    break;
                case 4: 
                    break;  
            }
        }
    }
}
