// See https://aka.ms/new-console-template for more information
using ModularMonolith.Analytics;
using ModularMonolith.Database;
Console.WriteLine("Вся функицональность модульного монолита разделена на разные изолированные как бы модули(или пакеты в java, или namespaces, или библиотеки C#)");
Console.WriteLine("Результаты аналитики: "+Analytics.Handle(14,8));
Database.Connect();//классы в архитектуре не обязательно должны быть статичными, важна сама суть - разделение на модули функциональности
Console.WriteLine("Данные из БД: " + Database.ProvideData(123));