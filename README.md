# Repeat Finder

#### C# skill demonstration project:  Week 2 - July, 2016

#### By Jim Klein

## Description

Repeat Finder is a sample application for demonstrating basic proficiency in BDD coding techniques and creating simple web apps using Nancy, Razor and related technologies.

A user can enter a sentence and a word to find and receives a count of the occurrences of that word in the input sentence.

##BDD Notes

Behavior           |inputSentence          |inputWord        |Output          |Remarks
------------------ | --------------------- |-----------------|----------------|--------------|
Count should be 0 if no occurrence of search word. |Four score and seven years ago.|the|0|This is a simple test of the case where the string does not contain the word.
Match the word in a search string that contains only the word.|the|the|1|This input has a single example of the word.
Match all occurrences of letters in string. |the red fox chased the brown dog.|the|2|This sentence has multiple occurrences of the word.
Match all occurrences of letters in string, regardless of capitalizaiton. |the red fox chased the brown dog.|the|2|This sentence has multiple occurrences of the word with differing capitalizaiton.
Count should be zero if word occurs within another word. | heather | the | 0 | This is a simple example of the word occurring within another word.
Match word when preceded by punctuation. |The red fox chased the brown \"dog.\" 'dog -dog (dog.|dog|4|This sentence contains simple examples for each of the supported punctuation marks.
Match word when followed by punctuation. |The red fox chased the brown dog. dog, dog- dog' dog\" dog\' dog! dog? dog) |dog|9|This sentence contains simple examples for each of the supported punctuation marks.
Match only full word occurrences of a string: case insensitive match of string preceded by a space and followed by a space or a punctuation mark character. |The red fox chased the brown dog through the heather.|the|3|This sentence adds an occurrence of the word characters within another word.


## Setup/Installation Requirements
* Install this project by cloning this repository:
    https://github.com/JimKlein325/repeatcounter.git
* Compile using the PowerShell "dnx kestrel" command in the project directory
* View the app in your browser at "localhost:5004"

## Technologies Used
* Nancy, a lightweight web application framework, used to create websites using C#.
* Razor, a view engine that gives us a way to combine C# code with markup with an easy-to-use syntax.
* RESTful naming conventions for routes
* HTML
* Bootstrap

### License
MIT License  Copyright (c) 2016 **Jim Klein**
