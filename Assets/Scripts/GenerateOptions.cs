using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateOptions : MonoBehaviour
{
    //buttons
    [SerializeField] private GameObject option1;
    [SerializeField] private GameObject option2;
    [SerializeField] private GameObject option3;
    
    //image for the country
    [SerializeField] private GameObject countryImage;

    //arrays
    private string[] options = new string[47];

    // Start is called before the first frame update
    void Start()
    {
        //add all european countries to the array
        options[0] = "Albania";
        options[1] = "Andorra";
        options[2] = "Austria";
        options[3] = "Azerbaijan";
        options[4] = "Belarus";
        options[5] = "Belgium";
        options[6] = "Bosnia and Herzegovina";
        options[7] = "Bulgaria";
        options[8] = "Croatia";
        options[9] = "Czech Republic";
        options[10] = "Denmark";
        options[11] = "Estonia";
        options[12] = "Finland";
        options[13] = "France";
        options[14] = "Georgia";
        options[15] = "Germany";
        options[16] = "Greece";
        options[17] = "Hungary";
        options[18] = "Iceland";
        options[19] = "Ireland";
        options[20] = "Italy";
        options[21] = "Kosovo";
        options[22] = "Latvia";
        options[23] = "Liechtenstein";
        options[24] = "Lithuania";
        options[25] = "Luxembourg";
        options[26] = "Macedonia";
        options[27] = "Malta";
        options[28] = "Moldova";
        options[29] = "Monaco";
        options[30] = "Montenegro";
        options[31] = "Netherlands";
        options[32] = "Norway";
        options[33] = "Poland";
        options[34] = "Portugal";
        options[35] = "Romania";
        options[36] = "San Marino";
        options[37] = "Serbia";
        options[38] = "Slovakia";
        options[39] = "Slovenia";
        options[40] = "Spain";
        options[41] = "Sweden";
        options[42] = "Switzerland";
        options[43] = "United Kingdom";
        options[44] = "Vatican City";
        options[45] = "Turkey";
        options[46] = "Russia";
    }


    public void GenerateTheThingiemcJigs()
    {
        int rand = 0;
        int lastRand = 0;
        rand = (int)(Random.Range(0, 46));
        lastRand = rand;
        //generate the options
        option1.GetComponent<Button>().SetText(options[rand]);
        rand = (int)(Random.Range(0, 46));
        if(rand != lastRand)
        {
            option2.GetComponent<Button>().SetText(options[rand]);
            lastRand = rand;
        }
        rand = (int)(Random.Range(0, 46));
        if(rand != lastRand)
        {
            option3.GetComponent<Button>().SetText(options[rand]);
            lastRand = rand;
        }
        //generate the country image
    }
}
