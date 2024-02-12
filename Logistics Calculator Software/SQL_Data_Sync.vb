
Imports System.Data.SqlClient
Public Class SQL_Data_Sync

    Private connectionString As String = "Data Source=172.16.35.7;Initial Catalog=MES_IoT_Varroc;User ID=ValorUser;Password=1;"

    Public Function DataEntry(Plant As String, LR_No As String, Num_Invoices As Integer, VendorCode As String, VehicleType As String, TripType As String, Packaging_denomination As String, Customer_Code As String, Customer_Name As String, DeliveryLocation As String, Document_No As Integer, Invoice_Weight As Double, Invoice_Quantity As Double, Gross_Amount As Double, Basic_Price As Double, Pallet_Weight As Double, Total_Shipment_Weight_with_Pallet As Double, Total_Shipment_Weight_without_Pallet As Double, Total_Shipment_Weight As Double, Trip_Score As Double) As Boolean
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "INSERT INTO [dbo].[TRN_InvoiceWeight] " &
                                     "( [Plant], [LR_No], [Num_Invoices], [VendorCode], [VehicleType], [TripType], [Packaging_denomination], [Customer_Code], [Customer_Name], [DeliveryLocation], [Document_No], [Invoice_Weight], [Invoice_Quantity], [Gross_Amount], [Basic_Price], [Pallet_Weight], [Total_Shipment_Weight_with_Pallet], [Total_Shipment_Weight_without_Pallet], [Total_Shipment_Weight], [Trip_Score] ) " &
                                     "VALUES " &
                                     "(@Plant, @LR_No, @Num_Invoices, @VendorCode, @VehicleType, @TripType, @Packaging_denomination, @Customer_Code, @Customer_Name, @DeliveryLocation, @Document_No, @Invoice_Weight, @Invoice_Quantity, @Gross_Amount, @Basic_Price, @Pallet_Weight, @Total_Shipment_Weight_with_Pallet, @Total_Shipment_Weight_without_Pallet, @Total_Shipment_Weight, @Trip_Score)"

                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Plant", Plant)
                    command.Parameters.AddWithValue("@LR_No", LR_No)
                    command.Parameters.AddWithValue("@Num_Invoices", Num_Invoices)
                    command.Parameters.AddWithValue("@VendorCode", VendorCode)
                    command.Parameters.AddWithValue("@VehicleType", VehicleType)
                    command.Parameters.AddWithValue("@TripType", TripType)
                    command.Parameters.AddWithValue("@Packaging_denomination", Packaging_denomination)
                    command.Parameters.AddWithValue("@Customer_Code", Customer_Code)
                    command.Parameters.AddWithValue("@Customer_Name", Customer_Name)
                    command.Parameters.AddWithValue("@DeliveryLocation", DeliveryLocation)
                    command.Parameters.AddWithValue("@Document_No", Document_No)
                    command.Parameters.AddWithValue("@Invoice_Weight", Invoice_Weight)
                    command.Parameters.AddWithValue("@Invoice_Quantity", Invoice_Quantity)
                    command.Parameters.AddWithValue("@Gross_Amount", Gross_Amount)
                    command.Parameters.AddWithValue("@Basic_Price", Basic_Price)
                    command.Parameters.AddWithValue("@Pallet_Weight", Pallet_Weight)
                    command.Parameters.AddWithValue("@Total_Shipment_Weight_with_Pallet", Total_Shipment_Weight_with_Pallet)
                    command.Parameters.AddWithValue("@Total_Shipment_Weight_without_Pallet", Total_Shipment_Weight_without_Pallet)
                    command.Parameters.AddWithValue("@Total_Shipment_Weight", Total_Shipment_Weight)
                    command.Parameters.AddWithValue("@Trip_Score", Trip_Score)
                    command.ExecuteNonQuery()
                End Using
            End Using

            Return True
        Catch ex As Exception
            ' Handle exception or log the error
            Return False
        End Try
    End Function


    Public Function CheckInvoiceinSQL(InvoiceNo As String) As Boolean
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT COUNT(*) FROM TRN_InvoiceWeight WHERE Document_No = @InvoiceNo"

                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@InvoiceNo", InvoiceNo)

                    Dim result As Object = command.ExecuteScalar()

                    ' Check if there are any rows with the specified Document_No
                    If result IsNot Nothing AndAlso Convert.ToInt32(result) > 0 Then
                        Return True
                    Else
                        Return False
                    End If
                End Using
            End Using
        Catch ex As Exception
            ' Handle exception or log the error
            Return False
        End Try
    End Function


End Class
