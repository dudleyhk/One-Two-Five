﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class GameManager : MonoBehaviour
{
    private CollisionManager collisionManager;


    private void Awake()
    {
        collisionManager = new CollisionManager();
        if(collisionManager == null)
            Debug.LogWarning("Warning: CollisionManager creation error!");
    }
}
