using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniGamePlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");
        transform.position += new Vector3(x, 0, z) * 0.1f;
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("game終了");
        SceneManager.LoadScene("test");
        //"test"はヒエラルキーの一番最上部のファイル名がscene名になる
    }
}