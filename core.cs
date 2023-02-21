using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; 

public class core : MonoBehaviour
{
    public int isBattle = 0; 
    public hegemonia heg;
    public borgo bor;
    public string bot1; 
    public string bot2;
    //public int[] id = new int[40];
    public ArrayList id = new ArrayList() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }; 

    void Start()
    {
        //standardowe na start
        heg = FindObjectsOfType<hegemonia>()[0];
        bor = FindObjectsOfType<borgo>()[0];

        //postawianie sztabu pierwszego bota
        switch (bot1)
        {
            case "Borgo":
                bor.which = 1;
                bor.oponent = bot2;
                bor.isLife = true; 
                bor.StartGame();
                GetId(1);
                UnityEngine.Debug.Log($"core Start(): bor.StartGame(): {id[2]} {id[3]} {id[4]} {id[5]} {id[6]} {id[7]} {id[8]} {id[9]} {id[10]} {id[11]} {id[12]} {id[13]} {id[14]} {id[15]} {id[16]} {id[17]} {id[18]} {id[19]} {id[20]} {id[21]} {id[22]} {id[23]} {id[24]} {id[25]} {id[26]} {id[27]} {id[28]} {id[29]} {id[30]} {id[31]} {id[32]} {id[33]} {id[34]} {id[35]} {id[36]} {id[37]} {id[38]} {id[39]}");
                break;
            case "Hegemonia":
                heg.which = 1;
                heg.oponent = bot2;
                heg.isLife = true;
                heg.StartGame();
                GetId(1);
                UnityEngine.Debug.Log($"core Start(): heg.StartGame(): {id[2]} {id[3]} {id[4]} {id[5]} {id[6]} {id[7]} {id[8]} {id[9]} {id[10]} {id[11]} {id[12]} {id[13]} {id[14]} {id[15]} {id[16]} {id[17]} {id[18]} {id[19]} {id[20]} {id[21]} {id[22]} {id[23]} {id[24]} {id[25]} {id[26]} {id[27]} {id[28]} {id[29]} {id[30]} {id[31]} {id[32]} {id[33]} {id[34]} {id[35]} {id[36]} {id[37]} {id[38]} {id[39]}");
                break;
        }
        //postawianie sztabu drógiego bota
        switch (bot2)
        {
            case "Borgo":
                bor.which = 2;
                bor.oponent = bot1;
                bor.isLife = true;
                bor.StartGame();
                GetId(2);
                UnityEngine.Debug.Log($"core Start(): bor.StartGame(): {id[2]} {id[3]} {id[4]} {id[5]} {id[6]} {id[7]} {id[8]} {id[9]} {id[10]} {id[11]} {id[12]} {id[13]} {id[14]} {id[15]} {id[16]} {id[17]} {id[18]} {id[19]} {id[20]} {id[21]} {id[22]} {id[23]} {id[24]} {id[25]} {id[26]} {id[27]} {id[28]} {id[29]} {id[30]} {id[31]} {id[32]} {id[33]} {id[34]} {id[35]} {id[36]} {id[37]} {id[38]} {id[39]}");
                break;
            case "Hegemonia":
                heg.which = 2;
                heg.oponent = bot1;
                heg.isLife = true;
                heg.StartGame();
                GetId(2); 
                UnityEngine.Debug.Log($"core Start(): heg.StartGame(): {id[2]} {id[3]} {id[4]} {id[5]} {id[6]} {id[7]} {id[8]} {id[9]} {id[10]} {id[11]} {id[12]} {id[13]} {id[14]} {id[15]} {id[16]} {id[17]} {id[18]} {id[19]} {id[20]} {id[21]} {id[22]} {id[23]} {id[24]} {id[25]} {id[26]} {id[27]} {id[28]} {id[29]} {id[30]} {id[31]} {id[32]} {id[33]} {id[34]} {id[35]} {id[36]} {id[37]} {id[38]} {id[39]}");
                break;
        }

        //zrobienie 4x na zmianê ruchu ka¿dego bota
        //for (int j = 0; j < 4; j++)
        while(isBattle < 2)
        {
            switch (bot1)
            {
                case "Hegemonia":
                    heg.Movement();
                    for (int i = 0; i < 40; i++)
                    {
                        id[i] = heg.id[i];
                    }
                    break;
                case "Borgo":
                    bor.Movement();
                    for (int i = 0; i < 40; i++)
                    {
                        id[i] = bor.id[i];
                    }
                    break;
            }
            switch (bot2)
            {
                case "Hegemonia":
                    heg.Movement();
                    for (int i = 0; i < 40; i++)
                    {
                        if (i % 2 == 0)
                        {
                            id[i] = Int32.Parse(heg.id[i].ToString()) * -1;
                        }
                        else
                        {
                            id[i] = heg.id[i];
                        }
                    }
                    break;
                case "Borgo":
                    bor.Movement();
                    for (int i = 0; i < 40; i++)
                    {
                        if (i % 2 == 0)
                        {
                            id[i] = Int32.Parse(bor.id[i].ToString()) * -1;
                        }
                        else
                        {
                            id[i] = bor.id[i];
                        }
                    }
                    break;
            }
        }
    }

    public void Battle()
    {
        isBattle++; 
        for(int i = 0; i < 4; i++)
        {
            UnityEngine.Debug.Log($"core Battle(); i = {i}");
            switch (bot1)
            {
                case "Borgo":
                    bor.InitiativeBattle(i);
                    break;
                case "Hegemonia":
                    heg.InitiativeBattle(i);
                    break;
            }
            switch (bot2)
            {
                case "Borgo":
                    bor.InitiativeBattle(i);
                    break;
                case "Hegemonia":
                    heg.InitiativeBattle(i);
                    break;
            }
            switch (bot1)
            {
                case "Borgo":
                    bor.DeleteAll();
                    if (!bor.isHQLife(false))
                    {
                        lose("Borgo");
                    }
                    break;
                case "Hegemonia":
                    heg.DeleteAll();
                    if (!heg.isHQLife(false))
                    {
                        lose("Hegemonia");
                    }
                    break;
            }
            switch (bot2)
            {
                case "Borgo":
                    bor.DeleteAll();
                    if (!bor.isHQLife(false))
                    {
                        lose("Borgo");
                    }
                    break;
                case "Hegemonia":
                    heg.DeleteAll();
                    if (!heg.isHQLife(false))
                    {
                        lose("Hegemonia");
                    }
                    break;
            }
        }
    }

    public void lose(string name)
    {
        UnityEngine.Debug.Log($"core lose({name})"); 
    }

    public void Attack(string name, int idHex, int health)
    {
        UnityEngine.Debug.Log($"core Attack({name}, {idHex}, {health})");
        switch (bot1)
        {
            case "Hegemonia":
                if (name != "Hegemonia")
                {
                    GetId(2);
                    heg.Attack(idHex, health);
                }
                break;
            case "Borgo":
                if (name != "Borgo")
                {
                    GetId(2);
                    bor.Attack(idHex, health);
                }
                break;
        }
        switch (bot2)
        {
            case "Hegemonia":
                if (name != "Hegemonia")
                {
                    GetId(1);
                    heg.Attack(idHex, health);
                }
                break;
            case "Borgo":
                if (name != "Borgo")
                {
                    GetId(1);
                    bor.Attack(idHex, health);
                }
                break;
        }
    }

    public void GetId(int s)
    {
        switch (s)
        {
            case 1:
                switch (bot1)
                {
                    case "Hegemonia":
                        for (int i = 0; i < 40; i++)
                        {
                            id[i] = heg.id[i];
                        }
                        break;
                    case "Borgo":
                        for (int i = 0; i < 40; i++)
                        {
                            id[i] = bor.id[i];
                        }
                        break;
                }
                break;
            case 2:
                switch (bot2)
                {
                    case "Hegemonia":
                        for (int i = 0; i < 40; i++)
                        {
                            if (i % 2 == 0)
                            {
                                id[i] = Int32.Parse(heg.id[i].ToString()) * -1;
                            }
                            else
                            {
                                id[i] = heg.id[i];
                            }
                        }
                        break;
                    case "Borgo":
                        for (int i = 0; i < 40; i++)
                        {
                            if (i % 2 == 0)
                            {
                                id[i] = Int32.Parse(bor.id[i].ToString()) * -1;
                            }
                            else
                            {
                                id[i] = heg.id[i];
                            }
                        }
                        break;
                }
                break; 
        }
    }

    public void Grenade(string name, int idHex)
    {
        UnityEngine.Debug.Log($"core Grenade({name}, {idHex})"); 
        switch (bot1)
        {
            case "Hegemonia":
                if(name != "Hegemonia")
                {
                    GetId(2); 
                    heg.GrenadeF(idHex); 
                }
                break;
            case "Borgo":
                if(name != "Borgo")
                {
                    GetId(2);
                    bor.GrenadeF(idHex); 
                }
                break; 
        }
        switch (bot2)
        {
            case "Hegemonia":
                if(name != "Hegemonia")
                {
                    GetId(1);
                    heg.GrenadeF(idHex); 
                }
                break;
            case "Borgo":
                if(name != "Borgo")
                {
                    GetId(1);
                    bor.GrenadeF(idHex); 
                }
                break; 
        }
    }

    public void Pushing(string name, int idHex)
    {
        UnityEngine.Debug.Log($"core Pushing({name}, {idHex})"); 
        //przepychanie odpowiedniego elementu odpowiedniego bota
        switch (bot1)
        {
            case "Hegemonia":
                switch (bot2){
                    case "Hegemonia":
                        if(name != "hegemonia")
                        {
                            heg.Pushing(idHex);
                        }
                        else
                        {
                            bor.Pushing(idHex); 
                        }
                        break;
                    case "Borgo":
                        if(name != "borgo")
                        {
                            bor.Pushing(idHex); 
                        }
                        else
                        {
                            heg.Pushing(idHex); 
                        }
                        break;
                }
                break;
            case "Borgo":
                switch (bot2)
                {
                    case "Hegemonia":
                        if (name != "hegemonia")
                        {
                            heg.Pushing(idHex);
                        }
                        else
                        {
                            bor.Pushing(idHex); 
                        }
                        break;
                    case "Borgo":
                        if (name != "borgo")
                        {
                            bor.Pushing(idHex);
                        }
                        else
                        {
                            heg.Pushing(idHex); 
                        }
                        break;
                }
                break;
        }
    }
}
