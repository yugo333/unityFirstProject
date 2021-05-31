using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListArray : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        List<int> numberList = new List<int>(); //宣言のみ
        List<int> nList = new List<int>() { 10, 2, 3, 4, 5, 59 }; //初期化
        List<string> nameList = new List<string>() { "yugo", "tanaka"};
        //

        //取得
        Debug.Log(nList[1]);
        //代入
        nList[1] = -100;
        Debug.Log(nList[1]);
        //レングスはカウント
        Debug.Log(numberList.Count);
        Debug.Log(nList.Count);
        Debug.Log(nameList.Count);
        //for分
        for(int i=0;i< nameList.Count; i++)
        {
            Debug.Log("追加前_"+nameList[i]);
        }
        //追加
        nameList.Add("ジーザス");
        for(int i=0;i< nameList.Count; i++)
        {
            Debug.Log("追加後_"+ nameList[i]);
        }
        //削除　Remove 直接指定
        nameList.Remove(nameList[0]);
        for (int i = 0; i < nameList.Count; i++)
        {
            Debug.Log("削除後_" + nameList[i]);
        }
        //削除　RemoveAt　何番目を削除するのか
        nameList.RemoveAt(0);
        for (int i = 0; i < nameList.Count; i++)
        {
            Debug.Log("削除後2_" + nameList[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
