using Desktop_Application.Classes;
using Desktop_Application.Forms.Borrowings;

namespace Desktop_Application.Forms.Reservations;

public partial class EditReservation : Form
{
    private readonly DataGridView _reservations_grd;

    private DateTime _reservationEndDate;
    private bool _extend = false;

    public EditReservation(DataGridView reservations_grd)
    {
        _reservations_grd = reservations_grd;
        InitializeComponent();
    }

    private void OnLoad(object sender, EventArgs e)
    {
        DragWindow.Handle(this, header, title);
        BorderPaint.Handle(this);
        CloseThisWindow.Handle(this, close_btn);
        CloseThisWindow.Handle(this, cancel);
        HandleKeys.Handle(this, Keys.Enter, Save);
        HandleKeys.Handle(this, Keys.Escape, (s, e) => this.Close());

        var result = HandleQueries.SelectFromFile("SelectUsername");
        HandleGrids.Fill(dropDown_user, result);

        var selectedRow = _reservations_grd.SelectedRows[0].Cells;

        dropDown_user.Text = selectedRow["reservations_username"].Value.ToString();
        textBox_books.Text = selectedRow["reservations_isbn"].Value.ToString();

        string rDateString = selectedRow["reservations_endDate"].Value.ToString() ?? string.Empty;
        int[] rDate = rDateString
            .Split('/')
            .Select(int.Parse)
            .ToArray();
        _reservationEndDate = new(rDate[2], rDate[1], rDate[0]);
    }

    private void Save(object sender, EventArgs e)
    {
        if (ValidateInput())
        {
            if (_extend) _reservationEndDate = _reservationEndDate.AddDays(5);
            HandleQueries.UpdateReservation(dropDown_user.Text, textBox_books.Text, _reservationEndDate);
            MessageBox.Show("Reservation updated succesfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }

    private bool ValidateInput()
    {
        if (textBox_books.Text == string.Empty)
        {
            MessageBox.Show("Books are required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
        return true;
    }

    private void OpenChooseBooks(object sender, EventArgs e)
    {
        List<string> selectedBooks = textBox_books.Text.Split(", ").ToList();
        ChooseBooks chooseBooks = new(selectedBooks);
        chooseBooks.ShowDialog();

        textBox_books.Text = string.Join(", ", ChooseBooks.SelectedISBNs);
    }

    private void ExtendReservation(object sender, EventArgs e)
    {
        if (!_extend)
        {
            button_extend.Text = "Cancel reservation extension";
            button_extend.BackgroundColor = Color.FromArgb(80, 77, 180);
            button_extend.ForeColor = Color.White;
            _extend = true;
        }
        else
        {
            button_extend.Text = "Extend reservation by 5 days";
            button_extend.BackgroundColor = Color.White;
            button_extend.ForeColor = Color.Black;
            _extend = false;
        }
    }
}