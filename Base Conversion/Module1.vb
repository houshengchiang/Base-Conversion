Module Module1
    'add exception to count
    Sub Main()

        Dim NumToConv As Integer
        Dim BaseNum As Integer
        Dim Remainder As Integer
        Dim count As Integer
        Dim order(count) As Integer
        Dim result(count) As Integer

        Console.WriteLine("Enter a number to convert:")
        NumToConv = Console.ReadLine()
        Console.WriteLine("You Entered: " & NumToConv)

        Console.WriteLine("Enter a base number:")
        BaseNum = Console.ReadLine()
        Console.WriteLine("You entered: " & BaseNum)

        Console.WriteLine("")

        Do
            count = count + 1
            order(count) = order(count)
            Remainder = NumToConv Mod BaseNum
            order(count) = Remainder
            Console.Write(order(count))
            NumToConv = NumToConv \ BaseNum


            'Console.ReadKey()
        Loop While NumToConv <> 0




        Console.ReadKey()

    End Sub

End Module
