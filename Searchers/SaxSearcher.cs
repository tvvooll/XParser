using System.Collections.Generic;
using System.Xml;

namespace XParser
{
    //Метод SAX.
    class SaxSearcher : ISearcher
    {
        public List<Publication> Search(Filter filter)
        {
            //Инициализируем список, куда будем складывать удовлетворяющие фильтру публиккации
            var publications = new List<Publication>();
            //Ридер для считывания xml документа
            var xmlReader = new XmlTextReader(Constants.Path);
            
            
            //Елемент (публикация), который будет считатся текущим, пока не начнётся следующий.
            Publication current = new Publication();
            //Текущее свойство.
            var prop = "";
            //Индикатор того удовлетворяет ПОКА текущий елемент фильтру или нет.
            var check = true;
            while (xmlReader.Read())
            {
                switch (xmlReader.Name)
                {
                    case "Publications": break;
                    case "Publication":
                        //Если это конец елемента публикация, то проверяем подходит ли он нам по индикатору
                        //Если да, то добавляем в результирующий список. И сбрасываем текущий елемент, так как дальше мы будем считывать новую публикацию.
                        if (xmlReader.NodeType == XmlNodeType.EndElement)
                        {
                            if (check)
                                publications.Add(current);
                            current = new Publication();
                            check = true;
                        }
                        break;
                        //Если нет названия елемента, значит это текстовое значение.
                        //Смотрим, какое текущее свойство и в зависимости от этого меняем свойство текущей публикации.
                    case "":
                        if (xmlReader.NodeType == XmlNodeType.Text)
                        {
                            switch (prop)
                            {
                                case "LastName":   current.LastName   = xmlReader.Value; break;
                                case "FirstName":  current.FirstName  = xmlReader.Value; break;
                                case "MiddleName": current.MiddleName = xmlReader.Value; break;
                                case "Faculty":    current.Faculty    = xmlReader.Value; break;
                                case "Cathedra":   current.Cathedra   = xmlReader.Value; break;
                                case "Topic":      current.Topic      = xmlReader.Value; break;
                                case "Date":       current.Date       = xmlReader.Value; break;
                            }
                            //Проверяем, подходит ли нам пока что данная публикация.
                            check = filter.Check(current);
                        }
                        break;
                    default:
                        //Если это елемент но нне публикация, то это её своство, сохраняем её имя как текущую.
                        if (xmlReader.NodeType == XmlNodeType.Element)
                            prop = xmlReader.Name;
                        break;
                }
            }
            return publications;
        }
    }
}
