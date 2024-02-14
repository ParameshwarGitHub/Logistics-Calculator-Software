Imports System.IO.Ports
Imports System.Text
Imports System.IdentityModel.Tokens.Jwt
Imports Newtonsoft.Json.Linq
Imports System.Threading


Public Class Form1
    Private WithEvents serialPort As SerialPort
    Private WithEvents serialPortScanner As SerialPort
    Private connected As Boolean = False
    Dim SqlDataEntry As New SQL_Data_Sync()
    Dim JsonCall As New JSONFILE()

    Private Sub ButtonConnect_Click(sender As Object, e As EventArgs) Handles ButtonConnect.Click
        If Not connected Then
            Try
                serialPort = New SerialPort("COM6", 9600)
                serialPort.Open()
                connected = True
                StatusLabel.Text = "Connected"
                ButtonConnect.Text = "Disconnect"
            Catch ex As Exception
                MsgBox("Error Connecting to Weight Device")
            End Try

            Try
                serialPortScanner = New SerialPort("COM7", 128000)
                serialPortScanner.Open()
            Catch ex As Exception
                MsgBox("Error Connecting to Scanner")
            End Try
        Else
            DisconnectScanner()
        End If
    End Sub

    Private Sub DisconnectScanner()
        If connected Then
            ' Close the serial port
            serialPort.Close()
            connected = False
            StatusLabel.Text = "Disconnected"
            ButtonConnect.Text = "Connect"
        End If
    End Sub

    Private Sub SerialPort_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles serialPort.DataReceived
        Try
            ' Read the response from the serial port
            Dim response As String = serialPort.ReadLine()

            ' Assuming the response contains the barcode data
            ' Extract the barcode data from the response and update the UI
            Dim barcodeData As String = ExtractBarcodeData(response)

            ' Update the UI with the scanned barcode data if not frozen
            If Not isWeightFrozen Then
                Me.Invoke(Sub()
                              Weight_Label.Text = barcodeData
                          End Sub)
            End If
        Catch ex As Exception
            MessageBox.Show("Error reading response: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub SerialPortScanner_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles serialPortScanner.DataReceived
        Try
            ' Read the response from the serial port
            Dim response As String = serialPortScanner.ReadLine()

            ' Assuming the response contains the barcode data
            ' Extract the barcode data from the response and update the UI
            Dim barcodeData As String = ExtractBarcodeData(response)

            ' Update the UI with the scanned barcode data
            Me.Invoke(Sub()
                          ScanQR_TextBox.Text = barcodeData
                          Thread.Sleep(0.5)
                          Button1.PerformClick()
                      End Sub)

        Catch ex As Exception
            MessageBox.Show("Error reading response: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function ExtractBarcodeData(response As String) As String
        ' Implement logic to extract barcode data from the response
        ' This may involve parsing the response based on the protocol used by your scanner
        ' For simplicity, let's assume the barcode data is the entire response
        Return response.Trim()
    End Function
    Private Sub SendSerialCommand(command As String)
        Try
            ' Check if the serial port is open
            If serialPort IsNot Nothing AndAlso serialPort.IsOpen Then
                ' Send the command
                serialPort.Write(command)

                ' Optionally, you can wait for a response in the SerialPort_DataReceived event
            Else
                MessageBox.Show("Serial port not open. Please open the serial port first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error sending serial command: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Make sure to disconnect when closing the form
        'DisconnectScanner()
    End Sub

    'Private Sub TextBoxBarcode_TextChanged(sender As Object, e As EventArgs) Handles TextBoxBarcode.TextChanged
    '    ' Optional: You can perform additional actions when the barcode text changes
    'End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ButtonConnect.PerformClick()
            Data_Panel.Hide()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub ConfimInvoice_Button_Click(sender As Object, e As EventArgs) Handles ConfimInvoice_Button.Click
        Try
            ' Read the input from the TextBox
            Dim inputString As String = InvoiceNumber_TextBox.Text.Trim()

            ' Try to parse the input as an integer
            Dim invoiceNumber As Integer
            If Integer.TryParse(inputString, invoiceNumber) AndAlso invoiceNumber > 0 Then
                ' Valid positive integer input
                InvoiceNumber_TextBox.ReadOnly = True
                InvoiceNumber_TextBox.BackColor = Color.Beige

                Data_Panel.Show()
            Else
                ' Invalid input, display a messagebox
                MessageBox.Show("Please input a valid positive integer.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                InvoiceNumber_TextBox.ReadOnly = False
            End If

            ' Hide the Data_Panel (optional, uncomment if needed)
            ' Data_Panel.Hide()

            ' Perform additional actions with the entered integer value if needed
        Catch ex As Exception
            ' Handle any other exceptions here
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try


            Dim numberOfIterations As Integer
            If Integer.TryParse(InvoiceNumber_TextBox.Text, numberOfIterations) Then
                ' Counter variable to keep track of iterations
                Dim currentIteration As Integer = 0
                Dim selectedTripType As String = TripType_ComboBox.SelectedItem.ToString()
            Dim floatValue As Double
            Dim allowedWeightValue As Double
            Dim weightscore As Double
                For i As Integer = 1 To numberOfIterations
                    Dim scannedvalue = ScanQR_TextBox.Text

                If IsCapsLockOn() Then
                    Console.WriteLine("Caps Lock is ON. Reversing casing...")
                    Dim reversedString As String = ReverseCasing(scannedvalue)
                    scannedvalue = reversedString
                Else
                    Console.WriteLine("Caps Lock is OFF. Doing nothing...")
                    ' Do nothing or perform other actions as needed
                End If

                Dim jsonresponse = JsonCall.GetJwtPayloadAsJson(scannedvalue)

                ' Extract the DocNo value
                Dim outerObject As JObject = JObject.Parse(jsonresponse)

                ' Extract the inner JSON string from the "data" field
                Dim innerJsonString As String = outerObject("data").ToString()

                ' Parse the inner JSON string
                Dim innerObject As JObject = JObject.Parse(innerJsonString)

                ' Extract the DocNo value
                Dim docNo As String = innerObject("DocNo").ToString()
                Dim DocDt As String = innerObject("DocDt").ToString()
                Dim TotInvVal As String = innerObject("TotInvVal").ToString()

                Dim Success = SqlDataEntry.CheckInvoiceinSQL(docNo)
                MsgBox(Success)

                If Not Success Then
                    ' Counter variable to keep track of values
                    Static counter As Integer = 1

                    ' Values to be added in each row based on the counter

                    ' Check for duplicate InvoiceNo before adding a new row
                    If Not IsDuplicateInvoiceNo(docNo) Then
                        ' No duplicate found, add the new row to the DataGridView
                        DataView_Grid.Rows.Add(docNo, DocDt, TotInvVal)

                        ' Update the Status_Label text
                        Status_Label.Text = "Scanned!!"

                        ' Increment the counter and reset it to 1 when it reaches 7
                        counter += 3
                        If counter > 9 Then
                            counter = 1
                        End If
                    Else
                        ' Duplicate found, display messagebox
                        MessageBox.Show("Duplicate Invoice Scanned", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If

                Else
                    MessageBox.Show("Invoice Already Scanned in DB", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                End If



            Select Case selectedTripType
                Case "Weight Basis"

                    'Logic for weight score

                    If Double.TryParse(Weight_Label.Text, floatValue) Then
                ' Display a messagebox to show the floatValue
                'MessageBox.Show($" Float Value: {floatValue}")

                ' Extract the allowedWeightValue from Vehicle_ComboBox

                Dim selectedVehicle As String = Vehicle_ComboBox.SelectedItem.ToString()
                Dim allowedWeight As String() = selectedVehicle.Split(":")
                If allowedWeight.Length > 1 Then
                    If Double.TryParse(allowedWeight(1).Trim(), allowedWeightValue) Then
                        ' Now, 'allowedWeightValue' contains the extracted double value
                        ' Add more logic as needed



                    Else
                        ' Handle the case where parsing to double fails
                        MessageBox.Show("Error parsing allowed weight as a double.")
                    End If
                Else
                    ' Handle the case where splitting the text doesn't result in two parts
                    MessageBox.Show("Error splitting text in Vehicle ComboBox.")
                End If

            Else
                ' Handle the case where parsing fails
                MessageBox.Show("Error parsing the string as a floating-point number.")
            End If
            weightscore = (floatValue / allowedWeightValue) * 10
            TripScore_Label.Text = weightscore.ToString()
            If weightscore >= 0 AndAlso weightscore <= 10 Then
                TripScore_Label.BackColor = Color.Indigo
            ElseIf weightscore > 10 Then
                TripScore_Label.BackColor = Color.Red
            Else
                TripScore_Label.BackColor = Color.Red
            End If

                Case "Trip Basis"

                    'Logic for trip type
                    If Double.TryParse(Weight_Label.Text, floatValue) Then
                ' Display a messagebox to show the floatValue
                MessageBox.Show($" Float Value: {floatValue}")

                ' Extract the allowedWeightValue from Vehicle_ComboBox

                Dim selectedVehicle As String = Vehicle_ComboBox.SelectedItem.ToString()
                Dim allowedWeight As String() = selectedVehicle.Split(":")
                If allowedWeight.Length > 1 Then
                    If Double.TryParse(allowedWeight(1).Trim(), allowedWeightValue) Then
                        ' Now, 'allowedWeightValue' contains the extracted double value
                        ' Add more logic as needed



                    Else
                        ' Handle the case where parsing to double fails
                        MessageBox.Show("Error parsing allowed weight as a double.")
                    End If
                Else
                    ' Handle the case where splitting the text doesn't result in two parts
                    MessageBox.Show("Error splitting text in Vehicle ComboBox.")
                End If

            Else
                ' Handle the case where parsing fails
                MessageBox.Show("Error parsing the string as a floating-point number.")
            End If
            weightscore = (floatValue / allowedWeightValue) * 10
            TripScore_Label.Text = weightscore.ToString()
            If weightscore >= 0 AndAlso weightscore <= 10 Then
                TripScore_Label.BackColor = Color.Indigo
            ElseIf weightscore > 10 Then
                TripScore_Label.BackColor = Color.Red
            Else
                TripScore_Label.BackColor = Color.Red
            End If

            'Update the label for the next scan
            Status_Label.Text = "Waiting For Scan"

End Select
            'Clear the textbox after scanning
            ScanQR_TextBox.Clear()
                    ' Increment the counter
                    currentIteration += 1

                    ' Check if we have reached the desired number of iterations
                    If currentIteration >= numberOfIterations Then
                        Exit For ' Exit the loop if the desired iterations are reached
                    End If
                Next

                ' Check if the number of rows in DataView_Grid has reached the specified value
                If DataView_Grid.Rows.Count >= numberOfIterations Then
                    ' Disable the Button1
                    Button1.Enabled = False
                    MessageBox.Show("Number of invoices reached. Button1 is now disabled.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Else
                MessageBox.Show("Please enter a valid number in the InvoiceNumber_TextBox.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If



        Catch ex As Exception
            ' Handle any other exceptions here
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub


    Function IsCapsLockOn() As Boolean
        Return Control.IsKeyLocked(Keys.CapsLock)
    End Function

    Function ReverseCasing(input As String) As String
        Dim reversedString As String = ""
        For Each c As Char In input
            If Char.IsLetter(c) Then
                If Char.IsUpper(c) Then
                    reversedString &= Char.ToLower(c)
                Else
                    reversedString &= Char.ToUpper(c)
                End If
            Else
                reversedString &= c
            End If
        Next
        Return reversedString
    End Function


    Private Function IsDuplicateInvoiceNo(newInvoiceNo As String) As Boolean
        ' Check for duplicate InvoiceNo in the existing rows
        For Each row As DataGridViewRow In DataView_Grid.Rows
            If Not row.IsNewRow Then
                Dim existingInvoiceNo As String = row.Cells("InvoiceNo").Value.ToString()
                If newInvoiceNo = existingInvoiceNo Then
                    ' Duplicate found
                    Return True
                End If
            End If
        Next
        ' No duplicate found
        Return False
    End Function

    Private Sub Vehicle_ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Vehicle_ComboBox.SelectedIndexChanged
        ' Handle the SelectedIndexChanged event of the Vehicle_ComboBox
        Dim selectedItemText As String = Vehicle_ComboBox.Text

        ' Parse the first part (vehicle name)
        Dim parts As String() = selectedItemText.Split(":")
        If parts.Length > 1 Then
            ' Extract the vehicle name (part before the ':')
            firstPart = parts(0).Trim()

            ' Now 'firstPart' contains the extracted string value before the ':'
            ' You can use 'firstPart' as needed in your code
            Console.WriteLine("Vehicle Name: " & firstPart)

            ' Parse the second part (allowed weight)
            Dim allowedWeightValue As Integer
            If Integer.TryParse(parts(1).Trim(), allowedWeightValue) Then
                ' Now, 'allowedWeightValue' contains the extracted integer value
                AllowedWeight_Label.Text = allowedWeightValue.ToString()
                Console.WriteLine("Allowed Weight: " & allowedWeightValue)
            Else
                ' Handle the case where parsing to integer fails
                MsgBox("Error parsing allowed weight as an integer.")
            End If
        Else
            ' Handle the case where splitting the text doesn't result in two parts
            MsgBox("Error splitting text in Vehicle ComboBox.")
        End If

        ' Get the selected item from the ComboBox
        Dim selectedVehicle As String = Vehicle_ComboBox.SelectedItem.ToString()





    End Sub

    Private Sub ScanQR_TextBox_TextChanged(sender As Object, e As EventArgs) Handles ScanQR_TextBox.TextChanged
        If Control.IsKeyLocked(Keys.CapsLock) Then
            '    ' Caps Lock is on, turn it off
            SendKeys.Send("{CAPSLOCK}")
            Console.WriteLine("Caps Lock turned off.")
        Else
            Console.WriteLine("Caps Lock is already off.")
        End If
    End Sub

    Private Sub ScannedInvoice_Label_Click(sender As Object, e As EventArgs) Handles ScannedInvoice_Label.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub TripType_ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TripType_ComboBox.SelectedIndexChanged
        ' Get the selected item from the ComboBox
        selectedTripType = TripType_ComboBox.SelectedItem.ToString()
        ' Implement logic based on the selected item
        Select Case selectedTripType
            Case "Weight Basis"
                ' Logic for Weight Basis

                ' Extract the floatValue from the Weight_Label


            Case "Trip Basis"
                ' Logic for Trip Basis
                MessageBox.Show("Trip Basis logic here.")
                ' Add more code as needed for Trip Basis

                ' Add more cases for additional options if needed

            Case Else
                ' Handle any other cases if needed

        End Select
    End Sub

    Private Sub Weight_Label_Click(sender As Object, e As EventArgs) Handles Weight_Label.TextChanged
        Try
            Dim stringValue As String = Weight_Label.Text
            Dim floatValue As Double

            If Double.TryParse(stringValue, floatValue) Then
                Console.WriteLine(floatValue.ToString)
                If floatValue < 0 Then
                    Weight_Label.BackColor = Color.Red
                    Weight_Label.ForeColor = Color.White
                ElseIf floatValue > Integer.Parse(AllowedWeight_Label.Text) Then
                    Weight_Label.BackColor = Color.Red
                    Weight_Label.ForeColor = Color.White
                Else
                    Weight_Label.BackColor = Color.Transparent
                    Weight_Label.ForeColor = Color.Indigo
                End If
                ' Conversion successful, 'floatValue' now contains the float value
                'MsgBox(floatValue.ToString())
            Else
                ' Handle the case where parsing fails
                MsgBox("Error parsing the string as a floating-point number.")
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Public firstPart As String
    Dim selectedTripType As String

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim numberOfIterations As Integer
        If Integer.TryParse(InvoiceNumber_TextBox.Text, numberOfIterations) AndAlso numberOfIterations > 0 Then

            ' Your existing code here
            Dim allowedWeight As String() = Vehicle_ComboBox.Text.Split(":")
            If allowedWeight.Length > 1 Then
                Dim allowedWeightValue As Integer
                If Integer.TryParse(allowedWeight(1).Trim(), allowedWeightValue) Then
                    ' Now, 'allowedWeightValue' contains the extracted integer value
                    Dim Success As Boolean = SqlDataEntry.DataEntry("2200", LRNumber_TextBox.Text, Val(InvoiceNumber_TextBox.Text).ToString, "VendorCode", firstPart, selectedTripType, "Packaging_denomination", "Customer_Code", "Customer_Name", "DeliveryLocation", 122222, 22.4, 22.3, 22.4, 22.4, 22.333, 222.22, 222.0, 2.0, TripScore_Label.Text)
                    MsgBox(Success)
                Else
                    ' Handle the case where parsing to integer fails
                    MsgBox("Error parsing allowed weight as an integer.")
                End If
            Else
                ' Handle the case where splitting the text doesn't result in two parts
                MsgBox("Error splitting text in Vehicle ComboBox.")
            End If

        Else
            ' Handle the case where InvoiceNumber is not a valid positive integer
            MsgBox("Invalid InvoiceNumber. Please enter a valid positive integer.")
        End If
    End Sub
    Private isWeightFrozen As Boolean = False
    Private Sub FreezeWeight_Button_Click(sender As Object, e As EventArgs) Handles FreezeWeight_Button.Click
        isWeightFrozen = Not isWeightFrozen
        UpdateFreezeButtonState()
    End Sub
    Private Sub UpdateFreezeButtonState()
        FreezeWeight_Button.Text = If(isWeightFrozen, "Unfreeze", "Freeze")
    End Sub

    Private Sub ViewTable_Button_Click(sender As Object, e As EventArgs) Handles ViewTable_Button.Click
        Tabel.Show()
    End Sub


End Class