using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Plotina : MonoBehaviour
{
    public Animator anim_bober;
    public DragMe dragMe;
    public AudioSource audioSource;
    public AudioClip[] sound;
    public int pickup_item_value = 0;
    public bool isPlaying = false;
    public CharacterManager characterManager;

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
        if (other.tag == "Small_Rock" && !characterManager.isPlayable)
        {
            dragMe = GetComponent<DragMe>();
            if (!audioSource.isPlaying)
            {
                characterManager.ActiveCutScene = CharacterManager.CutScene.small_rock;
                audioSource.Stop();
                audioSource.PlayOneShot(sound[0]);
                dragMe.Reset();
            }
        }

        if (other.tag == "Big_Rock" && !characterManager.isPlayable)
        {
            dragMe = GetComponent<DragMe>();
            if (!audioSource.isPlaying)
            {
                audioSource.Stop();
                audioSource.PlayOneShot(sound[0]);
                Destroy(other.gameObject);
                pickup_item_value = pickup_item_value + 1;
                characterManager.ActiveCutScene = CharacterManager.CutScene.tot_rock;
                anim_bober.SetBool("activated", true);
            }
        }
    }

    public void NextLevel()
    {
        SceneManager.LoadScene("Scene_1");
    }
}
