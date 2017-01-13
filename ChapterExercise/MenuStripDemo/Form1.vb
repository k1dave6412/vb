﻿Public Class Form1

    ' 表單載入時執行
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '  豐富文字方塊填滿整個表單()
        RichTextBox1.Dock = DockStyle.Fill
    End Sub
    ' 執行功能表的 [檔案/開檔] 指令執行
    Private Sub 開檔ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 開檔ToolStripMenuItem.Click
        ' 使用Try...Catch...來補捉沒有檔案可能發生的例外
        Try
            ' 將test.rtf檔的內容載入到RichTextBox1豐富文字方塊內
            RichTextBox1.LoadFile("test.rtf", RichTextBoxStreamType.RichText)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    ' 執行功能表的 [檔案/存檔] 指令執行
    Private Sub 存檔ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 存檔ToolStripMenuItem.Click
        ' 將RichTextBox1豐富文字方塊內的資料儲存到test.rtf檔
        RichTextBox1.SaveFile("test.rtf", RichTextBoxStreamType.RichText)
    End Sub
    ' 執行功能表的 [檔案/清除] 指令執行
    Private Sub 清除ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 清除ToolStripMenuItem.Click
        RichTextBox1.Text = ""
    End Sub
    ' 執行功能表的 [檔案/結束] 指令執行
    Private Sub 結束ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 結束ToolStripMenuItem.Click
        Application.Exit()
    End Sub
    ' 執行功能表的 [項目符號] 指令執行
    Private Sub 項目符號ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 項目符號ToolStripMenuItem.Click
        RichTextBox1.SelectionBullet = Not RichTextBox1.SelectionBullet
    End Sub

    ' cboSize字型大小下拉式清單SelectedIndex屬性值改變時執行(即選取清單時執行)
    Private Sub cboSize_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSize.SelectedIndexChanged
        ' 設定選取字型的樣式
        RichTextBox1.SelectionFont = New Font(RichTextBox1.Font.FontFamily.ToString(), Single.Parse(cboSize.Text), RichTextBox1.Font.Style)
    End Sub
    ' cboFontColor字型色彩下拉式清單SelectedIndex屬性值改變時執行
    ' (即選取下拉式清單時執行)
    Private Sub cboFontColor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFontColor.SelectedIndexChanged
        If cboFontColor.Text = "黑" Then
            RichTextBox1.SelectionColor = Color.Black
        ElseIf cboFontColor.Text = "紅" Then
            RichTextBox1.SelectionColor = Color.Red
        ElseIf cboFontColor.Text = "綠" Then
            RichTextBox1.SelectionColor = Color.Green
        ElseIf cboFontColor.Text = "藍" Then
            RichTextBox1.SelectionColor = Color.Blue
        End If
    End Sub

End Class