﻿namespace HW6_PRO.Models
{
    public class ProgrammingLanguage
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ExampleCode { get; set; }
    }
}

//Использование маршрутизации в паттерне MVC приложения ASP.Net Задание
//1. Создать проект ASP.Net Core с реализацией паттерна MVC.
//2. Используя систему маршрутизации, реализовать обработку запросов,
//обеспечив следующий функциональность приложения:
//-Приложение позволяет отображать информацию о различных языках программирования.
//На начальном этапе при выполнении запроса в формате localhost:порт отображается
//информация о языках программирования, по которым можно получить справку.
//- При запросе в формате localhost:порт / Programming / Info / язык / цвет отображается
//информация о языке программирования, название которого указано в блоке язык. Заголовок
//на странице отображается цветом, указанным в блоке цвет. Блок язык является обязательным,
//блок цвет не является обязательным.
//- При запросе в формате localhost:порт / Programming / Example / язык отображается страница
//с примером программного кода на соответствующем языке (определяется блоком язык).