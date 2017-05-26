' The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

''' <summary>
''' An empty page that can be used on its own or navigated to within a Frame.
''' </summary>
Public NotInheritable Class MainPage
    Inherits Page

	Protected Overrides Sub OnNavigatedTo(e As NavigationEventArgs)
		ApplicationView.GetForCurrentView().SetPreferredMinSize(New Size(350, 400))

		ApplicationView.PreferredLaunchViewSize = New Size(350, 400)
		ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.PreferredLaunchViewSize
	End Sub
End Class
