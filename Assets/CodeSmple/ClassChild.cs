using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// newClass でClassCjildの関数を実行する
public class ClassChild : MonoBehaviour
{
   
    public int hp = 100;
    public void Attack()
    {
        Debug.Log("child Attack");
    }

    // Update is called once per frame
    void Heal()
    {
        Debug.Log("child Heal");
    }
}
