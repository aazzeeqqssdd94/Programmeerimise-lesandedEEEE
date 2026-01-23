namespace MATHEMATICS_USERINPUT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. kirjuta programm, mis
            //omab täisarvu muutujat vanuse jaoks
            //küsib kasutajalt tema vanust. int.Parse() üritab muuta andmeid tekstist arvuks
            //omab täisarvu muutujat aastaarvu jaoks
            //küsib kasutajalt praegust kalendriaastat. int.Parse() üritab muuta andmeid tekstist arvuks
            //omab muutujat sünniaasta jaoks, siia sisse omimstatakse tehte tulemus, kus aastaarvust lahutatakse vanus

            //2. kirjuta programm, mis
            //küsib kasutajalt tema nime
            //hoiab seda nime sõne-tüüpi muutujas
            //kuvab välja tervituse, liites juurde inimese nime

            //3. kirjuta programm, mis
            //omab muutujat kommikaal
            //omab muutujat sõpradearv
            //küsib kasutajalt mitu grammi kommi tal on
            //muutujasse kommikaal pannakse kasutaja sisestatud arv
            //küsib kasutajalt mitme inimese jaoks ta kommi ostis
            //ootab kuni kasutaja sisestab arvu, mis omistatakse muutujasse sõpradearv
            //kuvatakse välja tehe kus kommikaal jagatakse sõpradearvuga

            //4. kirjuta programm, mis
            //omab muutujat õunapuusaak
            //omab muutujat sõbersai
            //küsib kasutajalt mitu õuna ta õunapuu talle andis
            //muutujasse õunapuusaak pannakse kasutaja sisestatud arv
            //küsib kasutajalt mitu õuna ta sõber tahtis
            //ootab kuni kasutaja sisestab arvu, mis omistatakse muutujasse sõbersai
            //kuvatakse välja tehe kus õunapuusaak muutujast lahutatakse maha sõbersai,
            //ning kuvatakse koos sõnumiga "sul on nii palju õunu alles"

            //4. kirjuta programm, mis
            //omab neli täisarvu muutujat, üks ema, isa, kasutaja ja õe jaoks
            //küsib kasutajalt kasutaja pikkust
            //paneb kasutajalt saadud väärtuse õigesse muutujasse
            //küsib kasutajalt kasutaja ema pikkust
            //paneb kasutajalt saadud väärtuse õigesse muutujasse
            //küsib kasutajalt kasutaja isa pikkust
            //paneb kasutajalt saadud väärtuse õigesse muutujasse
            //küsib kasutajalt kasutaja õe pikkust
            //paneb kasutajalt saadud väärtuse õigesse muutujasse
            //programm tekitab uue muutuja, kus arvutatakse välja kasutaja perekonnaliikmete keskmine pikkus
            //kuva kasutajale tema perekonna keskmine pikkus

            //5. kirjuta programm, mis
            //omab viite muutujat: esmaspäev, teisipäev, kolmapäev, neljapäev ja reede
            //küsib kasutajalt eraldi küsimusega iga päeva kohta "mitu minutit arvutimänge mängisid"
            //peale igat küsimust, sisestab vastavasse muutujasse kasutaja poolt saadud tulemuse
            //programm teeb muutuja "ajakulu" kuhu arvutatakse liites kokku kõik nädalapäeva muutujad
            //programm teeb muutuja päevakeskmine, mis hetkel on 0;
            //muutujasse päevakeskmine arvutatakse ajakulu muutujat kasutades keskmine tehtega (ajakulu / 5)
            //programm kuvab kasutajale oma nädalase koguajakulu
            //programm kuvab kasutajale päeva keskmise ajakulu
            //programm teeb muutuja "tundidesajakulu", mille sisse pannakse tehte (ajakulu/60) tulemus
            //programm kontrollib IF abil, kas  ajakulu on 35h või suurem
            //kui on suurem, kuva hoiatus "sinu mängimisele kulub peaaegu samasugune aeg nagu tavalisel inimesel töönädalas töötamisele"
            //kui on väiksem, ära tee midagi.

            //1. напиши программу, которая
            //имеет целочисленную переменную для возраста
            //спрашивает у пользователя его возраст. int.Parse() пытается преобразовать данные из текста в число
            //имеет целочисленную переменную для текущего года
            //спрашивает у пользователя текущий календарный год. int.Parse() пытается преобразовать данные из текста в число
            //имеет переменную для года рождения, в которую присваивается результат вычитания возраста из текущего года

            //2. напиши программу, которая
            //спрашивает у пользователя его имя
            //сохраняет это имя в строковой переменной
            //выводит приветствие, добавляя к нему имя человека

            //3. напиши программу, которая
            //имеет переменную вес конфет
            //имеет переменную количество друзей
            //спрашивает у пользователя, сколько грамм конфет у него есть
            //в переменную вес конфет записывается введённое пользователем число
            //спрашивает у пользователя, для скольких человек он покупал конфеты
            //ожидает, пока пользователь введёт число, которое присваивается переменной количество друзей
            //выводит действие, где вес конфет делится на количество друзей

            //4. напиши программу, которая
            //имеет переменную урожай яблок
            //имеет переменную "хотелки друга"
            //спрашивает у пользователя, сколько яблок дал ему его яблоня
            //в переменную урожай яблок записывается введённое пользователем число
            //спрашивает у пользователя, сколько яблок хотел его друг
            //ожидает, пока пользователь введёт число, которое присваивается переменной "хотелки друга"
            //выводит действие, где из урожая яблок вычитается количество яблок, которые хотел друг,
            //и выводит сообщение "у тебя осталось столько-то яблок"

            //4. напиши программу, которая
            //имеет четыре целочисленные переменные, для мамы, папы, пользователя и сестры
            //спрашивает у пользователя рост пользователя
            //записывает полученное значение в соответствующую переменную
            //спрашивает у пользователя рост мамы
            //записывает полученное значение в соответствующую переменную
            //спрашивает у пользователя рост папы
            //записывает полученное значение в соответствующую переменную
            //спрашивает у пользователя рост сестры
            //записывает полученное значение в соответствующую переменную
            //программа создаёт новую переменную, где вычисляется средний рост членов семьи
            //выводит пользователю средний рост его семьи

            //5. напиши программу, которая
            //имеет пять переменных: понедельник, вторник, среда, четверг и пятница
            //спрашивает у пользователя отдельно для каждого дня: "сколько минут играл в компьютерные игры"
            //после каждого вопроса записывает полученный результат в соответствующую переменную
            //программа создаёт переменную "общее время", куда складываются все переменные дней недели
            //программа создаёт переменную "среднее в день", которая изначально равна 0;
            //в переменную среднее в день вычисляется среднее значение, используя переменную "общее время" (общее время / 5)
            //программа выводит пользователю общее время, проведённое за неделей
            //программа выводит пользователю среднее время в день
            //программа создаёт переменную "общее время в часах", куда записывается результат (общее время/60)
            //программа проверяет с помощью IF, если общее время ≥ 35 часов
            //если больше, выводит предупреждение "на игры у тебя уходит почти столько же времени, сколько обычный человек работает за неделю"
            //если меньше, ничего не делает


        }
    }
}
