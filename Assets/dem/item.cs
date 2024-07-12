using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]

public abstract class item : MonoBehaviour
{
    // Start is called before the first frame update
    public abstract void Active(Collider2D collision);

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Active(collision);
            Destroy(this.gameObject);
        }
    }
}
