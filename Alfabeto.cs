using System;
// write in 2019 by maurizio.conti@fablabromagna.org

public static class Alfabeto
{
    public static bool Verifica(string input)
    {
        input = input.ToLower();
        bool pangramma=false;
        string alfabeto ="abcdefghijklmnopqrstuvwxyz";
        int[] conferma = {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1};
        int[] prova ={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        int certezza = 0;
        for (int i = 0; i < input.Length;i++)
        {
            for (int cnt = 0; cnt < alfabeto.Length;cnt++)
            {
                if(alfabeto[cnt]==input[i])
                {
                    prova[cnt] = 1;
                }
            }
        }
        for (int i = 0; i < conferma.Length; i++)
        {
            if (conferma[i] == prova[i])
            {
                certezza++;
            } 
        }
        if(certezza==26||certezza==21)
            pangramma = true;
        else
            pangramma = false;
        return pangramma;
    }
}
