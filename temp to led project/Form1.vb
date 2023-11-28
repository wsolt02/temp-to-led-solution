Option Explicit On
Option Strict Off
Option Infer Off

Imports System.Net.Http
Imports System.Windows.Forms.DataVisualization.Charting

Public Class Form1
    ' Timer for fetching temperature and humidity data from sensors.
    Private WithEvents SensorDataFetchTimer As New Timer()
    ' Timer for updating chart series and labels.
    Private WithEvents DataUpdateTimer As New Timer()
    ' Timer for controlling the WLED device.
    Private WithEvents WledControlTimer As New Timer()
    ' Timer for limiting how often preset 4 can be sent to the WLED device.
    Private WithEvents WledWarningLimitTimer As New Timer()
    ' IP addresses of the devices to fetch data from.
    Private ipAddresses As String() = {"192.168.0.48", "192.168.0.49", "192.168.0.50"}
    ' Locations corresponding to the IP addresses.
    Private locations As String() = {"Upstairs", "Garage", "Outside"}
    ' Flag to track if a command has been sent to the WLED device.
    Private wledCommandSent As Boolean = False
    ' Flag to track if the test button has been clicked.
    Private testButtonClicked As Boolean = False
    Private WithEvents DataFetchAndUpdateTimer As New Timer()

    ' Declare timer intervals as variables for easy modification.
    Private DataFetchAndUpdateTimerInterval As Integer = 5000 ' 5 seconds for DataFetchAndUpdateTimer.
    Private WledControlTimerInterval As Integer = 10000 ' 10 seconds for WledControlTimer.
    Private WledWarningLimitTimerInterval As Integer = 180000 ' 3 minutes for WledWarningLimitTimer.

    ' Handles the tick event of DataFetchAndUpdateTimer.
    Private Async Sub DataFetchAndUpdateTimer_Tick(sender As Object, e As EventArgs) Handles DataFetchAndUpdateTimer.Tick
        ' Fetch temperature and humidity data from sensors and update the chart.
        Using client As New HttpClient()
            Try
                ' Loop through each sensor's IP address.
                For i As Integer = 0 To ipAddresses.Length - 1
                    Dim ipAddress = ipAddresses(i)
                    Dim location = locations(i)

                    ' Fetch temperature and humidity data from the sensor.
                    Dim temperature As String = Await client.GetStringAsync($"http://{ipAddress}/temperature")
                    Dim humidity As String = Await client.GetStringAsync($"http://{ipAddress}/humidity")

                    ' Update chart series and labels with the received data.
                    UpdateChartAndLabels(location, temperature, humidity)

                    ' Check if the current location is selected in the ComboBox or if "All" is selected.
                    If location = ComboBox_choose.SelectedItem.ToString() OrElse ComboBox_choose.SelectedItem.ToString() = "All" Then
                        ' If yes, make the corresponding chart series visible.
                        ShowChartSeries(location)
                    Else
                        ' If no, hide the corresponding chart series.
                        HideChartSeries(location)
                    End If

                    ' Check if the temperature triggers a command to the WLED device.
                    CheckAndSendWledCommand(temperature)
                Next
            Catch ex As Exception
                ' Show an error message if an exception occurs.
                MessageBox.Show(ex.Message)
            End Try
        End Using
    End Sub

    ' Handles the tick event of WledControlTimer.
    Private Async Sub WledControlTimer_Tick(sender As Object, e As EventArgs) Handles WledControlTimer.Tick
        ' Revert the WLED device back to its original state.
        Using client As New HttpClient()
            Try
                ' Send HTTP GET request to revert the WLED device back to its original state and await the response.
                Await client.GetAsync($"http://192.168.0.44/win&PL={Txt_background_preset.Text}")

                ' Stop WledControlTimer.
                WledControlTimer.Stop()

            Catch ex As Exception
                ' Show an error message if an exception occurs.
                MessageBox.Show(ex.Message)
            End Try
        End Using
    End Sub

    ' Handles the tick event of WledWarningLimitTimer.
    Private Sub WledWarningLimitTimer_Tick(sender As Object, e As EventArgs) Handles WledWarningLimitTimer.Tick
        ' Stop WledWarningLimitTimer and reset wledCommandSent.
        WledWarningLimitTimer.Stop()
        wledCommandSent = False
    End Sub

    ' Handles the click event of the Test button.
    Private Sub Button_Test_Click(sender As Object, e As EventArgs) Handles Button_Test.Click
        ' Set testButtonClicked to true when the test button is clicked.
        testButtonClicked = True
    End Sub

    ' Handles the load event of the form.
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set up chart series, labels, and timers.
        SetUpChartAndLabels()
        SetUpTimers()
    End Sub

    ' Handles the click event of the Exit button.
    Private Sub Button_Exit_Click(sender As Object, e As EventArgs) Handles Button_Exit.Click
        ' Stop both timers to avoid triggering their events after closing the form.
        DataFetchAndUpdateTimer.Stop()
        WledControlTimer.Stop()

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit? =(", "Miss you!!!", MessageBoxButtons.OKCancel)

        If result = DialogResult.OK Then
            Me.Close()
        End If
    End Sub

    ' Function to update chart series and labels with temperature and humidity data.
    Private Sub UpdateChartAndLabels(location As String, temperature As String, humidity As String)
        ' Add the received temperature and humidity data as points to the corresponding chart series.
        Chart1.Series($"Temperature {location}").Points.AddY(Double.Parse(temperature))
        Chart1.Series($"Humidity {location}").Points.AddY(Double.Parse(humidity))

        ' Update the text of the corresponding labels with the received data.
        DirectCast(Me.Controls($"lbl_temp_{location}"), Label).Text = temperature
        DirectCast(Me.Controls($"lbl_humid_{location}"), Label).Text = humidity
    End Sub

    ' Function to show a chart series.
    Private Sub ShowChartSeries(location As String)
        Chart1.Series($"Temperature {location}").Enabled = True
        Chart1.Series($"Humidity {location}").Enabled = True
    End Sub

    ' Function to hide a chart series.
    Private Sub HideChartSeries(location As String)
        Chart1.Series($"Temperature {location}").Enabled = False
        Chart1.Series($"Humidity {location}").Enabled = False
    End Sub

    ' Function to check temperature and send a command to the WLED device if needed.
    Private Async Sub CheckAndSendWledCommand(temperature As String)
        If (Double.Parse(temperature) < Double.Parse(TextBox_trigger_temp.Text) OrElse testButtonClicked) AndAlso Not wledCommandSent Then
            ' Send HTTP GET request to the WLED device with the preset number from Txt_warning_preset and await the response.
            Using client As New HttpClient()
                Await client.GetAsync($"http://192.168.0.44/win&PL={Txt_warning_preset.Text}")
            End Using

            ' Set wledCommandSent to true and start WledControlTimer and WledWarningLimitTimer.
            wledCommandSent = True
            WledControlTimer.Start()
            WledWarningLimitTimer.Start()

            ' Reset testButtonClicked to false.
            testButtonClicked = False
        End If
    End Sub

    ' Function to set up chart series, labels, and ComboBox.
    Private Sub SetUpChartAndLabels()
        ' Loop over each sensor's IP address.
        For i As Integer = 0 To ipAddresses.Length - 1
            Dim ipAddress = ipAddresses(i)
            Dim location = locations(i)

            ' Add a new series for temperature to the chart and set its properties.
            Chart1.Series.Add($"Temperature {location}")
            Chart1.Series($"Temperature {location}").ChartType = SeriesChartType.Line
            Chart1.Series($"Temperature {location}").BorderWidth = 3

            ' Add a new series for humidity to the chart and set its properties.
            Chart1.Series.Add($"Humidity {location}")
            Chart1.Series($"Humidity {location}").ChartType = SeriesChartType.Line
            Chart1.Series($"Humidity {location}").BorderWidth = 3

            ' Add new labels to the form's Controls collection for temperature and humidity.
            Me.Controls.Add(New Label() With {.Name = $"lbl_temp_{location}", .Location = New Point(10, 10)})
            Me.Controls.Add(New Label() With {.Name = $"lbl_humid_{location}", .Location = New Point(10, 30)})
        Next

        ' Create a new Font object.
        Dim legendFont As New Font("Arial", 12) ' Replace "Arial" with your desired font name and 12 with your desired font size.

        ' Set the Font property of the Chart's Legend object to the new Font.
        Chart1.Legends(0).Font = legendFont

        ' Set up ComboBox_choose.
        ComboBox_choose.Location = New Point(300, 43)
        ComboBox_choose.DataSource = locations.Concat(New String() {"All"}).ToArray()

        ' Set the default selected item to "All".
        ComboBox_choose.SelectedIndex = ComboBox_choose.Items.Count - 1
    End Sub

    ' Function to set up timers.
    Private Sub SetUpTimers()
        ' Start DataFetchAndUpdateTimer with an interval of x seconds (1 sec = 1000 milliseconds).
        DataFetchAndUpdateTimer.Interval = DataFetchAndUpdateTimerInterval
        DataFetchAndUpdateTimer.Start()

        ' Set WledControlTimer's interval to 10 seconds (to revert the WLED device back to its original state).
        WledControlTimer.Interval = WledControlTimerInterval

        ' Set WledWarningLimitTimer's interval to 3 minutes (to limit how often preset 4 can be sent to the WLED device).
        WledWarningLimitTimer.Interval = WledWarningLimitTimerInterval
    End Sub
End Class
