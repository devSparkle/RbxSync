Public NotInheritable Class MainPage
	Inherits Page

	Protected Overrides Sub OnNavigatedTo(e As NavigationEventArgs)
		ApplicationView.GetForCurrentView().SetPreferredMinSize(New Size(350, 400))

		ApplicationView.PreferredLaunchViewSize = New Size(350, 400)
		ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.PreferredLaunchViewSize
	End Sub
End Class
