Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        limpiar()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcantidad.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If chbsmall.Checked = False And chbmedium.Checked = False And chblarge.Checked = False Then
            MsgBox("No as elegido tamaño")

        End If

        If Rbalgodon.Checked = False And Rbseda.Checked = False And Rblona.Checked = False Then
            MsgBox("No as elegido material")
            End
        End If

        If txtcantidad.Text = " " Then
                MsgBox("Ingrese una cantidad")
            End
        End If

            Dim tamaño As String
        Dim material As String

        If chbsmall.Checked Then
            tamaño = "small"
        ElseIf chbmedium.Checked Then
            tamaño = "medium"

        Else
        tamaño = "large"
        End If

        If Rbseda.Checked Then
            material = "seda"
        ElseIf Rbalgodon.Checked Then
            material = "algodon"

        Else
            material = "lona"
        End If


        calcular(material, tamaño, Val(txtcantidad.Text))
        Me.Hide()
        Form2.Show()


        Dim a = 0
        a = calcular(a)
        MsgBox(a)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (MsgBox("DESEA SALIR", vbQuestion + vbYesNo, "MENSAJE SALIDA") = vbYes) Then
            End
        Else
            'LLAMADA AL PROCEDIMIENTO QUE LIMPIA LOS OBJETOS EN EL FORMULARIO
            limpiar()
        End If
    End Sub
End Class
