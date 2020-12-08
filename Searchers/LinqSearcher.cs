using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace XParser
{
    //Метод Linq.
    class LinqSearcher : ISearcher
    {
        public List<Publication> Search(Filter filter)
        {
            //Загружаем документ.
            var data = XDocument.Load(Constants.Path);
            return data.Element("Publications")                                     //Выбираем публикации.
                        .Elements("Publication")                                    //Выбираем все публикации.
                        .Where(item =>                                              //Выбираем нужные.
                            filter.Check(new Publication                            //Формируем обьект публикации чтобы передать в метод проверки фильтра.
                            {                                                       //.
                                FirstName  = item.Element("FirstName") ?.Value,     //.
                                LastName   = item.Element("LastName")  ?.Value,     //.
                                MiddleName = item.Element("MiddleName")?.Value,     //.
                                Faculty    = item.Element("Faculty")   ?.Value,     //.
                                Cathedra   = item.Element("Cathedra")  ?.Value,     //.
                                Topic      = item.Element("Topic")     ?.Value,     //.
                                Date       = item.Element("Date")      ?.Value      //Отправляем на проверку методу фильтра.
                            })
                        )
                        .Select(item => new Publication                             //Из отфильтрованых елементов формируем обьекты публикации
                        {                                                           //.
                            FirstName  = item.Element("FirstName") ?.Value,         //.
                            LastName   = item.Element("LastName")  ?.Value,         //.
                            MiddleName = item.Element("MiddleName")?.Value,         //.
                            Faculty    = item.Element("Faculty")   ?.Value,         //.
                            Cathedra   = item.Element("Cathedra")  ?.Value,         //.
                            Topic      = item.Element("Topic")     ?.Value,         //.
                            Date       = item.Element("Date")      ?.Value          //.
                        }                                                           //.
                        ).ToList();                                                 //Приводим к списку.
        }

        //Находит все опции в файле для каждого из фильтров.
        public Dictionary<string, List<string>> GetFilterItems()
        {
            //Открываем файл.
            var data = XDocument.Load(Constants.Path);

            //Создаём первичный словать фильтров с пустмыми списками елементов.
            var filter = new Dictionary<string, List<string>>
            {
                { "LastName",   new List<string>() },
                { "FirstName",  new List<string>() },
                { "MiddleName", new List<string>() },
                { "Faculty",    new List<string>() },
                { "Cathedra",   new List<string>() },
                { "Topic",      new List<string>() },
                { "Date",       new List<string>() }
            };

            //Для каждой публикации...
            foreach (var publictation in data.Element("Publications").Elements("Publication"))
            {
                //Смотрим на каждое свойство...
                foreach (var prop in publictation.Elements())
                {
                    List<string> filterList;
                    //Если такое свойство есть в словаре фильтров...
                    if(filter.TryGetValue(prop.Name.ToString(), out filterList))
                    {
                        //То проверяем содержится ли значение этого свойства с списке значений фильтра
                        if (!filterList.Contains(prop.Value))
                            //Если нет, то добавляем его в список.
                            filterList.Add(prop.Value);
                    }
                }
            }
            return filter;
        }
    }
}
