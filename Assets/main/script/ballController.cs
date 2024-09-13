using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class ballController : MonoBehaviour
{
    [SerializeField] List<GameObject> balls = new List<GameObject>();
    [SerializeField] List<GameObject> saveballs = new List<GameObject>();
    [SerializeField] Text text;
    public static int turn = 1;
    public bool shotok = true;
    public string firstname;
    public bool outflag;
    // Start is called before the first frame update
    void Start()
    {
        SaveBall();
    }

    // Update is called once per frame
    void Update()
    {
        int active = 0, count = 0;
        foreach (var ball in balls)
        {
            if (ball.active == true && ball.name != "0")
            {
                transform.position = ball.transform.position;
                firstname = ball.name;
                break;
            }
        }
        foreach (var ball in balls)
        {
            if (ball.active == true && shotok == false)
            {
                active++;
                var rb = ball.GetComponent<Rigidbody2D>();
                if (rb.velocity == Vector2.zero)
                {
                    count++;
                }
            }
        }
        if (count == active && shotok == false)
        {
            if (outflag)
            {
                loadballs();
                outflag = false;
            }
            SaveBall();
            turnadd();
        }
    }
    public void SaveBall()
    {
        for (int i = 0; i < saveballs.Count; i++)
        {
            saveballs[i].transform.position = balls[i].transform.position;
            if (balls[i].active)
            {
                saveballs[i].SetActive(true);
            }
            else
            {
                saveballs[i].SetActive(false);
            }
            var tr = balls[i].GetComponent<TrailRenderer>();
            tr.Clear();
        }
    }
    public void loadballs()
    {
        for (int i = 0; i < saveballs.Count; i++)
        {
            if (saveballs[i].active)
            {
                balls[i].SetActive(true);
            }
            else
            {
                balls[i].SetActive(false);
            }
            balls[i].transform.position = saveballs[i].transform.position;
        }
    }
    public void turnadd()
    {
        shotok = true;
        turn++;
        text.text = "PLAYER " + (turn % 2 + 1) + " TURN";
    }
}
