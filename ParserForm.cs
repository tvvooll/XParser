using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace XParser
{
    public partial class ParserForm : Form
    {
        ISearcher Searcher { get; set; } = new SaxSearcher();
        public ParserForm()
        {
            InitializeComponent();

            //Проходимся по файлу, смотрим какие значения принимает каждый из фильтрируемых параметров
            //И добавляем в соответствующие списки.
            var filterOptions = (new LinqSearcher()).GetFilterItems();
            LastNameFilter.Items.AddRange(filterOptions["LastName"].ToArray());
            FirstNameFilter.Items.AddRange(filterOptions["FirstName"].ToArray());
            MiddleNameFilter.Items.AddRange(filterOptions["MiddleName"].ToArray());

            FacultyFilter.Items.AddRange(filterOptions["Faculty"].ToArray());
            CathedraFilter.Items.AddRange(filterOptions["Cathedra"].ToArray());
            TopicFilter.Items.AddRange(filterOptions["Topic"].ToArray());
            DateFilter.Items.AddRange(filterOptions["Date"].ToArray());
        }

        //Нажатие на кнопку поиска...
        private void SearchButton_Click(object sender, EventArgs e)
        {
            //Инициализируем фильтр
            Filter filter = new Filter();

            //Если фильтры включены, то считываем значения с соответствующих елементов интерфейса.
            if(FiltersCheckBox.Checked)
                filter = new Filter
                {
                    FirstName  = (string)FirstNameFilter.SelectedItem,
                    LastName   = (string)LastNameFilter.SelectedItem,
                    MiddleName = (string)MiddleNameFilter.SelectedItem,
                    Faculty    = (string)FacultyFilter.SelectedItem,
                    Cathedra   = (string)CathedraFilter.SelectedItem,
                    Topic      = (string)TopicFilter.SelectedItem,
                    Date       = (string)DateFilter.SelectedItem
                };
            
            //Выполняем поиск, и форматируем результаты к удобному для восприятия виду.
            OutputTextBox.Text = FormatPublications(Searcher.Search(filter));
            //Если результат пуст, то сообщаем об этом.
            if (OutputTextBox.Text == "")
                OutputTextBox.Text = "За цими фільтрами нічого не знайдено.";
        }


        //Метод для форматирования информации о публикациях.
        private string FormatPublications(List<Publication> publications)
        {
            //Воспользуемся StringBuilder`ом чтобы лишний раз не засорять память работой со строками.
            var builder = new StringBuilder();
            //Проходися по публикациях и запизываем информацию о каждой из них.
            foreach(var item in publications)
            {
                builder.Append($"Прізвище: {    item.LastName   };\r\n");
                builder.Append($"Ім'я: {        item.FirstName  };\r\n");
                builder.Append($"По-батькові: { item.MiddleName };\r\n");
                builder.Append($"Факультет: {   item.Faculty    };\r\n");
                builder.Append($"Кафедра: {     item.Cathedra   };\r\n");
                builder.Append($"Тема: {        item.Topic      };\r\n");
                builder.Append($"Дата: {        item.Date       }.\r\n\r\n");
            }
            //Возвращаем результат, конвертированный в строку.
            return builder.ToString();
        }

        //Нажатие на кнопку транформации...
        private void TransformButton_Click(object sender, EventArgs e)
        {
            //Выполняем трансформацию...
            (new Transformer()).Transform();
        }

        //Методы для работы переключателя между методами поиска.
        
        private void LinqRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (LinqRadioButton.Checked)
                Searcher = new LinqSearcher();
        }

        private void DomRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (DomRadioButton.Checked)
                Searcher = new DomSearcher();
        }

        private void SaxRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (SaxRadioButton.Checked)
                Searcher = new SaxSearcher();
        }
    }
}
