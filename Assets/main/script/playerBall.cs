using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerBall : MonoBehaviour
{
    [SerializeField] GameObject ballcon;
    [SerializeField] GameObject bo;
    ballController _BC;
    bool tourch;

    // Start is called before the first frame update
    void Start()
    {
        _BC = ballcon.GetComponent<ballController>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (_BC.shotok)
        {
            bo.SetActive(true);
            if (Input.GetAxisRaw("Horizontal") < 0)
            {
                transform.Rotate(0, 0, 1.0f);
            }
            if (Input.GetAxisRaw("Horizontal") > 0)
            {
                transform.Rotate(0, 0, -1.0f);
            }
            if (Input.GetAxisRaw("Vertical") > 0)
            {
                if (bo.transform.localScale.x < 3f)
                {
                    bo.transform.localScale += new Vector3(0.05f, 0, 0);
                }
            }
            if (Input.GetAxisRaw("Vertical") < 0)
            {
                if (bo.transform.localScale.x > 0.5f)
                {
                    bo.transform.localScale += new Vector3(-0.05f, 0, 0);
                }
            }
            if (Input.GetKey(KeyCode.Space))
            {
                add();
                _BC.shotok = false;
            }
            if (Input.GetKey(KeyCode.Escape))
            {
                Initiate.Fade("start", Color.black, 1.0f);
            }
        }
        else
        {
            bo.SetActive(false);
        }
    }
    public void add()
    {
        var _rb = GetComponent<Rigidbody2D>();
        _rb.AddForce(transform.right * bo.transform.localScale.x * 3, ForceMode2D.Impulse);
        tourch = false;
        _BC.outflag = false;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name != _BC.firstname && collision.gameObject.tag != "GameController" && ballController.turn != 0 && !tourch)
        {
            _BC.outflag = true;
        }
        if (collision.gameObject.tag == "Finish")
        {
            _BC.outflag = true;
        }
        if(collision.gameObject.tag != "GameController")
        {
            tourch = true;
        }
    }
}
