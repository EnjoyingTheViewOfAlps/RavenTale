using Rrewusz.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Rrewusz
{
    class Player
    {
        Random rnd = new Random();
        private int _hp;
        private int _mana;
        public Player(int HP, int Mana) 
        {
            _hp= HP;
            _mana= Mana;
        }
        private int GetMana() { return _mana; }
        private void SetMana(int ManaCost) { _mana -= ManaCost; }
        private void AddMana() { _mana++; }
        public int GetHP() { return _hp; }
        public void SetHP(int newHP)
        {
            _hp = newHP;
        }
        public void Attack(Enemy enemy)
        {
            if(_mana >= 2)
            {
                int Attack = rnd.Next(1, 2);
                int EnemyHP = enemy.GetHP();
                EnemyHP -= Attack;
                enemy.SetHP(EnemyHP);
                SetMana(2);
                AddMana();
            }
            else
            {

            }
        }
        public void Block()
        {
            int BeforeHP = _hp;
            _hp= BeforeHP;
        }
        public void Heal()
        {
            _hp = _hp + 3;
        }
    }
}
