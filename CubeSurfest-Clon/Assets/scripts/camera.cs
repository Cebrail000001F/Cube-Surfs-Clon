using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public Transform target; //takip edecegi obje
    public Vector3 offset;   //takip etme mesafe aralýgý
   
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position,
           target.position + offset, Time.deltaTime * 2);
    }
}
