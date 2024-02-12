<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        WelcomeUser_Label = New Label()
        ViewTable_Button = New Button()
        InoviceNumber_Label = New Label()
        InvoiceNumber_TextBox = New TextBox()
        ImageList2 = New ImageList(components)
        Header_Label = New Label()
        TextBox11 = New TextBox()
        Label15 = New Label()
        Logout_Button = New Button()
        Reset_Button = New Button()
        GroupBox7 = New GroupBox()
        StatusLabel = New Label()
        ButtonConnect = New Button()
        ScanInvoice_Label = New Label()
        ScanQR_TextBox = New TextBox()
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        Status_Label = New Label()
        DataView_Grid = New DataGridView()
        InvoiceNo = New DataGridViewTextBoxColumn()
        InvoiceDate = New DataGridViewTextBoxColumn()
        InvoiceValue = New DataGridViewTextBoxColumn()
        Label3 = New Label()
        TodayScore_Label = New Label()
        Label8 = New Label()
        TripScore_Label = New Label()
        Weight_Label = New Label()
        Label18 = New Label()
        Data_Panel = New Panel()
        FreezeWeight_Button = New Button()
        Button2 = New Button()
        Button1 = New Button()
        InputData_GroupBox = New GroupBox()
        ComboBox1 = New ComboBox()
        LocationSelect_Label = New Label()
        Vehicle_ComboBox = New ComboBox()
        LRNumber_Label = New Label()
        Label5 = New Label()
        LRNumber_TextBox = New TextBox()
        Label7 = New Label()
        TripType_ComboBox = New ComboBox()
        ScannedInvoice_Label = New Label()
        Label4 = New Label()
        ConfimInvoice_Button = New Button()
        AllowedWeight_Label = New Label()
        Label2 = New Label()
        GroupBox7.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(DataView_Grid, ComponentModel.ISupportInitialize).BeginInit()
        Data_Panel.SuspendLayout()
        InputData_GroupBox.SuspendLayout()
        SuspendLayout()
        ' 
        ' WelcomeUser_Label
        ' 
        WelcomeUser_Label.AutoSize = True
        WelcomeUser_Label.BackColor = Color.WhiteSmoke
        WelcomeUser_Label.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        WelcomeUser_Label.Location = New Point(26, 139)
        WelcomeUser_Label.Margin = New Padding(4, 0, 4, 0)
        WelcomeUser_Label.Name = "WelcomeUser_Label"
        WelcomeUser_Label.Size = New Size(144, 25)
        WelcomeUser_Label.TabIndex = 19
        WelcomeUser_Label.Text = "Welcome User1"
        ' 
        ' ViewTable_Button
        ' 
        ViewTable_Button.BackColor = Color.WhiteSmoke
        ViewTable_Button.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        ViewTable_Button.Location = New Point(1335, 35)
        ViewTable_Button.Margin = New Padding(4, 3, 4, 3)
        ViewTable_Button.Name = "ViewTable_Button"
        ViewTable_Button.Size = New Size(143, 44)
        ViewTable_Button.TabIndex = 20
        ViewTable_Button.Text = "View Table"
        ViewTable_Button.UseVisualStyleBackColor = False
        ' 
        ' InoviceNumber_Label
        ' 
        InoviceNumber_Label.AutoSize = True
        InoviceNumber_Label.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        InoviceNumber_Label.Location = New Point(13, 218)
        InoviceNumber_Label.Margin = New Padding(4, 0, 4, 0)
        InoviceNumber_Label.Name = "InoviceNumber_Label"
        InoviceNumber_Label.Size = New Size(340, 38)
        InoviceNumber_Label.TabIndex = 15
        InoviceNumber_Label.Text = "Enter Number of Invoice"
        ' 
        ' InvoiceNumber_TextBox
        ' 
        InvoiceNumber_TextBox.BackColor = SystemColors.Window
        InvoiceNumber_TextBox.BorderStyle = BorderStyle.FixedSingle
        InvoiceNumber_TextBox.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        InvoiceNumber_TextBox.Location = New Point(356, 213)
        InvoiceNumber_TextBox.Margin = New Padding(4, 3, 4, 3)
        InvoiceNumber_TextBox.Name = "InvoiceNumber_TextBox"
        InvoiceNumber_TextBox.Size = New Size(158, 61)
        InvoiceNumber_TextBox.TabIndex = 19
        InvoiceNumber_TextBox.TextAlign = HorizontalAlignment.Center
        ' 
        ' ImageList2
        ' 
        ImageList2.ColorDepth = ColorDepth.Depth32Bit
        ImageList2.ImageSize = New Size(16, 16)
        ImageList2.TransparentColor = Color.Transparent
        ' 
        ' Header_Label
        ' 
        Header_Label.AutoSize = True
        Header_Label.BackColor = Color.Transparent
        Header_Label.Font = New Font("Segoe UI Semibold", 36F, FontStyle.Bold)
        Header_Label.ForeColor = Color.Indigo
        Header_Label.Location = New Point(26, 25)
        Header_Label.Margin = New Padding(4, 0, 4, 0)
        Header_Label.Name = "Header_Label"
        Header_Label.Size = New Size(1235, 96)
        Header_Label.TabIndex = 0
        Header_Label.Text = "LOGISTICS EFFICIENCY CALCULATOR"
        ' 
        ' TextBox11
        ' 
        TextBox11.Location = New Point(1019, -410)
        TextBox11.Margin = New Padding(4)
        TextBox11.Name = "TextBox11"
        TextBox11.Size = New Size(792, 39)
        TextBox11.TabIndex = 29
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(1019, -458)
        Label15.Margin = New Padding(4, 0, 4, 0)
        Label15.Name = "Label15"
        Label15.Size = New Size(294, 32)
        Label15.TabIndex = 30
        Label15.Text = "SCAN INVOICE QR CODE"
        ' 
        ' Logout_Button
        ' 
        Logout_Button.Location = New Point(1485, 36)
        Logout_Button.Margin = New Padding(4)
        Logout_Button.Name = "Logout_Button"
        Logout_Button.Size = New Size(143, 44)
        Logout_Button.TabIndex = 31
        Logout_Button.Text = "Logout"
        Logout_Button.UseVisualStyleBackColor = True
        ' 
        ' Reset_Button
        ' 
        Reset_Button.Location = New Point(1635, 36)
        Reset_Button.Margin = New Padding(4)
        Reset_Button.Name = "Reset_Button"
        Reset_Button.Size = New Size(143, 44)
        Reset_Button.TabIndex = 32
        Reset_Button.Text = "Reset"
        Reset_Button.UseVisualStyleBackColor = True
        ' 
        ' GroupBox7
        ' 
        GroupBox7.BackColor = Color.LightGray
        GroupBox7.Controls.Add(StatusLabel)
        GroupBox7.Controls.Add(ButtonConnect)
        GroupBox7.Controls.Add(Reset_Button)
        GroupBox7.Controls.Add(WelcomeUser_Label)
        GroupBox7.Controls.Add(Logout_Button)
        GroupBox7.Controls.Add(ViewTable_Button)
        GroupBox7.Controls.Add(Header_Label)
        GroupBox7.Location = New Point(1, 15)
        GroupBox7.Margin = New Padding(4)
        GroupBox7.Name = "GroupBox7"
        GroupBox7.Padding = New Padding(4)
        GroupBox7.Size = New Size(1880, 180)
        GroupBox7.TabIndex = 34
        GroupBox7.TabStop = False
        ' 
        ' StatusLabel
        ' 
        StatusLabel.AutoSize = True
        StatusLabel.BackColor = Color.WhiteSmoke
        StatusLabel.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        StatusLabel.Location = New Point(1580, 96)
        StatusLabel.Margin = New Padding(4, 0, 4, 0)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New Size(127, 25)
        StatusLabel.TabIndex = 38
        StatusLabel.Text = "Disconnected"
        ' 
        ' ButtonConnect
        ' 
        ButtonConnect.BackColor = Color.WhiteSmoke
        ButtonConnect.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        ButtonConnect.Location = New Point(1409, 86)
        ButtonConnect.Margin = New Padding(4, 3, 4, 3)
        ButtonConnect.Name = "ButtonConnect"
        ButtonConnect.Size = New Size(143, 44)
        ButtonConnect.TabIndex = 33
        ButtonConnect.Text = "Connect"
        ButtonConnect.UseVisualStyleBackColor = False
        ' 
        ' ScanInvoice_Label
        ' 
        ScanInvoice_Label.AutoSize = True
        ScanInvoice_Label.Location = New Point(15, 10)
        ScanInvoice_Label.Margin = New Padding(4, 0, 4, 0)
        ScanInvoice_Label.Name = "ScanInvoice_Label"
        ScanInvoice_Label.Size = New Size(294, 32)
        ScanInvoice_Label.TabIndex = 35
        ScanInvoice_Label.Text = "SCAN INVOICE QR CODE"
        ' 
        ' ScanQR_TextBox
        ' 
        ScanQR_TextBox.BorderStyle = BorderStyle.FixedSingle
        ScanQR_TextBox.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        ScanQR_TextBox.Location = New Point(18, 61)
        ScanQR_TextBox.Margin = New Padding(4)
        ScanQR_TextBox.Multiline = True
        ScanQR_TextBox.Name = "ScanQR_TextBox"
        ScanQR_TextBox.Size = New Size(483, 91)
        ScanQR_TextBox.TabIndex = 36
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(13, 759)
        PictureBox1.Margin = New Padding(4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(146, 147)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 37
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightGray
        Panel1.Controls.Add(Status_Label)
        Panel1.Location = New Point(167, 759)
        Panel1.Margin = New Padding(4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1702, 147)
        Panel1.TabIndex = 38
        ' 
        ' Status_Label
        ' 
        Status_Label.BackColor = Color.Transparent
        Status_Label.Font = New Font("Segoe UI Semibold", 30F, FontStyle.Bold)
        Status_Label.ForeColor = Color.Indigo
        Status_Label.Location = New Point(11, 24)
        Status_Label.Margin = New Padding(4, 0, 4, 0)
        Status_Label.Name = "Status_Label"
        Status_Label.Size = New Size(1564, 104)
        Status_Label.TabIndex = 39
        Status_Label.Text = "Waiting For Scan"
        Status_Label.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' DataView_Grid
        ' 
        DataView_Grid.AllowUserToAddRows = False
        DataView_Grid.AllowUserToDeleteRows = False
        DataView_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataView_Grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataView_Grid.Columns.AddRange(New DataGridViewColumn() {InvoiceNo, InvoiceDate, InvoiceValue})
        DataView_Grid.Location = New Point(1101, 46)
        DataView_Grid.Margin = New Padding(4)
        DataView_Grid.Name = "DataView_Grid"
        DataView_Grid.ReadOnly = True
        DataView_Grid.RowHeadersWidth = 62
        DataView_Grid.Size = New Size(734, 344)
        DataView_Grid.TabIndex = 39
        ' 
        ' InvoiceNo
        ' 
        InvoiceNo.HeaderText = "InvoiceNo"
        InvoiceNo.MinimumWidth = 8
        InvoiceNo.Name = "InvoiceNo"
        InvoiceNo.ReadOnly = True
        ' 
        ' InvoiceDate
        ' 
        InvoiceDate.HeaderText = "InvoiceDate"
        InvoiceDate.MinimumWidth = 8
        InvoiceDate.Name = "InvoiceDate"
        InvoiceDate.ReadOnly = True
        ' 
        ' InvoiceValue
        ' 
        InvoiceValue.HeaderText = "InvoiceValue"
        InvoiceValue.MinimumWidth = 8
        InvoiceValue.Name = "InvoiceValue"
        InvoiceValue.ReadOnly = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label3.Location = New Point(1424, 213)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(115, 25)
        Label3.TabIndex = 17
        Label3.Text = "Today Score"
        ' 
        ' TodayScore_Label
        ' 
        TodayScore_Label.Font = New Font("Segoe UI Semibold", 25F, FontStyle.Bold)
        TodayScore_Label.Location = New Point(1390, 238)
        TodayScore_Label.Margin = New Padding(4, 0, 4, 0)
        TodayScore_Label.Name = "TodayScore_Label"
        TodayScore_Label.Size = New Size(201, 60)
        TodayScore_Label.TabIndex = 40
        TodayScore_Label.Text = "0000"
        TodayScore_Label.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label8.Location = New Point(1712, 213)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(97, 25)
        Label8.TabIndex = 41
        Label8.Text = "Trip Score"
        ' 
        ' TripScore_Label
        ' 
        TripScore_Label.Font = New Font("Segoe UI Semibold", 25F, FontStyle.Bold)
        TripScore_Label.Location = New Point(1667, 238)
        TripScore_Label.Margin = New Padding(4, 0, 4, 0)
        TripScore_Label.Name = "TripScore_Label"
        TripScore_Label.Size = New Size(201, 60)
        TripScore_Label.TabIndex = 42
        TripScore_Label.Text = "0000"
        TripScore_Label.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Weight_Label
        ' 
        Weight_Label.Font = New Font("Segoe UI Semibold", 35F, FontStyle.Bold)
        Weight_Label.ForeColor = Color.Indigo
        Weight_Label.Location = New Point(18, 204)
        Weight_Label.Margin = New Padding(4, 0, 4, 0)
        Weight_Label.Name = "Weight_Label"
        Weight_Label.Size = New Size(483, 86)
        Weight_Label.TabIndex = 44
        Weight_Label.Text = "0000"
        Weight_Label.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label18.Location = New Point(216, 179)
        Label18.Margin = New Padding(4, 0, 4, 0)
        Label18.Name = "Label18"
        Label18.Size = New Size(74, 25)
        Label18.TabIndex = 43
        Label18.Text = "Weight"
        ' 
        ' Data_Panel
        ' 
        Data_Panel.Controls.Add(FreezeWeight_Button)
        Data_Panel.Controls.Add(Label18)
        Data_Panel.Controls.Add(Button2)
        Data_Panel.Controls.Add(Weight_Label)
        Data_Panel.Controls.Add(Button1)
        Data_Panel.Controls.Add(DataView_Grid)
        Data_Panel.Controls.Add(ScanQR_TextBox)
        Data_Panel.Controls.Add(ScanInvoice_Label)
        Data_Panel.Controls.Add(InputData_GroupBox)
        Data_Panel.Location = New Point(13, 321)
        Data_Panel.Margin = New Padding(4)
        Data_Panel.Name = "Data_Panel"
        Data_Panel.Size = New Size(1856, 434)
        Data_Panel.TabIndex = 45
        ' 
        ' FreezeWeight_Button
        ' 
        FreezeWeight_Button.Location = New Point(191, 329)
        FreezeWeight_Button.Name = "FreezeWeight_Button"
        FreezeWeight_Button.Size = New Size(134, 58)
        FreezeWeight_Button.TabIndex = 49
        FreezeWeight_Button.Text = "Freeze"
        FreezeWeight_Button.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(334, 329)
        Button2.Name = "Button2"
        Button2.Size = New Size(167, 61)
        Button2.TabIndex = 48
        Button2.Text = "Save"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(18, 329)
        Button1.Name = "Button1"
        Button1.Size = New Size(167, 61)
        Button1.TabIndex = 47
        Button1.Text = "Next"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' InputData_GroupBox
        ' 
        InputData_GroupBox.Controls.Add(ComboBox1)
        InputData_GroupBox.Controls.Add(LocationSelect_Label)
        InputData_GroupBox.Controls.Add(Vehicle_ComboBox)
        InputData_GroupBox.Controls.Add(LRNumber_Label)
        InputData_GroupBox.Controls.Add(Label5)
        InputData_GroupBox.Controls.Add(LRNumber_TextBox)
        InputData_GroupBox.Controls.Add(Label7)
        InputData_GroupBox.Controls.Add(TripType_ComboBox)
        InputData_GroupBox.Location = New Point(509, 42)
        InputData_GroupBox.Margin = New Padding(4)
        InputData_GroupBox.Name = "InputData_GroupBox"
        InputData_GroupBox.Padding = New Padding(4)
        InputData_GroupBox.Size = New Size(537, 348)
        InputData_GroupBox.TabIndex = 28
        InputData_GroupBox.TabStop = False
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(164, 231)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(335, 40)
        ComboBox1.TabIndex = 18
        ' 
        ' LocationSelect_Label
        ' 
        LocationSelect_Label.AutoSize = True
        LocationSelect_Label.BackColor = Color.WhiteSmoke
        LocationSelect_Label.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        LocationSelect_Label.Location = New Point(8, 239)
        LocationSelect_Label.Margin = New Padding(4, 0, 4, 0)
        LocationSelect_Label.Name = "LocationSelect_Label"
        LocationSelect_Label.Size = New Size(112, 32)
        LocationSelect_Label.TabIndex = 17
        LocationSelect_Label.Text = "Location"
        ' 
        ' Vehicle_ComboBox
        ' 
        Vehicle_ComboBox.FormattingEnabled = True
        Vehicle_ComboBox.Items.AddRange(New Object() {"3 Wheeler : 300 ", "Tata Ace : 450", "LPT 407 : 2600", "909 Tempo : 5000 "})
        Vehicle_ComboBox.Location = New Point(161, 39)
        Vehicle_ComboBox.Margin = New Padding(4, 3, 4, 3)
        Vehicle_ComboBox.Name = "Vehicle_ComboBox"
        Vehicle_ComboBox.Size = New Size(335, 40)
        Vehicle_ComboBox.TabIndex = 16
        ' 
        ' LRNumber_Label
        ' 
        LRNumber_Label.AutoSize = True
        LRNumber_Label.BackColor = Color.WhiteSmoke
        LRNumber_Label.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        LRNumber_Label.Location = New Point(8, 176)
        LRNumber_Label.Margin = New Padding(4, 0, 4, 0)
        LRNumber_Label.Name = "LRNumber_Label"
        LRNumber_Label.Size = New Size(143, 32)
        LRNumber_Label.TabIndex = 13
        LRNumber_Label.Text = "LR Number"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.WhiteSmoke
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label5.Location = New Point(8, 47)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(94, 32)
        Label5.TabIndex = 14
        Label5.Text = "Vehicle"
        ' 
        ' LRNumber_TextBox
        ' 
        LRNumber_TextBox.BorderStyle = BorderStyle.FixedSingle
        LRNumber_TextBox.Location = New Point(164, 169)
        LRNumber_TextBox.Margin = New Padding(4, 3, 4, 3)
        LRNumber_TextBox.MaxLength = 10
        LRNumber_TextBox.Name = "LRNumber_TextBox"
        LRNumber_TextBox.Size = New Size(335, 39)
        LRNumber_TextBox.TabIndex = 15
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.WhiteSmoke
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label7.Location = New Point(8, 102)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(119, 32)
        Label7.TabIndex = 6
        Label7.Text = "Trip Type"
        ' 
        ' TripType_ComboBox
        ' 
        TripType_ComboBox.AutoCompleteCustomSource.AddRange(New String() {"Akurdi", "Alandi", "dsada", "afdadaf"})
        TripType_ComboBox.AutoCompleteMode = AutoCompleteMode.Suggest
        TripType_ComboBox.AutoCompleteSource = AutoCompleteSource.CustomSource
        TripType_ComboBox.FormattingEnabled = True
        TripType_ComboBox.Items.AddRange(New Object() {"Weight Basis", "Trip Basis"})
        TripType_ComboBox.Location = New Point(164, 102)
        TripType_ComboBox.Margin = New Padding(4, 3, 4, 3)
        TripType_ComboBox.Name = "TripType_ComboBox"
        TripType_ComboBox.Size = New Size(335, 40)
        TripType_ComboBox.TabIndex = 12
        ' 
        ' ScannedInvoice_Label
        ' 
        ScannedInvoice_Label.Font = New Font("Segoe UI Semibold", 25F, FontStyle.Bold)
        ScannedInvoice_Label.Location = New Point(1112, 238)
        ScannedInvoice_Label.Margin = New Padding(4, 0, 4, 0)
        ScannedInvoice_Label.Name = "ScannedInvoice_Label"
        ScannedInvoice_Label.Size = New Size(201, 60)
        ScannedInvoice_Label.TabIndex = 48
        ScannedInvoice_Label.Text = "0000"
        ScannedInvoice_Label.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label4.Location = New Point(1130, 213)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(151, 25)
        Label4.TabIndex = 47
        Label4.Text = "Scanned Invoice"
        ' 
        ' ConfimInvoice_Button
        ' 
        ConfimInvoice_Button.Location = New Point(548, 213)
        ConfimInvoice_Button.Name = "ConfimInvoice_Button"
        ConfimInvoice_Button.Size = New Size(157, 61)
        ConfimInvoice_Button.TabIndex = 46
        ConfimInvoice_Button.Text = "Confirm"
        ConfimInvoice_Button.UseVisualStyleBackColor = True
        ' 
        ' AllowedWeight_Label
        ' 
        AllowedWeight_Label.Font = New Font("Segoe UI Semibold", 25F, FontStyle.Bold)
        AllowedWeight_Label.Location = New Point(852, 238)
        AllowedWeight_Label.Margin = New Padding(4, 0, 4, 0)
        AllowedWeight_Label.Name = "AllowedWeight_Label"
        AllowedWeight_Label.Size = New Size(201, 60)
        AllowedWeight_Label.TabIndex = 50
        AllowedWeight_Label.Text = "0000"
        AllowedWeight_Label.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label2.Location = New Point(870, 213)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(148, 25)
        Label2.TabIndex = 49
        Label2.Text = "Allowed Weight"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(14F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(1881, 911)
        Controls.Add(PictureBox1)
        Controls.Add(AllowedWeight_Label)
        Controls.Add(Label2)
        Controls.Add(ScannedInvoice_Label)
        Controls.Add(Label4)
        Controls.Add(ConfimInvoice_Button)
        Controls.Add(Data_Panel)
        Controls.Add(TripScore_Label)
        Controls.Add(Label8)
        Controls.Add(TodayScore_Label)
        Controls.Add(Label3)
        Controls.Add(Panel1)
        Controls.Add(InvoiceNumber_TextBox)
        Controls.Add(GroupBox7)
        Controls.Add(Label15)
        Controls.Add(InoviceNumber_Label)
        Controls.Add(TextBox11)
        Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Margin = New Padding(4, 3, 4, 3)
        Name = "Form1"
        Text = "TRIP SC"
        GroupBox7.ResumeLayout(False)
        GroupBox7.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        CType(DataView_Grid, ComponentModel.ISupportInitialize).EndInit()
        Data_Panel.ResumeLayout(False)
        Data_Panel.PerformLayout()
        InputData_GroupBox.ResumeLayout(False)
        InputData_GroupBox.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents WelcomeUser_Label As Label
    Friend WithEvents ViewTable_Button As Button
    Friend WithEvents InoviceNumber_Label As Label
    Friend WithEvents InvoiceNumber_TextBox As TextBox
    Friend WithEvents ImageList2 As ImageList
    Friend WithEvents Header_Label As Label
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Logout_Button As Button
    Friend WithEvents Reset_Button As Button
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents ScanInvoice_Label As Label
    Friend WithEvents ScanQR_TextBox As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ButtonConnect As Button
    Friend WithEvents StatusLabel As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Status_Label As Label
    Friend WithEvents DataView_Grid As DataGridView
    Friend WithEvents InvoiceNo As DataGridViewTextBoxColumn
    Friend WithEvents InvoiceDate As DataGridViewTextBoxColumn
    Friend WithEvents InvoiceValue As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents TodayScore_Label As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TripScore_Label As Label
    Friend WithEvents Weight_Label As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Data_Panel As Panel
    Friend WithEvents InputData_GroupBox As GroupBox
    Friend WithEvents Vehicle_ComboBox As ComboBox
    Friend WithEvents LRNumber_Label As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LRNumber_TextBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TripType_ComboBox As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ScannedInvoice_Label As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LocationSelect_Label As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ConfimInvoice_Button As Button
    Friend WithEvents AllowedWeight_Label As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents FreezeWeight_Button As Button

End Class
