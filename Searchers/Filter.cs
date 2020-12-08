using System.Collections.Generic;

namespace XParser
{
    //Предназначен для хранения настроек фильтрации поиска.
    public class Filter
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Faculty { get; set; }
        public string Cathedra { get; set; }
        public string Date { get; set; }
        public string Topic { get; set; }

        //Проверяет подходит ли данная публикация под фильтр
        public bool Check(Publication publication)
        {
            //Если значение свойства равно значению в фильтре, либо фильтр не задан, елемент подходит.
            return (publication.LastName   == LastName   || LastName   == null) &&
                   (publication.FirstName  == FirstName  || FirstName  == null) &&
                   (publication.MiddleName == MiddleName || MiddleName == null) &&
                   (publication.Faculty    == Faculty    || Faculty    == null) &&
                   (publication.Cathedra   == Cathedra   || Cathedra   == null) &&
                   (publication.Date       == Date       || Date       == null) &&
                   (publication.Topic      == Topic      || Topic      == null);
        }
    }
}