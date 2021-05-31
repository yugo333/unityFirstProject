using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewClass : MonoBehaviour
{
    public ClassChild enemy;
    void Start()
    {
        enemy.Attack();
        Debug.Log(enemy.hp);
    }

}