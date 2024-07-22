using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class result : MonoBehaviour
{
    [SerializeField]GameObject text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.GetComponent<Text>().text = $"あなたのサイズは{end.a}ぐらいです。\nSpaceでタイトルへ";
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("demstart");
        }
    }
}
