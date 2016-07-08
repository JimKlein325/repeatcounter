# Address Book

#### C# skill demonstration project:  Week 1 - July, 2016

#### By Jim Klein

## Description

Address Book is a sample application for demonstrating basic proficiency in creating simple web apps using Nancy, Razor and related technologies.

A user can enter contact information and build a list of contacts that are displayed as an address book, view contact details, and clear all of the entries in the address book.  

Behavior|inputSentence|inputWord|Output|Remarks
Match at least one occurrence of a string|The red fox chased the brown dog.|the|1|This is a simple sentence with multiple occurrences of search string.
Match case sensitive occurences of a string.|The red fox chased the brown dog.|the|1|This sentence has a single example of the word with differing capitalizaiton.
Match all occurences of chars in string.|The red fox chased the brown dog.|the|2|ditto
Match only full word occurrences of a string: case insensitive match of string preceded by a space and followed by a space or a punctuation mark character.|The red fox chased the brown dog through the heather.|the|3|This sentence adds an occurrence of the word characters within another word.

## Setup/Installation Requirements
* Install Address Book by cloning this repository:
    https://github.com/JimKlein325/addressbook.git
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
