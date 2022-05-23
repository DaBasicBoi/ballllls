using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class dedlol : MonoBehaviour

{
    public GameObject Dedlol;


    // Start is called before the first frame update
    void Start()
    {
        Dedlol.SetActive(false);
    }

// Update is called once per frame
    void Update()
    {
        if(gameHasEnded == true)
        {
            Uded();
        }
        else
        {
            Ualive();
        }
    }

    public void Uded()
    {
        Dedlol.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Ualive()
    {
        Dedlol.SetActive(false);
        Time.timeScale = 1f;
    }
}