using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //普通の
        string userName = "まんま";
        NewFunc(userName);
        //返り値
        int fuckinNumber=ReturenNumberFunc(2);
        Debug.Log(fuckinNumber);
    }

    void NewFunc(string userName)
    {
        Debug.Log("Yhaaaaa" + userName);
    }

    int ReturenNumberFunc(int Number)
    {
        return Number+1;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
