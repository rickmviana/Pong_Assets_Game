using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IAComputer : MonoBehaviour
{
    [SerializeField] public Transform ball;
    [SerializeField] public float SpeedForce;
    private ScrDetectmode scrDetectaMode;
    //[SerializeField] public bool resetSpeed;
    //[SerializeField] private float raioVisao;


    [SerializeField] private Rigidbody2D rigComp;
    
    // Start is called before the first frame update
    void Start()
    {
        scrDetectaMode = GameObject.Find("Detectmode").GetComponent<ScrDetectmode>();
        rigComp = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void FixedUpdate()
    {
        if (scrDetectaMode.onePlayer == true)
            rigComp.velocity = new Vector2(0, (ball.transform.position.y - transform.position.y) * SpeedForce);
        else
        { 
            rigComp.velocity = new Vector2(0, Input.GetAxis("vPlayer2") * SpeedForce);
        }
        if (scrDetectaMode.twoPlayers == true)
            rigComp.velocity = new Vector2(0, (ball.transform.position.y - transform.position.y) * SpeedForce);
    }
}
