'------------------------------------------------------------
'-                File Name : frmKarsInvoiceForm.frm                     - 
'-                Part of Project: Invoice Form                  -
'------------------------------------------------------------
'-                Written By: Austin Rippee                     -
'-                Written On: January 25th, 2022         -
'------------------------------------------------------------
'- File Purpose:                                            -
'- This file contains the invoice form code in which interacts
'- with the invoice form where the user will be shown the prices
'- of all of their options                                - 
'------------------------------------------------------------
Public Class frmKarsInvoiceForm
    '------------------------------------------------------------
    '-                Subprogram Name: btnExit_Click            -
    '------------------------------------------------------------
    '-                Written By: Austin Rippee                     -
    '-                Written On: January 25th, 2022        -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called whenever the user clicks the   -
    '- exit button.  The program will close out the form and end
    '- the whole application                                      –
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close() 'Closes current form (frmKarsInvoiceForm)
    End Sub

    '------------------------------------------------------------
    '-                Subprogram Name: btnQuit_Click            -
    '------------------------------------------------------------
    '-                Written By: Austin Rippee                     -
    '-                Written On: January 25th, 2022         -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called whenever the user is attempting
    '- to close out the application whether it is the 'X' button
    '- or the physical exit button                                     –
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub frmKarsInvoiceForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'If the user attempts to close the invoice form, a message box will be displayed asking if the user want to close the application
        If MessageBox.Show("Are you sure you want to quit?", "Kustom Karz Order System", MessageBoxButtons.YesNo) = DialogResult.No Then
            e.Cancel = True
        Else
            End
        End If
    End Sub

    '------------------------------------------------------------
    '-                Subprogram Name: btnChangeOrder_Click            -
    '------------------------------------------------------------
    '-                Written By: Austin Rippee                     -
    '-                Written On: January 25th, 2022         -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called whenever the user clicks the   -
    '- changeOrder button.  The program will return back to the
    '- order form in which none of the user's options have been
    '- changed.
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub btnChangeOrder_Click(sender As Object, e As EventArgs) Handles btnChangeOrder.Click
        Me.Visible = False 'Closes invoice form
        frmKarsOrderForm.Visible = True 'Opens order form
    End Sub

    '------------------------------------------------------------
    '-                Subprogram Name: btnSubmit_Click            -
    '------------------------------------------------------------
    '-                Written By: Austin Rippee                     -
    '-                Written On: January 25th, 2022         -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called whenever the user clicks the   -
    '- submit button. The program will promopt the user that the
    '- order has been submitted to manfuacturing successfully.
    '- This doesn't do anything besides prompt a messagebox and
    '- return to the order form with all textboxes and options
    '- unselected to start a new order–
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        MessageBox.Show("Order successfully submitted to manfuacturing.", "Kustom Karz Ordering System") 'Successfully completed messagebox
        Me.Visible = False 'Closes the invoice form
        frmKarsOrderForm.txtName.Text = "" 'Clears name textbox
        frmKarsOrderForm.lstType.SelectedIndex = -1 'Sets value of cartype to index -1 (no value)
        frmKarsOrderForm.updQuantity.Value = "1" 'Sets the car quantity to 1 (Lowest value)
        frmKarsOrderForm.radV12.Checked = True 'Checks the first power option
        frmKarsOrderForm.chkLeather.Checked = False 'Unchecks leathers seats
        frmKarsOrderForm.chkHeated.Checked = False 'Unchecks heated seats
        frmKarsOrderForm.chkDefroster.Checked = False 'Unchecks defroster
        frmKarsOrderForm.chkAirConditioning.Checked = False 'Unchecks Air Conditoning
        frmKarsOrderForm.chkStereo.Checked = False 'Unchecks stereo
        frmKarsOrderForm.chkMP3.Checked = False 'Unchecks audio output
        frmKarsOrderForm.chkBluetooth.Checked = False 'Unchecks bluetooth
        frmKarsOrderForm.chkGPS.Checked = False 'Unchecks GPS
        frmKarsOrderForm.chkEntertainment.Checked = False 'Unchecks entertainment system
        frmKarsOrderForm.Visible = True 'Opens the order form with everything "back to normal"
    End Sub
End Class