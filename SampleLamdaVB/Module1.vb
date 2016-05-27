Module Module1



    Sub Main()
        'https://msdn.microsoft.com/ja-jp/library/bb531298.aspx

        'Lamba Expressionサンプル
        'ラムダ式サンプル

        'VBちっくにFunction～End Functionする場合
        Dim add1 = Function(num As Integer)
                       Return num + 1

                   End Function

        '一行で書く場合
        Dim add2 = Function(num As Integer) num + 2



        Console.WriteLine（add1(5))
        Console.WriteLine(add2(5))

        '関数を定義して即時実行する場合
        '(Function(num As Integer) num + 1)(5)
        '無名関数を定義して、5をパラメーターで渡す
        Console.WriteLine((Function(num As Integer) num + 1)(5))


        Dim aaa = Function(num1 As Integer, num2 As Integer)
                      Return num1 + num2
                  End Function
        Dim bbb = Function(num1 As Integer, num2 As Integer) (num1 + num2)



        'Sub～End Subで書く場合
        Dim wMsg = Sub(a As Integer)
                       Console.WriteLine(a.ToString())

                   End Sub

        wMsg(123)

        '一行で書く場合
        Dim writeMessage = Sub(msg As String) Console.WriteLine(msg)
        writeMessage("Lamba Expression")




    End Sub

End Module
