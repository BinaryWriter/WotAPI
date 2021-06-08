# WotAPI
Это C# библиотека для [World Of Tanks API](https://developers.wargaming.net/)
This is a C# library for the [World Of Tanks API](https://developers.wargaming.net/) <br>

Если у вас будут вопросы по использованию - пишите их в [сюда](https://github.com/BinaryWriter/WotAPI/issues) <br>
If you have any questions about the use - write them to [here](https://github.com/BinaryWriter/WotAPI/issues)

Примеры - [Русский](https://github.com/BinaryWriter/WotAPI/blob/master/ExamplesRU.md) | [Английский](https://github.com/BinaryWriter/WotAPI/blob/master/ExamplesEN.md) <br>
Examples - [RU](https://github.com/BinaryWriter/WotAPI/blob/master/ExamplesRU.md) | [EN](https://github.com/BinaryWriter/WotAPI/blob/master/ExamplesEN.md)

Создание WotApi:
```C#
  WotApi api = new WotApi("Application ID", ApiRegion.RU);
```
* "Application ID" - Айди вашего приложения. Вы можете получить его [тут](https://developers.wargaming.net/applications)
* ApiRegion.RU - Регион для запроса. Доступные: RU, EU, NA, ASIA

Creating a WotApi:
```C#
WotApi api = new WotApi("Application ID", ApiRegion.EU);
```
* "Application ID" - The ID of your application. You can get it [here](https://developers.wargaming.net/applications)
* ApiRegion.EU - The region for the request. Available: RU, EU, NA, ASIA

Выполнение запроса:
```C#
  RequestParameters parameters = new RequestParameters(Methods.Method, WotApi, ["search"], [page], [parameters]);
  ResponseClass clazz = api.SendRequest<ResponseClass>(parameters);
```
* Methods.Method - Один из доступных методов. Вы можете ознакомится с ними на [сайте Wargaming](https://developers.wargaming.net/reference/all/wot) (Method)
* WotApi - Апи который перед этим надо создать (WotApi)
* ["search"] - Если ваш метод производит поиск чего-либо то вам стоит указать этот параметр (Необязательно указывать) (string)
* [page] - Номер страницы (Необязательно указывать) (int) 
* [parameters] - Дополнительные параметры (Необязательно указывать) (Dictionary<string, string>)
* ResponseClass - Один из классов ответа

Request execution:
```C#
  RequestParameters parameters = new RequestParameters(Methods.Method, WotApi, ["search"], [page], [parameters]);
  ResponseClass clazz = api.sendRequest<ResponseClass>(parameters);
```

* Methods.Method - One of the available methods. You can find them at [Wargaming](https://developers.wargaming.net/reference/all/wot) (Method)
* WotApi - API which you need to create (WotApi)
* ["search"] - If your method searches for something that you should specify this parameter (Optional) (string)
* [page] - Page Number (Optional) (int) 
* [parameters] - Additional parameters (Optional) (Dictionary<string, string>)
* ResponseСlass - One of the response classes

Дополнительная информация | Additional information: <br>
	<li> Практически у всех полей есть описание | Almost all fields have a description:  </li>
	![image](https://github.com/BinaryWriter/WotAPI/raw/master/Images/ReadmeImage1.png)