namespace Contacts.Maui.Views.Controls;

public partial class ContactControl : ContentView
{
	public event EventHandler<string> OnError;
	public event EventHandler<EventArgs> OnSave;
	public event EventHandler<EventArgs> OnCancel;


	public ContactControl()
	{
		InitializeComponent();
	}

	public string Name
	{
		get
		{
			return entryName.Text;
		}
		set
		{
			entryName.Text = value;
		}
	}

	public string Email
	{
		get => entryEmail.Text;
		set => entryEmail.Text = value;
	}

	public string Address
	{
		get => entryAddress.Text;
		set => entryAddress.Text = value;
	}

	public string Phone
	{
		get => entryPhone.Text;
		set => entryPhone.Text = value;
	}

	private void BtnSave_OnClicked(object? sender, EventArgs e)
	{
		// We Can't Display Alert at Content View [ It just In Content Page Because it Page Element]
		// So We Will use Event to Notify the Parent Page to Display Alert [ Invoke an Event ]
		if (nameValidator.IsNotValid)
		{
			OnError?.Invoke(sender, "Name is required.");
			//DisplayAlert("Error", "Name is required.", "OK");
			return;
		}

		if (emailValidator.IsNotValid)
		{
			foreach (var error in emailValidator.Errors)
			{
				OnError?.Invoke(sender, error.ToString());
				//DisplayAlert("Error", error.ToString(), "OK");
			}
			return;
		}

		OnSave?.Invoke(sender, e);
	}

	private void BtnCancel_OnClicked(object? sender, EventArgs e)
	{
		OnCancel?.Invoke(sender, e);
	}
}