using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class end : item
{
    public static float a;
    // Start is called before the first frame update
    public override void Active(Collider2D collision)
    {
        a = collision.transform.localScale.x;
        SceneManager.LoadScene("demend");
    }
}