using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBox : MonoBehaviour
{
    //ぶつかった時に実行される物（条件：Collider ,Rigidbodyの定義）
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("ぶつかったよ");
    }

    //ぶつかった際のトリガーで発火する関数
    //(今回はHitCylinderのCollidercのis Triggerチェックボックスtrueで
    //こいつと接触した際に発火する用になる
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("トリガーエンター");
    }
    //ぶつかってから離れた時に発火する
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("離れたよ");
    }

    //OnTriggerStayはぶつかってる間ずっと呼び出される

}

/*当たり判定　Collider ,Rigidbody
 * collider 形を持った物や硬さなどの役割
 * HItBoxにRigidbodyを定義（Colliderは自動でなってると思う）
 * 再生ボタンを押した状態で無理やりぶつけると確認できる
 * IsTrigger 衝突される側につける（GUI側のColliderのなかにある）
 * IsTriggerをつけると物理的にはすり抜ける
*/