'Alexis Villagran 
'Spring 2025
'RCET 2265
'Say My Name
'https://github.com/alxsvxn/SayMyName.git

Option Explicit On
Option Strict On
Module SayMyName

    Sub Main()

        Console.WriteLine("What is your name?")

        Dim Name As String = Console.ReadLine() 'This will declare 'name' as a string & then ConsoleReadline will read the text inputted by the user.

        Console.ReadKey() 'Readkey is an operation that will execute the next line of code after a key is pressed
        Console.WriteLine()

        Console.WriteLine(Name & ": You know. You all know exactly who I am. Say my name.")

        Console.WriteLine()

        Console.WriteLine("Rossiter: You're, " & Name) 'Takes advantage of the fact that we have defined a variable and displays whatever string was inputted.

        Console.ReadKey()
        Console.WriteLine()

        Console.WriteLine(Name & ":You're goddamn right.")

    End Sub

End Module
