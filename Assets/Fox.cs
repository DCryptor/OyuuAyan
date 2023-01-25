using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fox : MonoBehaviour
{
    float timer;
    public float random_delay;
    public Transform[] fox_pos;
    public bool fox_active = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (timer <= 0.0f)
        {
            timer = 0.0f;
        }
        if (timer > 0.0f)
        {
            timer = timer - Time.deltaTime;
        }

        if (timer == 0.0f && fox_active)
        {
            transform.position = fox_pos[Random.Range(0, fox_pos.Length)].position;
            timer = random_delay;
        }
    }

    public void Fox_On()
    {
        this.gameObject.SetActive(true);
        fox_active = true;
    }
}
