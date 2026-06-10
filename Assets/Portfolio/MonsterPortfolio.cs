using UnityEngine;

namespace Portfolio
{
    public enum MonsterState
    {
        Idle,
        Chase,
        Attack
    }
    public class MonsterPortfolio
    {
        public string monsterName;
        public int monsterHp;
        public int monsterPower;

        public MonsterPortfolio(string newName, int newHp, int newPower)
        {
            monsterName = newName;
            monsterHp = newHp;
            monsterPower = newPower;
        }
    }
}