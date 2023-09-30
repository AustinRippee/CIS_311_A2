<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKarsInvoiceForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lstInvoice = New System.Windows.Forms.ListBox()
        Me.btnChangeOrder = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstInvoice
        '
        Me.lstInvoice.FormattingEnabled = True
        Me.lstInvoice.ItemHeight = 15
        Me.lstInvoice.Location = New System.Drawing.Point(13, 13)
        Me.lstInvoice.Name = "lstInvoice"
        Me.lstInvoice.Size = New System.Drawing.Size(485, 439)
        Me.lstInvoice.TabIndex = 0
        '
        'btnChangeOrder
        '
        Me.btnChangeOrder.Location = New System.Drawing.Point(13, 464)
        Me.btnChangeOrder.Name = "btnChangeOrder"
        Me.btnChangeOrder.Size = New System.Drawing.Size(141, 46)
        Me.btnChangeOrder.TabIndex = 1
        Me.btnChangeOrder.Text = "Change Order"
        Me.btnChangeOrder.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(186, 464)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(141, 46)
        Me.btnSubmit.TabIndex = 2
        Me.btnSubmit.Text = "Submit to Manufacturing"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(357, 464)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(141, 46)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmKarsInvoiceForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 522)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnChangeOrder)
        Me.Controls.Add(Me.lstInvoice)
        Me.Name = "frmKarsInvoiceForm"
        Me.Text = "Kustom Karz Invoice Form"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstInvoice As ListBox
    Friend WithEvents btnChangeOrder As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnExit As Button
End Class
