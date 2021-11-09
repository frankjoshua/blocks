using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class CubeSpawner : MonoBehaviour
{

    [SerializeField]
    GameObject cubePrefab;
    private ActionBasedController controller;


    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<ActionBasedController>();
        controller.activateAction.action.performed += Action_performed;
    }

    private void Action_performed(InputAction.CallbackContext obj)
    {
        Object.Instantiate(cubePrefab, new Vector3(0, 0.5f, 1), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
