# GameWer.UI.UniversalDevblog
🔷Дополнительная модернизируемая dll с интерфейсом для GameWer

Установка :
- Перенесите GameWer.UI.UniversalDevblog в корневую папку с GameWer
- Запустите GameWer

Модернизация :
- Данный DLL имеет полностью открытый исходный код, я предоставляю вам полный проект со всеми ресурсами
- Вы можете изменять всю панель, добавляя или изменяя функционал
- Основной функционал работает на реализации интерфейса IGameWer с зависимостью GameWer.SDK
- Изменяемые ссылки, данные находятся в Structures.cs (После изменений не забывайте компилировать весь проект)

Компиляция (Visual Studio) :
- Конфигурация решения Release (Для конечной компиляции)
- Платформа решения x64 (Обязательно! Иначе GameWer.SDK не примет ее, т.к сам состоит на x64)
- Сборка проекта (CTRL + SHIFT + B)
Файл будет находится в ..\\GameWer.UI.UniversalDevblog\bin\x64\Release\

Лицензия MIT (MIT License)
