﻿using System.Text.RegularExpressions;
using Desktop_Application.Classes;

namespace Desktop_Application.Forms.Users;

public partial class AddUser : Form
{
    private DateTime _dateOfBirth;
    private readonly bool _isAdmin;

    public AddUser(bool isAdmin)
    {
        _isAdmin = isAdmin;
        InitializeComponent();
    }

    private void OnLoad(object sender, EventArgs e)
    {
        HandleFonts.Set(this);
        DragWindow.Handle(this, header, title);
        BorderPaint.Handle(this);
        CloseWindow.Handle(this, close_btn);
        CloseWindow.Handle(this, cancel);
        HandleKeys.Handle(this, Keys.Enter, Save);
        HandleKeys.Handle(this, Keys.Escape, (s, e) => this.Close());

        // Roles - This is only visible for admins
        var result = HandleQueries.SelectFromFile("SelectRole");
        HandleGrids.Fill(comboBox_role, result);
        comboBox_role.SelectedIndex = 2;

        label_role.Visible = _isAdmin;
        comboBox_role.Visible = _isAdmin;
    }

    private void Save(object sender, EventArgs e)
    {
        if (ValidateInput())
        {
            string dateOfBirthString = $"{_dateOfBirth.Year}-{_dateOfBirth.Month}-{_dateOfBirth.Day}";

            string randomPassword = GeneratePassword.Generate("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnoqqrstuvwxyz0123456789", 12);
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(randomPassword);

            HandleQueries.InsertUser(textBox_firstName.Text, textBox_lastName.Text, dateOfBirthString, textBox_username.Text, hashedPassword, textBox_address.Text, comboBox_role.SelectedIndex + 1);

            ShowPassword showPassword = new(randomPassword);
            showPassword.ShowDialog();

            MessageBox.Show("User added succesfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }

    // returns true if everything is correct
    private bool ValidateInput()
    {
        if (textBox_firstName.Text == string.Empty)
        {
            MessageBox.Show("First name is required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
        else if (!Regex.IsMatch(textBox_firstName.Text, @"^[^""\\]+$"))
        {
            MessageBox.Show("First name is not in the correct format! Please check your special characters!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        if (textBox_lastName.Text == string.Empty)
        {
            MessageBox.Show("Last name is required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
        else if (!Regex.IsMatch(textBox_lastName.Text, @"^[^""\\]+$"))
        {
            MessageBox.Show("Last name is not in the correct format! Please check your special characters!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        if (textBox_username.Text == string.Empty)
        {
            MessageBox.Show("Username is required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
        else if (!Regex.IsMatch(textBox_username.Text, @"^[a-zA-Z][a-zA-Z0-9._]{2,19}$"))
        {
            MessageBox.Show("Username is not in the correct format! It must start with a letter and can only contain latin letters, numbers, underscores and dots.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
        else if (CheckUsername(textBox_username.Text))
        {
            MessageBox.Show("Username already exists!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        int[] bDate = dateOfBirth_datePicker.Text.Split('/').Select(int.Parse).ToArray();
        _dateOfBirth = new(bDate[2], bDate[1], bDate[0]);

        if (_dateOfBirth > DateTime.Today)
        {
            MessageBox.Show("Date of birth cannot be later than today!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
        else if (_dateOfBirth < DateTime.Now.AddYears(-130))
        {
            MessageBox.Show("Cannot enter date older than 130 years old!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        if (textBox_address.Text == string.Empty)
        {
            MessageBox.Show("Address is required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
        else if (!Regex.IsMatch(textBox_address.Text, @"^[^""\\]+$"))
        {
            MessageBox.Show("Address is not in the correct format! Please check your special characters!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
        return true;
    }

    private static bool CheckUsername(string username)
    {
        var result = HandleQueries.SelectFromFile("SelectUsername");
        foreach (string[] item in result)
        {
            if (item[0] == username) return true;
        }
        return false;
    }
}