using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassControler : item
{
    public override void Active(Collider2D collision)
    {
        collision.gameObject.transform.localScale = new Vector3(1, 1, 1);
    }
}
