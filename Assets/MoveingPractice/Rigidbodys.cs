using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rigidbodys : MonoBehaviour
{
    Rigidbody rb;
    
    void Start()
    {
        //これでインスペクターでaddしたRigidを取得し操作できる
        rb = GetComponent<Rigidbody>();
        //速度設定
        //rb.velocity = new Vector3(0.5f, 0, 0);
    }


    void Update()
    {
        //x方向に力を加える。updateないでやることでvelocity同じ動きになる
        rb.AddForce(new Vector3(0.5f, 0, 0));
    }
}

/*Rigidbody　物理演算
 インスペクターから　add componentでRigidbodyを選択
*Mass 重さ　重量感
*Drag　粘り気　液体系
*Angular Drag　回転摩擦　空気抵抗
*Use Gravity　重力
*Is Kinematic　物理演算使わなくさせる
*Insterpolate //
*Collision Detection UseGravityなどを使用する際にチェックボックスにチェックを入れると
*チェックをいれた方向にはUseGravityが適応されなくなるため指定方向には動かなくなる。
*Cnstraints //
 */

