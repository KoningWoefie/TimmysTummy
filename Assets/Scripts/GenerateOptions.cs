using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GenerateOptions : MonoBehaviour
{
    //buttons
    [SerializeField] private GameObject option1;
    public GameObject Option1 { get { return option1; } }
    [SerializeField] private GameObject option2;
    [SerializeField] private GameObject option3;

    [SerializeField]GameObject[] positions = new GameObject[3];

    Dictionary<string, Sprite> countries = new Dictionary<string, Sprite>();
    
    //image for the country
    [SerializeField] private GameObject countryImage;

    //arrays
    private string[] options = new string[47];

    // Start is called before the first frame update
    void Start()
    {
        //add all european countries to the array
        countries.Add("Albania", Resources.Load<Sprite>("Albania"));
        countries.Add("Andorra", Resources.Load<Sprite>("Andorra"));
        countries.Add("Austria", Resources.Load<Sprite>("Austria"));
        countries.Add("Azerbaijan", Resources.Load<Sprite>("Azerbaijan"));
        countries.Add("Belarus", Resources.Load<Sprite>("Belarus"));
        countries.Add("Belgium", Resources.Load<Sprite>("Belgium"));
        countries.Add("Bosnia and Herzegovina", Resources.Load<Sprite>("Bosnia and Herzegovina"));
        countries.Add("Bulgaria", Resources.Load<Sprite>("Bulgaria"));
        countries.Add("Croatia", Resources.Load<Sprite>("Croatia"));
        countries.Add("Czech Republic", Resources.Load<Sprite>("Czech Republic"));
        countries.Add("Denmark", Resources.Load<Sprite>("Denmark"));
        countries.Add("Estonia", Resources.Load<Sprite>("Estonia"));
        countries.Add("Finland", Resources.Load<Sprite>("Finland"));
        countries.Add("France", Resources.Load<Sprite>("France"));
        countries.Add("Georgia", Resources.Load<Sprite>("Georgia"));
        countries.Add("Germany", Resources.Load<Sprite>("Germany"));
        countries.Add("Greece", Resources.Load<Sprite>("Greece"));
        countries.Add("Hungary", Resources.Load<Sprite>("Hungary"));
        countries.Add("Iceland", Resources.Load<Sprite>("Iceland"));
        countries.Add("Ireland", Resources.Load<Sprite>("Ireland"));
        countries.Add("Italy", Resources.Load<Sprite>("Italy"));
        countries.Add("Kosovo", Resources.Load<Sprite>("Kosovo"));
        countries.Add("Latvia", Resources.Load<Sprite>("Latvia"));
        countries.Add("Liechtenstein", Resources.Load<Sprite>("Liechtenstein"));
        countries.Add("Lithuania", Resources.Load<Sprite>("Lithuania"));
        countries.Add("Luxembourg", Resources.Load<Sprite>("Luxembourg"));
        countries.Add("Macedonia", Resources.Load<Sprite>("Macedonia"));
        countries.Add("Malta", Resources.Load<Sprite>("Malta"));
        countries.Add("Moldova", Resources.Load<Sprite>("Moldova"));
        countries.Add("Monaco", Resources.Load<Sprite>("Monaco"));
        countries.Add("Montenegro", Resources.Load<Sprite>("Montenegro"));
        countries.Add("Netherlands", Resources.Load<Sprite>("Netherlands"));
        countries.Add("Norway", Resources.Load<Sprite>("Norway"));
        countries.Add("Poland", Resources.Load<Sprite>("Poland"));
        countries.Add("Portugal", Resources.Load<Sprite>("Portugal"));
        countries.Add("Romania", Resources.Load<Sprite>("Romania"));
        countries.Add("San Marino", Resources.Load<Sprite>("San Marino"));
        countries.Add("Serbia", Resources.Load<Sprite>("Serbia"));
        countries.Add("Slovakia", Resources.Load<Sprite>("Slovakia"));
        countries.Add("Slovenia", Resources.Load<Sprite>("Slovenia"));
        countries.Add("Spain", Resources.Load<Sprite>("Spain"));
        countries.Add("Sweden", Resources.Load<Sprite>("Sweden"));
        countries.Add("Switzerland", Resources.Load<Sprite>("Switzerland"));
        countries.Add("United Kingdom", Resources.Load<Sprite>("United Kingdom"));
        countries.Add("Vatican City", Resources.Load<Sprite>("Vatican City"));
        countries.Add("Turkey", Resources.Load<Sprite>("Turkey"));
        
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
    }


    public void GenerateTheThingiemcJigs()
    {
        //set the positions of the options
        int pos = 0;
        pos = (int)Random.Range(0, 3);
        option1.transform.position = positions[pos].transform.position;
        option2.transform.position = positions[(pos + 1) % 3].transform.position;
        option3.transform.position = positions[(pos + 2) % 3].transform.position;

        //set the country image
        int countryIndex = (int)(Random.Range(0, 46));
        countryImage.GetComponent<Image>().sprite = countries[(options[countryIndex])];

        //set the options
        int rand = 0;
        int lastRand = 0;
        rand = (int)(Random.Range(0, 46));
        lastRand = rand;
        option1.GetComponent<Button>().SetText(options[countryIndex]);
        option1.GetComponent<Button>().isRight = true;
        while (rand == lastRand || countryIndex == rand)
        {
            rand = (int)(Random.Range(0, 46));
        }
        option2.GetComponent<Button>().SetText(options[rand]);
        lastRand = rand;
        while (rand == lastRand || countryIndex == rand)
        {
            rand = (int)(Random.Range(0, 46));
        }
        option3.GetComponent<Button>().SetText(options[rand]);
    }
}
