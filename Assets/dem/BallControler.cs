using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControler : item
{
    // Start is called before the first frame update
    public override void Active(Collider2D collision)
    {
        collision.gameObject.transform.localScale = new Vector3(5,5,5);
    }
}
