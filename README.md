# 2_TestTaskForKATEK
Тестовое задание для ЗАО «КАТЭК»

Выбор базы данных остановил на Access. 
Зря и вот почему: постоянные несовместимости данных и строк подключения к непосредственной БД на Access: 
1) при работе с БД формата .accdb проект по просту отказывался работать с причинной несовместимости. Даже посредством спец. средств подключения от самой Visual Studio;
2) сохранил в более старом формате Access 2000-2003 (*.mdb). Работает нормально;
3) конфликты при записи одиннаковых значений в неиндексируемые и не уникальные ячейки столбцов;
4) думаю, что для поставленной задачи БД на СУБД SQLite справилась бы лучше: более отказоустойчивая и совместимая, но не было времени все переделать под неё.

Парсинг .docx документов дело не простое. Встроенных средств от Visual Studio не нашел, воспользовался сторонней библиотекой SautinSoft.Document.dll.
Не так часто возникали баги в виде значения "trial" вместо ожидаемого числа или даты. С чем связанно - так и не понял. От дебажить не смог, т.к. возникает крайне редко.

По запросу выборки из интервала дат из БД Access: БД упорно не желала делать выборку так, как я желаю. 
При разработке следующего готового запроса возникли следующие проблемы:
1) выборка происходила лишь по дню и не учитывалось все остальное;
2) формат даты 'dd:MM:yyyy HH:mm:ss' упорно не воспринимался базой данных, в следствии чего пришлось переделать весь проект под 'dd.MM.yyyy HH:mm:ss'и принудительный реформат всех поступающих документов для входных данных;
3) БД отказывается распозновать оператор BETWEEN, в следствии чего запрос несколько видоизменен.
SELECT Id,DataOfFinished FROM `StringsOfDocument` WHERE DataOfFinished >= Format('11.12.2018 21:04:43','dd.MM.yyyy HH:mm:ss')  AND DataOfFinished <= Format('11.12.2022 21:04:43','dd.MM.yyyy HH:mm:ss')

Не все моменты "на дурака" обработаны. Проект может вылетать, но в целом рабочий билд.

Реализована выборка из интервала дат в рамках самой программы до записи в БД.

По архитектуре БД приняты следующие решения:
1) присвоить каждой записи id документа, которому принадлежит;
2) за каждым id документа прикреплено его название;
3) в целом, все записи заказов располагаются в одной области, где ID заказа - уникален, но не является счётчиком(serial).

Думал над экспортом из БД в виде .docx или .csv, ведь с последним в подобном ключе было бы работать проще.

По интерфейсу программы:
1) в подвале расположен выбор БД;
2) вверху работа с данными;
3) думал, чтобы в зависимости от выбранного tabControl'а назначать разного обработчика, но это не понадобилось на этом этапе;
4) кнопка "Выбрать документ для загрузки" - позволяет импортировать документ во вьюху;
5) кнопка "Сохранить в БД" - отправить в БД из вьюхи все выбранные данные;
6) кнопка "Отобразить выборку" - выбор строк из интервала дат. При выборе других дат и повторном применении запрашивать из БД не надо, хранится временный экземпляр вьюхи.
7) кнопка "Показать загруженные документы" - расчитана для возможного выбора документов, хранящихся в БД, их их данных. Пока только отражаются лишь все документы;
8) кнопка "Показать данные всех документов с учетом интервала" - импорт из БД с учетом дат для выборки. 
