using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        bool hasHitSomething = Physics.Raycast(ray, out hit, 100f);

        if (hasHitSomething && hit.collider != null)
        {
            Debug.Log(hit.transform.name);
        }
    }

    private void 
}
