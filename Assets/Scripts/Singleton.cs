using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton
{
    private static Singleton instance;
    
    [HideInInspector]public string[] EUoptions = new string[46];
    [HideInInspector]public string[] NLPoptions = new string[12];

    public bool EU;
    public bool NL;

    public int score;

    public static Singleton Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
    }

    private Singleton()
    {
        //initialize fields
        score = 0;
        EU = false;
        NL = false;

        //add all the European countres to the array
        EUoptions[0]  = "Albania";
        EUoptions[1]  = "Andorra";
        EUoptions[2]  = "Austria";
        EUoptions[3]  = "Azerbaijan";
        EUoptions[4]  = "Belarus";
        EUoptions[5]  = "Belgium";
        EUoptions[6]  = "Bosnia and Herzegovina";
        EUoptions[7]  = "Bulgaria";
        EUoptions[8]  = "Croatia";
        EUoptions[9]  = "Czech Republic";
        EUoptions[10] = "Denmark";
        EUoptions[11] = "Estonia";
        EUoptions[12] = "Finland";
        EUoptions[13] = "France";
        EUoptions[14] = "Georgia";
        EUoptions[15] = "Germany";
        EUoptions[16] = "Greece";
        EUoptions[17] = "Hungary";
        EUoptions[18] = "Iceland";
        EUoptions[19] = "Ireland";
        EUoptions[20] = "Italy";
        EUoptions[21] = "Kosovo";
        EUoptions[22] = "Latvia";
        EUoptions[23] = "Liechtenstein";
        EUoptions[24] = "Lithuania";
        EUoptions[25] = "Luxembourg";
        EUoptions[26] = "Macedonia";
        EUoptions[27] = "Malta";
        EUoptions[28] = "Moldova";
        EUoptions[29] = "Monaco";
        EUoptions[30] = "Montenegro";
        EUoptions[31] = "Netherlands";
        EUoptions[32] = "Norway";
        EUoptions[33] = "Poland";
        EUoptions[34] = "Portugal";
        EUoptions[35] = "Romania";
        EUoptions[36] = "San Marino";
        EUoptions[37] = "Serbia";
        EUoptions[38] = "Slovakia";
        EUoptions[39] = "Slovenia";
        EUoptions[40] = "Spain";
        EUoptions[41] = "Sweden";
        EUoptions[42] = "Switzerland";
        EUoptions[43] = "United Kingdom";
        EUoptions[44] = "Vatican City";
        EUoptions[45] = "Turkey";

        //add all the Dutch provinces to the array
        NLPoptions[0]  = "Drenthe";
        NLPoptions[1]  = "Flevoland";
        NLPoptions[2]  = "Friesland";
        NLPoptions[3]  = "Gelderland";
        NLPoptions[4]  = "Groningen";
        NLPoptions[5]  = "Limburg";
        NLPoptions[6]  = "Noord-Brabant";
        NLPoptions[7]  = "Noord-Holland";
        NLPoptions[8]  = "Overijssel";
        NLPoptions[9]  = "Utrecht";
        NLPoptions[10] = "Zeeland";
        NLPoptions[11] = "Zuid-Holland";
    }
}
