using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Block : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -7.15f)
        {
            Destroy(gameObject);
        }       
    }
}
