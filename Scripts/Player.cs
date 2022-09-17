using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rigPlayer;
    private ScrDetectmode scrDm;

    [SerializeField] Transform ball;
    [SerializeField] bool pressionar;
    [SerializeField] float SpeedForce;

    // Start is called before the first frame update
    void Start()
    {
        scrDm = GameObject.Find("Detectmode").GetComponent<ScrDetectmode>();
        rigPlayer = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            pressionar = true;
        }
        else pressionar = false;
    
    }
    void FixedUpdate()
    {
        if (pressionar)
        {
            Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos3D.x, mousePos3D.y);

            Vector2 dir = mousePos2D - new Vector2(0, transform.position.y);

            rigPlayer.velocity = new Vector2(0, dir.y * SpeedForce);
        }
        else
            rigPlayer.velocity = Vector2.zero;
        if(pressionar == false)
            rigPlayer.velocity = new Vector2(0, Input.GetAxis("vPlayer1") * SpeedForce);
    
        if(scrDm.twoPlayers == true)
        {
            rigPlayer.velocity = new Vector2(0, (ball.transform.position.y - transform.position.y) * SpeedForce);
        }
    }   
}
