using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallPhysic : MonoBehaviour
{
    
    private Rigidbody2D rig2D;
    private gameManager gManagerScript;
    private ScrDetectmode ScrDmd;

    [SerializeField] public bool MenuG;
    [SerializeField] public AudioClip PointPl1;
    [SerializeField] public AudioClip PointPl2;
    [SerializeField] public AudioClip Som1;
    [SerializeField] public float x;
    [SerializeField] public float y;
    [SerializeField] public bool restartG;
    //[SerializeField] public float speed;
    //[SerializeField] public float SpeedForce;
    //[SerializeField] private IAComputer SpeedScr;
    //[SerializeField] private Rigidbody2D rigIA;

    // Start is called before the first frame update
    void Start()
    {
        //rigIA = GetComponent<Rigidbody2D>();
        rig2D = GetComponent<Rigidbody2D>();
        gManagerScript = GameObject.Find("GameManager").GetComponent<gameManager>();
        ScrDmd = GameObject.Find("Detectmode").GetComponent<ScrDetectmode>();
        //Gera uma velocidade de eixo aléatorio entre X & Y
        x = Random.Range(-6f, 6f);
        y = Random.Range(-6f, 6f);

        rig2D.velocity = new Vector2(x, y);

        restartG = true;
        MenuG = true;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        if (restartG == true)
        {

            if (rig2D.velocity.x < 2f && rig2D.velocity.x > -2f)
            {

                if (rig2D.velocity.x >= 0)
                {
                    rig2D.velocity = new Vector2(2f, rig2D.velocity.y);
                }

                else
                {
                    rig2D.velocity = new Vector2(-2f, rig2D.velocity.y);
                }
            }

            if (rig2D.velocity.y < 2f && rig2D.velocity.y > -2f)

            {

                if (rig2D.velocity.y >= 0)
                {
                    rig2D.velocity = new Vector2(rig2D.velocity.x, 2f);
                }

                else
                {
                    rig2D.velocity = new Vector2(rig2D.velocity.x, -2f);
                }

            }

        }
        //if (rig2D.velocity.x == 0 && rig2D.velocity.y == 0) {} 
        if (Input.GetKeyDown(KeyCode.Space) && restartG == false){
            Start();
        }if(Input.GetMouseButtonDown(0) && restartG == false){
            Start();
        }if(Input.GetKey(KeyCode.R)){
            rig2D.transform.position = Vector3.zero;
            Start();
        }if(Input.GetKey(KeyCode.E) && MenuG == true){
            SceneManager.LoadScene("Menu");
        }
        if(ScrDmd.twoPlayers == true && restartG == false)
        {
            Start();
        }

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "BarreiraR")
        {
            //Mesma coisa de rig2D.velocity = new Vector2(0, 0);
            rig2D.velocity = Vector2.zero; 
            transform.position = new Vector3(0, 0, 0);
            restartG = false;
            gManagerScript.Point1 += 1;
            AudioSource.PlayClipAtPoint(PointPl1, transform.position);
        }
    
        if(other.gameObject.tag == "BarreiraL")
        {
            rig2D.velocity = Vector2.zero;
            transform.position = new Vector3(0, 0, 0);
            restartG = false;
            gManagerScript.Point2 += 1;
            AudioSource.PlayClipAtPoint(PointPl2, transform.position);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Sidebarrier")
        {
            AudioSource.PlayClipAtPoint(Som1, transform.position);
        }
        if (collision.gameObject.tag == "PlayerBrr2")
        {
            AudioSource.PlayClipAtPoint(Som1, transform.position);
        }
        if (collision.gameObject.tag == "PlayerBrr")
        {
            AudioSource.PlayClipAtPoint(Som1, transform.position);
        }

    }
}
