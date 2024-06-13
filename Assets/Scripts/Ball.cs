using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject splashPrefab;

    private Game_Manager gm;

    public float jumpForce;
    void Start()
    {
        gm = GameObject.FindObjectOfType<Game_Manager>();
    }

    
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        rb.AddForce(Vector3.up*jumpForce);

        GameObject splash = Instantiate(splashPrefab, transform.position + new Vector3(0f,-0.2f,0f), transform.rotation);
        splash.transform.SetParent(other.gameObject.transform);

        string materialName = other.gameObject.GetComponent<MeshRenderer>().material.name;

        
         if (materialName=="Unsafe_Color (Instance)")
        {
            gm.RestartGame();
        }
        else if (materialName=="Last_Ring (Instance)")
        {
            Debug.Log("Next Level");
        }
    }
}
