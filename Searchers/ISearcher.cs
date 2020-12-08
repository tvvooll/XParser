using System;
using System.Collections.Generic;
using System.Text;

namespace XParser
{
    //Интерфейс, общий для всех методов поиска (интерфейс в паттерне "Стратегия")
    interface ISearcher
    {
        //Главный метод для поиска.
        List<Publication> Search(Filter filter);
    }
}
