Imports System.Windows.Forms
Public Module Equacoes

    Public Sub ResAparente(ByVal AreaMalha As Double,
                           ByVal p1 As Double,
                           ByVal d1 As Double,
                           ByVal p2 As Double,
                           ByVal N As Double,
                           ByRef alpha As Double, ByRef beta As Double, ByRef pa As Double)

        Dim r As Double

        r = Math.Sqrt(AreaMalha / Math.PI)
        alpha = r / d1
        beta = p2 / p1
        pa = N * p1

    End Sub

    'Ja retorna em m^2
    Public Function Amm2(ByVal Imalha As Double,
                         ByVal Tcurto As Double,
                         ByVal TCAP As Double,
                         ByVal Ar As Double,
                         ByVal Pr As Double,
                         ByVal K0 As Double,
                         ByVal Tm As Double,
                         ByVal Ta As Double) As Double

        Dim T0, T1 As Double

        T0 = (TCAP) / (Tcurto * Ar * Pr)
        T1 = (K0 + Tm) / (K0 + Ta)


        Amm2 = (Imalha * (197.4 / Math.Sqrt(T0 * Math.Log(T1)))) * 0.000506707

    End Function


    Public Function Cs(ByVal p As Double,
                            ByVal ps As Double,
                            ByVal hs As Double) As Double

        Cs = 1 - ((0.09 * (1 - (p / ps))) / (2 * hs + 0.09))
    End Function


    Public Function Etoque50(ByVal Cs As Double,
                         ByVal ps As Double,
                         ByVal ts As Double) As Double

        Etoque50 = (1000 + 1.5 * Cs * ps) * (0.116 / Math.Sqrt(ts))
    End Function


    Public Function Epasso50(ByVal Cs As Double,
                             ByVal ps As Double,
                             ByVal ts As Double) As Double

        Epasso50 = (1000 + 6 * Cs * ps) * (0.116 / Math.Sqrt(ts))
    End Function


    Public Function Rg(ByVal p As Double,
                       ByVal Lt As Double,
                       ByVal Area As Double,
                       ByVal h As Double) As Double

        Dim Eq1, Eq2 As Double

        Eq1 = (1 / Math.Sqrt(20 * Area))
        Eq2 = 1 / (1 + h * Math.Sqrt(20 / Area))

        If (Lt < 1) Then
            Lt = 1
        End If

        If Eq1 < 0.001 Then
            Eq1 = 0.001
        End If

        If Eq2 < 0.001 Then
            Eq2 = 0.001
        End If



        Rg = p * ((1 / Lt) + (Eq1) * (1 + (Eq2)))

    End Function


    Public Function Km(ByVal DistCondutores As Double,
                       ByVal Hmalha As Double,
                       ByVal h0 As Double,
                       ByVal DiametroCabo As Double,
                       ByVal n As Double) As Double

        Dim Kii, Kmi As Double
        Dim Kh As Double
        Dim T0, T1, T2, T3, T4, T5 As Double

        Kii = (2 * n) ^ (-2 / n)
        Kh = Math.Sqrt(1 + (Hmalha / h0))

        T0 = 1 / (2 * Math.PI)
        T1 = (DistCondutores ^ 2) / (16 * Hmalha * DiametroCabo)
        T2 = ((DistCondutores + 2 * Hmalha) ^ 2) / (8 * DistCondutores * DiametroCabo)
        T3 = Hmalha / (4 * DiametroCabo)
        T4 = Kii / Kh
        T5 = 8 / (Math.PI * (2 * n - 1))

        Kmi = T0 * (Math.Log(T1 + T2 - T3) + T4 * Math.Log(T5))

        Km = Kmi
    End Function



    Public Function Ki(ByVal n As Double) As Double

        Ki = 0.644 + 0.148 * n

    End Function

    Public Function Ks(ByVal n As Double,
                       ByVal h As Double,
                       ByVal D As Double) As Double

        Ks = (1 / Math.PI) * ((1 / (2 * h)) + (1 / (D + h)) + (1 / D) * (1 - 0.5 ^ (n - 2)))

    End Function


    'Tensão de toque na malha
    Public Function Etm(ByVal p As Double,
                        ByVal Ig As Double,
                        ByVal Km As Double,
                        ByVal Ki As Double,
                        ByVal Lt As Double) As Double

        Etm = (p * Ig * Km * Ki) / Lt

    End Function

    'Tensão de passo na malha
    Public Function Epm(ByVal p As Double,
                        ByVal Ig As Double,
                        ByVal Ks As Double,
                        ByVal Ki As Double,
                        ByVal Lt As Double) As Double

        Epm = (p * Ig * Ks * Ki) / Lt

    End Function


    Public Function CalculaLTmax(ByVal R As Double,
                                 ByVal p As Double,
                                 ByVal AreaMalha As Double,
                                 ByVal h As Double) As Double

        Dim Rmax As Double
        Dim Lt As Double = 0

        Rmax = Rg(p, 1, AreaMalha, h) 'Lt inicial igual a 1m

        While (Rmax > R)                 'Se a resistencia da malha for maior que a resistencia minima
            Lt += 1                      'Incrementa o tamanho maximo de malha em 5m
            If (Lt > 1000000.0) Then
                MessageBox.Show("Comprimento da malha inviável para essa configuração." & vbCrLf & _
                                "Altere a resistência do solo, a resitência mínima da malha ou a área.", "Erro", _
                                MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                Exit While
            Else
                Rmax = Rg(p, Lt, AreaMalha, h)
            End If
        End While


        Return Lt

    End Function


    Public Function RMaterial(ByVal tipo As String) As Double
        Select Case tipo
            Case "Pantano"
                RMaterial = 50
            Case "Lodo"
                RMaterial = 100
            Case "Humus"
                RMaterial = 150
            Case "Areia Argilosa"
                RMaterial = 200
            Case "Areia Silicosa"
                RMaterial = 1000
            Case "Brita"
                RMaterial = 3000
            Case "Calcareo"
                RMaterial = 5000
            Case "Granito"
                RMaterial = 10000
            Case Else
                RMaterial = 3000
        End Select

    End Function


    Public Sub RCabo(ByVal tipo As String,
                     ByRef TCAP As Double,
                     ByRef Ar As Double,
                     ByRef Pr As Double,
                     ByRef K0 As Double)
        'Tabela 1
        Select Case tipo
            Case "Cobre mole"
                Ar = 0.00393
                K0 = 234
                Pr = 1.72
                TCAP = 3.4
            Case "Cobre comercial"
                Ar = 0.00381
                K0 = 242
                Pr = 1.78
                TCAP = 3.4
            Case "Cobre com alma de aço"
                Ar = 0.00378
                K0 = 245
                Pr = 10.1
                TCAP = 3.8
            Case "Alumínio com alma de aço"
                Ar = 0.0036
                K0 = 258
                Pr = 8.48
                TCAP = 3.561
            Case "Aço 1020"
                Ar = 0.00377
                K0 = 245
                Pr = 15.9
                TCAP = 3.8
            Case "Aço inoxidável"
                Ar = 0.00377
                K0 = 245
                Pr = 17.5
                TCAP = 4.4
            Case "Zinco"
                Ar = 0.0032
                K0 = 293
                Pr = 20.1
                TCAP = 3.9
            Case "Aço inoxidável 304"
                Ar = 0.0013
                K0 = 749
                Pr = 72.0
                TCAP = 4.0
            Case Else
                Ar = 0.00381
                K0 = 242
                Pr = 1.78
                TCAP = 3.4
        End Select

    End Sub






End Module
