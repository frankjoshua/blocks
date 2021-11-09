using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickyCube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Loaded");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Colission");
        Transform colTransform = collision.gameObject.transform;
        if(colTransform.parent == null){
            gameObject.transform.SetParent(colTransform);
            foreach(Transform child in gameObject.transform){
                if(child != colTransform){
                    child.SetParent(colTransform);
                }
            }
        }
        
    }

}
