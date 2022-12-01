# Итоговая работа по итогам прохождения первого блока программы Разработчик

## Задание

1. Создать репозиторий на GitHUB
2. Начертить блоксхему алгоритма 
3. Снабдить репозиторий текстовым описанием решения
4. Написать программу решающую поставленную задачу.
5. Использовать контроль версий при решении поставленной задачи.

### Задача

 Написать программу, которая из имеющегося массива строк формирует массив из строк,  
 длина которых меньше, либо равна трем символам. Первоначальный массив можно ввести вручную или задать на старте программы.  
 При решении не рекомендуется пользоваться коллекциями.

## Каталоги и файлы:

\\Blockdiagram - каталог с блок-схемой выполненной в формате  MS Visio и PNG  
\\Program - каталог с проектом на С#  
Readme.md - этот файл  

## Описание решения

	Два варианта решения.
	
	1. В методе создаем временный массив такой же размерности как и исходный.  
	   Создаем счетчик инициализируя его в 0.
	   Проходим исходный масив в цикле for или foreach; элементы,  
	   длина которых будет меньше 4 сохраняем во временный массив, при  
	   этом индексом(для записи) будет счетчик. Инкрементируем счетчик.
	   После прохода мы будем иметь количество элементов в счетчике и,  
	   собственно, сами элементы во временном массиве.
	   После создаем уже итоговый массив размерностью как в счетчике и  
	   копируем в него нужное количество элементов из временного массива.  
	   Возвращаем результирующий массив.
	   
	2. Примерно то же самое, но с двумя проходами:
	   Проходим по первому массиву и считаем элементы длиной меньше 4.
	   Создаем итоговый массив размерностью равной количеству найденых элементов.
	   Создаем переменную индекса, для адресации элементов при записи.
	   Снова проходим по исходному массиву и элеименты удовлетворяющие нашему условию  
	   Записываем в результирующий массив по индексу, инкрементируя его после каждой записи.
	   Когда индекс сравняется с числом найденых элементов останавливаем цикл и возвращаем  
	   результирующий массив.
