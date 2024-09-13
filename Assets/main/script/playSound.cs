using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playSound : MonoBehaviour
{
    [SerializeField] private AudioSource a;
    [SerializeField] private AudioClip b;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        a.PlayOneShot(b);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        a.PlayOneShot(b);
    }
}
