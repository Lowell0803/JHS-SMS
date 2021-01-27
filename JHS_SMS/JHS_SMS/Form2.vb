Public Class Form2

    Private Sub P3Table1BindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles P3Table1BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.P3Table1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.P3DatabaseDataSet)

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'P3DatabaseDataSet.P3Table1' table. You can move, or remove it, as needed.
        Me.P3Table1TableAdapter.Fill(Me.P3DatabaseDataSet.P3Table1)

    End Sub
    Private Sub rdbtnMale_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbtnMale.CheckedChanged
        If rdbtnMale.Checked Then
            GenderTextBox.Text = rdbtnMale.Text
        End If
    End Sub

    Private Sub rdbtnFemale_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbtnFemale.CheckedChanged
        If rdbtnFemale.Checked Then
            GenderTextBox.Text = rdbtnFemale.Text
        End If
    End Sub

    Private Sub P3Table1BindingNavigator_RefreshItems(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles P3Table1BindingNavigator.RefreshItems
        If GenderTextBox.Text = rdbtnMale.Text Then
            rdbtnMale.Checked = True
            rdbtnFemale.Checked = False
        ElseIf GenderTextBox.Text = rdbtnFemale.Text Then
            rdbtnFemale.Checked = True
            rdbtnMale.Checked = False
        End If
    End Sub


    Private Sub btnPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrev.Click
        P3Table1BindingSource.MovePrevious()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            P3Table1BindingSource.EndEdit()
            TableAdapterManager.UpdateAll(P3DatabaseDataSet)
            MessageBox.Show("Record has been saved.", "Command Initiated")
        Catch ex As Exception
            MessageBox.Show("Please fill all fields.", "Error!")
        End Try
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        P3Table1BindingSource.AddNew()
        rdbtnMale.Checked = True
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Student_IDTextBox.Clear()
        First_NameTextBox.Clear()
        Last_NameTextBox.Clear()
        GenderTextBox.Clear()
        Enrolling_ForTextBox.Clear()
        PhoneTextBox.Clear()
        EmailTextBox.Clear()
    End Sub

    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        P3Table1BindingSource.RemoveCurrent()
        TableAdapterManager.UpdateAll(P3DatabaseDataSet)
        MessageBox.Show("Record has been deleted.", "Command Initiated")
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        P3Table1BindingSource.MoveNext()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub EmailTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmailTextBox.TextChanged

    End Sub

    Private Sub PhoneTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PhoneTextBox.TextChanged

    End Sub

    Private Sub Student_IDTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Student_IDTextBox.TextChanged

    End Sub

    Private Sub GenderTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenderTextBox.TextChanged

    End Sub

    Private Sub Enrolling_ForTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Enrolling_ForTextBox.TextChanged

    End Sub

    Private Sub Last_NameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Last_NameTextBox.TextChanged

    End Sub

    Private Sub First_NameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles First_NameTextBox.TextChanged

    End Sub
End Class