Public Class Form1
    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        txtDoubleInteger.Text = DoubleTheInteger(Val(txtInputInteger.Text))
        txtHalfInteger.Text = HalfTheInteger(Val(txtInputInteger.Text))
        txtSquareInteger.Text = SquareTheInteger(Val(txtInputInteger.Text))
        txtCubeInteger.Text = CubeTheInteger(Val(txtInputInteger.Text))
    End Sub

    Private Function DoubleTheInteger(ByVal intInputInteger As Integer) As Integer
        DoubleTheInteger = intInputInteger * 2
        Return DoubleTheInteger
    End Function

    Private Function HalfTheInteger(ByVal intInputInteger As Integer) As Double
        HalfTheInteger = intInputInteger / 2
        Return HalfTheInteger
    End Function

    Private Function SquareTheInteger(ByVal intInputInteger As Integer) As Integer
        SquareTheInteger = intInputInteger ^ 2
        Return SquareTheInteger
    End Function

    Private Function CubeTheInteger(ByVal intInputInteger As Integer) As Integer
        CubeTheInteger = intInputInteger ^ 3
        Return CubeTheInteger
    End Function
End Class
