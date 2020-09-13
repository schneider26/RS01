using RS.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace RS.ViewModels
{
    class MyListPageViewModel
    {
        public ObservableCollection<MyListModel> MyListCollector { get; set; }

        public MyListPageViewModel()
        {
            MyListCollector = new ObservableCollection<MyListModel>()
            { 
                new MyListModel(){id = 1, SignGroup= "Предупреждающие дорожные знаки"},
                new MyListModel(){id = 2, SignGroup= "Знаки приоритета дорожного движения"},
                new MyListModel(){id = 3, SignGroup= "Запрещающие знаки дорожного движения"},
                new MyListModel(){id = 4, SignGroup= "Предписывающие знаки"},
                new MyListModel(){id = 5, SignGroup= "Знаки особых предписаний"},
                new MyListModel(){id = 6, SignGroup= "Информационные дорожные знаки"},
                new MyListModel(){id = 7, SignGroup= "Знаки сервиса"},
                new MyListModel(){id = 8, SignGroup= "Знаки дополнительной информации"}
            };
        }
    }
}
