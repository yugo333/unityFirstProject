using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transforme : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //これでもトランスフォーム取得できる
        //Transforme tf = GetComponent<Transforme>();
    }

    // 0.02秒でアップデート
    void Update()
    {
        //何も指定しなくてもtransformeが使える、updateに指定することでアニメーションする
        //transform.position += new Vector3(0, 0.05f, 0);
        //上とほぼ一緒だが、現在の位置から移動しなさいって感じの意味になる
        transform.Translate(new Vector3(0, 0.05f, 0));
        transform.Rotate(new Vector3(0, 5f, 0));

    }
}


/*　Transforme
 * 基本的にGUI側で操作しmeshの子要素も設定できその子要素は親に依存んする
 * ヒエラルキーのmeshを右クリックしmesh追加することで子要素追加できる
 * 
 */