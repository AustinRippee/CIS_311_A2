'------------------------------------------------------------
'-                File Name : frmKarsOrderForm              - 
'-                Part of Project: Order Form               -
'------------------------------------------------------------
'-                Written By: Austin Rippee                 -
'-                Written On: January 25th, 2022            -
'------------------------------------------------------------
'- File Purpose:                                            -
'- This file serves the purpose as the main window that
'- appears when the user starts the program.  The user will
'- enter a name, car type, how many cars, the poweroption,
'- and any other additions                                      
'------------------------------------------------------------
'- Program Purpose:                                         -
'-                                                          -
'- The program serves as a way to buy multiple cars in bulk
'- of the same type.               
'------------------------------------------------------------
'- Global Variable Dictionary (alphabetically):             -
'- (None)
'------------------------------------------------------------
Public Class frmKarsOrderForm

    Const dblCoupeCost As Double = 10000 'Sets price for Coupe Car Type
    Const dblLuxuryCost As Double = 20000 'Sets price for Luxury Car Type
    Const dblSedanCost As Double = 17000 'Sets price for Sedan Car Type
    Const dblSportsCost As Double = 25000 'Sets price for Sports Car Type
    Const dblSUVCost As Double = 27000 'Sets price for SUV Car Type
    Const dblV4Price As Double = 500 'Sets price for V4 Poweroption
    Const dblV6Price As Double = 1000 'Sets price for V6 Poweroption
    Const dblV8Price As Double = 2500 'Sets price for V8 Poweroption
    Const dblV12Price As Double = 7500 'Sets price for V12 Poweroption
    Const dblHybridPrice As Double = 3000 'Sets price for Hybrid Poweroption
    Const dblElectricPrice As Double = 6000 'Sets price for Electric Poweroption

    '------------------------------------------------------------
    '-                Subprogram Name: btnOrder_Click           -
    '------------------------------------------------------------
    '-                Written By: Austin Rippee                 -
    '-                Written On: January 25th, 2022            -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called whenever the user clicks the   -
    '- order button. The program will take the user-inputed name
    '- the carp type, number of cars, and all the options and
    '- perform calculations of everything including the overall
    '- price of the order–
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- dblDriveCost - Sets the price of the poweroption from constants
    '- dblNumOptions - Keeps track of the number of options selected
    '- dblOptionsCost - Keeps track of the total price of the options selected
    '- strCarPrice - Creates a variable to store the per car price
    '- strGrandTotalPrice - Multiplies total vehcile price with the quantity of cars
    '- strOptionsPrice - Converts optionsprice to a currency format
    '- strPowerTrainOption - Keeps track of which poweroption was
    '-                       selected
    '- strPowerTrainPrice - Converts the poweroption price to a currency format
    '- strTextBreak - String that creates a strDup of '=' 50 times
    '                 to create a text break
    '- strVehicleTotal - Adds in the car price, options cost, and the
    '-                   poweroption cost and converts that number to a currency format
    '- strVehicleTotalPrice - Converts the Vehicle Total to a currency format
    '- 
    '------------------------------------------------------------
    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click

        Dim strTextBreak As String = StrDup(50, "=") 'Creates a "horizontal line" of equal signs 'Initializes strTextBreak
        Dim strCarPrice As String = "" 'Intializes strCarPrice as an empty string

        If String.IsNullOrEmpty(txtName.Text) Then 'Checks if the name textbox is empty or null
            MsgBox("You must add a customer name")
        ElseIf lstType.Text = "" Then 'Checks if a car type is selected
            MsgBox("You need to select a car type")
        ElseIf updQuantity.Value <= 0 Then 'Prevents the user from going below 1 car
            MsgBox("You must order at least 1 vehicle")
        Else
            If lstType.Text = "Coupe" Then 'Checks if Coupe Car Type is selected
                strCarPrice = Format(dblCoupeCost, "Currency")
            ElseIf lstType.Text = "Luxury" Then 'Checks if Luxury Car Type is selected
                strCarPrice = Format(dblLuxuryCost, "Currency")
            ElseIf lstType.Text = "Sedan" Then 'Checks if Sedan Car Type is selected
                strCarPrice = Format(dblSedanCost, "Currency")
            ElseIf lstType.Text = "Sports Edition" Then 'Checks if Sports Car Type is selected
                strCarPrice = Format(dblSportsCost, "Currency")
            ElseIf lstType.Text = "SUV" Then 'Checks if SUV Car Type is selected
                strCarPrice = Format(dblSUVCost, "Currency")
            End If

            frmKarsInvoiceForm.lstInvoice.Items.Clear() 'Clears the listbox so no message is duplicated after the changeOrder button is pressed on other form

            frmKarsInvoiceForm.lstInvoice.Items.Add(strTextBreak.ToString()) 'Adds a textbreak line
            frmKarsInvoiceForm.lstInvoice.Items.Add(vbTab + vbTab + "Kustom Karz Order") 'Adds the Invoice Title line
            frmKarsInvoiceForm.lstInvoice.Items.Add(strTextBreak.ToString()) 'Adds a textbreak line
            frmKarsInvoiceForm.lstInvoice.Items.Add("") 'Adds blank line as a seperator
            frmKarsInvoiceForm.lstInvoice.Items.Add("Getting ready to kustom manufacture for " + txtName.Text) 'Adds a line displaying user's name
            frmKarsInvoiceForm.lstInvoice.Items.Add("") 'Adds blank line as a seperator
            frmKarsInvoiceForm.lstInvoice.Items.Add("There will be " + updQuantity.Text + " car(s) kustom built") 'Adds a line displaying the number of vehicles being requested
            frmKarsInvoiceForm.lstInvoice.Items.Add(StrDup(50, "-")) 'Adds a textbreak line
            frmKarsInvoiceForm.lstInvoice.Items.Add("Kar form factor:" + vbTab + lstType.Text + vbTab + " at " + CStr(strCarPrice)) 'Adds a line displaying car type and car price

            Dim strPowerTrainOption As String = "" 'Initializes strPowerTrainOption as an empty string
            Dim strPowerTrainPrice As String = "" 'Initializes strPowerTrainPrice as an empty string
            Dim dblDriveCost As Double = 0  'Initializes dblDriveCost as a double of 0

            If radV12.Checked Then 'Checks if the V12 power option radio button has been pressed
                strPowerTrainOption = "V12" 'Sets name
                strPowerTrainPrice = Format(dblV12Price, "Currency") 'Sets price as a currency
                dblDriveCost = dblV12Price 'Sets price from the constant
            ElseIf radV8.Checked Then 'Checks if the V8 power option radio button has been pressed
                strPowerTrainOption = "V8" 'Sets name
                strPowerTrainPrice = Format(dblV8Price, "Currency") 'Sets price as a currency
                dblDriveCost = dblV8Price 'Sets price from the constant
            ElseIf radV6.Checked Then 'Checks if the V6 power option radio button has been pressed
                strPowerTrainOption = "V6" 'Sets name
                strPowerTrainPrice = Format(dblV6Price, "Currency") 'Sets price as a currency
                dblDriveCost = dblV6Price 'Sets price from the constant
            ElseIf radV4.Checked Then 'Checks if the V4 power option radio button has been pressed
                strPowerTrainOption = "V4" 'Sets name
                strPowerTrainPrice = Format(dblV4Price, "Currency") 'Sets price as a currency
                dblDriveCost = dblV4Price 'Sets price from the constant
            ElseIf radHybrid.Checked Then 'Checks if the Hybrid power option radio button has been pressed
                strPowerTrainOption = "Hybrid" 'Sets name
                strPowerTrainPrice = Format(dblHybridPrice, "Currency") 'Sets price as a currency
                dblDriveCost = dblHybridPrice 'Sets price from the constant
            ElseIf radElectric.Checked Then 'Checks if the Electric power option radio button has been pressed
                strPowerTrainOption = "Electric" 'Sets name
                strPowerTrainPrice = Format(dblElectricPrice, "Currency") 'Sets price as a currency
                dblDriveCost = dblElectricPrice 'Sets price from the constant
            Else
                MsgBox("Please Select a Drive Train Option") 'If nothing is selected (impossible), still has validation that something hasn't been checked
            End If

            'Adds a line displaying the power option that was selected and its price
            frmKarsInvoiceForm.lstInvoice.Items.Add("PowerTrain Option: " + vbTab + CStr(strPowerTrainOption) + vbTab + " at " + CStr(strPowerTrainPrice))
            frmKarsInvoiceForm.lstInvoice.Items.Add("") 'Adds blank line as a seperator

            Dim dblOptionsCost As Double = 0 'Initializes dblOptionsCost as a double of 0
            Dim dblNumOptions As Integer = 0 'Initializes dblNumOptions as a double of 0

            'A simple for each statement that checks which checkboxes are checked in the groupbox
            For Each c As Control In grpOptions.Controls
                If c.GetType Is GetType(CheckBox) Then
                    Dim cb As CheckBox = DirectCast(c, CheckBox)
                    If cb.Checked Then
                        dblNumOptions += 1 'Keeps track of how many options have been selected
                        dblOptionsCost += 750 'Adds $750 to each option selected
                    End If
                End If
            Next

            frmKarsInvoiceForm.lstInvoice.Items.Add("Here are the options requested:") 'Adds a line for options requested title

            'Checks for checkboxes being selected and displays them in ALPHABETICAL order
            If chkAirConditioning.Checked = True Then 'Checks if checkbox is checked
                frmKarsInvoiceForm.lstInvoice.Items.Add(vbTab + "Air Conditioning") 'Adds a line displaying Air Conditioning if it is checked
            End If
            If chkBluetooth.Checked = True Then 'Checks if checkbox is checked
                frmKarsInvoiceForm.lstInvoice.Items.Add(vbTab + "Bluetooth") 'Adds a line displaying Bluetooth if it is checked
            End If
            If chkMP3.Checked = True Then 'Checks if checkbox is checked
                frmKarsInvoiceForm.lstInvoice.Items.Add(vbTab + "CD/MP3 Connections") 'Adds a line displaying CD/MP3 connections if it is checked
            End If
            If chkEntertainment.Checked = True Then 'Checks if checkbox is checked
                frmKarsInvoiceForm.lstInvoice.Items.Add(vbTab + "Entertainment Package") 'Adds a line displaying Entertainment Package if it is checked
            End If
            If chkGPS.Checked = True Then 'Checks if checkbox is checked
                frmKarsInvoiceForm.lstInvoice.Items.Add(vbTab + "GPS") 'Adds a line displaying GPS if it is checked
            End If
            If chkHeated.Checked = True Then 'Checks if checkbox is checked
                frmKarsInvoiceForm.lstInvoice.Items.Add(vbTab + "Heated Seats") 'Adds a line displaying Heated Seats if it is checked
            End If
            If chkLeather.Checked = True Then 'Checks if checkbox is checked
                frmKarsInvoiceForm.lstInvoice.Items.Add(vbTab + "Leather Seats") 'Adds a line displaying Leather Seats if it is checked
            End If
            If chkStereo.Checked = True Then 'Checks if checkbox is checked
                frmKarsInvoiceForm.lstInvoice.Items.Add(vbTab + "Premium Stereo") 'Adds a line displaying Premium Stereo if it is checked
            End If
            If chkDefroster.Checked = True Then 'Checks if checkbox is checked
                frmKarsInvoiceForm.lstInvoice.Items.Add(vbTab + "Rear Defroster") 'Adds a line displaying Rear Defroster if it is checked
            End If

            'Initializes strOptionsPrice as a string of dblOptionsCost as a currency
            Dim strOptionsPrice As String = Format(CStr(dblOptionsCost), "Currency")
            'Initializes strVehicleTotal as a string of the sum of strCarPrice, dblOptionsCost, dblDriveCost as a currency
            Dim strVehicleTotal As String = Format(CStr(strCarPrice + dblOptionsCost + dblDriveCost), "Currency")
            'Initializes strGrandTotalPrice as a string multiplying the amount of cars with the total price as a currency
            Dim strGrandTotalPrice As String = Format(CStr(strVehicleTotal * updQuantity.Value.ToString()), "Currency")
            'Initializes strVehicleTotalPrice as a string of strVehicleTotal as a currency
            Dim strVehicleTotalPrice As String = Format(CStr(strVehicleTotal), "Currency")

            'Adds a line displaying the number of options selected the total options price
            frmKarsInvoiceForm.lstInvoice.Items.Add(CStr(dblNumOptions) + " Options Selected for a total of " + CStr(strOptionsPrice))
            frmKarsInvoiceForm.lstInvoice.Items.Add("") 'Adds blank line as a seperator
            frmKarsInvoiceForm.lstInvoice.Items.Add("") 'Adds blank line as a seperator
            'Adds a line displaying the per vehicle total price
            frmKarsInvoiceForm.lstInvoice.Items.Add("Per Vehicle Total:" + vbTab + vbTab + CStr(strVehicleTotalPrice))
            frmKarsInvoiceForm.lstInvoice.Items.Add(StrDup(50, "-")) 'Adds a textbreak line
            'Adds a line that displays the number of cars ordered
            frmKarsInvoiceForm.lstInvoice.Items.Add("Quantity Ordered:" + vbTab + vbTab + updQuantity.Value.ToString())
            frmKarsInvoiceForm.lstInvoice.Items.Add(StrDup(50, "-")) 'Adds a textbreak line
            'Adds a line ti display the grand total price
            frmKarsInvoiceForm.lstInvoice.Items.Add("Grand Total:" + vbTab + vbTab + CStr(strGrandTotalPrice))
            frmKarsInvoiceForm.lstInvoice.Items.Add("") 'Adds blank line as a seperator
            frmKarsInvoiceForm.lstInvoice.Items.Add(strTextBreak.ToString()) 'Adds a textbreak line

            Me.Visible = False 'Closes the order form
            frmKarsInvoiceForm.Visible = True 'Opens the invoice form
        End If


    End Sub

    '------------------------------------------------------------
    '-                Subprogram Name: frmKarsOrderForm_FormClosing
    '------------------------------------------------------------
    '-                Written By: Austin Rippee                 -
    '-                Written On: January 25th, 2022            -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called whenever the user is exiting the
    '- form. The program prohibits the user from exiting the form
    '- and suggests going to the invoice form to actually close                                      
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub frmKarsOrderForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'Displays the message box that the user cannot exit the form
        MessageBox.Show("Sorry but the application can only be closed on the Invoice Screen" + vbCrLf + "Please press Place Order to go to that screen...")
        e.Cancel = True
    End Sub

End Class