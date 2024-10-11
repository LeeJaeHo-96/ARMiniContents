using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chip : MonoBehaviour
{
    [SerializeField] Rigidbody rigid;


    void OnEnable()
    {
           rigid.AddForce(0, 100, 300);
        
    }

}
