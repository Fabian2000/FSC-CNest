# FSC-CNest
 A C# framework to make coding easier

## Why CNest?
CNest is a small, but powerful and crossplatform library that makes a lot of coding easier. It allows you to finish coding much faster than before.

## What does CNest mean?
CNest is a library from 2020 and was created for only one reason. Nesting windows forms controls. 
In 2021, the second version of CNest came up. Version 2 went more the way of a framework and contained nesting windows forms features, but also some other C# features, which were developed to make coding easier. Many big codes became one-liners.
Now in 2022 the first version of CNest 3 came out. It got renamed to FSC-CNest.
(FSC describes is the short prefix for the developer name). FSC-Nest does not include the nesting features anymore, but the name never changed. The functionality changed at all. A lot of more features than before and it will become more with the time.

## CNest features?
CNest has a lot of features ... It is compatible with windows, linux and more.

### Terminal using FSC_CNest.TerminalAdvanced
The Terminal class is a one to one copy of the Console class. You can use it like before. Instead of Console.WriteLine(); you can write Terminal.WriteLine();
Why Terminal? Why remaking an existing and good working class?
Terminal contains all features from Console, but also got some more advanced features.
Maybe you remember a moment, when you wrote:
```cs
Console.Write("Username: ");
Console.ReadLine();
```
As you can see, you have 2 lines of code. The Terminal class needs only one.
```cs
Terminal.ReadLine("Username: ");
```
What? You're not surprised? Ok, here's a better argument for you:
```
Console.WriteLine("Username: ");
Console.ReadLine();
Console.WriteLine("Password: ");
Console.ReadLine();
```
Do you see the problem? The password is visible. Isn't that bad?
Check out Terminal:
```cs
Terminal.ReadLine("Username: ");
Terminal.ReadLine("Password: ", true);
```
As you can see, Terminal accepts a boolean. This boolean toggles between clear text and password symbols.
Even the password symbol can be changed. Default symbol: *******
Terminal contains a lot of more cool features, try it out.

### Extensions: using FSC_CNest.Extensions
You are bored of a lot of methods? This extensions makes your life easier:

### Convert
CNest allows you to convert any type by doing this:
```cs
string s = "999";
int i = s.To<int>();
string anotherS = i.To<string>();
...
```

### Color
Invert() and GrayScale() are simple to use and do what they are made for.
Create a color:
`Color c = Color.Red;`
And now try the new features:
`c = c.Invert();`

### Encode and decode
```
string s = "hello";
s = s.EncodeBase64();
s = s.DecodeBase64();
s = s.EncodeURL();
s = s.DecodeURL();
```

### Hashes FSC_CNest.
It was never that easy to create a hash. Let's take MD5 as an example:
```
string s = "hello";
s = s.ToHashString("MD5");
byte b = s.ToHashBytes("MD5");
```
It's very easy. The use of MD5 is not a need. For all the hashes, check out the Microsoft documentation about HashAlgorithm.Create()

---

### Crypt using FSC_CNest.Crypt
AES, a really cool way of encryption. You think it is complex? Yes, a little bit. But CNest makes it easy for you. Check out the AES class

### RGB using FSC_CNest.Colors
Let's bring some color into your software. You like RGB? Don't worry, the RGB class delivers exactly what you need. Make a loop, call the Smooth RGB method and you get a smooth rainbow.
It also delivers a static random color generator.

### Graphics FSC_CNest.Graphics
What would you say, if you can pick a pixel from any xy-point on your screen? Now you can.
`ScreenActivity.PickColor(int x, int y)` picks any Pixel from x and y and returns it as Color.

### Hardware using FSC_CNest.Hardware
You need the possibility to create a hardware id (HWID)?
Or you only want to get some computer informations?
Check out `Computer.GetHardwareInfo(...);`. It has returns many informations of the computer, where your program is running on.

### IO using FSC_CNest.IO
Did the File class a remake like Console? No, don't worry. Not everything got a remake.

### Logger
IO has a logger for you. Check out the Logger class. You're bored of using multiple instances? Logger includes a singleton. `Logger.Instance`.
Logger has three possible Logging methods: Console, File and Console + File. (Console is a windows only feature and also works on non-console applications).

### PathBuilder
Yes, it sounds strange ... Why do you need a path builder? The answer is simple as always.
To answer that, you need to know, what PathBuilder do.
- Build a path.
- Navigate forward and backwards like in a browser.
- Check, if the needed navigation direction is possible.
- Return the path.
An example could be: You build a little file manager and you plan to include a path input. Now you want to navigate forward and backwards. PathBuilder does this for you.

### PathVar
There is not much to explain. You need the AppData path? Get it. Or what about the document path?
It's always annoying to use the normal way ... This small class makes it just easier ...

---

### Text using FSC_CNest.Text
If you are interested in using some UTF8 symbols like minimize, maximize, normalize and close, then check out the Symbols class

### Natives and NativesValues FSC_CNest.WindowsNatives
Not all features are made in C# only. The used native methods and some more are public available in the Native class. You need some NativeValues? Also they got their own class.

---
---

The library works crossplatform. It is very easy to use. Not all features work with every .Net / .Net Framework version and not all features are possible on other operating systems. The most features work everywhere.

You have a problem with the encoding? It is wrong?
You can manipulate the encoding of the whole library:
using FSC_CNest;
CNestSettings class

---

You like this idea of framework? Feel free to tell me more about your ideas to make it better and better.
