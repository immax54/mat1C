# MusicGuide
Мобильное приложение для обучения игре на различных музыкальных инструментах через просмотр видео-курсов, отработки навыков на практике и отслеживанием своего прогресса в обучении.

## Начало работы с приложением

Для начала работы с приложением необходимо установить его на свой телефон с OC Android.


### Установка

Пошаговая инструкция по установке приложения:

1.Загрузить на устройство:
```
MusicGuide.apk
```
2.По ссылке:
```
https://drive.google.com/u/0/uc?id=17AICrLf_L2dKpAGvdvFeB8_WBjcFgca_&export=download
```
и установить его

3.При необходимости войти в Настройки и перейти в раздел Безопасность и переключить функцию
```
Неизвестные источники	Вкл
```
4.Найти и запустить приложение на своём устройстве

## Запуск тестов

Для просмотра Автоматизированных тестов необходимо запустить IDE Android Studio и перейти по пути:
```
.\MG\app\src\test\java\com\example\youtubeplayerview\
```
Для запуска необходимо выбрать:
```
ExampleUnitTest.java
```
Результаты будут выводиться в терминал IDE



### Автоматические тесты

Для тестирования были разработаны:

```
parametrsSinLessonsAreEqual()
parametrsDrumLessonsAreEqual()
parametrsGuitarLessonsAreEqual()//Подсчет всех выполненных уроков и сравнение в % до 100 для каждого курса
storeValueIntTNotNull()//Проверка на сохранение числа в файл XML
storeValueIntTEqual()//Проверка на соответствие сохраненного числа в файл XML
Fetch()//Проверка на подключение файла XML
CountDrumLessonsForN()
CountGuitarLessonsForN()
CountSinLessonsForN()//Подсчет % под определенное количество уроков
YoutubeURL()// Подключение ссылки YouTube
```


## Выбор рабочего окружения

* [AndroidStudio](https://developer.android.com/studio) - IDE
* [android-youtube-player](https://github.com/PierfrancescoSoffritti/android-youtube-player) - Youtube player



## Автор

* **Петров Максим** - *Разработка* - [MusicGuide](https://github.com/immax54/MusicGuide)

## Лицензия

Проект под лицензией MIT 2022


