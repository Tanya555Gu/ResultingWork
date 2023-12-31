# Последовательность решения итоговой работы

1. Создаем массив строк с помощью метода *CreateArray()*
2. Проходимся по массиву с помощью метода *FindNumberItems()* с целью узнать количество элементов, которое удовлетворяет заданному условию (строки с длиной меньше либо равно 3)
3. Задаем условие на наличие или отсутствие таких элементов (то есть больше ли оно 0)
4. Если такие элементы обнаруживаются, то создаем новый массив с помощью метода *CreateNewArray()*
5. Выводим наш новый массив с помощью метода *PrintArray()*
6. Если таких элементов не обнаруживается, то создаем пустой массив
7. Выводим наш пустой массив с помощью метода *PrintArray()*

## Краткое описание методов
#### __*Метод string[] CreateArray()*__
Данный метод создает массив из строк и заполняет его значениями, которые вводит пользователь с консоли, после чего возвращает заполненный массив. Заполнение происходит с помощью цикла for, после того как пользователь задаст значение величины массива.
#### __*Метод void PrintArray(string[] array)*__
Данный метод позволяет выводить в консоль массив в заданном виде с помощью цикла for.
#### __*Метод int FindNumberItems(string[] array)*__
В данном методе мы берем счетчик и с его помощью узнаем количество строк, отвечающих заданному условию. Для этого проходимся по массиву с помощью цикла for и задания условия определенной длины строки. После метод возвращает значение счетчика.
#### __*Метод string[] CreateNewArray(string[] array, int count)*__
Данный метод берет ранее созданный массив и значение переменной, показывающей количество элементов, отвечающих условию. На основе этих данных с помощью цикла for он создает новый массив, состоящий только из элементов, отвечающих условию.