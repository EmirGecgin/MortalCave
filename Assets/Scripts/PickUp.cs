using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    private bool _wasCollected = false;
    public AudioClip collectSong;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player") && !_wasCollected)
        {
            _wasCollected = true;
            FindObjectOfType<PlayerStateManager>().TakeCoin(10);
            GetComponent<AudioSource>().PlayOneShot(collectSong);
            Destroy(gameObject,0.16f);
            

        }
    }
}
