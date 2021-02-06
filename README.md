# TextAnalizer
Данная программа позволяет анализировать текст на основе метрик. Пока это кол-во гласных, согласных букв и кол-во слов.
Иерархия классов построена таким образом, что можно без проблем добавить новые метрики, а также входной формат текста.
--------------
Все форматы текста наследуются от интерфейса IContent, а все метрики наследуются от интерфейса IMetric. 
Это позволяет строить взаимодействие объектов на уровне абстракции, не акцентируясь на конкретике.
