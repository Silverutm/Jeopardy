Module Excel
    Public Sub PasaraExcel()
        Dim oExcel As Object
        Dim oBook As Object
        Dim oSheet As Object

        'Start a new workbook in Excel.
        oExcel = CreateObject("Excel.Application")
        oBook = oExcel.Workbooks.Add

        'Add data to cells of the first worksheet in the new workbook.
        oSheet = oBook.Worksheets(1)
        oSheet.Range("A1").Value = "Last Name"
        oSheet.Range("B1").Value = "First Name"
        oSheet.Range("A1:B1").Font.Bold = True
        oSheet.Range("A2").Value = "Doe"
        oSheet.Range("B2").Value = "John"

        'Save the Workbook and quit Excel.
        oBook.SaveAs("Book11.xls")
        oSheet = Nothing
        oBook = Nothing
        oExcel.Quit()
        oExcel = Nothing
        GC.Collect()
        MsgBox("algo paso no se que era")
    End Sub

End Module
