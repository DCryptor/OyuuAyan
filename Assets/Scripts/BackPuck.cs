using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class BackPuck : MonoBehaviour
{
    public DragMe dragMe;
    public AudioSource audioSource;
    public AudioClip[] sound;
    public int pickup_item_value = 0;
    public bool isPlaying = false;
    public void Awake()
    {
        dragMe = GetComponent<DragMe>();
    }
    private void Update()
    {
        if (pickup_item_value == 2 && !isPlaying)
        {
            isPlaying = true;
            audioSource.PlayOneShot(sound[5]);
            Invoke("NextLevel", 4f);
        }
    }

    private void Start()
    {
        audioSource.PlayOneShot(sound[3]);
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Axe")
        {
            dragMe = GetComponent<DragMe>();
            if (!audioSource.isPlaying)
            {
                audioSource.Stop();
                audioSource.PlayOneShot(sound[0]);
                dragMe.Reset();
            }
        }
        if (other.tag == "Lopata")
        {
            dragMe = GetComponent<DragMe>();
            if (!audioSource.isPlaying)
            {
                audioSource.Stop();
                audioSource.PlayOneShot(sound[1]);
                dragMe.Reset();
            }
        }
        if (other.tag == "Knife")
        {
            dragMe = GetComponent<DragMe>();
            if (!audioSource.isPlaying)
            {
                audioSource.Stop();
                audioSource.PlayOneShot(sound[4]);
                Destroy(other.gameObject);
                pickup_item_value = pickup_item_value + 1;
            }
        }
        if (other.tag == "Lozhka")
        {
            dragMe = GetComponent<DragMe>();
            if (!audioSource.isPlaying)
            {
                audioSource.Stop();
                audioSource.PlayOneShot(sound[2]);
                dragMe.Reset();
            }
        }
        if (other.tag == "Korzina")
        {
            dragMe = GetComponent<DragMe>();
            if (!audioSource.isPlaying)
            {
                audioSource.Stop();
                audioSource.PlayOneShot(sound[4]);
                Destroy(other.gameObject);
                pickup_item_value = pickup_item_value + 1;
            }
        }
    }

    public void NextLevel()
    {
        SceneManager.LoadScene("Scene_1");
    }
}
