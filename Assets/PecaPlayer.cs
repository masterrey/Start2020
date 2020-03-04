using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PecaPlayer : Pecinhas
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (playertime && Input.GetKeyDown(KeyCode.RightArrow))
        {
           if(MovePiece(Dir.r))
            playertime = false;
        }
        if (playertime && Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if(MovePiece(Dir.l))
            playertime = false;
        }

        if (playertime && Input.GetKeyDown(KeyCode.UpArrow))
        {
            if(MovePiece(Dir.u))
            playertime = false;
        }
        if (playertime && Input.GetKeyDown(KeyCode.DownArrow))
        {
            if(MovePiece(Dir.d))
            playertime = false;
        }
    }
}
