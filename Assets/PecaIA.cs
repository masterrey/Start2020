using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PecaIA : Pecinhas
{
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SecondCall", 1, 1);
    }

    void SecondCall()
    {
        if (playertime == false)
        {
            if(MovePiece((Dir)Random.Range(0, 4)))
            playertime = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
