using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickyCube : MonoBehaviour
{
   public Color newColor = Random.ColorHSV(0F, 0.5F);
    // Start is called before the first frame update
    void Start()
    {
        ApplyMaterial(Random.ColorHSV(0F, 0.5F));
    }

    void ApplyMaterial(Color color)
    {
        newColor = color;
        // You can re-use this block between calls rather than constructing a new one each time.
        var block = new MaterialPropertyBlock();

        // You can look up the property by ID instead of the string to be more efficient.
        block.SetColor("_BaseColor", color);

        // You can cache a reference to the renderer to avoid searching for it.
        GetComponent<Renderer>().SetPropertyBlock(block);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Colision");
        Transform colTransform = collision.gameObject.transform;
        if(colTransform.parent == null){
            Color parentColor = collision.gameObject.GetComponent<StickyCube>().newColor;
            ApplyMaterial(parentColor);
            gameObject.transform.SetParent(colTransform);
            foreach(Transform child in gameObject.transform){
                if(child != colTransform){
                    child.SetParent(colTransform);
                }
            }
        }
        
    }

}
