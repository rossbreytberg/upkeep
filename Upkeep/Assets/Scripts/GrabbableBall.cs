using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabbableBall : OVRGrabbable
{
    static readonly Vector3 grabbedOffset = new Vector3(0, -0.01f, 0);

    public override void GrabBegin(OVRGrabber hand, Collider grabPoint)
    {
        base.GrabBegin(hand, grabPoint);
        transform.position = hand.transform.rotation * grabbedOffset + hand.transform.position;
    }
}
