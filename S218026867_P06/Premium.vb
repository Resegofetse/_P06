Option Strict On
Option Explicit On
Option Infer Off
'derived class
Public Class Premium
    ' Surname, Initials:PANANA R
    ' Practical: P06
    Inherits streaming_plan
    Private _excontent As exclusivecontent
    Private _Ads As Boolean
    'constructor
    Public Sub New()
        _excontent = New exclusivecontent()
    End Sub
    'property methods
    Public Property excontent() As exclusivecontent
        Get
            Return _excontent
        End Get
        Set(value As exclusivecontent)
            _excontent = value
        End Set
    End Property
    Public Property Ads() As Boolean
        Get
            Return _Ads
        End Get
        Set(value As Boolean)
            _Ads = value
        End Set
    End Property
    'functions and methods
    'function to check if the user would like to have ads or no ads when streaming
    Public Function NoAds(temp As Integer) As Boolean

        If temp = 1 Then
            Ads = False
        Else
            Ads = True
        End If
        Return Ads
    End Function
    'function to calculate price that user will pay for the chosen plan 
    Public Overrides Function Price() As Double

        Dim ads As Integer = 0
        Dim totcost As Double
        If _Ads = True Then
            ads += 50
        End If

        totcost = subscriptionfee + +ads + excontent.Tot() + Devices(devicetype)
        Return totcost
    End Function
    'function to display details about the users plan and the cost
    Public Overrides Function Display() As String
        Dim text As String = ""
        text &= MyBase.Display()
        text &= "Resolution is:  4k+HDR" & Environment.NewLine
        text &= "exclusive content:" & excontent.typeofcontent & Environment.NewLine
        text &= "Ads :" & Ads & Environment.NewLine
        text &= "Total cost for your plan is:" & CStr(Price())
        Return text

    End Function
End Class
