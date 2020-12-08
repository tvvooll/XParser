using System.Collections.Generic;
using System.Xml;

namespace XParser
{
    //Метод DOM.
    class DomSearcher : ISearcher
    {
        public List<Publication> Search(Filter filter)
        {
            //Создаём результирующий список и открываем документ.
            List<Publication> publications = new List<Publication>();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(Constants.Path);

            //Смотрим на каждый узел-публикацию в DOM-дереве...
            var publicationsNode = xmlDoc.DocumentElement.ChildNodes[1].SelectNodes("//Publications/Publication");
            foreach (XmlNode node in publicationsNode)
            {
                //формируем публикацию на основе узла.
                var publication = new Publication()
                {
                    LastName = node.SelectSingleNode("./LastName").InnerText,
                    FirstName = node.SelectSingleNode("./FirstName").InnerText,
                    MiddleName = node.SelectSingleNode("./MiddleName").InnerText,
                    Faculty = node.SelectSingleNode("./Faculty").InnerText,
                    Cathedra = node.SelectSingleNode("./Cathedra").InnerText,
                    Topic = node.SelectSingleNode("./Topic").InnerText,
                    Date = node.SelectSingleNode("./Date").InnerText,
                };
                
                //Проверяем на соответствие фильтру и в случае успеха, добавляем в результирующий список.
                bool check = filter.Check(publication);
                if(check)
                    publications.Add(publication);
            }
            return publications;
        }
    }
}
