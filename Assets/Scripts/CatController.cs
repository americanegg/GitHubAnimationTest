using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatController : MonoBehaviour
{
    public AudioSource musicSource;
    public AudioClip musicClipOne;
    public AudioClip musicClipTwo;
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

   void Update()

    {

     if (Input.GetKeyDown(KeyCode.W))

        {

          musicSource.clip = musicClipOne;

          musicSource.Play();

          anim.SetInteger("state", 1);

         }

     if (Input.GetKeyUp(KeyCode.W))

        {

          musicSource.Stop();

          anim.SetInteger("state", 0);

         }

     if (Input.GetKeyDown(KeyCode.R))

        {

          musicSource.clip = musicClipTwo;

          musicSource.Play();

          anim.SetInteger("state", 2);

         }

     if (Input.GetKeyUp(KeyCode.R))

        {

          musicSource.Stop();

          anim.SetInteger("state", 0);

         }

     if (Input.GetKeyDown(KeyCode.L))

        {

          musicSource.loop = true;

         }

     if (Input.GetKeyUp(KeyCode.L))

        {

          musicSource.loop = false;

        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
          Application.Quit();
        }
    }
}
