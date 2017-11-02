Imports System.Drawing

Public Class Effect

    Public Shared Sub Emboss(Src As Bitmap, ByRef Progress As Long)

        Progress = 0
        Dim TempBmp As New Bitmap(Src)
        Dim DispX As Integer = 1, DispY As Integer = 1
        Dim Red, Green, Blue As Integer

        With TempBmp
            For I = 0 To .Height - 2
                For J = 0 To .Width - 2
                    Dim FirstPixel, SecondPixel As Color
                    FirstPixel = .GetPixel(J, I)
                    SecondPixel = .GetPixel(J + DispX, I + DispY)
                    Red = Math.Min(Math.Abs(CInt(FirstPixel.R) - SecondPixel.R) + 128, 255)
                    Green = Math.Min(Math.Abs(CInt(FirstPixel.G) - SecondPixel.G) + 128, 255)
                    Blue = Math.Min(Math.Abs(CInt(FirstPixel.B) - SecondPixel.B) + 128, 255)
                    Src.SetPixel(J, I, Color.FromArgb(Red, Green, Blue))
                Next J

                If I Mod 10 = 0 Then
                    Progress = Int(100 * I / (Src.Height - 2))
                End If
            Next I
        End With

    End Sub

    Public Shared Sub Sharpen(Src As Bitmap, ByRef Progress As Long)

        Dim TempBmp As New Bitmap(Src)
        Dim DX As Integer = 1
        Dim DY As Integer = 1
        Dim Red, Green, Blue As Integer

        With TempBmp
            For I = DX To .Height - DX - 1

                For J = DY To .Width - DY - 1
                    Red = CInt(.GetPixel(J, I).R) + 0.5 * CInt((.GetPixel(J, I).R) - CInt(.GetPixel(J - DX, I - DY).R))
                    Green = CInt(.GetPixel(J, I).G) + 0.7 * CInt((.GetPixel(J, I).G) - CInt(.GetPixel(J - DX, I - DY).G))
                    Blue = CInt(.GetPixel(J, I).B) + 0.5 * CInt((.GetPixel(J, I).B - CInt(.GetPixel(J - DX, I - DY).B)))
                    Red = Math.Min(Math.Max(Red, 0), 255)
                    Green = Math.Min(Math.Max(Green, 0), 255)
                    Blue = Math.Min(Math.Max(Blue, 0), 255)
                    Src.SetPixel(J, I, Color.FromArgb(Red, Green, Blue))
                Next J

                If I Mod 10 = 0 Then
                    Progress = Int(100 * I / (Src.Height - 2))
                End If

            Next I
        End With

    End Sub

    Public Shared Sub Smooth(Src As Bitmap, ByRef Progress As Long)

        Dim TempBmp As New Bitmap(Src)
        Dim DX As Integer = 1
        Dim DY As Integer = 1
        Dim Red, Green, Blue As Integer

        With TempBmp
            For I = DX To .Height - DX - 1

                For J = DY To .Width - DY - 1

                    Red = CInt((CInt(.GetPixel(J - 1, I - 1).R) +
                            CInt(.GetPixel(J - 1, I).R) +
                            CInt(.GetPixel(J - 1, I + 1).R) +
                            CInt(.GetPixel(J, I - 1).R) +
                            CInt(.GetPixel(J, I).R) +
                            CInt(.GetPixel(J, I + 1).R) +
                            CInt(.GetPixel(J + 1, I - 1).R) +
                            CInt(.GetPixel(J + 1, I).R) +
                            CInt(.GetPixel(J + 1, I + 1).R)) / 9)

                    Green = CInt((CInt(.GetPixel(J - 1, I - 1).G) +
                            CInt(.GetPixel(J - 1, I).G) +
                            CInt(.GetPixel(J - 1, I + 1).G) +
                            CInt(.GetPixel(J, I - 1).G) +
                            CInt(.GetPixel(J, I).G) +
                            CInt(.GetPixel(J, I + 1).G) +
                            CInt(.GetPixel(J + 1, I - 1).G) +
                            CInt(.GetPixel(J + 1, I).G) +
                            CInt(.GetPixel(J + 1, I + 1).G)) / 9)

                    Blue = CInt((CInt(.GetPixel(J - 1, I - 1).B) +
                            CInt(.GetPixel(J - 1, I).B) +
                            CInt(.GetPixel(J - 1, I + 1).B) +
                            CInt(.GetPixel(J, I - 1).B) +
                            CInt(.GetPixel(J, I).B) +
                            CInt(.GetPixel(J, I + 1).B) +
                            CInt(.GetPixel(J + 1, I - 1).B) +
                            CInt(.GetPixel(J + 1, I).B) +
                            CInt(.GetPixel(J + 1, I + 1).B)) / 9)

                    Red = Math.Min(Math.Max(Red, 0), 255)
                    Green = Math.Min(Math.Max(Green, 0), 255)
                    Blue = Math.Min(Math.Max(Blue, 0), 255)
                    Src.SetPixel(J, I, Color.FromArgb(Red, Green, Blue))

                Next J

                If I Mod 10 = 0 Then
                    Progress = Int(100 * I / (Src.Height - 2))
                End If

            Next I
        End With

    End Sub

    Public Shared Sub Diffuse(Src As Bitmap, ByRef Progress As Long)

        Dim TempBmp As New Bitmap(Src)
        Dim DX As Integer
        Dim DY As Integer
        Dim Red As Integer, Green As Integer, Blue As Integer

        With TempBmp
            For I = 3 To .Height - 3

                For J = 3 To .Width - 3

                    DX = Rnd() * 4 - 2
                    DY = Rnd() * 4 - 2
                    Red = .GetPixel(J + DX, I + DY).R
                    Green = .GetPixel(J + DX, I + DY).G
                    Blue = .GetPixel(J + DX, I + DY).B
                    Src.SetPixel(J, I, Color.FromArgb(Red, Green, Blue))

                Next J

                If I Mod 10 = 0 Then
                    Progress = Int(100 * I / (Src.Height - 2))
                End If

            Next I
        End With

    End Sub

    Public Shared Sub RotateCCW(Src As Bitmap)
        Src.RotateFlip(RotateFlipType.Rotate270FlipNone)
    End Sub

    Public Shared Sub RotateCW(Src As Bitmap)
        Src.RotateFlip(RotateFlipType.Rotate90FlipNone)
    End Sub

    Public Shared Sub FlipHorizontal(Src As Bitmap)
        Src.RotateFlip(RotateFlipType.RotateNoneFlipX)
    End Sub

    Public Shared Sub FlipVertical(Src As Bitmap)
        Src.RotateFlip(RotateFlipType.RotateNoneFlipY)
    End Sub

End Class
