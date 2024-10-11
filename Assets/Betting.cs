using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Betting : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI text = null;
    [SerializeField] public float total;


    
    public void Start()
    {
        total = 0;
    }

    public void Update()
    {

        text.text = total.ToString();
    }


}
