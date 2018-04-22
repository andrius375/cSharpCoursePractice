using System;

class Program
{

     static void Main()
        {
            {
                // TODO : keiskite FROM..TO skaicius pagal tai kiek spesite padaryt uzduociu. (-19...19, -99..99, ir tt.)
                // min skaicius 
                const int FROM_NUMBER = -19;
                // max skaicius 
                const int TO_NUMBER = 19;

                string inputString = "";
                int inputNumber = 0;

                Console.Write("Sveiki!");
                while (inputString != " ")
                {
                    Console.Write("\n(Enter SPACE to exit.)\nIveskite skaiciu:");
                    inputString = Console.ReadLine();
                    if (checkIfGoodNumber(inputString))
                    {
                        Console.WriteLine("Skaicius teisingas!");
                        inputNumber = Convert.ToInt32(inputString);
                        if (checkIfNumberInRange(FROM_NUMBER, TO_NUMBER, inputNumber))
                        {
                            if (inputNumber >= 0 && inputNumber <= 19) // nuo 0 iki 19
                            {
                                Console.WriteLine("Skaicius {0} zodziais: {1}", inputNumber, changeNumberToText(inputNumber));
                            }
                            else if (inputNumber < 0 && inputNumber >= -10)// nuo -1 iki -10
                            {
                                Console.WriteLine("Skaicius {0} zodziais: minus {1}", inputNumber, changeNumberToText(inputNumber));
                            }
                            else if (inputNumber < -10 && inputNumber > -20)// nuo -11 iki -19
                            {
                                Console.WriteLine("Skaicius {0} zodziais: minus {1}", inputNumber, changeNumberToText(inputNumber));
                            }
                        }
                        else
                        {
                            Console.WriteLine("Blogas skaicius {0}, prasau ivesti skaiciu reziuose: {1}..{2}", inputString, FROM_NUMBER, TO_NUMBER);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ivesti duomenys:{0} nera skaicius!", inputString);
                    }
                }

                Console.WriteLine("\nAciu uz demesi, viso gero.");
                Console.ReadKey();
            }
        }

        // bendra funkcija apjungti visom funkcijom kurias jus sukursit.
        static string changeNumberToText(int number)
        {
            // TODO : pakeiskite sita funkcija pagal savo poreiki. (tiek kiek skaiciu spesite apdorot.)
            string changing = "";
            if (number > -11 && number < 11)
            {
                changing = keistiVienetus(number);
            }
            else if (number < -10 && number > -20 || number > 10 && number < 20)
            {
                changing = keistiDesimtis(number);
            }
            else if (number < -19 && number > -100 || number > 19 && number < 100)
            {
                changing = keistiDesimtis(number);
            }
            return changing;

        }

        // funkcija gauna string skaiciu, patikrina ar skaicius teisingu formatu. Pvz: "123", "-123" grazina true. "12a3", "1-23" grazina false.
        static bool checkIfGoodNumber(string dataToCheck)
        {
            //throw new NotImplementedException("TODO: grazinkite true, jei tekstas yra teisingas skaicius.");
            bool tikrinimas = false;
            for (int i = 0; i < dataToCheck.Length; i++)
            {
                if (i == 0)
                {
                    char simbolis = dataToCheck[i];
                    if (simbolis != 48 && simbolis != 49 && simbolis != 50 && simbolis != 51 && simbolis != 52 && simbolis != 53 && simbolis != 54 && simbolis != 55 && simbolis != 56 && simbolis != 57)
                    {
                        if (simbolis == 45)
                        {
                            tikrinimas = true;
                        }
                        else
                        {
                            tikrinimas = false;
                        }
                    }
                    else
                    {
                        tikrinimas = true;
                    }
                }
                if (i == 1)
                {
                    char simbolis = dataToCheck[i];
                    if (simbolis != 48 && simbolis != 49 && simbolis != 50 && simbolis != 51 && simbolis != 52 && simbolis != 53 && simbolis != 54 && simbolis != 55 && simbolis != 56 && simbolis != 57)
                    {
                        tikrinimas = false;
                    }
                    else
                    {
                        tikrinimas = true;
                    }
                }
                if (i == 2)
                {
                    char simbolis = dataToCheck[i];
                    if (simbolis != 48 && simbolis != 49 && simbolis != 50 && simbolis != 51 && simbolis != 52 && simbolis != 53 && simbolis != 54 && simbolis != 55 && simbolis != 56 && simbolis != 57)
                    {
                        tikrinimas = false;
                    }
                    else
                    {
                        tikrinimas = true;
                    }

                }

            }
            return tikrinimas;
        }

        // funkcija gauna true jei skaicius checkNumber yar tarp fromNumber ir toNumber (imtinai)
        private static bool checkIfNumberInRange(int fromNumber, int toNumber, int checkNumber)
        {
            // throw new NotImplementedException("TODO: Patikrinkite ar checkNumber yar tarp skaiciu fromNumber,  toNumber");
            bool arRezyje = false;
            if (checkNumber >= fromNumber && checkNumber <= toNumber)
            {
                arRezyje = true;
            }
            else
            {
                arRezyje = false;
            }
            return arRezyje;
        }

        // funkcija gauna int skaiciu, pakeicia ji i string teksta kuri zodziais nusako skaiciu. PVZ: -1684542 turi grazint - "minus vienas milijonas sesi simtai astuoniasdesimt keturi tukstanciai penki simtai keturiasdiasimt du"
        static string keistiVienetus(int number)
        {
            //  throw new NotImplementedException("TODO: grazinkite skaiciu -9...9 zodziais.");
            string vienetaiTekstas = "";
            if (number == -1 || number == 1)
            {
                vienetaiTekstas = "vienas";
            }
            if (number == -2 || number == 2)
            {
                vienetaiTekstas = "du";
            }
            if (number == -3 || number == 3)
            {
                vienetaiTekstas = "trys";
            }
            if (number == -4 || number == 4)
            {
                vienetaiTekstas = "keturi";
            }
            if (number == -5 || number == 5)
            {
                vienetaiTekstas = "penki";
            }
            if (number == -6 || number == 6)
            {
                vienetaiTekstas = "sesi";
            }
            if (number == -7 || number == 7)
            {
                vienetaiTekstas = "septyni";
            }
            if (number == -8 || number == 8)
            {
                vienetaiTekstas = "astuoni";
            }
            if (number == -9 || number == 9)
            {
                vienetaiTekstas = "devyni";
            }
            if (number == 0)
            {
                vienetaiTekstas = "nulis";
            }
            return vienetaiTekstas;
        }
        // TODO : sukurti funkcija kuri grazina skaiciu -19...19 zodziais - changeTeensToText
        static string keistiDesimtis(int number)
        {
            string desimtysTekstas = "";
            if (number == -11 || number == 11)
            {
                desimtysTekstas = "vienuolika";
            }
            if (number == -12 || number == 12)
            {
                desimtysTekstas = "dvylika";
            }
            if (number == -13 || number == 13)
            {
                desimtysTekstas = "trylika";
            }
            if (number == -14 || number == 14)
            {
                desimtysTekstas = "keturiolika";
            }
            if (number == -15 || number == 15)
            {
                desimtysTekstas = "penkiolika";
            }
            if (number == -16 || number == 16)
            {
                desimtysTekstas = "šešiolika";
            }
            if (number == -17 || number == 17)
            {
                desimtysTekstas = "septyniolika";
            }
            if (number == -18 || number == 18)
            {
                desimtysTekstas = "aštuoniolika";
            }
            if (number == -19 || number == 19)
            {
                desimtysTekstas = "devyniolika";
            }

            return desimtysTekstas;
        }

        // TODO : sukurti funkcija kuri grazina skaiciu -99...99 zodziais - changeTensToText

        // TODO : sukurti funkcija kuri grazina skaiciu -999...999 zodziais - changeHundredsToText

        // TODO : sukurti funkcija kuri grazina skaiciu -9999...9999 zodziais - changeThousandsToText

        // TODO : sukurti funkcija kuri grazina skaiciu -9999999...9999999 zodziais - changeMillionsToText

        // TODO : sukurti funkcija kuri grazina skaiciu -9999999999...9999999999 zodziais - changeBilllionsToText



        //Skaiciai zodziais:  
        // "minus"; 
        // "nulis", "vienas", "du", "trys", "keturi", "penki", "sesi", "septyni", "astuoni", "devyni"; 
        // "desimt", "vienualika", "dvylika", "trylika", "keturiolika", "penkiolika", "sesiolika", "septyniolika", "astuoniolika", "devyniolika"; 
        // "dvidesimt", "trisdesimt", "keturiasdesimt", "penkiasdesimt", "sesiasdesimt", "septyniasdesimt", "astuoniasdesimt", "devyniasdesimt"; 
        // "simtas", "tukstantis", "milijonas", "milijardas"; 
        // "simtai", "tukstanciai", "milijonai", "milijardai"; 
        // "simtu", "tukstanciu", "milijonu", "milijardu"; 
    }
