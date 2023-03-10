﻿using System;
using System.Collections.Generic;

class KodePos
{
    private Dictionary<string, string> tableKodePos = new Dictionary<string, string>()
    {
        {"Batununggal", "40266"},
        {"Kujangsari", "40287"},
        {"Mengger", "40267"},
        {"Wates  ", "40256"},
        {"Cijaura", "40287"},
        {"Jatisari", "40286"},
        {"Margasari", "40286"},
        {"Sekejati", "40286"},
        {"Kebonwaru", "40272"},
        {"Maleer", "40274"},
        {"Samoja", "40273"}
    };

    public string getKodePos(string kodepos)
    {
        if (tableKodePos.ContainsKey(kodepos))
        {
            return tableKodePos[kodepos];
        }
        else
        {
            return "";
        }
    }

    public void showAllKodePos()
    {
        foreach (KeyValuePair<string, string> keyval in tableKodePos)
        {
            Console.WriteLine("| " + keyval.Key + "\t |   "+ keyval.Value + "  |");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        KodePos kodepos = new KodePos();

        Console.WriteLine("|   Kelurahan    | Kode Pos |");
        Console.WriteLine("");

        kodepos.showAllKodePos();
    }
}