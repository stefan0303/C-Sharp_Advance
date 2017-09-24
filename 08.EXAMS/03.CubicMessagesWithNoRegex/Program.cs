using System;

class Program
{
    static void Main()
    {
        string text = Console.ReadLine();
        int n = int.Parse(Console.ReadLine());
        while (text != "Over!")
        {
            string digits = "";
            string code = "";
            string notLetter = "";

            for (int i = 0; i < text.Length; i++)
            {

                while (i < text.Length && Char.IsDigit(text[i]))
                {
                    digits += text[i];
                    i++;
                    if (i == text.Length)
                    {
                        break;
                    }

                }
                while (i < text.Length && Char.IsLetter(text[i]))
                {
                    code += text[i];
                    i++;
                    if (i == text.Length)
                    {
                        break;
                    }
                }
                while (i < text.Length && !Char.IsLetter(text[i]))
                {
                    notLetter += text[i];
                    i++;
                    if (i == text.Length)
                    {
                        break;
                    }
                }
            }
            string validNewString = digits + code + notLetter;
            //is valid
            if (validNewString == text && digits.Length > 0 && code.Length > 0 && notLetter.Length > 0 && n == code.Length)//is valid message
            {
                string allDigits = Convert.ToString(digits);
                for (int i = 0; i < notLetter.Length; i++)
                {
                    if (Char.IsDigit(notLetter[i]))
                    {
                        allDigits += Convert.ToString(notLetter[i]);

                    }
                }
                string print = code + " == ";

                for (int i = 0; i < allDigits.Length; i++)
                {
                    int index = (int)Char.GetNumericValue(allDigits[i]);//char to int

                    if (index >= code.Length)//?
                    {
                        print += " ";

                    }
                    else
                    {
                        print += code[index];
                    }
                }

                Console.WriteLine(print);

            }

            text = Console.ReadLine();
            if (text == "Over!")
            {
                break;

            }
            n = int.Parse(Console.ReadLine());
        }
    }
}

