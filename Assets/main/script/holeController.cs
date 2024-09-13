using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class holeController : MonoBehaviour
{
    [SerializeField] GameObject ballcon;
    ballController _BC;
    // Start is called before the first frame update
    void Start()
    {
        _BC = ballcon.GetComponent<ballController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.SetActive(false);
        if(collision.gameObject.name == "0")
        {
            _BC.outflag = true;
        }
        if(collision.gameObject.name == "9" && _BC.outflag == false)
        {
            Initiate.Fade("end", Color.black, 1.0f);
        }
    }
}
