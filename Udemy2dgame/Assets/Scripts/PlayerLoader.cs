using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLoader : MonoBehaviour
{
    public GameObject player;


    // Start is called before the first frame update
    void Start()
    {
        if (PlayerControl.instance == null)
        {
            Instantiate(player);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }

}