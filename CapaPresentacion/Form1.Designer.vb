<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.tbxNombre = New System.Windows.Forms.TextBox()
        Me.tbxCodigo = New System.Windows.Forms.TextBox()
        Me.tbxDescrip = New System.Windows.Forms.TextBox()
        Me.tbxBodega = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnInsertar = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnListar = New System.Windows.Forms.Button()
        Me.dgvListar = New System.Windows.Forms.DataGridView()
        CType(Me.dgvListar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbxNombre
        '
        Me.tbxNombre.Location = New System.Drawing.Point(307, 76)
        Me.tbxNombre.Name = "tbxNombre"
        Me.tbxNombre.Size = New System.Drawing.Size(294, 31)
        Me.tbxNombre.TabIndex = 0
        '
        'tbxCodigo
        '
        Me.tbxCodigo.Location = New System.Drawing.Point(307, 127)
        Me.tbxCodigo.Name = "tbxCodigo"
        Me.tbxCodigo.Size = New System.Drawing.Size(294, 31)
        Me.tbxCodigo.TabIndex = 1
        '
        'tbxDescrip
        '
        Me.tbxDescrip.Location = New System.Drawing.Point(307, 180)
        Me.tbxDescrip.Name = "tbxDescrip"
        Me.tbxDescrip.Size = New System.Drawing.Size(294, 31)
        Me.tbxDescrip.TabIndex = 2
        '
        'tbxBodega
        '
        Me.tbxBodega.Location = New System.Drawing.Point(307, 239)
        Me.tbxBodega.Name = "tbxBodega"
        Me.tbxBodega.Size = New System.Drawing.Size(294, 31)
        Me.tbxBodega.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(101, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(101, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Codigo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(101, 186)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 25)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Descripcion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(101, 242)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 25)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Nº Bodega"
        '
        'BtnInsertar
        '
        Me.BtnInsertar.Location = New System.Drawing.Point(53, 330)
        Me.BtnInsertar.Name = "BtnInsertar"
        Me.BtnInsertar.Size = New System.Drawing.Size(126, 51)
        Me.BtnInsertar.TabIndex = 8
        Me.BtnInsertar.Text = "Guardar"
        Me.BtnInsertar.UseVisualStyleBackColor = True
        '
        'BtnEditar
        '
        Me.BtnEditar.Location = New System.Drawing.Point(228, 330)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(126, 51)
        Me.BtnEditar.TabIndex = 9
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(390, 330)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(126, 51)
        Me.BtnEliminar.TabIndex = 10
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnListar
        '
        Me.BtnListar.Location = New System.Drawing.Point(549, 330)
        Me.BtnListar.Name = "BtnListar"
        Me.BtnListar.Size = New System.Drawing.Size(126, 51)
        Me.BtnListar.TabIndex = 11
        Me.BtnListar.Text = "Listar"
        Me.BtnListar.UseVisualStyleBackColor = True
        '
        'dgvListar
        '
        Me.dgvListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListar.Location = New System.Drawing.Point(12, 410)
        Me.dgvListar.Name = "dgvListar"
        Me.dgvListar.RowTemplate.Height = 33
        Me.dgvListar.Size = New System.Drawing.Size(704, 308)
        Me.dgvListar.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(728, 852)
        Me.Controls.Add(Me.dgvListar)
        Me.Controls.Add(Me.BtnListar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.BtnInsertar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbxBodega)
        Me.Controls.Add(Me.tbxDescrip)
        Me.Controls.Add(Me.tbxCodigo)
        Me.Controls.Add(Me.tbxNombre)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgvListar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbxNombre As System.Windows.Forms.TextBox
    Friend WithEvents tbxCodigo As System.Windows.Forms.TextBox
    Friend WithEvents tbxDescrip As System.Windows.Forms.TextBox
    Friend WithEvents tbxBodega As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BtnInsertar As System.Windows.Forms.Button
    Friend WithEvents BtnEditar As System.Windows.Forms.Button
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
    Friend WithEvents BtnListar As System.Windows.Forms.Button
    Friend WithEvents dgvListar As System.Windows.Forms.DataGridView

End Class
