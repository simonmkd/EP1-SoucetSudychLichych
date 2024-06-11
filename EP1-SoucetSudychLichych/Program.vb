Imports System

Module Program
   Sub Main(args As String())
        Dim cislo1, cislo2 As String
        Dim cisl, cisl2, vysledek As Integer
        Do
            Console.Write("Napiš číslo: ")
            cislo1 = Console.ReadLine()

            Console.Write("Napiš 2. číslo: ")
            cislo2 = Console.ReadLine()

            If Integer.TryParse(cislo1, cisl) And
                Integer.TryParse(cislo2, cisl2) Then
                If cisl >= 0 And cisl2 >= 0 Then
                    vysledek = cisl + cisl2
                    Console.WriteLine($"Výsledek je: {vysledek}")
                Else
                    Console.WriteLine("Zádávej pouze kladná čísla!")
                End If

            Else
                    Console.WriteLine("Zadávej pouze celá čísla!!")
            End If

        Loop
  End Sub
End Module
