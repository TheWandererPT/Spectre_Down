using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    //public InputController inputController;

    private Camera mainCamera;

    // Start is called before the first frame update
    private void Start()
    {
        mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
 
    private void OnShoot()
    {
        ShootRaycast();
    }

    private void ShootRaycast()
    {
        Ray ray=Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        bool hasHitSomething = Physics.Raycast(ray, out hit, 100f);

        if (hasHitSomething && hit.collider != null)
        {
            Debug.Log(hit.transform.name);
        }

    }
    
        
    

}
