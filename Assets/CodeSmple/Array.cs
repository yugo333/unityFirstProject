using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour
{
    //配列の宣言
    int[] a = { 10, 3, 5, -36, -33 };
    int[] b = new int[] { 10, 3, 5, -36, -33 };
    int[] c = new int[5] { 10, 3, 5, -36, -33 };

    // Start is called before the first frame update
    void Start()
    {
        // 配列取得
        int x = a[1];
        Debug.Log(x);

        a[1] = 7;
        Debug.Log(a[1]);

        //Debug.Log(a.Length);

        string[] names = { "take", "tom", "山" };
        for (int i = 0; i < names.Length; i++)
        {
            Debug.Log(names[i]);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

