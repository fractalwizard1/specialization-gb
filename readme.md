 **Приветствую уважаемые наставники,проверяющие и те, кто по-настоящему "рубит" в программировании..... в отличии от меня. Вы скажете "что за пассивная агрессия?" Я бы не хотел, что бы это звучало именно так, я бы хотел быть тем кто "рубит",как вы например... Но, пока я писал своего "кривого ослика", у меня сложилось впечатление что я - тупица, ибо програмирование даётся мне исключительно тяжко...**

*Знакомьтесь - "кривой ослик".
Я назвал  его так, взяв за основу аллегорию, где котрольное задание - это некий груз, который неоходимо доставить и нужен транспорт. И вот он - мой транспорт - кривой ослик, Самое удивительное, что свою функцию он выполняет.*

<img class="MMImage-Origin" src="https://st.depositphotos.com/1430648/3834/i/450/depositphotos_38340683-stock-photo-stubborn-donkey.jpg">

~~А теперь немного о том, как он это делает...~~

Начинается все с того, что пользователь должен ввести несколько массивов. Для данного условия я использовал переменную __string__ т.к. в нее можно поместить как цифры, так и буквы.
Обозначив переменные, выводим консоль ввода для пользователя.
После того как массивы введены с клавиатуры, обозначаем еще один массив типа __string__, в который помещаем данные которые были введены с клавиатуры.
Добавляем переменные __result__  и __realSize__
При помощи ключевого слова __var__ выясняем какой размер(длинна массива) через цикл __foreach__.
 __foreach__ перебирает элименты массива и записывает значения в переменную __value__ ,там же задаём условия поиска при помощи цикла __if__ "<= 3" как было в задании.

В конце выводим на консоль массивы,удовлетворяющие требованию задания.  