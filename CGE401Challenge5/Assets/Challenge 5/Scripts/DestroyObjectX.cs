/*
* Panagiotis Burbulis
* DestroyObjectX.cs
* Challenge 5
* Destroys the object after 2 seconds have passed
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjectX : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, 2); // destroy particle after 2 seconds
    }


}
