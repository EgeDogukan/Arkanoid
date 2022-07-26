using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSoundManagement : MonoBehaviour
{

    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponentInParent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.CompareTag("Projectile"))
        {
            
        }
        else
        {
            audioSource.PlayOneShot(audioSource.clip);
        }
    }
}