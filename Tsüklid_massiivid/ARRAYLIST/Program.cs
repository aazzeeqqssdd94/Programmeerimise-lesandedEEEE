namespace ARRAYLIST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //NB - ülesanded kasutavad tsükleid, tingimuslauseid, soovitavalt tee enne vähemalt tsükliteülesandeid ka

            //1. - "artifitsiaalne ebaintelligents"
            //Kirjuta massiiv (Array), milles on sõned. Tekita loend tühjalt, aga tee loendi pikkuseks 5 elementi.
            //Kirjuta for tsükkel, tsükkel peaks käima niikaua kuni massiivis elemente jätkub
            //tsükkel teeb iga elemendi juures järgnevad tegevused
            //- küsib kasutajalt nimisõna
            //- asetab vastavasse järjendi elementi kasutaja sisestuse
            //Kui tsükkel on läbi, kuvatakse kasutajale lause, iga elemendiga:
            // NB [0], [1] jne tekstis väljendab mitmendat elementi massiivist kasutatakse, seal pead ise kirjutama elementide kasutuse õigesti:
            //"Teie päringule [0] kohta oskan ainult vastata nii:\nMinu [2]-süsteem ei taju kuidas [3] on [0]iga seotud, \nja arvan et [0] probleemi lahendaks ära hoopis [4] rakendamine"

            //2. - "Statistikakuvar"
            //Kirjuta loend (List) tüüpi muutuja, milles on komakohaga arvud. Omista selle loendi sisse kolm komakohaga arvu
            //Kuva foreach tsükliga elemendid ükshaavalvälja
            //tekita string-tüüpi muutuja "uusSisestus", hetkel omista muutujasse ""
            //kirjuta while tsükkel, mille tingimus kontrollib, kas kasutaja sisestus ei ole "ei soovi"
            //tsükli sees küsi kasutajalt "kas soovid sisestada veel andmeid? kui ei, kirjuta "ei soovi""
            //tsükli sees omista muutujasse "uusSisestus" käsurea pealt saadud info
            //tsükli sees tee tingimuslause, mis kontrollib, kas "uusSisestus" ei ole "ei soovi"
            //tingimuse täitumisel, lisa loendile otsa element, kasutades selle jaoks muutujat "uusSisestus", ning samaaegselt teisendades muutuja komakohaga arvuks
            //kui while tsükkel lõppeb, kuva nagu alguseski, foreach tsükliga kogu loendi elemendid ükshaaval välja, nüüd kuvades ka juurde lisatud arve

            //NB - задания используют циклы и условные операторы, желательно сначала выполнить упражнения на циклы

            //1. - "искусственная неинтеллектуальность"
            //Создай массив (Array), содержащий строки. Изначально создается пустой, но длина массива должна быть 5 элементов.
            //Напиши цикл for, который проходит до конца массива
            //Внутри цикла для каждого элемента выполняются следующие действия:
            //- спрашивает у пользователя существительное
            //- помещает введённое пользователем значение в соответствующий элемент массива
            //Когда цикл завершится, выведи пользователю предложение, используя каждый элемент массива:
            // NB [0], [1] и т.д. в тексте обозначают, какой элемент массива используется. Нужно правильно использовать элементы массива:
            // "По вашему запросу [0] могу ответить только так:\nМоя система [2] не понимает, как [3] связано с [0], \nи думаю, что проблему [0] могло бы решить применение [4]"

            //2. - "Статистический дисплей"
            //Создай переменную типа список (List), содержащий числа с плавающей точкой. Присвой этому списку три числа с плавающей точкой.
            //Выведи элементы списка по одному с помощью цикла foreach
            //Создай строковую переменную "новыйВвод" и пока присвой ей ""
            //Напиши цикл while, условие которого проверяет, что пользовательский ввод не равен "не хочу"
            //Внутри цикла спрашивай пользователя: "Хотите ввести ещё данные? Если нет, напишите 'не хочу'"
            //Присваивай введённое пользователем значение переменной "новыйВвод"
            //Внутри цикла создай условие, проверяющее, что "новыйВвод" не равен "не хочу"
            //Если условие выполняется, добавь значение в конец списка, преобразовав строку "новыйВвод" в число с плавающей точкой
            //Когда цикл while закончится, выведи, как и в начале, все элементы списка с помощью foreach, теперь включая добавленные значения

        }
    }
}
