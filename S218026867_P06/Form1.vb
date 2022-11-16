Public Class frm_streamonline
    ' Surname, Initials:PANANA R
    ' Practical: P06

    'declaring variablles
    Private stndrd As Standard
    Private prem As Premium
    Private email As String = ""
    Private password As String = ""
    Private subscription As String
    'read in email,password from user to sign them up for streaming content online
    Private Sub btn_signup_Click(sender As Object, e As EventArgs) Handles btn_signup.Click
        MsgBox("Hello, thank you for choosing our streaming platform." & Environment.NewLine & "sign up and enjoy great content")
        email = InputBox("Enter  email")
        password = InputBox("Enter password")


    End Sub

    Private Sub btn_plan_Click(sender As Object, e As EventArgs) Handles btn_plan.Click
        Dim temp As Integer
        Dim dvtype As String
        'instintiate an object of type standard and premium
        stndrd = New Standard(email, password)
        prem = New Premium()
        'read in the subscription plan from the user
        temp = CInt(InputBox("Which subscription would you like:" & Environment.NewLine & "1.Standard subscription" & Environment.NewLine & "2.Premium subscription"))
        'if first plan , then read in devices,resolution and profiles the would like to have
        Select Case temp
            Case 1
                subscription = "Standard"
                stndrd.subscription = subscription
                stndrd.numdevices = CInt(InputBox("Which devices would you like to stream from:" & Environment.NewLine & "1.phone" & Environment.NewLine & "2.Tablet and computer" & Environment.NewLine & "3. Computer and TV"))
                dvtype = stndrd.devicetype
                stndrd.Devices(stndrd.numdevices)
                stndrd.Devices(dvtype)
                stndrd.quality(subscription)
                stndrd.nres = InputBox("Which Resolution would you like?" & Environment.NewLine & "1. 480p" & Environment.NewLine & "2.1080p")
                stndrd.Resolution()
                stndrd.numberofprofiles = CInt(InputBox("How many profiles would you like to have?" & Environment.NewLine & "1. for 1 profile" & Environment.NewLine & "2. for 4 profiles" & Environment.NewLine & "3. for more than 4 profiles"))
                stndrd.profiles()
                'if second plan, read in the device,extra content and ads
            Case 2
                subscription = "Premium"
                prem.subscription = subscription
                prem.numdevices = CInt(InputBox("Which devices would you like to stream from:" & Environment.NewLine & "1.phone" & Environment.NewLine & "2.Tablet and computer" & Environment.NewLine & "3. Computer and TV"))
                prem.Devices(prem.numdevices)
                dvtype = prem.devicetype
                prem.Devices(dvtype)
                prem.quality(subscription)
                Dim typecont As Integer = CInt((InputBox("Which Extra content would you like to add?" & Environment.NewLine & "1. Movies" & Environment.NewLine & "2. Series" & Environment.NewLine & "3.Documentaries")))
                prem.excontent.Typec(typecont)
                prem.excontent.Numberofshows(prem.excontent.typeofcontent)
                prem.excontent.Tot()
                Dim tempo As Integer = (InputBox("Would you like to see Ads while streaming?" & Environment.NewLine & "1.Yes" & Environment.NewLine & "2.No"))
                prem.NoAds(tempo)


        End Select

    End Sub
    'dispaly plan the user chose and the details of the plan
    Private Sub btn_display_Click(sender As Object, e As EventArgs) Handles btn_display.Click

        If subscription = "Standard" Then
            txt_dispay.Text = stndrd.Display()
        Else
            txt_dispay.Text = prem.Display()
        End If

    End Sub
    'clears the textbox
    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        txt_dispay.Clear()
    End Sub
    'stop running and exist 
    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub


End Class
