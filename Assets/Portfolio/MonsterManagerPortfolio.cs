using UnityEngine;
using System.Collections.Generic;
using Unity.Collections;

namespace Portfolio
{
    public class MonsterManagerPortfolio : MonoBehaviour
    {
        List<MonsterPortfolio> monsters = new List<MonsterPortfolio>();
        void Start()
        {
            int killCount = 0;
            monsters.Add(new MonsterPortfolio("슬라임", 10, 2));
            monsters.Add(new MonsterPortfolio("고블린", 30, 5));
            monsters.Add(new MonsterPortfolio("코발트", 20, 8));

            foreach (MonsterPortfolio monster in monsters)
            {
                print($"{monster.monsterName} 체력 : {monster.monsterHp} 공격력 : {monster.monsterPower}");
            }
            for (int i = monsters.Count - 1; i >= 0; i--)
            {
                if (monsters[i].monsterHp > 0)
                {
                    monsters[i].monsterHp -= 10;
                    Debug.Log($"{monsters[i].monsterName}의 남은 체력 : {monsters[i].monsterHp}");
                }
                if(monsters[i].monsterHp <= 0)
                {
                    Debug.Log($"{monsters[i].monsterName}이(가) 처치되었습니다.");
                    monsters.RemoveAt(i);
                    killCount++;
                }
            }
            Debug.Log($"처치 몬스터 : {killCount}");
        }
    }
}