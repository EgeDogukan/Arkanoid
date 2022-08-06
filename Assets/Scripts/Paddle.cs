using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{

    /* private float speed = 30f; */
    private Camera cam;
    private float x;
    private float y;
    public static float leftBorder;
    public static float rightBorder;
    public static float upperBorder;
    public static float lowerBorder;
    private float mousePos;
    public ProjectileBehaviour ProjectilePrefab;
    public Transform LaunchOffset;
    public AudioSource bounceSound;

    // Start is called before the first frame update
    void Start()
    {
        y = this.transform.position.y;
        cam = FindObjectOfType<Camera>();
        
        leftBorder = cam.ViewportToWorldPoint(new Vector3(0, 0, 0)).x;
        rightBorder = cam.ViewportToWorldPoint(new Vector3(1, 0, 0)).x;
        lowerBorder = cam.ViewportToWorldPoint(new Vector3(0, 0, 0)).y; //-5, +5
        upperBorder = cam.ViewportToWorldPoint(new Vector3(0, 1, 0)).y;             //Getting screen borders

        bounceSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        movePaddle();
        if(Input.GetButtonDown("Fire1"))
        {
            Instantiate(ProjectilePrefab, LaunchOffset.position, transform.rotation);
        }
    }

    private void movePaddle() 
    {
       /* if(Input.GetKey(KeyCode.LeftArrow))                   // Keyboard controls
        {
            x += speed * Time.deltaTime * -1;
            Debug.Log(x);
            x = Mathf.Clamp(x, -8.27f, 9.27f);
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            x += speed * Time.deltaTime;
            Debug.Log(x);
            x = Mathf.Clamp(x, -8.27f, 8.27f);
        } */

        mousePos = Mathf.Clamp(cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, 0, 0)).x, leftBorder, rightBorder);
        x = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, 0, 0)).x;
        this.transform.position = new Vector3(mousePos, y, 0);
    }

    private void OnCollisionEnter2D(Collision2D other) //Collision
    {
        bounceSound.PlayOneShot(bounceSound.clip);    
        StartCoroutine(Shake());
    }

    IEnumerator Shake()                 //Paddle Shake
    {
        this.GetComponent<Collider2D>().enabled = false;
            for (int i = 0; i < 5; i++)
           {
                transform.localPosition += new Vector3(BallMove.GetRigidbody2Dx() / 200, BallMove.GetRigidbody2Dy() / 200, 0);
                yield return new WaitForSeconds(0.01f);
                transform.localPosition -= new Vector3(BallMove.GetRigidbody2Dx() / 200, BallMove.GetRigidbody2Dy() / 200, 0);
                yield return new WaitForSeconds(0.01f);
                transform.localPosition += new Vector3(-BallMove.GetRigidbody2Dx() / 200, -BallMove.GetRigidbody2Dy() / 200, 0);
                yield return new WaitForSeconds(0.01f);
                transform.localPosition -= new Vector3(-BallMove.GetRigidbody2Dx() / 200, -BallMove.GetRigidbody2Dy() / 200, 0);
                yield return new WaitForSeconds(0.01f);
           }
        this.GetComponent<Collider2D>().enabled = true;
    }
}