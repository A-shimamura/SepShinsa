using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Rigidbody2D _rb;
    [SerializeField]float _moveSpeed=3f;
    // Start is called before the first frame update
    void Start()
    {
        _rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        Vector2 velocity = _rb.velocity;   // Ç±ÇÃïœêî velocity Ç…ë¨ìxÇåvéZÇµÇƒÅAç≈å„Ç… Rigidbody2D.velocity Ç…ñﬂÇ∑

        if (h != 0)
        {
            velocity.x = h * _moveSpeed;
        }
        _rb.velocity = velocity;
    }
}
