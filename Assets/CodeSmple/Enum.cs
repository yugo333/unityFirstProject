using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enum : MonoBehaviour
{
    // enum を使った配列処理_______（列挙型)
    enum DIRECTION
    {
        STOP, RIGHT, LEFT, TOP, BOTTOM
    }
    DIRECTION direction; //宣言


    // Start is called before the first frame update
    void Start()
    {
        // enum を使った配列処理_______（列挙型)
        direction = DIRECTION.STOP;
        Debug.Log(direction);
        switch (direction)
        {
            case DIRECTION.STOP:
                Debug.Log("停止");
                break;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
