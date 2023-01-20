using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Most : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    public void MostAnimation()
    {
        anim.SetTrigger("activate");
    }
}
