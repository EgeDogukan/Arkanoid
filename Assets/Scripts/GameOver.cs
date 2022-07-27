using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{

    private BoxCollider2D gameOverWall;
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        gameOverWall = GetComponent<BoxCollider2D>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator OnTriggerEnter2D(Collider2D other) 
    {
        audioSource.PlayOneShot(audioSource.clip, 0.5f);
        yield return new WaitForSeconds(2.8f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);    
    }
}
