<!-- class: center, middle -->
class: left, top

# Daily RegEx
### and my friend Vi[m]

Url: [https://kcoon.github.io/DailyRegEx](https://kcoon.github.io/DailyRegEx)

___
powered by [remark](https://github.com/gnab/remark)

???

Notes for the _first_ slide!

---

# What is RegEx?

From Wikipedia:

*A regular expression, regex or regexp is a sequence of characters that define a search pattern*

---
# Eh yeah...but what is it?

String: G01 X10 Y27 F200

Pattern: G(\d+)\s*X(\d+)\s*Y(\d+)\s*F(\d+)
_____________

Match Group1: 01 

Match Group2: 10 

Match Group3: 27 

Match Group4: 200 

[Link to Rubular](https://rubular.com/r/sbQvDdZjMWg5Hi)

---
# So it's a parsing language?

**Yes**

but only for simple context free parsing - commonly line based
---
# And you use this every day? Are you a compiler developer?

**Yes, I do**

**No, I'm not**

I'm using RegEx for refactoring at daily coding.
---

# Examples

The following slides are showing examples of refactoring C#-code

## But first a simple search and replace with vim

Vim has a command mode which is initiated with `:`

With the command `s` (for substitution) we can make a simple search and replace

```
:s/<pattern>/<substitution>/<parameter>
```

---
# Move comments from behind to above

``` csharp
		public double SeriousProperty { set; get; }	// the meaning of this property is super secret
```
``` csharp
		// the meaning of this property is super secret
		public double SeriousProperty { set; get; }	
```
```
s/\(.*\)\(\/\/.*\)/\t\t\2\r\1\r
```

---

# Normal comment to summary

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

---

# Add visibility to method

```
		// don't add visibility to this comment
		int MissingVisibilityMethod() => return 0;
```

```
		// don't add visibility to this comment
        public int MissingVisibilityMethod() => return 0;
```

```
s/^\(\s*\)\(\w\)/\1public \2
```

---

# From statement to expression body

```
		public int LifeUniverseAndEverything()
		{
			return 42;
		}
```

```
		public int LifeUniverseAndEverything() => 42;
```

```
s/\n\s*{\s*\n\s*return\s*\(.*\)\n\s*}/ => \1/g
```

---

# return code to xml-list item		
		
```
		//	*		1, 2, 3        different return codes with same meaning
		//	*		4              4 ever
		//	*		5              high 5
		//	*		6              sinister 6
		public int MethodWithReturnCodes()
		{
			return 0;
		}
```

```
		// s/^\D*\(\d\+\(,\s*\d\)*\)\s*\(.*\)$/\t\t\/\/\/\t<item>\r\t\t\/\/\/\t\t<term>\1<\/term>\r\t\t\/\/\/\t\t<description>\3<\/description>\r\t\t\/\/\/\t<\/item>
```

---

# Wasn't that mighty magic?

```
		///	<item>
		///		<term>1, 2, 3</term>
		///		<description>multiple return codes</description>
		///	</item>
		///	<item>
		///		<term>4</term>
		///		<description>4 ever</description>
		///	</item>
		///	<item>
		///		<term>5</term>
		///		<description>high 5</description>
		///	</item>
		///	<item>
		///		<term>6</term>
		///		<description>sinister 6</description>
		///	</item>
		public int MethodWithReturnCodes()
		{
			return 0;
		}
```
---

# Do I have to learn Vim now?

**No** but it's awesome!

RegEx can be used in different editors or IDEs.

I use VisualStudio with VsVim plugin

---
# Thanks
## Hack on