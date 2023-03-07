using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton
{
    private static Singleton instance;
    
    [HideInInspector]public string[] EUoptions = new string[43];
    [HideInInspector]public string[] NLPoptions = new string[12];

    public bool EU;
    public bool NL;

    public bool muted;

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
        muted = false;

        //add all the European countres to the array
        EUoptions[0]  = "Albanië";
        EUoptions[1]  = "Andorra";
        EUoptions[2]  = "Oostenrijk";
        EUoptions[3]  = "Wit Rusland";
        EUoptions[4]  = "België";
        EUoptions[5]  = "Bosnië and Herzegovina";
        EUoptions[6]  = "Bulgarije";
        EUoptions[7]  = "Kroatië";
        EUoptions[8]  = "Tsjechië";
        EUoptions[9]  = "Denemarken";
        EUoptions[10] = "Estland";
        EUoptions[11] = "Finland";
        EUoptions[12] = "Frankrijk";
        EUoptions[13] = "Duitsland";
        EUoptions[14] = "Griekenland";
        EUoptions[15] = "Hongarije";
        EUoptions[16] = "IJsland";
        EUoptions[17] = "Ierland";
        EUoptions[18] = "Italië";
        EUoptions[19] = "Kosovo";
        EUoptions[20] = "Letland";
        EUoptions[21] = "Liechtenstein";
        EUoptions[22] = "Litouwen";
        EUoptions[23] = "Luxemburg";
        EUoptions[24] = "Noord Macedonië";
        EUoptions[25] = "Malta";
        EUoptions[26] = "Moldavië";
        EUoptions[27] = "Monaco";
        EUoptions[28] = "Montenegro";
        EUoptions[29] = "Nederland";
        EUoptions[30] = "Noorwegen";
        EUoptions[31] = "Polen";
        EUoptions[32] = "Portugal";
        EUoptions[33] = "Roemenië";
        EUoptions[34] = "San Marino";
        EUoptions[35] = "Servië";
        EUoptions[36] = "Slowakije";
        EUoptions[37] = "Slovenië";
        EUoptions[38] = "Spanje";
        EUoptions[39] = "Zweden";
        EUoptions[40] = "Zwitserland";
        EUoptions[41] = "Verenigd Koninkrijk";
        EUoptions[42] = "Vaticanstad";

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
