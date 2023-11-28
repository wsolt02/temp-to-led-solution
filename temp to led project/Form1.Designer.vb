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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.LABEL_temp_48 = New System.Windows.Forms.Label()
        Me.lbl_temp_upstairs = New System.Windows.Forms.Label()
        Me.LABEL_humid_48 = New System.Windows.Forms.Label()
        Me.lbl_humid_upstairs = New System.Windows.Forms.Label()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.LABEL_temp_49 = New System.Windows.Forms.Label()
        Me.Label_humid_49 = New System.Windows.Forms.Label()
        Me.Label_temp_50 = New System.Windows.Forms.Label()
        Me.Label_humid_50 = New System.Windows.Forms.Label()
        Me.lbl_temp_outside = New System.Windows.Forms.Label()
        Me.lbl_humid_garage = New System.Windows.Forms.Label()
        Me.lbl_temp_garage = New System.Windows.Forms.Label()
        Me.lbl_humid_outside = New System.Windows.Forms.Label()
        Me.ComboBox_choose = New System.Windows.Forms.ComboBox()
        Me.TextBox_trigger_temp = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_warning_preset = New System.Windows.Forms.TextBox()
        Me.Txt_background_preset = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button_Exit = New System.Windows.Forms.Button()
        Me.Button_Test = New System.Windows.Forms.Button()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LABEL_temp_48
        '
        Me.LABEL_temp_48.AutoSize = True
        Me.LABEL_temp_48.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LABEL_temp_48.Location = New System.Drawing.Point(1211, 22)
        Me.LABEL_temp_48.Name = "LABEL_temp_48"
        Me.LABEL_temp_48.Size = New System.Drawing.Size(258, 46)
        Me.LABEL_temp_48.TabIndex = 0
        Me.LABEL_temp_48.Text = "upstairs temp"
        '
        'lbl_temp_upstairs
        '
        Me.lbl_temp_upstairs.AutoSize = True
        Me.lbl_temp_upstairs.BackColor = System.Drawing.SystemColors.Info
        Me.lbl_temp_upstairs.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_temp_upstairs.Location = New System.Drawing.Point(1587, 22)
        Me.lbl_temp_upstairs.Name = "lbl_temp_upstairs"
        Me.lbl_temp_upstairs.Size = New System.Drawing.Size(195, 46)
        Me.lbl_temp_upstairs.TabIndex = 1
        Me.lbl_temp_upstairs.Text = "Loading..."
        '
        'LABEL_humid_48
        '
        Me.LABEL_humid_48.AutoSize = True
        Me.LABEL_humid_48.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LABEL_humid_48.Location = New System.Drawing.Point(1211, 92)
        Me.LABEL_humid_48.Name = "LABEL_humid_48"
        Me.LABEL_humid_48.Size = New System.Drawing.Size(318, 46)
        Me.LABEL_humid_48.TabIndex = 2
        Me.LABEL_humid_48.Text = "upstairs humidity"
        '
        'lbl_humid_upstairs
        '
        Me.lbl_humid_upstairs.AutoSize = True
        Me.lbl_humid_upstairs.BackColor = System.Drawing.SystemColors.Info
        Me.lbl_humid_upstairs.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_humid_upstairs.Location = New System.Drawing.Point(1587, 92)
        Me.lbl_humid_upstairs.Name = "lbl_humid_upstairs"
        Me.lbl_humid_upstairs.Size = New System.Drawing.Size(195, 46)
        Me.lbl_humid_upstairs.TabIndex = 3
        Me.lbl_humid_upstairs.Text = "Loading..."
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.Color.Gray
        Me.Chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft
        Me.Chart1.BackSecondaryColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Chart1.BorderlineColor = System.Drawing.Color.DarkGray
        Me.Chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        Me.Chart1.BorderlineWidth = 3
        Me.Chart1.BorderSkin.BackSecondaryColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Chart1.BorderSkin.PageColor = System.Drawing.Color.Gray
        Me.Chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.FrameTitle7
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(31, 442)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Padding = New System.Windows.Forms.Padding(0, 0, 10, 200)
        Me.Chart1.Size = New System.Drawing.Size(2248, 812)
        Me.Chart1.TabIndex = 4
        Me.Chart1.Text = "Chart1"
        '
        'LABEL_temp_49
        '
        Me.LABEL_temp_49.AutoSize = True
        Me.LABEL_temp_49.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LABEL_temp_49.Location = New System.Drawing.Point(1211, 162)
        Me.LABEL_temp_49.Name = "LABEL_temp_49"
        Me.LABEL_temp_49.Size = New System.Drawing.Size(242, 46)
        Me.LABEL_temp_49.TabIndex = 5
        Me.LABEL_temp_49.Text = "garage temp"
        '
        'Label_humid_49
        '
        Me.Label_humid_49.AutoSize = True
        Me.Label_humid_49.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_humid_49.Location = New System.Drawing.Point(1211, 232)
        Me.Label_humid_49.Name = "Label_humid_49"
        Me.Label_humid_49.Size = New System.Drawing.Size(302, 46)
        Me.Label_humid_49.TabIndex = 6
        Me.Label_humid_49.Text = "garage humidity"
        '
        'Label_temp_50
        '
        Me.Label_temp_50.AutoSize = True
        Me.Label_temp_50.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_temp_50.Location = New System.Drawing.Point(1211, 302)
        Me.Label_temp_50.Name = "Label_temp_50"
        Me.Label_temp_50.Size = New System.Drawing.Size(248, 46)
        Me.Label_temp_50.TabIndex = 7
        Me.Label_temp_50.Text = "outside temp"
        '
        'Label_humid_50
        '
        Me.Label_humid_50.AutoSize = True
        Me.Label_humid_50.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_humid_50.Location = New System.Drawing.Point(1211, 372)
        Me.Label_humid_50.Name = "Label_humid_50"
        Me.Label_humid_50.Size = New System.Drawing.Size(308, 46)
        Me.Label_humid_50.TabIndex = 8
        Me.Label_humid_50.Text = "outside humidity"
        '
        'lbl_temp_outside
        '
        Me.lbl_temp_outside.AutoSize = True
        Me.lbl_temp_outside.BackColor = System.Drawing.SystemColors.Info
        Me.lbl_temp_outside.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_temp_outside.Location = New System.Drawing.Point(1589, 302)
        Me.lbl_temp_outside.Name = "lbl_temp_outside"
        Me.lbl_temp_outside.Size = New System.Drawing.Size(195, 46)
        Me.lbl_temp_outside.TabIndex = 9
        Me.lbl_temp_outside.Text = "Loading..."
        '
        'lbl_humid_garage
        '
        Me.lbl_humid_garage.AutoSize = True
        Me.lbl_humid_garage.BackColor = System.Drawing.SystemColors.Info
        Me.lbl_humid_garage.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_humid_garage.Location = New System.Drawing.Point(1589, 232)
        Me.lbl_humid_garage.Name = "lbl_humid_garage"
        Me.lbl_humid_garage.Size = New System.Drawing.Size(195, 46)
        Me.lbl_humid_garage.TabIndex = 10
        Me.lbl_humid_garage.Text = "Loading..."
        '
        'lbl_temp_garage
        '
        Me.lbl_temp_garage.AutoSize = True
        Me.lbl_temp_garage.BackColor = System.Drawing.SystemColors.Info
        Me.lbl_temp_garage.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_temp_garage.Location = New System.Drawing.Point(1587, 162)
        Me.lbl_temp_garage.Name = "lbl_temp_garage"
        Me.lbl_temp_garage.Size = New System.Drawing.Size(195, 46)
        Me.lbl_temp_garage.TabIndex = 11
        Me.lbl_temp_garage.Text = "Loading..."
        '
        'lbl_humid_outside
        '
        Me.lbl_humid_outside.AutoSize = True
        Me.lbl_humid_outside.BackColor = System.Drawing.SystemColors.Info
        Me.lbl_humid_outside.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_humid_outside.Location = New System.Drawing.Point(1587, 372)
        Me.lbl_humid_outside.Name = "lbl_humid_outside"
        Me.lbl_humid_outside.Size = New System.Drawing.Size(195, 46)
        Me.lbl_humid_outside.TabIndex = 12
        Me.lbl_humid_outside.Text = "Loading..."
        '
        'ComboBox_choose
        '
        Me.ComboBox_choose.BackColor = System.Drawing.SystemColors.Info
        Me.ComboBox_choose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ComboBox_choose.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_choose.FormattingEnabled = True
        Me.ComboBox_choose.Location = New System.Drawing.Point(420, 43)
        Me.ComboBox_choose.Name = "ComboBox_choose"
        Me.ComboBox_choose.Size = New System.Drawing.Size(469, 54)
        Me.ComboBox_choose.TabIndex = 13
        '
        'TextBox_trigger_temp
        '
        Me.TextBox_trigger_temp.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_trigger_temp.Location = New System.Drawing.Point(838, 147)
        Me.TextBox_trigger_temp.Name = "TextBox_trigger_temp"
        Me.TextBox_trigger_temp.Size = New System.Drawing.Size(100, 53)
        Me.TextBox_trigger_temp.TabIndex = 14
        Me.TextBox_trigger_temp.Text = "00"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(412, 154)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(405, 46)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Trigger warning temp:"
        '
        'Txt_warning_preset
        '
        Me.Txt_warning_preset.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_warning_preset.Location = New System.Drawing.Point(838, 252)
        Me.Txt_warning_preset.Name = "Txt_warning_preset"
        Me.Txt_warning_preset.Size = New System.Drawing.Size(100, 53)
        Me.Txt_warning_preset.TabIndex = 16
        Me.Txt_warning_preset.Text = "04"
        '
        'Txt_background_preset
        '
        Me.Txt_background_preset.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_background_preset.Location = New System.Drawing.Point(838, 357)
        Me.Txt_background_preset.Name = "Txt_background_preset"
        Me.Txt_background_preset.Size = New System.Drawing.Size(100, 53)
        Me.Txt_background_preset.TabIndex = 17
        Me.Txt_background_preset.Text = "02"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(412, 259)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(300, 46)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Warning preset:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(412, 364)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(260, 46)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Return preset"
        '
        'Button_Exit
        '
        Me.Button_Exit.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Button_Exit.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_Exit.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Exit.Location = New System.Drawing.Point(1989, 92)
        Me.Button_Exit.Name = "Button_Exit"
        Me.Button_Exit.Size = New System.Drawing.Size(222, 94)
        Me.Button_Exit.TabIndex = 20
        Me.Button_Exit.Text = "E&xit"
        Me.Button_Exit.UseVisualStyleBackColor = False
        '
        'Button_Test
        '
        Me.Button_Test.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Button_Test.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button_Test.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_Test.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Test.Location = New System.Drawing.Point(1989, 232)
        Me.Button_Test.Name = "Button_Test"
        Me.Button_Test.Size = New System.Drawing.Size(222, 94)
        Me.Button_Test.TabIndex = 21
        Me.Button_Test.Text = "&Test"
        Me.Button_Test.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(2358, 1266)
        Me.Controls.Add(Me.Button_Test)
        Me.Controls.Add(Me.Button_Exit)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txt_background_preset)
        Me.Controls.Add(Me.Txt_warning_preset)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox_trigger_temp)
        Me.Controls.Add(Me.ComboBox_choose)
        Me.Controls.Add(Me.lbl_humid_outside)
        Me.Controls.Add(Me.lbl_temp_garage)
        Me.Controls.Add(Me.lbl_humid_garage)
        Me.Controls.Add(Me.lbl_temp_outside)
        Me.Controls.Add(Me.Label_humid_50)
        Me.Controls.Add(Me.Label_temp_50)
        Me.Controls.Add(Me.Label_humid_49)
        Me.Controls.Add(Me.LABEL_temp_49)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.lbl_humid_upstairs)
        Me.Controls.Add(Me.LABEL_humid_48)
        Me.Controls.Add(Me.lbl_temp_upstairs)
        Me.Controls.Add(Me.LABEL_temp_48)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Temp and humidity"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LABEL_temp_48 As Label
    Friend WithEvents lbl_temp_upstairs As Label
    Friend WithEvents LABEL_humid_48 As Label
    Friend WithEvents lbl_humid_upstairs As Label
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents LABEL_temp_49 As Label
    Friend WithEvents Label_humid_49 As Label
    Friend WithEvents Label_temp_50 As Label
    Friend WithEvents Label_humid_50 As Label
    Friend WithEvents lbl_temp_outside As Label
    Friend WithEvents lbl_humid_garage As Label
    Friend WithEvents lbl_temp_garage As Label
    Friend WithEvents lbl_humid_outside As Label
    Friend WithEvents ComboBox_choose As ComboBox
    Friend WithEvents TextBox_trigger_temp As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Txt_warning_preset As TextBox
    Friend WithEvents Txt_background_preset As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button_Exit As Button
    Friend WithEvents Button_Test As Button
End Class
