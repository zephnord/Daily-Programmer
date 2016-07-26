##**Description**

A fraction exists of a numerator (top part) and a denominator (bottom part) as you probably all know.
Simplifying (or reducing) fractions means to make the fraction as simple as possible. Meaning that the denominator is a close to 1 as possible. This can be done by dividing the numerator and denominator by their greatest common divisor.


##**Formal Inputs & Outputs**

###**Input description**

You will be given a list with 2 numbers seperator by a space. The first is the numerator, the second the denominator
>4 8<br>
1536 78360<br>
51478 5536<br>
46410 119340<br>
7673 4729<br>
4096 1024<br>

###**Output description**

The most simplified numbers
>1 2<br>
64 3265<br>
25739 2768<br>
7 18<br>
7673 4729<br>
4 1<br> 

##**Notes/Hints**

Most languages have by default this kind of functionality, but if you want to challenge yourself, you should go back to the basic theory and implement it yourself.

##**Bonus**

Instead of using numbers, we could also use letters.<br>
For instance<br>
ab    a <br>
__ = _ <br>
cb    c <br>
And if you know that x = cb, then you would have this:<br>
ab   a <br>
__ = _ <br>
x    c <br>
and of course:<br>
a    1 <br>
__ = _ <br>
a    1 <br>

aa   a<br>
__ = _<br>
a    1<br>
The input will be first a number saying how many equations there are. And after the equations, you have the fractions.<br>
The equations are a letter and a value seperated by a space. An equation can have another equation in it.<br>
3<br>
x cb<br>
y ab<br>
z xa<br>
ab cb<br>
ab x<br>
x y<br>
z y<br>
z xay<br>
output:<br>
>a c<br>
a c<br>
c a<br>
c 1<br>
1 ab<br>

Source: https://www.reddit.com/r/dailyprogrammer/comments/4uhqdb/20160725_challenge_277_easy_simplifying_fractions/
