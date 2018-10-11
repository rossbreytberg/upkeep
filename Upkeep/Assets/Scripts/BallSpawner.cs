using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour {
    [SerializeField]
    protected GameObject ball;
    [SerializeField]
    protected OVRInput.Controller m_controller;
    static int colorIndex = 0;
    static readonly Color[] colors = new Color[] { new Color(54, 190, 255), new Color(255, 172, 245), new Color(255, 54, 54) };

    void Update () {
		if (OVRInput.GetDown(OVRInput.Button.Two, m_controller))
        {
            GameObject newBall = Instantiate(ball);
            newBall.transform.position = transform.position;
            Debug.Log("Colors");
            Debug.Log(colorIndex);
            Debug.Log(colors);
            Debug.Log(colorIndex % colors.Length);
            Debug.Log(colors[colorIndex % colors.Length]);
            colorIndex++;
        }
	}
}
