using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject shooter;
    [SerializeField] GameObject chip;
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
        shooter = GameObject.Find("ChipShoot");
        
        total = GameObject.Find("Total").GetComponent<Betting>().total;
    }

    public void Redchip()
    {
        chip = redChip;
    }

    public void Bluechip()
    {
        chip = blueChip;
    }

    public void Greenchip()
    {
        chip = greenChip;
    }
    public void Blackchip()
    {
        chip = blackChip;
    }
    public void OnButtonClicked()
    {
        
            Instantiate(chip, shooter.transform.position, shooter.transform.rotation);

        if (chip = redChip)
        {
            total += redPrice;
        }
        if (chip = blueChip)
        {
            total += bluePrice;
        }
        if (chip = greenChip)
        {
            total += greenPrice;
        }
        if (chip = blackChip)
        {
            total += blackPrice;
        }

    }

}
