
Дан сортированный файл котировок в формате *.csv. иди .txt. Файл заполнен данными, разбитыми по минутам. Т.е. каждая новая запись(строка), новая минута.

"Symbol" "Description" "Date" "Time" "Open" "High" "Low" "Close" "TotalVolume"
Символ /тикер /название	Описание Дата бара Время бара Цена открытия бара Наибольшая цена бара Наименьшая цена бара Цена закрытия бара Объём

Необходимо:

Задача 1.
Найти максимум и минимум цены за каждый день. Значения максимума и минимума дня вычисляются по параметрам High и Low. 
Сформировать файл в том же формате с двумя записями для каждого дня (Минимум и Максимум дня).

Задача 2.
Сформировать файл с данными в том же формате, но разбитыми по часам. 
Минутные бары агрегировать, так что Open – цена открытия часового диапазон, 
Close -цена закрытия диапазона, High - максимальная цена диапазона, 
Low – минимальная цена диапазона, TotalVolume – сумма на диапазоне.

Задача 3.
Написать алгоритм проверки данных файла с данными файла2. Файл2 может содержать в себе частично строки из исходного файла и строки которых в исходном файле нет. 
Сформировать три файла: «Новые строки» - содержит строки из файла2, которых нет в исходном файле
«потерянные строки» - содержит строки, которые были в исходном файле, но отсутствуют в файле2
«все строки» - содержит уникальные строки из исходного файла и файла2

Требования к выполнению:

Считать, что исходный файл всегда сортирован. Создать класс бара, работать объектами этого класса. 
Не использовать LINQ и сторонние библиотеки. В 3м задании проверять данные внутри файла, а не сами файлы.
