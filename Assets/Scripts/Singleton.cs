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
        EUoptions[0]  = "Albanië";
        EUoptions[1]  = "Andorra";
        EUoptions[2]  = "Oostenrijk";
        EUoptions[3]  = "Azerbeidzjan";
        EUoptions[4]  = "Wit Rusland";
        EUoptions[5]  = "België";
        EUoptions[6]  = "Bosnië and Herzegovina";
        EUoptions[7]  = "Bulgarije";
        EUoptions[8]  = "Kroatië";
        EUoptions[9]  = "Tsjechië";
        EUoptions[10] = "Denemarken";
        EUoptions[11] = "Estland";
        EUoptions[12] = "Finland";
        EUoptions[13] = "Frankrijk";
        EUoptions[14] = "Georgië";
        EUoptions[15] = "Duitsland";
        EUoptions[16] = "Griekenland";
        EUoptions[17] = "Hongarije";
        EUoptions[18] = "IJsland";
        EUoptions[19] = "Ierland";
        EUoptions[20] = "Italië";
        EUoptions[21] = "Kosovo";
        EUoptions[22] = "Letland";
        EUoptions[23] = "Liechtenstein";
        EUoptions[24] = "Litouwen";
        EUoptions[25] = "Luxemburg";
        EUoptions[26] = "Noord Macedonië";
        EUoptions[27] = "Malta";
        EUoptions[28] = "Moldavië";
        EUoptions[29] = "Monaco";
        EUoptions[30] = "Montenegro";
        EUoptions[31] = "Nederland";
        EUoptions[32] = "Noorwegen";
        EUoptions[33] = "Polen";
        EUoptions[34] = "Portugal";
        EUoptions[35] = "Roemenië";
        EUoptions[36] = "San Marino";
        EUoptions[37] = "Servië";
        EUoptions[38] = "Slowakije";
        EUoptions[39] = "Slovenië";
        EUoptions[40] = "Spanje";
        EUoptions[41] = "Zweden";
        EUoptions[42] = "Zwitserland";
        EUoptions[43] = "Verenigd Koninkrijk";
        EUoptions[44] = "Vaticanstad";
        EUoptions[45] = "Turkije";

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
