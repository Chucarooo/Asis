<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Conectar = New System.Windows.Forms.Button
        Me.Desconectar = New System.Windows.Forms.Button
        Me.Recuperar = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Alumnos = New System.Windows.Forms.Button
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Conectar
        '
        Me.Conectar.Location = New System.Drawing.Point(12, 26)
        Me.Conectar.Name = "Conectar"
        Me.Conectar.Size = New System.Drawing.Size(91, 23)
        Me.Conectar.TabIndex = 0
        Me.Conectar.Text = "Conectar"
        Me.Conectar.UseVisualStyleBackColor = True
        '
        'Desconectar
        '
        Me.Desconectar.Location = New System.Drawing.Point(137, 26)
        Me.Desconectar.Name = "Desconectar"
        Me.Desconectar.Size = New System.Drawing.Size(91, 23)
        Me.Desconectar.TabIndex = 1
        Me.Desconectar.Text = "Desconectar"
        Me.Desconectar.UseVisualStyleBackColor = True
        '
        'Recuperar
        '
        Me.Recuperar.Location = New System.Drawing.Point(12, 106)
        Me.Recuperar.Name = "Recuperar"
        Me.Recuperar.Size = New System.Drawing.Size(91, 23)
        Me.Recuperar.TabIndex = 2
        Me.Recuperar.Text = "Recuperar"
        Me.Recuperar.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(108, 106)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(163, 20)
        Me.TextBox1.TabIndex = 3
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(277, 106)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(312, 184)
        Me.DataGridView1.TabIndex = 4
        '
        'Alumnos
        '
        Me.Alumnos.Location = New System.Drawing.Point(277, 77)
        Me.Alumnos.Name = "Alumnos"
        Me.Alumnos.Size = New System.Drawing.Size(91, 23)
        Me.Alumnos.TabIndex = 5
        Me.Alumnos.Text = "Alumnos"
        Me.Alumnos.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(601, 327)
        Me.Controls.Add(Me.Alumnos)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Recuperar)
        Me.Controls.Add(Me.Desconectar)
        Me.Controls.Add(Me.Conectar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Conectar As System.Windows.Forms.Button
    Friend WithEvents Desconectar As System.Windows.Forms.Button
    Friend WithEvents Recuperar As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Alumnos As System.Windows.Forms.Button

End Class
