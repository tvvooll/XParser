using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Xsl;

namespace XParser
{
    class Transformer
    {
        //Трасформирует xml -(xsl)-> html
        public void Transform()
        {
            //Инициализируем трансформацию...
            XslCompiledTransform transform = new XslCompiledTransform();
            var input = Constants.Path;
            var xsl = Constants.XslPath;
            var output = Constants.HtmlPath;

            //Загружаем файл трансформации и трасформируем.
            transform.Load(xsl);
            transform.Transform(input, output);
        }
    }
}
