using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    

    public float speed;
    void Touchmove()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3 PotaPos = GameObject.Find("Pota").transform.position;

            if (mousePos.x > PotaPos.x)
            {
                transform.Translate(speed, 0, 0);
            }
            else if(mousePos.x < PotaPos.x)
            {
                transform.Translate(-speed, 0, 0);
            }
            
        }
    }
    void Start()
    {
        
    }

    
    private void FixedUpdate()
    {
        Touchmove();
    }
}
