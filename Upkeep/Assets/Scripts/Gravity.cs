using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    [SerializeField]
    protected Vector3 m_gravity = new Vector3(0, -9.81F, 0);

    void Start () {
        Physics.gravity = gravity;
    }

    public Vector3 gravity
    {
        get { return m_gravity; }
    }
}
