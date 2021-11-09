using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigSelector : MonoBehaviour
{
    
    public GameObject XRRig;
    public GameObject NonVRRig;
    private bool isOnXRDevice;
    
    private void Awake() {
        isOnXRDevice = Application.platform == RuntimePlatform.Android;
        XRRig.SetActive(isOnXRDevice);
        NonVRRig.SetActive(!isOnXRDevice);
    }

}
