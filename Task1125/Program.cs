﻿/*
    -----------------------
    |                     |
    |   Made by Denoos    |  
    |                     |
    -----------------------

    Ну короче вот вам типо задание.
    Оно короче вообще легкое (минут на 30 если подумать).
    Просто надо было вам чем то пару забить.

    Спойлер: это только выглядит страшно
    Первые 75% человек, кто сделает получат 5, очтальные посмотрим)

    Если вы это не проходили, не молчите, говорите)
    (Дядя Пушкин сказал что вы прошли методы, поэтому вы должны знать,
        так что должны сделать без особых проблем)

    Все коментарии в коде лечше не трогать (это проверка на работоспособность).
    Всё что надо раскоментить, будет написано.
    Смысл задания - заполнить и создать нужные методы, чтобы собрать приложение)

    По желанию:
    Можете группой разбить между собой все задачи и выполнить по частям,
        потом просто с гита у друг друга форкнете по кускам код)


    Описание приложения:
    Пользователя встречает стартовое сообщение, где нужно выбрать что он хочет сделать с ДНЕМ,
        должно быть добавление, удаление, редактирование, и просмотр инфы(не просто так),
        с добавлением все понятно, при удалении юзер должен получить сначало предупреждение,
        и если он напишет да, тогда удалить день из списка, при редактировании выводится кажый
        параметр дня с нумерацией и взависимости от введенного юзером числа, вы просите ввести
        новое значение параметра, также дожна быть цифра сохранить, которая обновляет этот день
        из списка,

    Сверху для всех, снизу для тех, кому не лень, при этом если упеваете только верх, то просмотр
        инфы делать не надо, ну или можете сдлеать, если полностью успеете
        
        при просмотре инфы пользователь получает всю инфу про конкретный день, при этом
        если юзер введет там какое-нибудь значение типа "Редактировать"/"Edit" и тд, то выводится 
        список уроков в этот день с нумерацией и если юзер вводит число, то редактируется элемент списка
        с таким номером - 1
    
    Тем, кто вот этот абзац сверху сделает, того мы не расцелуем конечно, но Дяде Пушкину скажем, что
        такой-то такой-то красава, молодец, поставте ему 5 дополнительную. (Если в подгруппе Николая Анатольевича
        то тоже попросим его поставить доп 5 за старание)
*/

using Task1125.Model;

namespace Task1125.Program
{
    public class Program()
    {

        //Все взаимодействия производите с этим свойством(вам Дядя Пушкин потом расскажет что это)
        //  пока что считайте это супер-переменной, которую можно вызвать в любом месте класса)
        // спойлер: про классы вам потом тоже расскажут
        public List<Day> Days { get; set; }

        public static void Main(string[] args)
        {
            /*
                Сразу говорю о том, что можно менять названия всего, кроме моделей, класса и 
                    этого метода, тк это точка вхождения, а с моделями вы не работали еще, 
                    в остальном дайте свободу фантазии, но делайте пожалуйста +- норм названия,
                    названия в роде popkaNegraIzYakytii будут непонятными, поэтому называйте нормально!
            */

            //Сюда вставте название метода для приветствия пользователя (стартовыйМетод)
            /*
                Здесь сделать свич-кейс с той переменной, которую вернул стартовый метод,
                    чтобы было видно, что хочет сделать пользователь, типо
                    добавить или удалить день, посмотреть инфу о дне и тд....
            */  
        }

        /*
            Часть первая - создать условный стартовый вывод для пользователя,
                который будет выводиться ему при запуске сего творения вашей группы.
            Главное чтобы был выбор того, что пользователь хочет выбрать, после чего
                считывалась какая-нибудь переменная и значение этой переменной (строка)
                возвращалось назад.
        */

        /*
            Добавление
            
            Здесь надо сделать добавление (я думаю тут всё очевидно, ребят), то есть создать
                новую переменную с типом данных Day (считайте, что это новый тип данных как int,
                string, char и тд), потом самое бональное заполение данными, но когда будете 
                добавлять уроки, если будете, также создайте переменную с типом данных Lesson,
                заполните ее и потом просто добавляете в Day, т.е. 
                day(это переменная типа Day).Lessons.Add(сюда название переменной типа Lesson);
        */

        /*
            Удаление
            Здесь метод, чтобы можно было удалять дни из списка, перед этим придумайте как сделать
                предупреждение вида: Вы хотите удалить эту фигню(на вас оформят кредит плиз :333)?
            Если да, тогда удаляйте смело, если нет, то ничего не надо делать)
        */

        /*
            Редактирование
            В редактировании выводится список всех дней с номерами,
                после чего получается число пользователя и данный элемент списка редактируется
            Если вы не в курсе, то List<> это тоже самое, что и массив, только у него нет конца
                в остальном же это одно и то же)
        */
        
        /*
            Подробная информация
            Сначала сделайте другие, потому что здесь вам придется подумать самим, как это реализовать
                потому что я пока точно не придумал что тут сделать, но основную суть посмотрите в самом
                верху, там где примерное описание даннного приложения
        */
    }
}

//Еще один спойлер
/* 
    Надеюсь вам понравилось задание, ведь такие задания у вас будут потом, когда закончите с этими
        задачами из задачника XD
    Привыкайте к заданиям такого рода, но в отличие от этого, там будет в разы меньше конкретики
        и больше свободы творчества
*/