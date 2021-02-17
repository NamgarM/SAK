﻿/// P3 Swiss Army Knife project
/// All
/// Group 2 (Iman, Namgar, Torben)
/// Summary: 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanEnable : MonoBehaviour
{
    public GameObject canOpen;
    public GameObject canClose;
    private string sakTag = "CanOpener";

    [HideInInspector]
    public bool canOpened = false;
    private GameObject audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("AudioManager");
    }

    void Start()
    {
        canClose.SetActive(true);
        canOpen.SetActive(false); 
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag(sakTag))
        {
            audioManager.GetComponent<AudioManager>().Play("Can");
            canOpen.SetActive(true);
            canClose.SetActive(false);
            // For adventure
            if(canOpened == false)
            {
                canOpened = true;
            }
        }
    }
}
