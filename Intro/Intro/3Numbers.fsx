﻿type num = Zero | OneMoreThan of num

Zero // what is my type?
let a = Zero
OneMoreThan Zero // and mytype)?
let two = (OneMoreThan (OneMoreThan Zero))
two

// make five with num!
// let five = 
// what is the type of five?

// What is the difference between Zero and 0
0 // what is my type?

//Are there more nums than bools?
//Are there more nums than positive ints?


// What are these things?
type boolnum = Zero of bool | OneMoreThan of boolnum
Zero true

type intnum = Zero of int | OneMoreThan of intnum
Zero 0