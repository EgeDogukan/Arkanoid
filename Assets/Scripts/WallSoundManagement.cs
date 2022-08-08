using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSoundManagement : MonoBehaviour
{

    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponentInParent<AudioSource>();
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