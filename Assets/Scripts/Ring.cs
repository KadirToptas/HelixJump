using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ring : MonoBehaviour
{
    public Transform ball;

    private Game_Manager gm;
    void Start()
    {
        gm = GameObject.FindObjectOfType<Game_Manager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y + 7f >=ball.position.y)
        {
            Destroy(gameObject);
            gm.GameScore(25);
        }
    }
}
