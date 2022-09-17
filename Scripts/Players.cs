using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Players : MonoBehaviour
{
    [SerializeField] public float SpeedForce;

    [SerializeField] public GameObject player1;
    [SerializeField] public GameObject player2;

    [SerializeField] public Rigidbody2D rig1;
    [SerializeField] public Rigidbody2D rig2;
    // Start is called before the first frame update
    void Start()
    {
        //rig1 = player1.GetComponent<Rigidbody2D>();
        
        rig1 = GameObject.Find("Player").GetComponent<Rigidbody2D>();
        rig2 = GameObject.Find("Player2").GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position += new Vector3(0, Input.GetAxis("Vertical") * SpeedForce * Time.deltaTime, 0);

        //player1.transform.position += new Vector3(0, Input.GetAxis("vPlayer1") * SpeedForce * Time.deltaTime, 0);
        //player2.transform.position += new Vector3(0, Input.GetAxis("vPlayer2") * SpeedForce * Time.deltaTime, 0);
    }

    private void FixedUpdate()
    {

        rig1.velocity = new Vector2(0, Input.GetAxis("vPlayer1") * SpeedForce);
        rig2.velocity = new Vector2(0, Input.GetAxis("vPlayer2") * SpeedForce);

    }

}
