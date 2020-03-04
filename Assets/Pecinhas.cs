using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pecinhas : MonoBehaviour
{
    protected enum Dir
    {
        r = 0,
        l = 1,
        u = 2,
        d = 3,
    }

    protected static bool playertime = true;

    protected bool MovePiece(Dir dir)
    {
        CheckNext(dir);
        switch (dir)
        {
            case (Dir.r):
                if (transform.position.x < 4f && transform.position.z < 4)
                {
                    transform.position += new Vector3(1f, 0, 1);
                }
                else { return false; }
            break;
            case (Dir.l):
                if (transform.position.x > -4f && transform.position.z > -4f)
                {
                    transform.position += new Vector3(-1, 0, -1);
                }
                else { return false; }
                break;
            case (Dir.u):
                if (transform.position.z < 4f && transform.position.x > -4f)
                {
                    transform.position += new Vector3(-1, 0, 1);
                }
                else { return false; }
                break;
            case (Dir.d):
                if (transform.position.z > -4f && transform.position.x < 4f)
                {
                    transform.position += new Vector3(1, 0, -1);
                }
                else { return false; }
                break;
        }
        return true;
    }

    protected bool MovePieceNocheck(Dir dir)
    {
        
        switch (dir)
        {
            case (Dir.r):
                if (transform.position.x < 4f && transform.position.z < 4)
                {
                    transform.position += new Vector3(1f, 0, 1);
                }
                else { return false; }
                break;
            case (Dir.l):
                if (transform.position.x > -4f && transform.position.z > -4f)
                {
                    transform.position += new Vector3(-1, 0, -1);
                }
                else { return false; }
                break;
            case (Dir.u):
                if (transform.position.z < 4f && transform.position.x > -4f)
                {
                    transform.position += new Vector3(-1, 0, 1);
                }
                else { return false; }
                break;
            case (Dir.d):
                if (transform.position.z > -4f && transform.position.x < 4f)
                {
                    transform.position += new Vector3(1, 0, -1);
                }
                else { return false; }
                break;
        }
        return true;
    }

    void CheckNext(Dir dir)
    {
        RaycastHit hit;
        Vector3 vdir=Vector3.zero;
        switch (dir)
        {
            case (Dir.r):
                vdir= new Vector3(1, 0, 1);
            break;
            case (Dir.l):
                vdir = new Vector3(-1, 0, -1);
                break;
            case (Dir.u):
                vdir = new Vector3(-1, 0, 1);
                break;
            case (Dir.d):
                vdir = new Vector3(1, 0, -1);
                break;
        }
        if (Physics.Raycast(transform.position, vdir, out hit, 2))
        {
            Destroy(hit.transform.gameObject);
            MovePieceNocheck(dir);
        }
    }
}
