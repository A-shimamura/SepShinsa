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
        text.GetComponent<Text>().text = $"���Ȃ��̃T�C�Y��{end.a}���炢�ł��B\nSpace�Ń^�C�g����";
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("demstart");
        }
    }
}
