<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmKarsOrderForm
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
        Me.lblCustName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblCarType = New System.Windows.Forms.Label()
        Me.lstType = New System.Windows.Forms.ListBox()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.updQuantity = New System.Windows.Forms.NumericUpDown()
        Me.grpDriveTrain = New System.Windows.Forms.GroupBox()
        Me.radV6 = New System.Windows.Forms.RadioButton()
        Me.radV8 = New System.Windows.Forms.RadioButton()
        Me.radElectric = New System.Windows.Forms.RadioButton()
        Me.radHybrid = New System.Windows.Forms.RadioButton()
        Me.radV4 = New System.Windows.Forms.RadioButton()
        Me.radV12 = New System.Windows.Forms.RadioButton()
        Me.grpOptions = New System.Windows.Forms.GroupBox()
        Me.chkEntertainment = New System.Windows.Forms.CheckBox()
        Me.chkGPS = New System.Windows.Forms.CheckBox()
        Me.chkBluetooth = New System.Windows.Forms.CheckBox()
        Me.chkMP3 = New System.Windows.Forms.CheckBox()
        Me.chkStereo = New System.Windows.Forms.CheckBox()
        Me.chkAirConditioning = New System.Windows.Forms.CheckBox()
        Me.chkDefroster = New System.Windows.Forms.CheckBox()
        Me.chkHeated = New System.Windows.Forms.CheckBox()
        Me.chkLeather = New System.Windows.Forms.CheckBox()
        Me.btnOrder = New System.Windows.Forms.Button()
        CType(Me.updQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDriveTrain.SuspendLayout()
        Me.grpOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCustName
        '
        Me.lblCustName.AutoSize = True
        Me.lblCustName.Location = New System.Drawing.Point(13, 13)
        Me.lblCustName.Name = "lblCustName"
        Me.lblCustName.Size = New System.Drawing.Size(97, 15)
        Me.lblCustName.TabIndex = 0
        Me.lblCustName.Text = "Customer Name:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(116, 10)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(341, 23)
        Me.txtName.TabIndex = 1
        '
        'lblCarType
        '
        Me.lblCarType.AutoSize = True
        Me.lblCarType.Location = New System.Drawing.Point(13, 50)
        Me.lblCarType.Name = "lblCarType"
        Me.lblCarType.Size = New System.Drawing.Size(55, 15)
        Me.lblCarType.TabIndex = 2
        Me.lblCarType.Text = "Car Type:"
        '
        'lstType
        '
        Me.lstType.FormattingEnabled = True
        Me.lstType.ItemHeight = 15
        Me.lstType.Items.AddRange(New Object() {"Coupe", "Luxury", "Sedan", "Sports Edition", "SUV"})
        Me.lstType.Location = New System.Drawing.Point(74, 39)
        Me.lstType.Name = "lstType"
        Me.lstType.Size = New System.Drawing.Size(120, 34)
        Me.lstType.TabIndex = 2
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Location = New System.Drawing.Point(275, 50)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(56, 15)
        Me.lblQuantity.TabIndex = 5
        Me.lblQuantity.Text = "Quantity:"
        '
        'updQuantity
        '
        Me.updQuantity.Location = New System.Drawing.Point(337, 46)
        Me.updQuantity.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.updQuantity.Name = "updQuantity"
        Me.updQuantity.Size = New System.Drawing.Size(120, 23)
        Me.updQuantity.TabIndex = 3
        Me.updQuantity.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'grpDriveTrain
        '
        Me.grpDriveTrain.Controls.Add(Me.radV6)
        Me.grpDriveTrain.Controls.Add(Me.radV8)
        Me.grpDriveTrain.Controls.Add(Me.radElectric)
        Me.grpDriveTrain.Controls.Add(Me.radHybrid)
        Me.grpDriveTrain.Controls.Add(Me.radV4)
        Me.grpDriveTrain.Controls.Add(Me.radV12)
        Me.grpDriveTrain.Location = New System.Drawing.Point(13, 94)
        Me.grpDriveTrain.Name = "grpDriveTrain"
        Me.grpDriveTrain.Size = New System.Drawing.Size(444, 59)
        Me.grpDriveTrain.TabIndex = 4
        Me.grpDriveTrain.TabStop = False
        Me.grpDriveTrain.Text = "Drive Train Selection:"
        '
        'radV6
        '
        Me.radV6.AutoSize = True
        Me.radV6.Location = New System.Drawing.Point(150, 22)
        Me.radV6.Name = "radV6"
        Me.radV6.Size = New System.Drawing.Size(43, 19)
        Me.radV6.TabIndex = 6
        Me.radV6.Text = "V-6"
        Me.radV6.UseVisualStyleBackColor = True
        '
        'radV8
        '
        Me.radV8.AutoSize = True
        Me.radV8.Location = New System.Drawing.Point(89, 22)
        Me.radV8.Name = "radV8"
        Me.radV8.Size = New System.Drawing.Size(43, 19)
        Me.radV8.TabIndex = 5
        Me.radV8.Text = "V-8"
        Me.radV8.UseVisualStyleBackColor = True
        '
        'radElectric
        '
        Me.radElectric.AutoSize = True
        Me.radElectric.Location = New System.Drawing.Point(348, 22)
        Me.radElectric.Name = "radElectric"
        Me.radElectric.Size = New System.Drawing.Size(63, 19)
        Me.radElectric.TabIndex = 9
        Me.radElectric.Text = "Electric"
        Me.radElectric.UseVisualStyleBackColor = True
        '
        'radHybrid
        '
        Me.radHybrid.AutoSize = True
        Me.radHybrid.Location = New System.Drawing.Point(271, 22)
        Me.radHybrid.Name = "radHybrid"
        Me.radHybrid.Size = New System.Drawing.Size(61, 19)
        Me.radHybrid.TabIndex = 8
        Me.radHybrid.Text = "Hybrid"
        Me.radHybrid.UseVisualStyleBackColor = True
        '
        'radV4
        '
        Me.radV4.AutoSize = True
        Me.radV4.Location = New System.Drawing.Point(213, 22)
        Me.radV4.Name = "radV4"
        Me.radV4.Size = New System.Drawing.Size(43, 19)
        Me.radV4.TabIndex = 7
        Me.radV4.Text = "V-4"
        Me.radV4.UseVisualStyleBackColor = True
        '
        'radV12
        '
        Me.radV12.AutoSize = True
        Me.radV12.Checked = True
        Me.radV12.Location = New System.Drawing.Point(18, 22)
        Me.radV12.Name = "radV12"
        Me.radV12.Size = New System.Drawing.Size(49, 19)
        Me.radV12.TabIndex = 4
        Me.radV12.TabStop = True
        Me.radV12.Text = "V-12"
        Me.radV12.UseVisualStyleBackColor = True
        '
        'grpOptions
        '
        Me.grpOptions.Controls.Add(Me.chkEntertainment)
        Me.grpOptions.Controls.Add(Me.chkGPS)
        Me.grpOptions.Controls.Add(Me.chkBluetooth)
        Me.grpOptions.Controls.Add(Me.chkMP3)
        Me.grpOptions.Controls.Add(Me.chkStereo)
        Me.grpOptions.Controls.Add(Me.chkAirConditioning)
        Me.grpOptions.Controls.Add(Me.chkDefroster)
        Me.grpOptions.Controls.Add(Me.chkHeated)
        Me.grpOptions.Controls.Add(Me.chkLeather)
        Me.grpOptions.Location = New System.Drawing.Point(13, 169)
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.Size = New System.Drawing.Size(444, 146)
        Me.grpOptions.TabIndex = 8
        Me.grpOptions.TabStop = False
        Me.grpOptions.Text = "Options:"
        '
        'chkEntertainment
        '
        Me.chkEntertainment.AutoSize = True
        Me.chkEntertainment.Location = New System.Drawing.Point(285, 96)
        Me.chkEntertainment.Name = "chkEntertainment"
        Me.chkEntertainment.Size = New System.Drawing.Size(148, 19)
        Me.chkEntertainment.TabIndex = 18
        Me.chkEntertainment.Text = "Entertainment Package"
        Me.chkEntertainment.UseVisualStyleBackColor = True
        '
        'chkGPS
        '
        Me.chkGPS.AutoSize = True
        Me.chkGPS.Location = New System.Drawing.Point(285, 59)
        Me.chkGPS.Name = "chkGPS"
        Me.chkGPS.Size = New System.Drawing.Size(47, 19)
        Me.chkGPS.TabIndex = 15
        Me.chkGPS.Text = "GPS"
        Me.chkGPS.UseVisualStyleBackColor = True
        '
        'chkBluetooth
        '
        Me.chkBluetooth.AutoSize = True
        Me.chkBluetooth.Location = New System.Drawing.Point(285, 23)
        Me.chkBluetooth.Name = "chkBluetooth"
        Me.chkBluetooth.Size = New System.Drawing.Size(78, 19)
        Me.chkBluetooth.TabIndex = 12
        Me.chkBluetooth.Text = "Bluetooth"
        Me.chkBluetooth.UseVisualStyleBackColor = True
        '
        'chkMP3
        '
        Me.chkMP3.AutoSize = True
        Me.chkMP3.Location = New System.Drawing.Point(128, 95)
        Me.chkMP3.Name = "chkMP3"
        Me.chkMP3.Size = New System.Drawing.Size(141, 19)
        Me.chkMP3.TabIndex = 17
        Me.chkMP3.Text = "CD/MP3 Connections"
        Me.chkMP3.UseVisualStyleBackColor = True
        '
        'chkStereo
        '
        Me.chkStereo.AutoSize = True
        Me.chkStereo.Location = New System.Drawing.Point(128, 58)
        Me.chkStereo.Name = "chkStereo"
        Me.chkStereo.Size = New System.Drawing.Size(111, 19)
        Me.chkStereo.TabIndex = 14
        Me.chkStereo.Text = "Premium Stereo"
        Me.chkStereo.UseVisualStyleBackColor = True
        '
        'chkAirConditioning
        '
        Me.chkAirConditioning.AutoSize = True
        Me.chkAirConditioning.Location = New System.Drawing.Point(128, 22)
        Me.chkAirConditioning.Name = "chkAirConditioning"
        Me.chkAirConditioning.Size = New System.Drawing.Size(114, 19)
        Me.chkAirConditioning.TabIndex = 11
        Me.chkAirConditioning.Text = "Air Conditioning"
        Me.chkAirConditioning.UseVisualStyleBackColor = True
        '
        'chkDefroster
        '
        Me.chkDefroster.AutoSize = True
        Me.chkDefroster.Location = New System.Drawing.Point(7, 96)
        Me.chkDefroster.Name = "chkDefroster"
        Me.chkDefroster.Size = New System.Drawing.Size(100, 19)
        Me.chkDefroster.TabIndex = 16
        Me.chkDefroster.Text = "Rear Defroster"
        Me.chkDefroster.UseVisualStyleBackColor = True
        '
        'chkHeated
        '
        Me.chkHeated.AutoSize = True
        Me.chkHeated.Location = New System.Drawing.Point(6, 59)
        Me.chkHeated.Name = "chkHeated"
        Me.chkHeated.Size = New System.Drawing.Size(94, 19)
        Me.chkHeated.TabIndex = 13
        Me.chkHeated.Text = "Heated Seats"
        Me.chkHeated.UseVisualStyleBackColor = True
        '
        'chkLeather
        '
        Me.chkLeather.AutoSize = True
        Me.chkLeather.Location = New System.Drawing.Point(7, 23)
        Me.chkLeather.Name = "chkLeather"
        Me.chkLeather.Size = New System.Drawing.Size(95, 19)
        Me.chkLeather.TabIndex = 10
        Me.chkLeather.Text = "Leather Seats"
        Me.chkLeather.UseVisualStyleBackColor = True
        '
        'btnOrder
        '
        Me.btnOrder.Location = New System.Drawing.Point(13, 333)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(444, 78)
        Me.btnOrder.TabIndex = 19
        Me.btnOrder.Text = "Place Car(s) Order"
        Me.btnOrder.UseVisualStyleBackColor = True
        '
        'frmKarsOrderForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 423)
        Me.Controls.Add(Me.btnOrder)
        Me.Controls.Add(Me.grpOptions)
        Me.Controls.Add(Me.grpDriveTrain)
        Me.Controls.Add(Me.updQuantity)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.lstType)
        Me.Controls.Add(Me.lblCarType)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblCustName)
        Me.Name = "frmKarsOrderForm"
        Me.Text = "Kustom Karz Order Form"
        CType(Me.updQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDriveTrain.ResumeLayout(False)
        Me.grpDriveTrain.PerformLayout()
        Me.grpOptions.ResumeLayout(False)
        Me.grpOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCustName As Label
    Friend WithEvents txtCarType As TextBox
    Friend WithEvents lblCarType As Label
    Friend WithEvents lstType As ListBox
    Friend WithEvents lblQuantity As Label
    Friend WithEvents numQuantity As NumericUpDown
    Friend WithEvents grpDriveTrain As GroupBox
    Friend WithEvents rbtnV6 As RadioButton
    Friend WithEvents rbtnV8 As RadioButton
    Friend WithEvents rbtnElectric As RadioButton
    Friend WithEvents rbtnHybrid As RadioButton
    Friend WithEvents rbtnV4 As RadioButton
    Friend WithEvents rbtnV12 As RadioButton
    Friend WithEvents grpOptions As GroupBox
    Friend WithEvents chkEntertainment As CheckBox
    Friend WithEvents chkGPS As CheckBox
    Friend WithEvents chkBluetooth As CheckBox
    Friend WithEvents chkMP3 As CheckBox
    Friend WithEvents chkStereo As CheckBox
    Friend WithEvents chkAirConditioning As CheckBox
    Friend WithEvents chkDefroster As CheckBox
    Friend WithEvents chkHeated As CheckBox
    Friend WithEvents chkLeather As CheckBox
    Friend WithEvents btnOrder As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents updQuantity As NumericUpDown
    Friend WithEvents radV6 As RadioButton
    Friend WithEvents radV8 As RadioButton
    Friend WithEvents radElectric As RadioButton
    Friend WithEvents radHybrid As RadioButton
    Friend WithEvents radV4 As RadioButton
    Friend WithEvents radV12 As RadioButton
End Class
