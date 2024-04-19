using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyModel<T>
{
    public T enemyLvl;

    public EnemyModel(T level)
    {
        enemyLvl = level;
    }

    public void Defeated()
    {
        Debug.Log("Enemy defeated: " + enemyLvl);
    }
}
