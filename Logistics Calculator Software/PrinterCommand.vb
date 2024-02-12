Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Net
Imports System.Xml
Imports System.Web
Imports System.Data
Imports System.Drawing.Printing
Imports System.Data.SqlClient
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Runtime
Imports Microsoft.SqlServer
Imports System.Configuration
Imports System.Text.ASCIIEncoding

Public Class PrinterCommand
    Public Structure DOCINFO
        Dim pDocName As String
        Dim pOutputFile As String
        Dim pDataType As String
    End Structure

    ''' <summary>  
    '''   Printing Code  
    ''' </summary>  
    ''' <remarks>  
    '''   Converted from http://support.microsoft.com/kb/322091  
    ''' </remarks>  
    <ProgId("ByBoxInterop.RawPrinterHelper"), ClassInterface(ClassInterfaceType.None)>
    Public Class RawPrinterHelper

        <DllImport("winspool.drv", CharSet:=CharSet.Ansi, ExactSpelling:=False, CallingConvention:=CallingConvention.StdCall)>
        Public Shared Function OpenPrinter(ByVal pPrinterName As String, ByRef phPrinter As IntPtr, ByVal pDefault As Integer) As Long
        End Function

        <DllImport("winspool.drv", CharSet:=CharSet.Ansi, ExactSpelling:=False, CallingConvention:=CallingConvention.StdCall)>
        Public Shared Function StartDocPrinter(ByVal hPrinter As IntPtr, ByVal Level As Integer, ByRef pDocInfo As DOCINFO) As Long
        End Function

        <DllImport("winspool.drv", CharSet:=CharSet.Auto, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)>
        Public Shared Function StartPagePrinter(ByVal hPrinter As IntPtr) As Long
        End Function

        <DllImport("winspool.drv", CharSet:=CharSet.Ansi, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)>
        Public Shared Function WritePrinter(ByVal hPrinter As IntPtr, ByVal data() As Byte, ByVal buf As Integer, ByRef pcWritten As Integer) As Long
        End Function

        <DllImport("winspool.drv", CharSet:=CharSet.Auto, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)>
        Public Shared Function EndPagePrinter(ByVal hPrinter As IntPtr) As Long
        End Function

        <DllImport("winspool.drv", CharSet:=CharSet.Auto, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)>
        Public Shared Function EndDocPrinter(ByVal hPrinter As IntPtr) As Long
        End Function

        <DllImport("winspool.drv", CharSet:=CharSet.Auto, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)>
        Public Shared Function ClosePrinter(ByVal hPrinter As IntPtr) As Long
        End Function

        Public Shared Function SendStringToPrinter(ByVal printerName As String, ByVal outputString As String)
            Dim bSuccess As Boolean
            bSuccess = SendBytesToPrinter(printerName, ASCII.GetBytes(outputString))
            Return bSuccess
        End Function

        Public Shared Function SendBytesToPrinter(ByVal printerName As String, ByVal byteData() As Byte)
            Dim dwError As Integer = 0
            Dim dwWritten As Integer = 0
            Dim hPrinter As IntPtr = New IntPtr(0)
            Dim di As DOCINFO = New DOCINFO
            Dim bSuccess As Boolean = False

            di.pDocName = "Rawr Doc"
            di.pDataType = "RAW"

            If OpenPrinter(printerName, hPrinter, IntPtr.Zero) Then
                If StartDocPrinter(hPrinter, 1, di) Then
                    If StartPagePrinter(hPrinter) Then
                        bSuccess = WritePrinter(hPrinter, byteData, byteData.Length, dwWritten)
                        EndPagePrinter(hPrinter)
                    End If
                    EndDocPrinter(hPrinter)
                End If
                ClosePrinter(hPrinter)
            End If

            If Not bSuccess Then dwError = Marshal.GetLastWin32Error
            Return bSuccess
        End Function

        Public Shared Function SendFileToPrinter(ByVal printerName As String, ByVal fileName As String) As Boolean
            Dim fs As FileStream = New FileStream(fileName, FileMode.Open)
            Dim br As BinaryReader = New BinaryReader(fs)
            Dim bytes() As Byte
            Dim bSuccess As Boolean = False

            ReDim bytes(fs.Length - 1)
            bytes = br.ReadBytes(fs.Length)
            bSuccess = SendBytesToPrinter(printerName, bytes)
            fs.Close()

            Return bSuccess
        End Function

    End Class
End Class
