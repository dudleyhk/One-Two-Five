﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public SpriteRenderer SpriteRenderer { get; protected  set; }
    public Vector3 Target { get; set; }
    public float Speed { get; set; }

    [SerializeField] protected Vector3 direction;
}