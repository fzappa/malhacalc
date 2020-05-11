
Imports BMath.Matriz
Imports BMath.Constantes

Imports BGeom.Vetor
Imports BGeom.Ponto
Imports BGeom.Transformacoes

Imports BObjetos.Objetos

Imports System.Drawing

Public Class Principal

    Dim Larg, Comp, p1, p2, d1 As Double
    Dim N, Imalha, Tdef, Nhastes, Hmalha As Double
    Dim Rmalha, Rgm, Lt, DistCond As Double
    Dim Correcao, Vt, Vp, Vtm, Vpm As Double
    Dim Km1, Ki1, Ks1, NDmalha As Double
    Dim alpha, beta, rhoa As Double
    Dim area, Na, Nb, Lhastes, Lcabos As Double
    Dim Tmax, Tamb As Double

    '------- Mouse ---------
    Private flag As Boolean = False
    Private dx, dy As Integer
    Private mousepoint As Point
    Private shift As Integer

    Private IsDragging As Boolean = False
    Private IsClick As Boolean = False
    Private StartPoint, FirstPoint, LastPoint As Point

    Private Zoom As Double = 5
    Private angx As Integer = 10
    Private angy As Integer = 10
    '---------------------------------


    Private Sub ConsideraçõesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsideraçõesToolStripMenuItem.Click
        Consideracoes.ShowDialog()
    End Sub

    Private Sub AutorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AutorToolStripMenuItem.Click
        Autor.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Calcula()
        Desenha()
    End Sub

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reset()
        Calcula()
    End Sub

    Private Sub ComboBox_material_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_material.SelectedIndexChanged
        Calcula()
    End Sub

    Private Sub ComboBox_condutor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_condutor.SelectedIndexChanged
        Calcula()
    End Sub

    Private Sub Reset()
        TextBox_largura.Text = "70"
        TextBox_comprimento.Text = "70"
        TextBox_rho1.Text = "2500"
        TextBox_d1.Text = "0,102"
        TextBox_rho2.Text = "400"
        TextBox_N.Text = "0,67"
        TextBox_correnteMalha.Text = "1200"
        TextBox_tempoCurto.Text = "0,5"
        TextBox_hmalha.Text = "0,5"
        TextBox_hastes.Text = "0"
        TextBox_distCond.Text = "7"
        TextBox_rminMalha.Text = "2,78"
        TextBox_tempMax.Text = "850"
        TextBox_tempAmbiente.Text = "40"
        ComboBox_material.SelectedIndex = 5
        ComboBox_condutor.SelectedIndex = 1
    End Sub

    Private Sub LeDados()
        Larg = CDbl(TextBox_largura.Text)
        Comp = CDbl(TextBox_comprimento.Text)
        p1 = CDbl(TextBox_rho1.Text)
        d1 = CDbl(TextBox_d1.Text)
        p2 = CDbl(TextBox_rho2.Text)
        N = CDbl(TextBox_N.Text)
        Imalha = CDbl(TextBox_correnteMalha.Text)
        Tdef = CDbl(TextBox_tempoCurto.Text)
        Hmalha = CDbl(TextBox_hmalha.Text)
        Nhastes = CDbl(TextBox_hastes.Text)
        Rmalha = CDbl(TextBox_rminMalha.Text)
        DistCond = CDbl(TextBox_distCond.Text)
        Tamb = CDbl(TextBox_tempAmbiente.Text)
        Tmax = CDbl(TextBox_tempMax.Text)
        area = Larg * Comp
    End Sub

    Private Sub ValidaHastes()
        Dim TotalHastes As Integer
        TotalHastes = CInt((CInt(Larg / DistCond) + 1) * (CInt((Comp / DistCond) + 1)))
        If Nhastes > TotalHastes Then
            Nhastes = TotalHastes
            TextBox_hastes.Text = TotalHastes.ToString
        End If
    End Sub






    Private Sub Calcula()
        GC.Collect()
        Dim DiametroCabo, SecCabo As Double
        Dim TCAP, Ar, Pr, K0 As Double
        LeDados()
        ValidaHastes()

        RCabo(ComboBox_condutor.Text, TCAP, Ar, Pr, K0)
        SecCabo = Amm2(Imalha, Tdef, TCAP, Ar, Pr, K0, Tmax, Tamb)
        DiametroCabo = 2 * Math.Sqrt(SecCabo / Math.PI) * 0.001

        'Malha Quadrada
        Na = Larg / DistCond
        Nb = Comp / DistCond

        NDmalha = Math.Sqrt(Na * Nb)

        Correcao = Cs(p2, p1, Hmalha)
        Km1 = Km(DistCond, Hmalha, 1, DiametroCabo, NDmalha)
        Ki1 = Ki(NDmalha)
        Ks1 = Ks(Math.Max(Na, Nb), Hmalha, DistCond)

        Lt = CalculaLTmax(Rmalha, p2, area, Hmalha)
        Lcabos = Lt
        Lhastes = Nhastes * 3
        Lt = Lcabos + Lhastes
        
        Vt = Etoque50(Correcao, RMaterial(ComboBox_material.Text), Tdef)
        Vp = Epasso50(Correcao, RMaterial(ComboBox_material.Text), Tdef)
        Vtm = Etm(p2, Imalha, Km1, Ki1, Lt)
        Vpm = Epm(p2, Imalha, Ks1, Ki1, Lt)
        Rgm = Rg(p2, Lt, area, Hmalha)

        ResAparente(area, p1, d1, p2, N, alpha, beta, rhoa)

        Label_gastoCabos.Text = Math.Round(Lt, 2).ToString + " [m]"
        Label_tensaoToqueMax.Text = Math.Round(Vt, 2).ToString + " [V]"
        Label_tensaoPassoMax.Text = Math.Round(Vp, 2).ToString + " [V]"
        Label_alpha.Text = Math.Round(alpha, 2).ToString + " [m]"
        Label_beta.Text = Math.Round(beta, 2).ToString + " [m]"
        Label_rhoA.Text = Math.Round(rhoa, 2).ToString + " [Ω x m]"

        If (Vtm > Vt) Then
            Label_tensaoToqueMaxMalha.ForeColor = Color.Red
            Label_tensaoToqueMaxMalha.Font = New Font(Label_tensaoToqueMaxMalha.Font, FontStyle.Bold)
            Label_tensaoToqueMaxMalha.Text = Math.Round(Vtm, 2).ToString + " [V]    ATENÇÃO! Valor maior que o da tensão de toque máximo!"
        Else
            Label_tensaoToqueMaxMalha.ForeColor = Color.Black
            Label_tensaoToqueMaxMalha.Font = New Font(Label_tensaoToqueMaxMalha.Font, FontStyle.Regular)
            Label_tensaoToqueMaxMalha.Text = Math.Round(Vtm, 2).ToString + " [V]"
        End If

        If (Vpm > Vp) Then
            Label_tensaoPassoMaxMalha.ForeColor = Color.Red
            Label_tensaoPassoMaxMalha.Font = New Font(Label_tensaoPassoMaxMalha.Font, FontStyle.Bold)
            Label_tensaoPassoMaxMalha.Text = Math.Round(Vpm, 2).ToString + " [V]    ATENÇÃO! Valor maior que o da tensão de passo máxima!"
        Else
            Label_tensaoPassoMaxMalha.ForeColor = Color.Black
            Label_tensaoPassoMaxMalha.Font = New Font(Label_tensaoToqueMaxMalha.Font, FontStyle.Regular)
            Label_tensaoPassoMaxMalha.Text = Math.Round(Vpm, 2).ToString + " [V]"
        End If

        Label_resistenciaMalha.Text = Math.Round(Rgm, 2).ToString + " [Ω x m]"
        Label_comprimentoCabos.Text = Math.Round(Lcabos, 2).ToString + " [m]"
        Label_secaoCabo.Text = Math.Round(SecCabo, 2).ToString + " [mm²]"
        Label_GPR.Text = Math.Round(Imalha * Rgm, 2).ToString + " [V]"
        Label_comprimentoHastes.Text = Math.Round(Lhastes, 2).ToString + " [m]"

        Label_Km1.Text = Math.Round(Km1, 2).ToString
        Label_Ki1.Text = Math.Round(Ki1, 2).ToString
        Label_Ks1.Text = Math.Round(Ks1, 2).ToString
        Label_Cs1.Text = Math.Round(Correcao, 2).ToString

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Reset()
    End Sub


    Private Sub Desenha()
        GC.Collect()
        LeDados()
        ValidaHastes()
        Dim Plano As New Plano(New Ponto3D(0, 0, 0), DistCond, Larg - 1, DistCond, Comp - 1)
        Dim Eixos1 As New Eixos(DistCond)
        Dim Eixos2 As New Eixos(Larg * 0.5)
        Dim TotalHastes As Integer
        Dim nhaste As Integer

        Dim _GL As Graphics
        Dim Cam1 As New BObjetos.Camera.Camera3D
        Dim MT, MROT, MCAM As New Matriz4x4

        _GL = PictureBox1.CreateGraphics

        ' Limpa a janela
        _GL.Clear(SystemColors.Window) '

        'Vetores iniciais da camera
        Dim Eye As New Vetor3D(1, 1, 1)
        Dim Centro As New Vetor3D(0, 0, 0) 'Localizacao da camera
        Dim Up As New Vetor3D(ZERO, ZERO, 1)

        'Parâmetros da câmera
        Cam1.Eye = Centro
        Cam1.Center = Eye
        Cam1.Up = -Up
        Cam1.Projecao = 0
        Cam1.Yaw = angx
        Cam1.Pitch = angy

        'Matriz rotacao do mouse
        MROT = MatrizRotacionaZ(angx) * MatrizRotacionaY(angy)

        'Matriz Camera
        MCAM = MROT * Cam1.Camera
        MT = MatrizEscala3D(Zoom, Zoom, Zoom, Centro) * MCAM ' 0 = Projecao

        TotalHastes = CInt((CInt(Larg / DistCond) + 1) * (CInt((Comp / DistCond) + 1)))
        Dim Vertices(TotalHastes) As Cilindro

        'Mapeia todos os vertices
        nhaste = 0
        For j = 0 To CInt(Larg / DistCond)
            For i = 0 To CInt(Comp / DistCond)
                Vertices(nhaste) = New Cilindro(New Ponto3D(i * DistCond, j * DistCond, 0), New Ponto3D(i * DistCond, j * DistCond, -10), 0.02, 1, 1)
                nhaste += 1
            Next
        Next


        nhaste = 0
        If Nhastes > TotalHastes Then
            MessageBox.Show("Para esta versão, o número total de hastes" & vbCrLf & _
                            "não pode ser maior que o número de vértices" & vbCrLf & _
                            "da malha.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        Else
            For h = 0 To CInt(Nhastes) - 1
                Vertices(h).GeraCasca3D()
                Vertices(h).Desenha(PictureBox1, MT)
            Next

        End If

        'For j = 0 To CInt(Larg / DistCond)
        '    For i = 0 To CInt(Comp / DistCond)
        '        For h = 0 To CInt(Nhastes) - 1
        '            Haste(h) = New Cilindro(New Ponto3D(i * DistCond, j * DistCond, 0), New Ponto3D(i * DistCond, j * DistCond, -10), 0.02, 1, 1)
        '            Haste(h).GeraCasca3D()
        '            Haste(h).Desenha(PictureBox1, MT)
        '        Next
        '    Next
        'Next


        Plano.Cor = Color.Black
        Plano.Desenha(PictureBox1, MT)
        Eixos1.Desenha(PictureBox1, MT)
        Eixos2.DesenhaCantoTela(PictureBox1, MCAM)
    End Sub


    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click
        Desenha()
    End Sub


    Private Function GraficoGPR() As Double()
        LeDados()
        Dim GPR(101) As Double
        'For i = 0 To 100 Step 1
        For j = 0 To Larg Step 1
            GPR(CInt(j)) = Imalha * Rg(p1, Lt, j * j, Hmalha)
        Next
        'Next

        Return GPR

    End Function


#Region "Eventos do mouse"

    Private Sub PictureBox1_MouseWheel(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseWheel

        If e.Delta > 0 Then
            If Zoom > 10 Then 'Se zoom maior que 10
                Zoom += 5     ' faz o incremento de 5
                If Zoom > 1000 Then 'Se zoom maior que 1000, mantem
                    Zoom = 1000
                End If
            Else
                Zoom += 0.5 'Se zoom menor que 10, incrementa de 0.5
            End If
        ElseIf e.Delta < 0 Then
            If Zoom <= 10 Then
                Zoom -= 0.5
                If Zoom < 1 Then
                    Zoom = 1
                End If
            Else
                Zoom -= 5
            End If
        End If
        Calcula()
        Desenha()

    End Sub

    Private Sub PictureBox1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PictureBox1.MouseDown
        If e.Button = MouseButtons.Left Then
            StartPoint = PictureBox1.PointToScreen(New Point(e.X, e.Y))
            FirstPoint = StartPoint
            IsDragging = True
            Calcula()
            Desenha()
        End If
    End Sub

    Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PictureBox1.MouseMove
        If IsDragging Then
            Dim EndPoint As Point = PictureBox1.PointToScreen(New Point(e.X, e.Y))
            IsClick = False
            angx += (EndPoint.X - StartPoint.X)
            angy += (EndPoint.Y - StartPoint.Y)
            StartPoint = EndPoint
            LastPoint = EndPoint
            Calcula()
            Desenha()
        End If
    End Sub

    Private Sub PictureBox1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseUp
        IsDragging = False
        If LastPoint = StartPoint Then IsClick = True Else IsClick = False
    End Sub

#End Region


    'Public Sub Plota()
    '    Dim Valores() As Double
    '    LeDados()
    '    Valores = GraficoGPR()

    '    Chart1.Series.Clear()
    '    Chart1.Series.Add("Novo")
    '    Chart1.Series("Novo").BorderWidth = 2

    '    'Inicializa e plota o gráfico
    '    Chart1.Series("Novo").ChartType = SeriesChartType.Line 'DataVisualization.Charting.SeriesChartType.Line
    '    For i = 0 To 100 Step 1
    '        Chart1.Series("Novo").Points.AddXY(1, Valores(i)) 'Adds the data from the array to the first series
    '    Next
    'End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label_Km.Click

    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label_Cs.Click

    End Sub
End Class
