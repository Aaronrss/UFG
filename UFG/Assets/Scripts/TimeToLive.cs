﻿/*

    GILBERTO ECHEVERRIA IDEA TO DESTORY A BULLET
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeToLive : MonoBehaviour
{
    public float timeToLive;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, timeToLive);
    }
}
