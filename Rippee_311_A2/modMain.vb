Module modMain
    '------------------------------------------------------------
    '-                Subprogram Name: Main()            -
    '------------------------------------------------------------
    '-                Written By: Austin Rippee                     -
    '-                Written On: January 25th, 2022         -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called whenever the user loads the program.
    '- Theoretically, the order form will show and then with the
    '- press of the exit button or the X button of the program, the
    '- form will call the function ApplicationExit()
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Sub Main()
        frmKarsOrderForm.ShowDialog()
        'If frmKarsInvoiceForm.DialogResult.Cancel Then
        'ApplicationExit()
        'End If
        If frmKarsInvoiceForm.btnExit.Enabled Then
            ApplicationExit()
        End If
    End Sub

    '------------------------------------------------------------
    '-                Function Name: ApplicationExit()            -
    '------------------------------------------------------------
    '-                Written By: Austin Rippee                     -
    '-                Written On: January 25th, 2022         -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This function is called when the user clicks on the exit
    '- button or presses the X button, the function will performclick
    '- btnExit, making the program close the form and end the application
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- Boolean – If the program is exiting or not            -
    '------------------------------------------------------------
    Public Function ApplicationExit()
        frmKarsInvoiceForm.btnExit.PerformClick()
        Return True
    End Function

End Module
