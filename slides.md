<!-- class: center, middle -->
class: left, top

# Daily RegEx
### and my friend Vi[m]

Url: [Url](https://kcoon.github.io/DailyRegEx)

???

Notes for the _first_ slide!

---

# Agenda

1. Normal comment to summary
2. Deep-dive
3. ...

[NOTE]: Note that you need active internet connection to access remark.js script file
---

# Normal comment to summary

normal
*italic*
**bold**

```
		// Square function $d \rightarrow d^2 $
		public double Square(double d) =>  d * d;
```
```
		/// <summary>
		///		Square function $d \rightarrow d^2 $
		/// </summary>
		public double Square(double d) =>  d * d;
```

```
s/\/\/\s*\(.*\)/\/\/\/<summary>\r\t\t\/\/\/\t\t\1\r\t\t\/\/\/<\/summary>
```

