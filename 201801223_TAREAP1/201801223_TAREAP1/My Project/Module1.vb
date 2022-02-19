Module Module1
    Public Const precio_mano_obra_small = 65.55
    Public Const precio_mano_obra_medium = 85.99
    Public Const precio_mano_obra_large = 99.99

    Public Const yarda_algodon = 15
    Public Const yarda_seda = 23
    Public Const yarda_lona = 30.99


    Public Const cantidad_yarda_small = 2
    Public Const cantidad_yarda_medium = 2.5
    Public Const cantidad_yarda_large = 3

    Public Function calcular(ByVal b As Double)
        b = 2
        Return b
    End Function
    Public precio_costo = 0
    Public precio_venta = 0


    Public Sub calcular(material As String, tamaño As String, cantidad As Double)
        Select Case tamaño
            Case "small"
                precio_costo = cantidad * precio_mano_obra_small + cantidad * yarda_algodon * cantidad_yarda_small
            Case "medium"
                precio_costo = cantidad * precio_mano_obra_small + cantidad * yarda_seda * cantidad_yarda_small
            Case "large"
                precio_costo = cantidad * precio_mano_obra_small + cantidad * yarda_lona * cantidad_yarda_small
        End Select

        Select Case material
            Case "algodon"
                precio_costo = cantidad * precio_mano_obra_medium + cantidad * yarda_algodon * cantidad_yarda_medium
            Case "seda"
                precio_costo = cantidad * precio_mano_obra_medium + cantidad * yarda_seda * cantidad_yarda_medium
            Case "lona"
                precio_costo = cantidad * precio_mano_obra_medium + cantidad * yarda_lona * cantidad_yarda_medium

        End Select
        'large

        precio_venta = precio_costo + 0.65 * precio_costo




    End Sub
    Sub limpiar()
        Form1.txtcantidad.Clear()

        Form2.Label1.Text = "limpio"
    End Sub

    Sub salir()
        End
    End Sub
End Module
