using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject shooter;
    [SerializeField] GameObject chip = null;
    [SerializeField] GameObject redChip;
    [SerializeField] float redPrice = 50;
    [SerializeField] GameObject blueChip;
    [SerializeField] float bluePrice = 100;
    [SerializeField] GameObject greenChip;
    [SerializeField] float greenPrice = 500;
    [SerializeField] GameObject blackChip;
    [SerializeField] float blackPrice = 1000;

    public float total;


    private void Start()
    {
        shooter = this.gameObject;
        
        total = GameObject.Find("Total").GetComponent<Betting>().total;
    }

    public void Redchip()
    {
        chip = redChip;
        total += redPrice;
        Debug.Log("레드칩 베팅");
    }

    public void Bluechip()
    {
        chip = blueChip;
        total += bluePrice;
        Debug.Log("블루칩 베팅");
    }

    public void Greenchip()
    {
        chip = greenChip;
        total += greenPrice;
        Debug.Log("그린칩 베팅");
    }
    public void Blackchip()
    {
        chip = blackChip;
        total += blackPrice;
        Debug.Log("블랙칩 베팅");
    }
    public void OnButtonClicked()
    {
        
            Instantiate(chip, shooter.transform.position, shooter.transform.rotation);

      

    }

}
