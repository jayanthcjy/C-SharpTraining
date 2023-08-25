using System;


public class Logic
    {
    public string FloatAddition(string float1,string float2)
    {

        string[] float1Array = float1.Split('.');
        string[] float2Array = float2.Split('.');

        int int1 = Convert.ToInt32(float1Array[0]);
        int int2 = Convert.ToInt32(float2Array[0]);
        string tempdecimal1 = "0." + float1Array[1];
        string tempdecimal2 = "0." + float2Array[1];
        float decimal1 = float.Parse(tempdecimal1);
        float decimal2 = float.Parse(tempdecimal2);

        Console.WriteLine(int1 + " " + int2);
        Console.WriteLine(decimal1 + " " + decimal2);

        int n1 = int1, n2 = int2;
        float n3 = decimal1, n4 = decimal2;
        string b1 = string.Empty;
        while (n1 != 0)
        {
            b1 = n1 % 2 + b1;
            n1 /= 2;
        }
        string b2 = string.Empty;
        while (n2 != 0)
        {
            b2 = n2 % 2 + b2;
            n2 /= 2;
        }
        string b3 = string.Empty, b4 = string.Empty;
        int i = 9;
        while (i != 0 && n3 != 0)
        {
            n3 = n3 * 2;
            if (n3 == 1)
            {
                b3 = b3 + 1;
                break;
            }
            if (n3 > 1)
            {
                b3 = b3 + 1;
                n3 = n3 - 1;
            }
            else
            {
                b3 = b3 + 0;

            }
            i--;
        }
        i = 9;
        while (i != 0 && n4 != 0)
        {
            n4 = n4 * 2;
            if (n4 == 1)
            {
                b4 = b4 + 1;
                break;
            }
            if (n4 > 1)
            {
                b4 = b4 + 1;
                n4 = n4 - 1;
            }
            else
            {
                b4 = b4 + 0;
            }
            i--;
        }

        int b1len = b1.Length;
        int b2len = b2.Length;
        int b3len = b3.Length;
        int b4len = b4.Length;

        if (b1len >= b2len)
        {
            int j = b1len - b2len;
            while (j != 0)
            {
                b2 = 0 + b2;
                j--;
            }
            b1 = 0 + b1;
            b2 = 0 + b2;
        }
        else
        {
            int j = b2len - b1len;
            while (j != 0)
            {
                b1 = 0 + b1;
                j--;
            }
            b1 = 0 + b1;
            b2 = 0 + b2;
        }

        if (b3len >= b4len)
        {
            int j = b3len - b4len;
            while (j != 0)
            {
                b4 = b4 + 0;
                j--;
            }
        }
        else
        {
            int j = b4len - b3len;
            while (j != 0)
            {
                b3 = b3 + 0;
                j--;
            }

        }
        int c = 0;
        string deci = "";
        for (i = 8; i >= 0; i--)
        {
            if (c == 0 && (b3[i] == '0' && b4[i] == '0'))
            {
                deci = "0" + deci;
                continue;
            }
            else if (c == 1 && (b3[i] == '0' && b4[i] == '0'))
            {
                deci = "1" + deci;
                c = 0;
                continue;
            }
            else if (c == 1 && ((b3[i] == '1' && b4[i] == '0') || (b3[i] == '0' && b4[i] == '1')))
            {
                deci = "0" + deci;
                c = 1;
                continue;
            }
            else if (c == 0 && ((b3[i] == '1' && b4[i] == '0') || (b3[i] == '0' && b4[i] == '1')))
            {
                deci = "1" + deci;
                c = 0;
                continue;
            }

            else if (c == 0 && ((b3[i] == '1' && b4[i] == '1')))
            {
                deci = "0" + deci;
                c = 1;
                continue;
            }
            else if (c == 1 && ((b3[i] == '1' && b4[i] == '1')))
            {
                deci = "1" + deci;
                c = 1;
                continue;
            }

        }

        string n = "";
        int len = b1.Length;
        for (i = len - 1; i >= 0; i--)
        {
            if (c == 0 && (b1[i] == '0' && b2[i] == '0'))
            {
                n = "0" + n;
                continue;
            }
            else if (c == 1 && (b1[i] == '0' && b2[i] == '0'))
            {
                n = "1" + n;
                c = 0;
                continue;
            }
            else if (c == 1 && ((b1[i] == '1' && b2[i] == '0') || (b1[i] == '0' && b2[i] == '1')))
            {
                n = "0" + n;
                c = 1;
                continue;
            }
            else if (c == 0 && ((b1[i] == '1' && b2[i] == '0') || (b1[i] == '0' && b2[i] == '1')))
            {
                n = "1" + n;
                c = 0;
                continue;
            }

            else if (c == 0 && ((b1[i] == '1' && b2[i] == '1')))
            {
                n = "0" + n;
                c = 1;
                continue;
            }
            else if (c == 1 && ((b1[i] == '1' && b2[i] == '1')))
            {
                n = "1" + n;
                c = 1;
                continue;
            }

        }


        double ansN = 0;
        int ind = 0;
        for (int idx = n.Length - 1; idx >= 0; idx--)
        {
            if (n[idx] == '1')
            {
                ansN += Math.Pow(2, ind);
            }
            ind++;
        }
        double ansD = 0;
         ind = 0;
        for (int d = 0; d <= deci.Length - 1; d++)
        {
           
                if (deci[d] == '1')
                {
                    ansD += Math.Pow(2, ind);
               
                }
                ind--;
          
        }
        string tempAnsD = Convert.ToString(ansD);



        Console.WriteLine(int1 + " " + decimal1 + " " + int2 + " " + decimal2 + " " + b1 + " " + b2 + " " + b3 + " " + b4);
        Console.WriteLine(n + " " + deci + " " + ansN + tempAnsD.Substring(tempAnsD.IndexOf('.')));


        return "s";
    }
    }

