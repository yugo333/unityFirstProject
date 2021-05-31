using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// キーボードを使ってコンソールにログを出す
// 方向キー
// ボタン入力
// 基本if文で囲んで使う
public class Keyboard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Horizontal///////////////////////////////////////////////////////
        // keyBoardの右、左、A,D　キーで横方向の入力をー1〜1の間で操作できる（値を返す）
        float x = Input.GetAxis("Horizontal");
        //  Debug.Log(x);
        // Vertical///////////////////////////////////////////////////////
        // Z軸の動きをkey操作できる上、下,W,S　キーで操作ー1〜1を返す
        float z = Input.GetAxis("Vertical");
        //  Debug.Log(z);

        // Raw系はー1か0か1の値しか取らない、一気に動く///////////////////////////
        float rawX = Input.GetAxisRaw("Horizontal");
        //Debug.Log(rawX);
        float rawZ = Input.GetAxisRaw("Vertical");
        // Debug.Log(rawZ);

        // Btn入力///////////////////////////////////////////////////////
        /* 基本的にはGetButtonの身は使わない、
         * なぜならキーを押したとき話した時など複数回種強くされるため
        if (Input.GetButton("Jump"))
        {
            Debug.Log("Jumpはspase");
        }
        */
        // これで１回ずつ発火される///////////////////////
        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("Jumpはspase");
        }
        
        //key入力///////////////////////////////////////////////////////
        if (Input.GetKeyDown(KeyCode.J))
        {
            Debug.Log("Jを押した");
        }
    }
}
