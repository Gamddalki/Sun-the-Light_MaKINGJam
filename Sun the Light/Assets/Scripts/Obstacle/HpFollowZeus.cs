﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpFollowZeus : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        gameObject.transform.position = gameObject.transform.parent.parent.position + new Vector3 (-0.8f, 2f, 0);
    }
}
