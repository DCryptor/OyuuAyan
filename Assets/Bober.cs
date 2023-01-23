using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bober : MonoBehaviour
{
    public GameObject grib;
    private Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

public void BoberAnimation()
{
    grib.SetActive(true);
    anim.SetBool("activated",true);

}
}
