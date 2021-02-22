' ASIC PTO Tracker created by Chris DePaul on 2/19/2021 using Visual Studio 2019 and VB language.

Public Class frmMain
	Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		dtpPTO.Format = DateTimePickerFormat.Custom
		dtpPTO.CustomFormat = "ddd MMM dd yyyy"

		' Declare the variable for the readable file.
		Dim schedPTO_in As IO.StreamReader

		' Determine if the Scheduled PTO file exists.
		If IO.File.Exists("Scheduled PTO.txt") Then
			' Open the file for input.
			schedPTO_in = IO.File.OpenText("Scheduled PTO.txt")
			' Read the file and assign to the Scheduled PTO box.
			txtBoxScheduled.Text = schedPTO_in.ReadToEnd.ToString()
			schedPTO_in.Close()
		End If

		Dim PTO_in As IO.StreamReader

		' Determine if the PTO Hours file exists.
		If IO.File.Exists("PTO Hours Available.txt") Then
			' Open the file for input.
			PTO_in = IO.File.OpenText("PTO Hours Available.txt")
			' Read the file and assign to the Scheduled PTO box.
			lblOverall.Text = PTO_in.ReadToEnd.ToString()
			PTO_in.Close()
		End If

		' Determine if the PTO Protected Hours file exists.
		If IO.File.Exists("PTO Protected Hours.txt") Then
			' Open the file for input.
			PTO_in = IO.File.OpenText("PTO Protected Hours.txt")
			' Read the file and assign to the Scheduled PTO box.
			lblPTOPremain.Text = PTO_in.ReadToEnd.ToString()
			PTO_in.Close()
		End If

		' Determine if the PTO Regular Hours file exists.
		If IO.File.Exists("PTO Regular Hours.txt") Then
			' Open the file for input.
			PTO_in = IO.File.OpenText("PTO Regular Hours.txt")
			' Read the file and assign to the Scheduled PTO box.
			lblPTORremain.Text = PTO_in.ReadToEnd.ToString()
			PTO_in.Close()
		End If


	End Sub
	Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
		Me.Close()

	End Sub

	Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
		' Declare the write variable for the scheduled pto text file.
		Dim schedPTO_out As IO.StreamWriter

		' Open the file for changes/append.
		schedPTO_out = IO.File.AppendText("Scheduled PTO.txt")

		' Write the scheduled PTO days on a separate line in the file including the date selected in the DateTimePicker and the Start and End texboxes.
		' IfThenElse statement is to mark the time as protected or not protected.
		If cbxPTOP.Checked Then
			schedPTO_out.Write(" *Protected Time* ")
		End If
		schedPTO_out.Write(dtpPTO.Text & " ")
		schedPTO_out.Write(txtStartTime.Text.Trim & " - ")
		schedPTO_out.Write(txtEndTime.Text.Trim & " ")
		schedPTO_out.WriteLine("")

		' Close the text file so that it can be used in the application elsewhere.
		schedPTO_out.Close()

		' Clears the Time textboxes each time a new entry is entered.
		txtStartTime.Text = String.Empty
		txtEndTime.Text = String.Empty

		' Delcare the read variable for the scheduled pto text file.
		Dim schedPTO_in As IO.StreamReader

		' Determine if the Scheduled PTO file exists.
		If IO.File.Exists("Scheduled PTO.txt") Then
			' Open the file for input.
			schedPTO_in = IO.File.OpenText("Scheduled PTO.txt")
			' Read the file and assign it to the Scheduled PTO box for easy readability.
			txtBoxScheduled.Text = schedPTO_in.ReadToEnd.ToString()
			schedPTO_in.Close()
		Else
			MessageBox.Show("Cannot find the PTO File.", "Scheduled PTO",
							MessageBoxButtons.OK, MessageBoxIcon.Error)
		End If

		' This will unmark the Protected Time checkbox every time a new submission is sent.
		cbxPTOP.Checked = False

	End Sub


	Private Sub btnEditTime_Click(sender As Object, e As EventArgs) Handles btnEditTime.Click
		' Allows the user to open the text file in which the PTO data is saved and can edit it (this is temporary until my coding knowledge gets better).
		If IO.File.Exists("Scheduled PTO.txt") Then
			Process.Start("Scheduled PTO.txt")
		Else
			MessageBox.Show("Cannot find the PTO file, you must submit time off before you can edit the Scheduled PTO file.", "Scheduled PTO", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End If

	End Sub

	Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
		' This button is used to refresh the Scheduled PTO text box with any edits that were made to the existing text file.

		Dim infile As IO.StreamReader
		' Determine if the Scheduled PTO file exists.
		If IO.File.Exists("Scheduled PTO.txt") Then
			' Open the file for input.
			infile = IO.File.OpenText("Scheduled PTO.txt")
			' Read the file and assign to the Scheduled PTO box.
			txtBoxScheduled.Text = infile.ReadToEnd.ToString()
			infile.Close()
		Else
			MessageBox.Show("Cannot find the PTO File.", "Scheduled PTO",
							MessageBoxButtons.OK, MessageBoxIcon.Error)
		End If

	End Sub

	Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
		Me.Close()

	End Sub

	Private Sub btnPTOR_Click(sender As Object, e As EventArgs) Handles btnPTOI.Click
		' Assigns the PTO hours section with variables and also handles the input portion of the PTO hours in that group area - reducing the overall PTO hours will be coded in a separate section.

		' Assigning all variables as decimals because PTO can only be used in 15 minute increments or as full days (Example: 1.25 = 1 hour 15 minutes or 8.50 = Full day (this includes a 30 minute unpaid lunch).
		Dim decPTOR As Decimal
		Dim decPTOP As Decimal
		Dim decPTORU As Decimal
		Dim decPTOPU As Decimal

		Decimal.TryParse(txtPTORtotal.Text, decPTOR)
		Decimal.TryParse(txtPTOPtotal.Text, decPTOP)
		Decimal.TryParse(txtPTORused.Text, decPTORU)
		Decimal.TryParse(txtPTOPused.Text, decPTOPU)

		lblOverall.Text = decPTOR + decPTOP
		lblPTOPremain.Text = decPTOP
		lblPTORremain.Text = decPTOR

		' Delcare the PTO variable to write to a text file.
		Dim PTO_out As IO.StreamWriter

		' Open the file for changes/append.
		PTO_out = IO.File.AppendText("PTO Hours Available.txt")

		' Write the contents of the PTO input texboxes to a file.
		PTO_out.WriteLine(lblOverall.Text.Trim)

		' Close the text file so that it can be used in the application elsewhere.
		PTO_out.Close()

		' Delcare the PTO variable to write to a text file.
		Dim PTO_out2 As IO.StreamWriter

		' Open the file for changes/append.
		PTO_out2 = IO.File.AppendText("PTO Protected Hours.txt")

		' Write the contents of the PTO input texboxes to a file.
		PTO_out2.WriteLine(lblPTOPremain.Text.Trim)

		' Close the text file so that it can be used in the application elsewhere.
		PTO_out2.Close()

		' Delcare the PTO variable to write to a text file.
		Dim PTO_out3 As IO.StreamWriter

		' Open the file for changes/append.
		PTO_out3 = IO.File.AppendText("PTO Regular Hours.txt")

		' Write the contents of the PTO input texboxes to a file.
		PTO_out3.WriteLine(txtPTORtotal.Text.Trim)

		' Close the text file so that it can be used in the application elsewhere.
		PTO_out3.Close()

		txtPTORtotal.ReadOnly = True
		txtPTOPtotal.ReadOnly = True

	End Sub

	Private Sub btnClearPTO_Click(sender As Object, e As EventArgs) Handles btnClearPTO.Click
		' Clear out the contents of the Regular PTO and the Protected PTO textboxes.
		txtPTOPtotal.Text = String.Empty
		txtPTORtotal.Text = String.Empty
		lblOverall.Text = String.Empty
		txtPTORused.Text = String.Empty
		txtPTOPused.Text = String.Empty
		lblPTOPremain.Text = String.Empty
		lblPTORremain.Text = String.Empty

		' Change the property of the textboxes to be editable again since the user input incorrect information.
		txtPTORtotal.ReadOnly = False
		txtPTOPtotal.ReadOnly = False

		' Deletes the entire PTO Hours text file so that a new one can be created.
		If System.IO.File.Exists("PTO Hours Available.txt") = True Then
			System.IO.File.Delete("PTO Hours Available.txt")
		End If

		' Deletes the entire PTO Protected Hours file so that a new one can be created.
		If System.IO.File.Exists("PTO Protected Hours.txt") = True Then
			System.IO.File.Delete("PTO Protected Hours.txt")
		End If

		' Deletes the entire PTO Regular Hours file so that a new one can be created.
		If System.IO.File.Exists("PTO Regular Hours.txt") = True Then
			System.IO.File.Delete("PTO Regular Hours.txt")
		End If

	End Sub

	Private Sub btnPTOU_Click(sender As Object, e As EventArgs) Handles btnPTOU.Click
		' Reduce the overall PTO label by either Regular PTO or Protected PTO input by the user.

		' Delcare the variables as decimals because people can only use PTO in 15 minute increments.
		Dim decPTORu As Decimal
		Dim decPTOPu As Decimal
		Dim decOverall As Decimal
		Dim decSub1 As Decimal
		Dim decSub2 As Decimal

		' Assign the variables to the appropriate labels.
		Decimal.TryParse(lblPTORremain.Text, decPTORu)
		Decimal.TryParse(lblPTOPremain.Text, decPTOPu)
		Decimal.TryParse(lblOverall.Text, decOverall)
		Decimal.TryParse(txtPTORused.Text, decSub1)
		Decimal.TryParse(txtPTOPused.Text, decsub2)

		lblOverall.Text = lblOverall.Text - decSub2
		lblOverall.Text = lblOverall.Text - decSub1
		lblPTOPremain.Text = decPTOPu - decSub2
		lblPTORremain.Text = decPTORu - decSub1


	End Sub
End Class
