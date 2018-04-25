using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            string bigStringToList = @"Žinote, tą jausmą, kai savaitgalį norisi pamiegoti ilgiau, bet kaimynai anksti pradeda remontuoti savo namus? Gręžimas, kalimas, keiksmai ir labai triukšmingi įrankiai - viso to pakanka sugadinti jūsų dienai. Tačiau visa tai - niekis, palyginti su didžiausiu žmogaus sukurtu garsu.
Motociklo garsas vos už 8 metrų siekia tik 90 dB 
©Piero | commons.wikimedia.org
Žmonės yra labai triukšmingi padarai. Kartais šalia judrios gatvės sunku ir susikalbėti, o didžiųjų miestų gyventojai labai retai gali patirti visišką tylą. Akustinė tarša, beje, labai kenkia sveikatai. Žmogui reikia poilsio, o triukšme jis apskritai negalimas. Net jei jūs išmokstate triukšmą ignoruoti, jis vis tiek jus veikia ir trumpina jūsų gyvenimą. Tačiau miesto triukšmas, palyginti su garsiausiais mūsų sukeltais garsais, nėra toks jau blogas.
Šnabždesys sukelia maždaug 20 decibelų garsą - jo išgirsti per keletą metrų jau neįmanoma. Daugelis paukščių gieda maždaug 44 dB garsu - vėlgi, jūsų langai tą triukšmą blokuoja. Kita vertus, mažai kas skundžiasi paukščių giesmėmis. Įprastas pokalbis namuose sukelia 50 dB garsą, o geras dulkių siurblys - 70. Maždaug čia prasideda garsai, kurių mes negalime pakęsti ilgesnį laiką. Štai gero motociklo garsas vos už 8 metrų siekia net 90 decibelų. Tokį garsą sukėlė ir Čeliabinsko meteoritas už 650 km. Tačiau tokie garsai nekenkia jau vien todėl, kad tokiame triukšme žmogus ilgai nebūna.
Tuo tarpu tokiais įrankiais kaip pneumatinis kūjis tenka pasidarbuoti ilgiau - jis sukelia 100-120 dB garsą, priklausomai nuo to, su kokiomis medžiagomis dirbama. Lėktuvnešio denyje dažnai pasigirsta 140 dB garsas, todėl visi ten dirbantys žmonės dėvi garsą blokuojančias ausines. NASA akustinių tyrimų kameroje palydovai išbandomi net 163 dB garsu, kurį žmonėms ilgą laiką ištverti būtų jau labai sunku. Tačiau šalia „Saturn V“ raketos paleidimo aikštelės galima užfiksuoti net 204 dB garsą, kuris gali sukelti negrįžtamą žalą sveikatai.
Povandeninio laivo sonaras skleidžia nepaprastai didelį garsą 
©Paul Halliwell/MOD | commons.wikimedia.org
Taigi, raketos yra nepaprastai triukšmingos, bet tokios jos neturi būti. Ateityje galbūt bus išrasti kitokie raketiniai varikliai, kurie tokio didžiulio garso nesukels. Kitaip tariant, tas milžiniškas garsas nėra būtinas raketos veikimui. Tačiau didžiausias žmogaus sukeltas garsas iš tiesų yra būtinas. Tai - povandeninių laivų sonarai.
Garsas vandenyje sklinda visiškai kitaip nei ore. Bangos vandenyje yra daug stipresnės, todėl jas nesunku panaudoti savo reikmėms. Banginiai naudoja echolokaciją. Jie skleidžia garsus ir jaučia kaip bangos atsimuša į įvairius objektus ir sugrįžta. Banginių skleidžiamas garsas yra apie 175 dB, tačiau jie neprilygsta povandeninių laivų sonarams, kurie skleidžia didesnius nei 230 dB signalus.
Šis garsas yra toks stiprus, kad nardytojai lekia iš vandens, o banginiai užplaukia ant sausumos. Iš tiesų, povandeninių laivų sonarai veikia panašiai, kaip ir banginių echolokacijos sistema - sonarai stebi sugrįžtantį aidą ir pagal jį nustato įvairių objektų formas ir atstumą. Sonaro veikimą gali išgirsti kiti povandeniniai laivai, todėl tenka pasitelkti strategiją ir savo sonarą naudoti tik tada, kai tai daryti saugu.
Jei žmonės norėtų panašų garsą atkurti sausumoje, tikriausiai reikėtų pasitelkti visą eilę sprogimų. O štai gamta tai gali padaryti ugnikalnio išsiveržimu. Manoma, kad 1883 metų Karakatau išsiveržimas sukėlė kur kas didesnį garsą nei povandeninio laivo sonaras, nes net už 160 km garso stiprumas siekė 172 dB.";

            List<string> text = bigStringToList.Split(' ').ToList();

            Console.WriteLine("1. Parodyti originalų tekstą;");
            Console.WriteLine("2. Pašalinti žodį iš teksto;");
            Console.WriteLine("3. Kiek elementų turi tekstas?");
            Console.WriteLine("4. Kiek pasikartojančių žodžių turi tekstas?");
            // Console.ReadKey();

            int chosenMenu = int.Parse(Console.ReadLine());

            switch (chosenMenu)
            {
                case 1:
                    printList(text);
                    break;
                case 2:
                    Console.Write("Koki zodi pasalint?");
                    string wordToRemoveFromList = Convert.ToString(Console.ReadLine());
                    text.Remove(wordToRemoveFromList);
                    printList(text);
                    break;
                case 3:
                    int wordCount = text.Count();
                    Console.WriteLine("Tekstas turi " + wordCount + " elementu.");
                    Console.ReadKey();
                    break;
                case 4:
                    Console.WriteLine("Tekstas turi " + countWords(text) + " žodžių.");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Netinkamas pasirinkimas!");
                    Console.ReadKey();
                    break;
            }

        }

        static void printList(List<string> text)
        {
            foreach (string tekst in text)

                Console.Write(" " + tekst);
            Console.WriteLine("\n============================================");

            Console.ReadKey();
        }
        static string countWords(List<string> text)
        {
            int dublicatesWrodsInText = 0;
            for (int i = 0; i < text.Count; i++)
            {
                for (int j = i + 1; j < text.Count; j++)
                {
                    if (text[i] == text[j] && i != j)
                    {
                        dublicatesWrodsInText++;
                    }
                }
            }
            return dublicatesWrodsInText.ToString();
        }

    }
}