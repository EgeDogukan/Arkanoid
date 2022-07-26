using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{

    /* private float speed = 30f; */
    private Camera cam;
    private float x;
    private float y;
    private float leftBorder;
    private float rightBorder;
    private float mousePos;
    public ProjectileBehaviour ProjectilePrefab;
    public Transform LaunchOffset;
    public AudioSource bounceSound;

    // Start is called before the first frame update
    void Start()
    {
        y = this.transform.position.y;
        cam = FindObjectOfType<Camera>();
        
        leftBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0)).x;
        rightBorder = cam.ViewportToWorldPoint(new Vector3(1, 0, 0)).x;

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

    private void OnCollisionEnter2D(Collision2D other) {
        bounceSound.PlayOneShot(bounceSound.clip);
    }
}