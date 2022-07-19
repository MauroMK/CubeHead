using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Physics.Raycast(transform.position, transform.forward, out hit, 10f))
            {
                if (hit.collider.gameObject.tag == "enemie")
                {
                    Destroy(hit.collider.gameObject);
                }
            }
        }
    }
}
