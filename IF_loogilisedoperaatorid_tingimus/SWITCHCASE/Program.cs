using System;

namespace SWITCHCASE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //küsi kasutajalt kas ta soovib omale uut autot
            //kui ei, siis programm lõppeb kasutajale sõnumiga "headaega"
            //kui jah, siis küsi kasutajalt milline automudel talle meeldib
            //erista switch case abil:
            //  kui talle meeldib audi - siis ütle audi on noormuttidele
            //  kui talle meeldib volkswagen - siis ütle autobahn on su elu ja armastus
            //  kui talle meeldib lada - siis ütle ah käi potilaadale!
            //  kui talle meeldib mustang - hobustele autokuuris asja pole
            //  kui talle meeldib opel - siis ütle opeleeri kuskil mujal
            //  kui talle meeldib programmi kirjutaja lemmikmark - OPPA, SEE JUBA LÄHEB
            //(kui eelnevalt oli ülesande kirjelduses programmeerija lemmikmark, siis asenda seal see mark millegi muuga)

            //küsi kasutajalt millises riigis talle meeldiks elada
            //valikuteks anna talle: ei tea, Eesti, Läti, Leedu, saksamaa, poola, ukraina.
            //erista switch case abil riik, ning prindi konsooli selle riigi lipu jagu ridu, mis on värvitud console.backgroundcolor meetodiga
            //lipuvärve vaata googlest, kasuta võimalikult sarnaseid vasteid, üks lipp on 6 rida,
            //et kolmese triibuga lippe saaks teha (&/3=2 rida per triip)ja kahe triibuga lippe saaks teha (6/2 =3 rida per triip

            //küsi kasutajalt kas ta õpib koolis
            //kui ei, siis programm lõppeb kasutajale sõnumiga "edu tööturul"
            //kui jah, siis küsi kasutajalt mitmendas klassis ta käib
            //tee muutuja "vastus" mis hoiab meeles kasutaja vastust
            //kui klass, kus õpilane parasjagu on, asub vahemikus 1-4, siis
            //      erista switch case abil:
            //          esimeses klassis - küsi muutujasse "vastus" küsimusele "kelleks sa saada tahad?" sisend.
            //          teises klassis - küsi muutujasse "vastus" küsimusele "kas sulle koolis meeldib õppida?" sisend.
            //          kolmandas klassis - küsi muutujasse "vastus" küsimusele "kuidas kolmandas klassis läheb?" sisend.
            //          neljandas klassis - küsi muutujasse "vastus" küsimusele "kas koolis kiusatakse sind?" sisend.
            //kui klass, kus õpilane parasjagu on, asub vahemikus 5-8, siis
            //      erista switch case abil:
            //          viiendas klassis - küsi muutujasse "vastus" küsimusele "kirjuta oma sõnadega murdvõrrandi valem" sisend.
            //          kuuendas klassis - küsi muutujasse "vastus" küsimusele "kas kohustuslik kirjandus meeldib, või on ajaraiskamine?" sisend.
            //          seitsmendas klassis - küsi muutujasse "vastus" küsimusele "Kas põhikool on raske, või lihtne" sisend.
            //          kaheksandas klassis - küsi muutujasse "vastus" küsimusele "kellena sa ennast tänasel tööturul näed ja kas see mida sina teha tahad sellega kokku sobib?" sisend.
            //kui klass, kus õpilane parasjagu on, asub kõrgemal kui 8 klass, siis:
            //küsi kasutajalt niikaua kuni muutuja "vastus" tühi ei ole (tsüklis) "mis pärast kooli lõpetamist plaanis on?"
            //anna talle valikuks "ei tea", "ei kavatse kooli lõpetada", "oma vastus"
            //tsükkel käib niikaua kuni vastuses midagi on.
            //erista switch case abil:
            //  kui ta ei tea - kuva sõnum "loodan et see idee ka ükspäev tuleb"
            //  kui ei kavatse - kuva sõnum "see on halb otsus. mul on sinust kahju :c"
            //  kõige muu puhul - "oh, see on hea asi teha :D" ja sõnumisse kuvatakse kasutaja vastus muutujast vastus
            //viimase sõnumina kuva "Küsitlusprogramm sulgub, viimane sisestatud vastus" ning lisa juurde muutuja vastus sisu

            // спроси у пользователя, хочет ли он себе новую машину
            // если нет, то программа завершается сообщением пользователю "до свидания"
            // если да, то спроси у пользователя, какая модель автомобиля ему нравится
            // раздели с помощью switch case:
            //  если ему нравится audi — скажи: audi для молодых девушек
            //  если ему нравится volkswagen — скажи: автобан — твоя жизнь и любовь
            //  если ему нравится lada — скажи: ах, иди-ка ты на рынок горшков!
            //  если ему нравится mustang — лошадям не место в автогараже
            //  если ему нравится opel — тогда скажи: опелируй где-нибудь в другом месте
            //  если ему нравится любимая марка программиста — скажи: ОППА, ВОТ ЭТО УЖЕ ПОШЛО
            // (если ранее в описании задания была указана любимая марка программиста,
            //  то замени там эту марку на какую-нибудь другую)

            // спроси у пользователя, в какой стране ему хотелось бы жить
            // предложи варианты: не знаю, Эстония, Латвия, Литва, Германия, Польша, Украина
            // раздели страны с помощью switch case и выведи в консоль столько строк,
            // сколько полос у флага этой страны, окрашенных с помощью метода Console.BackgroundColor
            // цвета флагов посмотри в Google, используй максимально похожие оттенки
            // один флаг состоит из 6 строк,
            // чтобы флаги с тремя полосами можно было сделать (6/3 = 2 строки на полосу),
            // а флаги с двумя полосами — (6/2 = 3 строки на полосу)

            // спроси у пользователя, учится ли он в школе
            // если нет, то программа завершается сообщением пользователю "удачи на рынке труда"
            // если да, то спроси у пользователя, в каком классе он учится
            // создай переменную "vastus", которая хранит ответ пользователя
            // если класс, в котором сейчас учится ученик, находится в диапазоне 1–4, то
            //      раздели с помощью switch case:
            //          в первом классе — спроси и сохрани в переменную "vastus" ответ на вопрос
            //          "кем ты хочешь стать?"
            //          во втором классе — спроси и сохрани в переменную "vastus" ответ на вопрос
            //          "нравится ли тебе учиться в школе?"
            //          в третьем классе — спроси и сохрани в переменную "vastus" ответ на вопрос
            //          "как идут дела в третьем классе?"
            //          в четвёртом классе — спроси и сохрани в переменную "vastus" ответ на вопрос
            //          "издеваются ли над тобой в школе?"
            // если класс, в котором сейчас учится ученик, находится в диапазоне 5–8, то
            //      раздели с помощью switch case:
            //          в пятом классе — спроси и сохрани в переменную "vastus" ответ на вопрос
            //          "напиши своими словами формулу дробного уравнения"
            //          в шестом классе — спроси и сохрани в переменную "vastus" ответ на вопрос
            //          "нравится ли обязательная литература или это пустая трата времени?"
            //          в седьмом классе — спроси и сохрани в переменную "vastus" ответ на вопрос
            //          "трудная ли основная школа или лёгкая?"
            //          в восьмом классе — спроси и сохрани в переменную "vastus" ответ на вопрос
            //          "кем ты видишь себя на сегодняшнем рынке труда и совпадает ли это с тем,
            //           чем ты хочешь заниматься?"
            // если класс, в котором сейчас учится ученик, выше 8 класса, то:
            //      спрашивай пользователя до тех пор, пока переменная "vastus" не станет непустой (в цикле):
            //      "какие планы после окончания школы?"
            //      предложи варианты: "не знаю", "не собираюсь заканчивать школу", "свой вариант"
            //      цикл продолжается до тех пор, пока в ответе есть хоть что-то
            //      раздели с помощью switch case:
            //          если он не знает — выведи сообщение:
            //          "надеюсь, что однажды эта идея всё-таки появится"
            //          если не собирается — выведи сообщение:
            //          "это плохое решение. мне тебя жаль :c"
            //          во всех остальных случаях —
            //          "о, это хорошее дело :D" и выведи ответ пользователя из переменной vastus
            // в качестве последнего сообщения выведи:
            // "Опросная программа закрывается, последний введённый ответ:"
            // и добавь к сообщению содержимое переменной vastus


            Console.WriteLine("kas ta soovib omale uut autot (JAH/EI)");
            string küsi = Console.ReadLine();
            if (küsi == "JAH" || küsi == "jah")
            {
                Console.WriteLine("hästi");
            }
            else 
            {
                Console.WriteLine("headaega");
                Environment.Exit(0);  //see on exit programm
            }
            Console.WriteLine("kasutajalt milline automudel talle meeldib?");
            Console.WriteLine("1. Audi");
            Console.WriteLine("2. Volkswagen");
            Console.WriteLine("3. Lada");
            Console.WriteLine("4. Mustang");
            Console.WriteLine("5. Opel");
            Console.WriteLine("6. Buss");
            int auto = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                if (auto <= 6 && auto > 0) { break; }
                else 
                {
                    Console.WriteLine("proovi veel");
                    auto = Convert.ToInt32(Console.ReadLine());
                }
                
            }


            switch (auto)
            {
                case 1:
                    Console.WriteLine("audi on noormuttidele");
                    break;
                case 2:
                    Console.WriteLine("autobahn on su elu ja armastus");
                    break;
                case 3:
                    Console.WriteLine("ah käi potilaadale!");
                    break;
                case 4:
                    Console.WriteLine("hobustele autokuuris asja pole");
                    break;
                case 5:
                    Console.WriteLine("opeleeri kuskil mujal");
                    break;
                case 6:
                    Console.WriteLine("OPPA, SEE JUBA LÄHEB");
                    break;
                default:
                    Console.WriteLine("vale");
                    Environment.Exit(0);
                    break;

            }

            Console.WriteLine("millises riigis talle meeldiks elada?");
            Console.WriteLine("1. Eesti");
            Console.WriteLine("2. Läti");
            Console.WriteLine("3. Leedu");
            Console.WriteLine("4. saksamaa");
            Console.WriteLine("5. poola");
            Console.WriteLine("6. ukraina");
            int riigis = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                if (riigis <= 6 && riigis > 0) { break; }
                else
                {
                    Console.WriteLine("proovi veel");
                    riigis = Convert.ToInt32(Console.ReadLine());
                }

            }


            switch (riigis)
            {
                case 1:
                    Console.WriteLine(Console.BackgroundColor = ConsoleColor.Blue);
                    Console.WriteLine(Console.BackgroundColor = ConsoleColor.Black);
                    Console.WriteLine(Console.BackgroundColor = ConsoleColor.White);
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
                case 2:
                    Console.WriteLine(Console.BackgroundColor = ConsoleColor.Red);
                    Console.WriteLine(Console.BackgroundColor = ConsoleColor.White);
                    Console.WriteLine(Console.BackgroundColor = ConsoleColor.Red);
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
                case 3:
                    Console.WriteLine(Console.BackgroundColor = ConsoleColor.Yellow);
                    Console.WriteLine(Console.BackgroundColor = ConsoleColor.DarkGreen);
                    Console.WriteLine(Console.BackgroundColor = ConsoleColor.DarkRed);
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
                case 4:
                    Console.WriteLine(Console.BackgroundColor = ConsoleColor.Black);
                    Console.WriteLine(Console.BackgroundColor = ConsoleColor.Red);
                    Console.WriteLine(Console.BackgroundColor = ConsoleColor.Yellow);
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
                case 5:
                    Console.WriteLine(Console.BackgroundColor = ConsoleColor.White);
                    Console.WriteLine(Console.BackgroundColor = ConsoleColor.Red);
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
                case 6:
                    Console.WriteLine(Console.BackgroundColor = ConsoleColor.Blue);
                    Console.WriteLine(Console.BackgroundColor = ConsoleColor.Yellow);
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
            }
          
            Console.WriteLine("kas ta õpib koolis? (JAH/EI)");
            string õpima = Console.ReadLine();
            if (õpima == "JAH" || õpima == "jah")
            {
                
            }
            else //EI
            {
                Console.WriteLine("edu tööturul");
                Environment.Exit(0);  //see on exit programm
            }


            while (true)
            {
                Console.WriteLine("mitmendas klassis sa käib");
                int vastus = Convert.ToInt32(Console.ReadLine());
                if (vastus >= 1 && vastus <= 8)
                {
                    switch (vastus)
                    {
                        case 1:
                            Console.WriteLine("kelleks sa saada tahad?");
                            break;
                        case 2:
                            Console.WriteLine("kas sulle koolis meeldib õppida");
                            break;
                        case 3:
                            Console.WriteLine("kuidas kolmandas klassis läheb?");
                            break;
                        case 4:
                            Console.WriteLine("kas koolis kiusatakse sind?");
                            break;
                        case 5:
                            Console.WriteLine("kirjuta oma sõnadega murdvõrrandi valem");
                            break;
                        case 6:
                            Console.WriteLine("kas kohustuslik kirjandus meeldib, või on ajaraiskamine?");
                            break;
                        case 7:
                            Console.WriteLine("Kas põhikool on raske, või lihtne");
                            break;
                        case 8:
                            Console.WriteLine("kellena sa ennast tänasel tööturul näed ja kas see mida sina teha tahad sellega kokku sobib?");
                            break;
                    }
                    break;
                }
                
            }

            Console.WriteLine("mis pärast kooli lõpetamist plaanis on?");
            Console.WriteLine("1. ei tea");
            Console.WriteLine("2. ei kavatse kooli lõpetada");
            Console.WriteLine("3. Ma õpin tehnikumis.");
            Console.WriteLine("4. oma vastus");
            string result = "";
            while (true)
            {
                int vastus2 = Convert.ToInt32(Console.ReadLine());
                if (vastus2 == 4)
                {
                   string vastus3 = Console.ReadLine();
                    Console.WriteLine($"Küsitlusprogramm sulgub, viimane sisestatud vastus on {vastus2}");
                    result = "Küsitlusprogramm sulgub, viimane sisestatud vastus on {vastus2}";
                    break;
                }
                if (vastus2 >= 1 && vastus2 <= 3)
                {
                    switch (vastus2)
                    {
                        case 1:
                           Console.WriteLine("loodan et see idee ka ükspäev tuleb");
                            result = "(loodan et see idee ka ükspäev tuleb)";
                            break;
                        case 2:
                            Console.WriteLine("see on halb otsus. mul on sinust kahju :c");
                            result = "(see on halb otsus. mul on sinust kahju :c)";
                            break;
                        case 3:
                            Console.WriteLine("oh, see on hea asi teha :D");
                            result = "(oh, see on hea asi teha :D)";
                            break;
                        

                    }
                    break;
                }
                else { continue; }
            }
            Console.WriteLine($"Küsitlusprogramm sulgub, viimane sisestatud vastus on {result}");



        }
    }
}
